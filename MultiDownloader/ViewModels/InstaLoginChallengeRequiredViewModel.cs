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
        private string _groupBoxIdentityConfirmation;
        private string _textBlockHeaderCode;
        private string _textBoxChallengeCodeTag;
        private string _pictureBoxKey;
        private string _pictureBoxIdentityConfirmation;
        private string _groupBoxBorderBrush;
        private string _textBlockMethodText;
        private string _pictuteBoxMethod;
        private string _verifyCodeVisibility;

        
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
            GroupBoxIdentityConfirmation = "Identity Confirmation";
            TextBlockHeaderCode = "Code";
            TextBoxChallengeCodeTag = "Enter the code...";
            PictureBoxKey = "../Resource/KeyDark.png";
            PictureBoxIdentityConfirmation = "../Resource/identification_documents_50px.png";
            GroupBoxBorderBrush = "#FFFFFFFF";
            TextBlockMethodText = "Method : ";
            PictureBoxMethod = "../Resource/MethodDark.png";
            VerifyCodeVisibility = "Visible";
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

        public string GroupBoxIdentityConfirmation
        {
            get => _groupBoxIdentityConfirmation;
            set
            { _groupBoxIdentityConfirmation = value;
                NotifyOfPropertyChange(GroupBoxIdentityConfirmation);
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
        public string PictureBoxIdentityConfirmation
        {
            get => _pictureBoxIdentityConfirmation;
            set
            {
                _pictureBoxIdentityConfirmation = value;
                NotifyOfPropertyChange(PictureBoxIdentityConfirmation);
            }
        }
        public string GroupBoxBorderBrush
        {
            get { return _groupBoxBorderBrush; }
            set
            {
                _groupBoxBorderBrush = value;
                NotifyOfPropertyChange(GroupBoxBorderBrush);
            }
        }
        public string TextBlockMethodText
        {
            get { return _textBlockMethodText; }
            set
            {
                _textBlockMethodText = value;
                NotifyOfPropertyChange(nameof(TextBlockMethodText));
            }
        }
        public string PictureBoxMethod
        {
            get { return _pictuteBoxMethod; }
            set
            {
                _pictuteBoxMethod = value;
                NotifyOfPropertyChange(PictureBoxMethod);
            }
        }

        public string VerifyCodeVisibility
        {
            get { return _verifyCodeVisibility; }
            set
            {
                _verifyCodeVisibility = value;
                NotifyOfPropertyChange(VerifyCodeVisibility);
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
