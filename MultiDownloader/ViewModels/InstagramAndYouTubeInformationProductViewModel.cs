using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using Caliburn.Micro;

namespace MultiDownloader.ViewModels
{
    public class InstagramAndYouTubeInformationProductViewModel : Screen
    {

        private string _backgroundWindowColor;
        private string _backgroundTopGridColor;
        private string _windowTitleText;
        private string _textColor;
        private int _comboBoxSelectedIndex;
        private ObservableCollection<ComboBoxItem> _itemes;
        private ComboBoxItem _sitemes;
        private string _imagePageInformationSourceHeader;
        private string _textBlockPageInformationHeaderText;
        private string _textBlockAuthorText;
        private string _textBlockAuthorInformationText;
        private string _textBlockPageNameText;
        private string _textBlockPageNameInformationText;

        //===========================
        private string _page;
        private string _pageInformation;
        //===========================

        private string _imageMediaInformationSourceHeader;
        private string _textBlockMediaInformationHeaderText;
        private string _imageMediaTypeSource;
        private string _textBlockMediaTypeText;
        private string _textBlockMediaTypeInformationText;

        //===========================
        private string _comboBox;
        //===========================

        private string _groupBoxBorderBrush;
        private string _imageDownloaderProgramTypeSource;
        private string _textBlockDownloaderProgramTypeText;
        private string _buttonBackContent;
        private string _buttonStartContent;
        private string _comboBoxVisibility;

        



        public InstagramAndYouTubeInformationProductViewModel()
        {
            BackgroundWindowColor = "#181745";
            BackgroundTopGridColor = "#0F0F2D";
            WindowTitleText = "Multi Downloader";
            TextColor = "White";
            Itemes = new ObservableCollection<ComboBoxItem>()
            {
                new ComboBoxItem(){ Slide="1", ProductType="Nirav", ProductTime="35.34"}
                ,new ComboBoxItem(){Slide="2",ProductType="Kapil", ProductTime="36.34" }
            };
            ImagePageInformationSourceHeader = "../Resource/PageInfo.png";
            TextBlockPageInformationHeaderText = "Page Information";
            TextBlockAuthorText = "Author : ";

            TextBlockAuthorInformationText = "بعدا نوشته شود";

            TextBlockPageNameText = "Page Name : ";

            TextBlockPageNameInformationText = "بعدا نوشته شود";

            Page = "بعدا پر شود";
            PageInformation = "بعدا پر شود";

            ImageMediaInformationSourceHeader = "../Resource/productDarkpx.png";
            TextBlockMediaInformationHeaderText = "Media Information";
            ImageMediaTypeSource = "../Resource/PageInfo.png";
            TextBlockMediaTypeText = "Media Type : ";
            TextBlockMediaTypeInformationText = "Video ( 1:00:00 )";
            GroupBoxBorderBrush = "#FFFFFFFF";
            ImageDownloaderProgramTypeSource = "../Resource/YoutubeDark.png";
            TextBlockDownloaderProgramTypeText = "YouTube";
            ButtonBackContent = "Back";
            ButtonStartContent = "Start";
            ComboBoxVisibility = "Visible";
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
        public string TextColor
        {
            get => _textColor;
            set
            {
                _textColor = value;
                NotifyOfPropertyChange(TextColor);
            }
        }
        public ObservableCollection<ComboBoxItem> Itemes
        {
            get { return _itemes; }
            set { _itemes = value; }
        }
        public ComboBoxItem SItems
        {
            get { return _sitemes; }
            set 
            {
                _sitemes = value;
            }
        }
        public int ComboBoxSelectedIndex 
        {
            get => _comboBoxSelectedIndex;
            set 
            {
                _comboBoxSelectedIndex = value;
                NotifyOfPropertyChange(ComboBoxSelectedIndex.ToString());
            }
        }
        public string ImagePageInformationSourceHeader
        {
            get { return _imagePageInformationSourceHeader; }
            set
            {
                _imagePageInformationSourceHeader = value;
                NotifyOfPropertyChange(ImagePageInformationSourceHeader);
            }
        }
        public string TextBlockPageInformationHeaderText
        {
            get { return _textBlockPageInformationHeaderText; }
            set
            {
                _textBlockPageInformationHeaderText = value;
                NotifyOfPropertyChange(TextBlockPageInformationHeaderText);
            }
        }
        public string TextBlockAuthorText
        {
            get { return _textBlockAuthorText; }
            set
            {
                _textBlockAuthorText = value;
                NotifyOfPropertyChange(TextBlockAuthorText);
            }
        }
        public string TextBlockAuthorInformationText
        {
            get { return _textBlockAuthorInformationText; }
            set
            {
                _textBlockAuthorInformationText = value;
                NotifyOfPropertyChange(TextBlockAuthorText);
            }
        }
        public string TextBlockPageNameText
        {
            get { return _textBlockPageNameText; }
            set
            {
                _textBlockPageNameText = value;
                NotifyOfPropertyChange(TextBlockPageNameText);
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
                NotifyOfPropertyChange(ImageMediaInformationSourceHeader);
            }
        }
        public string TextBlockMediaInformationHeaderText
        {
            get { return _textBlockMediaInformationHeaderText; }
            set
            {
                _textBlockMediaInformationHeaderText = value;
                NotifyOfPropertyChange(TextBlockMediaInformationHeaderText);
            }
        }
        public string ImageMediaTypeSource
        {
            get { return _imageMediaTypeSource; }
            set
            {
                _imageMediaTypeSource = value;
                NotifyOfPropertyChange(ImageMediaTypeSource);
            }
        }
        public string TextBlockMediaTypeInformationText
        {
            get { return _textBlockMediaTypeInformationText; }
            set
            {
                _textBlockMediaTypeInformationText = value;
                NotifyOfPropertyChange(TextBlockMediaTypeInformationText);
            }
        }

        //===========================
        public string ComboBox
        {
            get { return _comboBox; }
            set
            {
                _comboBox = value;
                NotifyOfPropertyChange();
            }
        }
        //===========================

        public string TextBlockMediaTypeText
        {
            get { return _textBlockMediaTypeText; }
            set
            {
                _textBlockMediaTypeText = value;
                NotifyOfPropertyChange(TextBlockMediaTypeText);
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
        public string ImageDownloaderProgramTypeSource
        {
            get { return _imageDownloaderProgramTypeSource; }
            set
            {
                _imageDownloaderProgramTypeSource = value;
                NotifyOfPropertyChange(ImageDownloaderProgramTypeSource);
            }
        }
        public string TextBlockDownloaderProgramTypeText
        {
            get { return _textBlockDownloaderProgramTypeText; }
            set
            {
                _textBlockDownloaderProgramTypeText = value;
                NotifyOfPropertyChange(TextBlockDownloaderProgramTypeText);
            }
        }
        public string ButtonBackContent
        {
            get { return _buttonBackContent; }
            set
            {
                _buttonBackContent = value;
                NotifyOfPropertyChange(ButtonBackContent);
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
                NotifyOfPropertyChange(ComboBoxVisibility);
            }
        }


        #endregion

        #region Methods
        public void ButtonDownload()
        {

        }



        #endregion
    }
}
