using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using MultiDownloader.Classes;
using YoutubeExplode;

namespace MultiDownloader.ViewModels
{
    public partial class InstagramAndYouTubeInformationProductViewModel : Screen
    {      
        #region Fields

        private string _backgroundWindowColor;
        private string _backgroundTopGridColor;
        private string _windowTitleText;
        private string _textColor;
        private string _imagePageInformationSourceHeader;
        private string _textBlockPageInformationHeaderText;
        private string _textBlockAuthorText;
        private string _textBlockAuthorInformationText;
        private string _textBlockPageNameText;
        private string _textBlockPageNameInformationText;
        public bool IsBusy { get; set; }

        //===========================
        private string _page;
        private string _pageInformation;
        //===========================

        private string _imageMediaInformationSourceHeader;
        private string _textBlockMediaInformationHeaderText;
        private string _imageMediaTypeSource;
        private string _textBlockMediaTypeText;
        private string _textBlockMediaTypeInformationText;
        private string _imageDownloaderProgramTypeSource;
        private string _groupBoxBorderBrush;
        private string _textBlockDownloaderProgramTypeText;
        private string _buttonBackContent;
        private string _buttonStartContent;
        private string _bottomGridEnable;

        private string _comboBoxSelectedIndex;
        private string _comboBoxVisibility;
        private string _comboBoxText;
        private string _comboBoxImageItem;
        private ObservableCollection<ComboBoxItem> _comboBoxItemes;

        #endregion

        #region Constractor

        public void InitializeComponent()
        {
            BackgroundWindowColor = "#181745";
            BackgroundTopGridColor = "#0F0F2D";
            WindowTitleText = "Multi Downloader";
            TextColor = "White";
            ComboBoxItems = new ObservableCollection<ComboBoxItem>();

            ImagePageInformationSourceHeader = "../Resource/PageInfo.png";
            TextBlockPageInformationHeaderText = "Page Information";
            TextBlockAuthorText = "Author : ";

            TextBlockAuthorInformationText = "Loading...";

            TextBlockPageNameText = "Page Name : ";

            TextBlockPageNameInformationText = "Loading...";

            Page = "بعدا پر شود";
            PageInformation = "Loading...";

            ImageMediaInformationSourceHeader = "../Resource/productDarkpx.png";
            TextBlockMediaInformationHeaderText = "Media Information";
            ImageMediaTypeSource = "../Resource/PageInfo.png";
            TextBlockMediaTypeText = "Media Type : ";
            TextBlockMediaTypeInformationText = "Loading...";
            GroupBoxBorderBrush = "#FFFFFFFF";


            if (ProductStatus is "Instagram")
            {
                ImageDownloaderProgramTypeSource = "../Resource/InstagramDark.png";
                TextBlockDownloaderProgramTypeText = "Instagram";
            }
            else if (ProductStatus is "Youtube")
            {
                ImageDownloaderProgramTypeSource = "../Resource/YoutubeDark.png";
                TextBlockDownloaderProgramTypeText = "Youtube";
            }


            ButtonBackContent = "Back";
            ButtonStartContent = "Start";
            ComboBoxVisibility = "Hidden";
            Alert = new Alert();
            LinkDownloadMultiPageMedia = new List<string>();

            YoutubeClient = new YoutubeClient();
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
        public string TextColor
        {
            get => _textColor;
            set
            {
                _textColor = value;
                NotifyOfPropertyChange(nameof(TextColor));
            }
        }
        public string ImagePageInformationSourceHeader
        {
            get { return _imagePageInformationSourceHeader; }
            set
            {
                _imagePageInformationSourceHeader = value;
                NotifyOfPropertyChange(nameof(ImagePageInformationSourceHeader));
            }
        }
        public string TextBlockPageInformationHeaderText
        {
            get { return _textBlockPageInformationHeaderText; }
            set
            {
                _textBlockPageInformationHeaderText = value;
                NotifyOfPropertyChange(nameof(TextBlockPageInformationHeaderText));
            }
        }
        public string TextBlockAuthorText
        {
            get { return _textBlockAuthorText; }
            set
            {
                _textBlockAuthorText = value;
                NotifyOfPropertyChange(nameof(TextBlockAuthorText));
            }
        }
        public string TextBlockAuthorInformationText
        {
            get { return _textBlockAuthorInformationText; }
            set
            {
                _textBlockAuthorInformationText = value;
                NotifyOfPropertyChange(nameof(TextBlockAuthorInformationText));
            }
        }
        public string TextBlockPageNameText
        {
            get { return _textBlockPageNameText; }
            set
            {
                _textBlockPageNameText = value;
                NotifyOfPropertyChange(nameof(TextBlockPageNameText));
            }
        }
        public string TextBlockPageNameInformationText
        {
            get { return _textBlockPageNameInformationText; }
            set
            {
                _textBlockPageNameInformationText = value;
                NotifyOfPropertyChange(nameof(TextBlockPageNameInformationText));
            }
        }

        //===========================
        public string Page
        {
            get { return _page; }
            set
            {
                _page = value;
                NotifyOfPropertyChange();
            }
        }

        public string PageInformation
        {
            get { return _pageInformation; }
            set
            {
                _pageInformation = value;
                NotifyOfPropertyChange();
            }
        }
        //===========================

        public string ImageMediaInformationSourceHeader
        {
            get { return _imageMediaInformationSourceHeader; }
            set
            {
                _imageMediaInformationSourceHeader = value;
                NotifyOfPropertyChange(nameof(ImageMediaInformationSourceHeader));
            }
        }
        public string TextBlockMediaInformationHeaderText
        {
            get { return _textBlockMediaInformationHeaderText; }
            set
            {
                _textBlockMediaInformationHeaderText = value;
                NotifyOfPropertyChange(nameof(TextBlockMediaInformationHeaderText));
            }
        }
        public string ImageMediaTypeSource
        {
            get { return _imageMediaTypeSource; }
            set
            {
                _imageMediaTypeSource = value;
                NotifyOfPropertyChange(nameof(ImageMediaTypeSource));
            }
        }
        public string TextBlockMediaTypeInformationText
        {
            get { return _textBlockMediaTypeInformationText; }
            set
            {
                _textBlockMediaTypeInformationText = value;
                NotifyOfPropertyChange(nameof(TextBlockMediaTypeInformationText));
            }
        }
        public string TextBlockMediaTypeText
        {
            get { return _textBlockMediaTypeText; }
            set
            {
                _textBlockMediaTypeText = value;
                NotifyOfPropertyChange(nameof(TextBlockMediaTypeText));
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
        public string ImageDownloaderProgramTypeSource
        {
            get { return _imageDownloaderProgramTypeSource; }
            set
            {
                _imageDownloaderProgramTypeSource = value;
                NotifyOfPropertyChange(nameof(ImageDownloaderProgramTypeSource));
            }
        }
        public string TextBlockDownloaderProgramTypeText
        {
            get { return _textBlockDownloaderProgramTypeText; }
            set
            {
                _textBlockDownloaderProgramTypeText = value;
                NotifyOfPropertyChange(nameof(TextBlockDownloaderProgramTypeText));
            }
        }
        public string ButtonBackContent
        {
            get { return _buttonBackContent; }
            set
            {
                _buttonBackContent = value;
                NotifyOfPropertyChange(nameof(ButtonBackContent));
            }
        }
        public string ButtonStartContent
        {
            get { return _buttonStartContent; }
            set
            {
                _buttonStartContent = value;
                NotifyOfPropertyChange(nameof(ButtonStartContent));
            }
        }
        public string ComboBoxVisibility
        {
            get { return _comboBoxVisibility; }
            set
            {
                _comboBoxVisibility = value;
                NotifyOfPropertyChange(nameof(ComboBoxVisibility));
            }
        }
        public string BottomGridEnable
        {
            get { return _bottomGridEnable; }
            set
            {
                _bottomGridEnable = value;
                NotifyOfPropertyChange(nameof(BottomGridEnable));
            }
        }

        public string ComboBoxText
        {
            get { return _comboBoxText; }
            set
            {
                _comboBoxText = value;
                NotifyOfPropertyChange(nameof(ComboBoxText));
            }
        }
        public string ComboBoxImageItem
        {
            get { return _comboBoxImageItem; }
            set
            {
                _comboBoxImageItem = value;
                NotifyOfPropertyChange(nameof(ComboBoxImageItem));
            }
        }
        public string ComboBoxSelectedIndex
        {
            get => _comboBoxSelectedIndex;
            set
            {
                _comboBoxSelectedIndex = value;
                NotifyOfPropertyChange(nameof(ComboBoxSelectedIndex));
            }
        }
        public ObservableCollection<ComboBoxItem> ComboBoxItems
        {
            get { return _comboBoxItemes; }
            set
            {
                _comboBoxItemes = value;
                NotifyOfPropertyChange(nameof(ComboBoxItems));
            }
        }

        #endregion

        public static string InputURL { get; set; }
        public static string ProductStatus { get; set; } //Youtube or Instagram
        public string LinkDownloadSingleMedia { get; set; }
        public Alert Alert { get; set; }
        public List<string> LinkDownloadMultiPageMedia { get; set; }
        public YoutubeClient YoutubeClient { get; set; }

        #endregion
    }
}
