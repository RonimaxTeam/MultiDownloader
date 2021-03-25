using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using Caliburn.Micro;
using CustomAlertBoxDemo;
using InstagramApiSharp.Classes;
using MultiDownloader.Classes;

namespace MultiDownloader.ViewModels
{
    public partial class InstaLoginChallengeRequiredViewModel : Screen
    {
        public InstaLoginChallengeRequiredViewModel()
        {
            InitializeComponent();
        }

        #region Methods

        public async void ButtonChallengeSend()
        {
            //IWindowManager manager = new WindowManager();
            //manager.ShowWindow(new InstagramAndYouTubeInformationProductViewModel(), null, null);

            await ChallengeSend();
        }

        public async void ButtonChallengeVerifyCode()
        {
            await ChallengeVerify();
        }

        public async Task ChallengeSend()
        {
            try
            {
                bool isEmail = RadioButtonEmail;

                if (isEmail)
                {

                    var email = await InstagramLogin.InstaApi.RequestVerifyCodeToEmailForChallengeRequireAsync();
                    if (email.Succeeded)
                    {
                        PanelMethodEnable = false;
                        VerifyCodeVisibility = Visibility.Visible;
                        Alert.Show("The code was sent", Form_Alert.enmType.Success);
                    }
                    else
                    {
                        Alert.Show("Invalid Email", Form_Alert.enmType.Error);
                    }

                }
                else
                {
                    var phoneNumber = await InstagramLogin.InstaApi.RequestVerifyCodeToSMSForChallengeRequireAsync();
                    if (phoneNumber.Succeeded)
                    {
                        PanelMethodEnable = false;
                        VerifyCodeVisibility = Visibility.Visible;
                        Alert.Show("The code was sent", Form_Alert.enmType.Success);
                    }
                    else
                    {
                        Alert.Show("Invalid phone select email", Form_Alert.enmType.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                Alert.Show("Unknown error", Form_Alert.enmType.Error); ;
            }
        }

        public async Task ChallengeVerify()
        {
            var regex = new Regex(@"^-*[0-9,\.]+$");
            if (!regex.IsMatch(TextBoxChallengeCode.Trim()))
            {
                Alert.Show("The code is numeric format",Form_Alert.enmType.Warning);
                return;
            }
            if (TextBoxChallengeCode.Trim().Length != 6)
            {
                Alert.Show("The code must be 6 digits",Form_Alert.enmType.Warning);
               return;
            }

            try
            {
                var verifyLogin = await InstagramLogin.InstaApi.VerifyCodeForChallengeRequireAsync(TextBoxChallengeCode.Trim());
                if (verifyLogin.Succeeded)
                {
                    Alert.Show("Successfully login", Form_Alert.enmType.Success);
                    IWindowManager manager = new WindowManager();
                    manager.ShowWindow(new InstagramAndYouTubeInformationProductViewModel());
                    TryClose();
                }
                else
                {
                    if (verifyLogin.Value == InstaLoginResult.TwoFactorRequired)
                    {
                        Alert.Show("Two factor required", Form_Alert.enmType.Warning);
                    }
                    else
                    {
                        Alert.Show("Invalid Code", Form_Alert.enmType.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                Alert.Show("Unknown error", Form_Alert.enmType.Error);
            }
        }
        
        #endregion
    }
}
