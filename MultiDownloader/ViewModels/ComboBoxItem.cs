using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace MultiDownloader.ViewModels
{
    public class ComboBoxItem : Screen
    {
        private string _comboBoxImageItem;

        public string SlideOrProductType { get; set; }
        public string ProductTypeAndProductTimeOrQuality { get; set; }

        public string ComboBoxImageItem
        {
            get { return _comboBoxImageItem; }
            set
            {
                _comboBoxImageItem = value;
                NotifyOfPropertyChange(nameof(ComboBoxImageItem));
            }
        }

        public string Size { get; set; }
        
    }
}
