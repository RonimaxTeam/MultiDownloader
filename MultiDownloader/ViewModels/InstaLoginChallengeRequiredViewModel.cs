using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace MultiDownloader.ViewModels
{
    public class InstaLoginChallengeRequiredViewModel : Screen
    {
        private string _backgroundWindowColor;
        private string _backgroundTopGridColor;
        private string _windowTitleText;
        private string _radioButtonEmailContent;
        private string _radioButtonPhoneContent;
        private string _buttonChallengeSendContent;
        private string _buttonChallengeVerifyCodeContent;
        private string _textBoxChallengeCode;
        private string _textBlockCode;
        private string _textBlockMethod;
        private string _textBlockHeaderCode;
        private string _textBoxChallengeCodeTag;
        private string _pictureBoxKey;
        private string _pictureBoxMethod;

        public InstaLoginChallengeRequiredViewModel()
        {
            BackgroundWindowColor = "#181745";
            BackgroundTopGridColor = "#0F0F2D";
            WindowTitleText = "Multi Downloader";
            RadioButtonEmailContent = "Email";
            RadioButtonPhoneContent = "Phone";
            ButtonChallengeSendContent = "Send";
            ButtonChallengeVerifyCodeContent = "Verify Code";
            TextBlockCode = "Code :";
            TextBlockMethod = "Method";
            TextBlockHeaderCode = "Code";
            TextBoxChallengeCodeTag = "Inter the code...";
            PictureBoxKey = "../Resource/KeyDark.png";
            PictureBoxMethod = "../Resource/MethodDark.png";
        }

        #region Properties

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

        public string RadioButtonEmailContent 
        {
            get => _radioButtonEmailContent;
            set
            {
                _radioButtonEmailContent = value;
                NotifyOfPropertyChange(RadioButtonEmailContent);
            }
        }

        public string RadioButtonPhoneContent
        {
            get => _radioButtonPhoneContent;
            set
            {
                _radioButtonPhoneContent = value;
                NotifyOfPropertyChange(RadioButtonPhoneContent);
            }
        }
        public string ButtonChallengeSendContent
        {
            get => _buttonChallengeSendContent;
            set
            {
                _buttonChallengeSendContent = value;
                NotifyOfPropertyChange(ButtonChallengeSendContent);
            }
        }
        public string ButtonChallengeVerifyCodeContent
        {
            get => _buttonChallengeVerifyCodeContent;
            set
            {
                _buttonChallengeVerifyCodeContent = value;
                NotifyOfPropertyChange(ButtonChallengeVerifyCodeContent);
            }
        }
        public string TextBoxChallengeCode
        {
            get => _textBoxChallengeCode;
            set
            {
                _textBoxChallengeCode = value;
                NotifyOfPropertyChange(TextBoxChallengeCode);
            }
        }

        public string TextBlockCode
        {
            get => _textBlockCode;
            set
            {
                _textBlockCode = value;
                NotifyOfPropertyChange(TextBlockCode);
            }
        }

        public string TextBlockMethod
        {
            get => _textBlockMethod;
            set
            {
                _textBlockMethod = value;
                NotifyOfPropertyChange(TextBlockMethod);
            }
        }
        public string TextBlockHeaderCode
        {
            get => _textBlockHeaderCode;
            set
            {
                _textBlockHeaderCode = value;
                NotifyOfPropertyChange(TextBlockHeaderCode);
            }
        }
        public string TextBoxChallengeCodeTag
        {
            get => _textBoxChallengeCodeTag;
            set
            {
                _textBoxChallengeCodeTag = value;
                NotifyOfPropertyChange(TextBoxChallengeCodeTag);
            }
        }
        public string PictureBoxKey
        {
            get => _pictureBoxKey;
            set
            {
                _pictureBoxKey = value;
                NotifyOfPropertyChange(PictureBoxKey);
            }
        }
        public string PictureBoxMethod
        {
            get => _pictureBoxMethod;
            set
            {
                _pictureBoxMethod = value;
                NotifyOfPropertyChange(PictureBoxMethod);
            }
        }

        #endregion

        #region Methods
        public void ButtonChallengeSend()
        {
            IWindowManager manager = new WindowManager();
            manager.ShowWindow(new InstagramAndYouTubeInformationProductViewModel(), null, null);
        }

        #endregion
    }
}
