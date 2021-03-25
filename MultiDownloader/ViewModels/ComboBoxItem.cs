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

        public string Slide { get; set; }
        public string ProductTypeAndProductTime { get; set; }

        public string ComboBoxImageItem
        {
            get { return _comboBoxImageItem; }
            set
            {
                _comboBoxImageItem = value;
                NotifyOfPropertyChange(nameof(ComboBoxImageItem));
            }
        }
        
    }
}
