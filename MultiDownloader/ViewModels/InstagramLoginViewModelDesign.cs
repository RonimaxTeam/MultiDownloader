using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using MultiDownloader.Classes;

namespace MultiDownloader.ViewModels
{
    public partial class InstagramLoginViewModel : Screen
    {
        #region Fields

        private string _buttonInstagramLoginContent;
        private string _backgroundWindowColor;
        private string _backgroundTopGridColor;
        private string _windowTitleText;
        private string _pictureBoxUserNameFilePath;
        private string _pictureBoxPasswordFilePath;
        private string _textBoxUserNameInstagramContent;
        private string _textBoxPasswordInstagramContent;
        private string _textBoxUserNameInstagramContentTag;
        private string _textBoxPasswordInstagramContentTag;

        #endregion

        #region Constractor

        public void InitializeComponent()
        {
            ButtonInstagramLoginContent = "Login";
            BackgroundWindowColor = "#181745";
            BackgroundTopGridColor = "#0F0F2D";
            WindowTitleText = "Multi Downloader";
            PictureBoxUserNameFilePath = "../Resource/UserDark.png";
            PictureBoxPasswordFilePath = "../Resource/PasswordDark.png";
            TextBoxUserNameInstagramContentTag = "Uername/Email...";
            TextBoxPasswordInstagramContentTag = "Password...";
            Alert = new Alert();
        }

        #endregion

        #region Properties

        #region Design Properties

        public string ButtonInstagramLoginContent
        {
            get
            {
                return _buttonInstagramLoginContent;
            }
            set
            {
                _buttonInstagramLoginContent = value;
                NotifyOfPropertyChange(nameof(ButtonInstagramLoginContent));
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
        public string PictureBoxUserNameFilePath
        {
            get
            {
                return _pictureBoxUserNameFilePath;
            }
            set
            {
                _pictureBoxUserNameFilePath = value;
                NotifyOfPropertyChange(nameof(PictureBoxUserNameFilePath));
            }
        }
        public string PictureBoxPasswordFilePath
        {
            get
            {
                return _pictureBoxPasswordFilePath;
            }
            set
            {
                _pictureBoxPasswordFilePath = value;
                NotifyOfPropertyChange(nameof(PictureBoxPasswordFilePath));
            }
        }
        public string TextBoxUserNameInstagramContent
        {
            get
            {
                return _textBoxUserNameInstagramContent;
            }
            set
            {
                _textBoxUserNameInstagramContent = value;
                NotifyOfPropertyChange(nameof(TextBoxUserNameInstagramContent));
            }
        }
        public string TextBoxPasswordInstagramContent
        {
            get
            {
                return _textBoxPasswordInstagramContent;
            }
            set
            {
                _textBoxPasswordInstagramContent = value;
                NotifyOfPropertyChange(nameof(TextBoxPasswordInstagramContent));
            }
        }
        public string TextBoxUserNameInstagramContentTag
        {
            get
            {
                return _textBoxUserNameInstagramContentTag;
            }
            set
            {
                _textBoxUserNameInstagramContentTag = value;
                NotifyOfPropertyChange(nameof(TextBoxUserNameInstagramContentTag));
            }
        }
        public string TextBoxPasswordInstagramContentTag
        {
            get
            {
                return _textBoxPasswordInstagramContentTag;
            }
            set
            {
                _textBoxPasswordInstagramContentTag = value;
                NotifyOfPropertyChange(nameof(TextBoxPasswordInstagramContentTag));
            }
        }

        #endregion

        public Alert Alert { get; set; }

        #endregion
    }
}
