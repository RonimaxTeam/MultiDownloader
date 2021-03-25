using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultiDownloader.Classes;
using InstagramApiSharp.Classes;
using Screen = Caliburn.Micro.Screen;
using System.Windows.Threading;
using CustomAlertBoxDemo;
using Caliburn.Micro;
using MultiDownloader.Views;

namespace MultiDownloader.ViewModels
{
    public partial class InstagramLoginViewModel : Screen
    {
        public InstagramLoginViewModel()
        {
            InitializeComponent();
        }
        
        #region Methods

        public async void ButtonLogin()
        {
            LoginingDesign();
            await InstaLogin(TextBoxUserNameInstagramContent, InstagramLoginView.Password);
            InstaLoginResultHandler();
        }

        public void LoginingDesign()
        {

        }

        public async Task InstaLogin(string username, string password)
        {
           await InstagramLogin.Login(username, password);
        }

        public void InstaLoginResultHandler()
        {
            if (InstagramLogin.InstagramLoginResult.Succeeded is true)
            {
                Alert.Show("Login Successfully",Form_Alert.enmType.Success);
                IWindowManager manager = new WindowManager();
                manager.ShowWindow(new InstagramAndYouTubeInformationProductViewModel());
                TryClose();
            }
            else if (InstagramLogin.InstagramLoginResult.Value.ToString() is "ChallengeRequired")
            {
                IWindowManager manager = new WindowManager();
                manager.ShowWindow(new InstaLoginChallengeRequiredViewModel());
                TryClose();
            }
            else
            {
                Alert.Show("Incorrect user and password",Form_Alert.enmType.Error);
            }


        }
        
        #endregion
    }
}
