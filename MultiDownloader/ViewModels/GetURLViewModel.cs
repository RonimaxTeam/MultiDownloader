using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using Caliburn.Micro;
using CustomAlertBoxDemo;
using MultiDownloader.Classes;

namespace MultiDownloader.ViewModels
{
    public class GetURLViewModel : Screen
    {
        private string _enterURLLableText;
        private string _buttonCheckURLContent;
        private string _backgroundWindowColor;
        private string _backgroundTopGridColor;
        private string _windowTitleText;
        private string _textBoxURL;
        private string _textBoxURLTag;
        private bool _buttonCheckUrlEnable;
        private bool _textBoxUrlEnable;
        private List<string> Patterns;

        public GetURLViewModel()
        {
            EnterURLLableText = "Please Enter Your URL ( Youtube and Instagram ) :";
            ButtonCheckURLContent = "Check URL";
            BackgroundWindowColor = "#181745";
            BackgroundTopGridColor = "#0F0F2D";
            WindowTitleText = "Multi Downloader";
            TextBoxURLTag = "Inter your post link";
            ButtonCheckUrlEnable = true;
            TextBoxUrlEnable = true;
            CheckStructure = new CheckStructure();
            DialogAlert = new Alert();
            ApplyCheckRuls();
        }

        #region Properties
        public string EnterURLLableText
        {
            get
            {
                return _enterURLLableText;
            }
            set
            {
                _enterURLLableText = value;
                NotifyOfPropertyChange(EnterURLLableText);
            }
        }
        public string ButtonCheckURLContent
        {
            get
            {
                return _buttonCheckURLContent;
            }
            set
            {
                _buttonCheckURLContent = value;
                NotifyOfPropertyChange(ButtonCheckURLContent);
            }
        }
        public string BackgroundWindowColor
        {
            get
            {
                return _backgroundWindowColor;
            }
            set
            {
                _backgroundWindowColor = value;
                NotifyOfPropertyChange(BackgroundWindowColor);
            }
        }
        public string BackgroundTopGridColor
        {
            get
            {
                return _backgroundTopGridColor;
            }
            set
            {
                _backgroundTopGridColor = value;
                NotifyOfPropertyChange(BackgroundTopGridColor);
            }
        }
        public string WindowTitleText
        {
            get
            {
                return _windowTitleText;
            }
            set
            {
                _windowTitleText = value;
                NotifyOfPropertyChange(WindowTitleText);
            }
        }
        public string TextBoxURL
        {
            get
            {
                return _textBoxURL;
            }
            set
            {
                _textBoxURL = value;
                NotifyOfPropertyChange(TextBoxURL);
            }
        }
        public string TextBoxURLTag
        {
            get
            {
                return _textBoxURLTag;
            }
            set
            {
                _textBoxURLTag = value;
                NotifyOfPropertyChange(TextBoxURLTag);
            }
        }
        public bool ButtonCheckUrlEnable
        {
            get { return _buttonCheckUrlEnable; }
            set
            {
                _buttonCheckUrlEnable = value;
                NotifyOfPropertyChange(ButtonCheckUrlEnable.ToString());
            }
        }
        public bool TextBoxUrlEnable
        {
            get { return _textBoxUrlEnable; }
            set
            {
                _textBoxUrlEnable = value;
                NotifyOfPropertyChange(TextBoxUrlEnable.ToString());
            }
        }
        public CheckStructure CheckStructure { get; set; }
        public Alert DialogAlert;
        #endregion

        #region Methods

        public void ButtonCheckURL()
        {
            if (!string.IsNullOrEmpty(TextBoxURL))
            {
                if (CheckStructureURL() && TextBoxURL.Contains("www.instagram.com"))
                {
                    IWindowManager manager = new WindowManager();
                    manager.ShowWindow(new InstagramLoginViewModel());
                }
                else if (CheckStructureURL() && TextBoxURL.Contains("www.youtube.com"))
                {
                    IWindowManager manager = new WindowManager();
                    manager.ShowWindow(new InstagramAndYouTubeInformationProductViewModel());
                }
                else
                {
                    DialogAlert.Show("Invalid Url",Form_Alert.enmType.Error);
                }
            }
            else
            {
                DialogAlert.Show("The link place is empty",Form_Alert.enmType.Error);
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

        #endregion



    }
}
