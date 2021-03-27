using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using MultiDownloader.Classes;

namespace MultiDownloader.ViewModels
{
    public partial class DownloaderViewModel : Screen
    {

        #region Fields

        private string _backgroundWindowColor;
        private string _backgroundTopGridColor;
        private string _windowTitleText;
        private string _imageDownloadStatusGroupBoxHeader;
        private string _textColor;
        private string _textBlockDownloadStatusHeaderText;
        private string _progressBarDownloadValue;
        private string _textBlockfileSize;
        private string _textBlockDownloaded;
        private string _textBlockDownloadSpeed;
        private string _textBlockfileSizeInformation;
        private string _textBlockDownloadedInformation;
        private string _textBlockDownloadSpeedInformation;

        

        #endregion

        #region Constractor

        public void InitializeComponent()
        {
            BackgroundWindowColor = "#181745";
            BackgroundTopGridColor = "#0F0F2D";
            WindowTitleText = "Multi Downloader";
            TextColor = "White";
            ImageDownloadStatusGroupBoxHeader = "../Resource/DownloadDark.png";
            TextBlockDownloadStatusHeaderText = "Download Status";
            ProgressBarDownloadValue = "10";
            TextBlockFileSize = "File Size";
            TextBlockDownloaded = "Downloaded";
            TextBlockDownloadSpeed = "Download Speed";
            TextBlockFileSizeInformation = "50 MB";
            TextBlockDownloadedInformation = "12.5 MB ( 10/00 % )";
            TextBlockDownloadSpeedInformation = "200 KB/sec";

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
        public string ImageDownloadStatusGroupBoxHeader
        {
            get
            {
                return _imageDownloadStatusGroupBoxHeader;
            }
            set
            {
                _imageDownloadStatusGroupBoxHeader = value;
                NotifyOfPropertyChange(nameof(ImageDownloadStatusGroupBoxHeader));
            }
        }
        public string TextColor
        {
            get => _textColor;
            set
            {
                _textColor = value;
                NotifyOfPropertyChange(nameof(TextColor));
            }
        }
        public string TextBlockDownloadStatusHeaderText
        {
            get => _textBlockDownloadStatusHeaderText;
            set
            {
                _textBlockDownloadStatusHeaderText = value;
                NotifyOfPropertyChange(nameof(TextBlockDownloadStatusHeaderText));
            }
        }
        public string ProgressBarDownloadValue
        {
            get { return _progressBarDownloadValue; }
            set
            {
                _progressBarDownloadValue = value;
                NotifyOfPropertyChange(nameof(ProgressBarDownloadValue));
            }
        }
        public string TextBlockFileSize
        {
            get { return _textBlockfileSize; }
            set
            {
                _textBlockfileSize = value; 
                NotifyOfPropertyChange(nameof(TextBlockFileSize));
            }
        }
        public string TextBlockDownloaded
        {
            get { return _textBlockDownloaded; }
            set
            {
                _textBlockDownloaded = value;
                NotifyOfPropertyChange(nameof(TextBlockDownloaded));
            }
        }
        public string TextBlockDownloadSpeed
        {
            get { return _textBlockDownloadSpeed; }
            set
            {
                _textBlockDownloadSpeed = value;
                NotifyOfPropertyChange(nameof(TextBlockDownloadSpeed));
            }
        }
        public string TextBlockFileSizeInformation
        {
            get { return _textBlockfileSizeInformation; }
            set
            {
                _textBlockfileSizeInformation = value;
                NotifyOfPropertyChange(nameof(TextBlockFileSizeInformation));
            }
        }
        public string TextBlockDownloadedInformation
        {
            get { return _textBlockDownloadedInformation; }
            set
            {
                _textBlockDownloadedInformation = value;
                NotifyOfPropertyChange(nameof(TextBlockDownloadedInformation));
            }
        }
        public string TextBlockDownloadSpeedInformation
        {
            get { return _textBlockDownloadSpeedInformation; }
            set
            {
                _textBlockDownloadSpeedInformation = value;
                NotifyOfPropertyChange(nameof(TextBlockDownloadSpeedInformation));
            }
        }

        #endregion

        public Alert Alert { get; set; }

        #endregion


    }
}
