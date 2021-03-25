using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using MultiDownloader.Classes;

namespace MultiDownloader.ViewModels
{
    public partial class GetURLViewModel : Screen
    {
        #region Fields

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

        #endregion

        #region Constractor

        public void InitializeComponent()
        {
            //Initialize Design properties
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
        }

        #endregion

        #region Properties

        #region Design Properties

        public string EnterURLLableText
        {
            get
            {
                return _enterURLLableText;
            }
            set
            {
                _enterURLLableText = value;
                NotifyOfPropertyChange(nameof(EnterURLLableText));
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
                NotifyOfPropertyChange(nameof(ButtonCheckURLContent));
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
        public string TextBoxURL
        {
            get
            {
                return _textBoxURL;
            }
            set
            {
                _textBoxURL = value;
                NotifyOfPropertyChange(nameof(TextBoxURL));
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
                NotifyOfPropertyChange(nameof(TextBoxURLTag));
            }
        }
        public bool ButtonCheckUrlEnable
        {
            get { return _buttonCheckUrlEnable; }
            set
            {
                _buttonCheckUrlEnable = value;
                NotifyOfPropertyChange(nameof(ButtonCheckUrlEnable));
            }
        }
        public bool TextBoxUrlEnable
        {
            get { return _textBoxUrlEnable; }
            set
            {
                _textBoxUrlEnable = value;
                NotifyOfPropertyChange(nameof(TextBoxUrlEnable));
            }
        }

        #endregion

        public CheckStructure CheckStructure { get; set; }
        public Alert DialogAlert;

        #endregion
    }
}
