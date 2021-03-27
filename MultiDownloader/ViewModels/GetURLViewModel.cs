using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using Caliburn.Micro;
using CustomAlertBoxDemo;
using MultiDownloader.Classes;

namespace MultiDownloader.ViewModels
{
    public partial class GetURLViewModel : Screen
    {
        
        public GetURLViewModel()
        {
            InitializeComponent();
            ApplyCheckRuls();
        }

        #region Methods

        public void ButtonCheckURL()
        {
            if (!string.IsNullOrEmpty(TextBoxURL))
            {
                if (CheckStructureURL() && TextBoxURL.Contains("www.instagram.com"))
                {
                    SetMediaStatus();
                    Alert.Show("Please login than continue", Form_Alert.enmType.Info);
                    IWindowManager manager = new WindowManager();   
                    manager.ShowWindow(new InstagramLoginViewModel());
                    
                    TryClose();
                }
                else if (CheckStructureURL() && TextBoxURL.Contains("www.youtube.com"))
                {
                    SetMediaStatus();
                    IWindowManager manager = new WindowManager();        
                    manager.ShowWindow(new InstagramAndYouTubeInformationProductViewModel());
                    
                    TryClose();
                }
                else
                {
                    Application.Current.Dispatcher.Invoke(delegate { Alert.Show("Invalid Url", Form_Alert.enmType.Error); });
                }
            }
            else
            {
                Application.Current.Dispatcher.Invoke(delegate { Alert.Show("The link place is empty", Form_Alert.enmType.Error); });
            }
            
        }

        public bool CheckStructureURL()
        {
            return CheckStructure.Check(TextBoxURL);
        }

        public void ApplyCheckRuls()
        {
            Patterns = new List<string>()
            {
                "^(https://www.instagram.com/p/)",
                "^(https://www.instagram.com/tv/)",
                "^(https://www.youtube.com/)"
            };

            CheckStructure.ApplyRules(Patterns);
        }

        public void SetMediaStatus()
        {
            InstagramAndYouTubeInformationProductViewModel.InputURL = TextBoxURL;
            if (TextBoxURL.Contains("www.instagram.com"))
            {
                InstagramAndYouTubeInformationProductViewModel.ProductStatus = "Instagram";
            }
            else if (TextBoxURL.Contains("www.youtube.com"))
            {
                InstagramAndYouTubeInformationProductViewModel.ProductStatus = "Youtube";
            }
        }

        #endregion

    }
}
