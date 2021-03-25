using MultiDownloader.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MultiDownloader.ViewModels
{
    public partial class InstaLoginChallengeRequiredViewModel
    {

        #region Fields

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
        private Visibility _verifyCodeVisibility;
        private bool _panelMethodEnable;
        private bool _radioButtonEmail;

        #endregion

        #region Constractor

        public void InitializeComponent()
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
            VerifyCodeVisibility = Visibility.Hidden;
            PanelMethodEnable = true;

            Alert = new Alert();
        }

        #endregion

        #region Properties

        #region Design Properties

        public string BackgroundWindowColor
        {
            get
            {
                return _backgroundWindowColor;
            }
            set
            {
                _backgroundWindowColor = value;
                NotifyOfPropertyChange(nameof(BackgroundWindowColor));
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
                NotifyOfPropertyChange(nameof(BackgroundTopGridColor));
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
                NotifyOfPropertyChange(nameof(WindowTitleText));
            }
        }

        public string RadioButtonEmailContent
        {
            get => _radioButtonEmailContent;
            set
            {
                _radioButtonEmailContent = value;
                NotifyOfPropertyChange(nameof(RadioButtonEmailContent));
            }
        }

        public string RadioButtonPhoneContent
        {
            get => _radioButtonPhoneContent;
            set
            {
                _radioButtonPhoneContent = value;
                NotifyOfPropertyChange(nameof(RadioButtonPhoneContent));
            }
        }
        public string ButtonChallengeSendContent
        {
            get => _buttonChallengeSendContent;
            set
            {
                _buttonChallengeSendContent = value;
                NotifyOfPropertyChange(nameof(ButtonChallengeSendContent));
            }
        }
        public string ButtonChallengeVerifyCodeContent
        {
            get => _buttonChallengeVerifyCodeContent;
            set
            {
                _buttonChallengeVerifyCodeContent = value;
                NotifyOfPropertyChange(nameof(ButtonChallengeVerifyCodeContent));
            }
        }
        public string TextBoxChallengeCode
        {
            get => _textBoxChallengeCode;
            set
            {
                _textBoxChallengeCode = value;
                NotifyOfPropertyChange(nameof(TextBoxChallengeCode));
            }
        }

        public string TextBlockCode
        {
            get => _textBlockCode;
            set
            {
                _textBlockCode = value;
                NotifyOfPropertyChange(nameof(TextBlockCode));
            }
        }

        public string GroupBoxIdentityConfirmation
        {
            get => _groupBoxIdentityConfirmation;
            set
            {
                _groupBoxIdentityConfirmation = value;
                NotifyOfPropertyChange(nameof(GroupBoxIdentityConfirmation));
            }
        }
        public string TextBlockHeaderCode
        {
            get => _textBlockHeaderCode;
            set
            {
                _textBlockHeaderCode = value;
                NotifyOfPropertyChange(nameof(TextBlockHeaderCode));
            }
        }
        public string TextBoxChallengeCodeTag
        {
            get => _textBoxChallengeCodeTag;
            set
            {
                _textBoxChallengeCodeTag = value;
                NotifyOfPropertyChange(nameof(TextBoxChallengeCodeTag));
            }
        }
        public string PictureBoxKey
        {
            get => _pictureBoxKey;
            set
            {
                _pictureBoxKey = value;
                NotifyOfPropertyChange(nameof(PictureBoxKey));
            }
        }
        public string PictureBoxIdentityConfirmation
        {
            get => _pictureBoxIdentityConfirmation;
            set
            {
                _pictureBoxIdentityConfirmation = value;
                NotifyOfPropertyChange(nameof(PictureBoxIdentityConfirmation));
            }
        }
        public string GroupBoxBorderBrush
        {
            get { return _groupBoxBorderBrush; }
            set
            {
                _groupBoxBorderBrush = value;
                NotifyOfPropertyChange(nameof(GroupBoxBorderBrush));
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
                NotifyOfPropertyChange(nameof(PictureBoxMethod));
            }
        }

        public Visibility VerifyCodeVisibility
        {
            get { return _verifyCodeVisibility; }
            set
            {
                _verifyCodeVisibility = value;
                NotifyOfPropertyChange(nameof(VerifyCodeVisibility));
            }
        }

        public bool PanelMethodEnable
        {
            get { return _panelMethodEnable; }
            set
            {
                _panelMethodEnable = value;
                NotifyOfPropertyChange(nameof(PanelMethodEnable));
            }
        }

        public bool RadioButtonEmail
        {
            get { return _radioButtonEmail; }
            set
            {
                _radioButtonEmail = value;
                NotifyOfPropertyChange(nameof(RadioButtonEmail));
            }
        }

        #endregion

        public Alert Alert { get; set; }

        #endregion

    }
}
