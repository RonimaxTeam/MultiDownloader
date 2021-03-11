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

        public string TextBlockAuthorText
        {
            get { return _textBlockAuthorText; }
            set
            {
                _textBlockAuthorText = value;

            }
        }



        //NotifyOfPropertyChange();


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

        #endregion

        #region Methods
        public void ButtonDownload()
        {

        }



        #endregion
    }
}
