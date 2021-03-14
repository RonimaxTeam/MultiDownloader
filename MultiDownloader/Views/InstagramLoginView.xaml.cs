using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MultiDownloader.Views
{
    /// <summary>
    /// Interaction logic for InstagramLoginView.xaml
    /// </summary>
    public partial class InstagramLoginView : Window
    {
        public InstagramLoginView()
        {
            InitializeComponent();
        }

        private void UIElement_OnMouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void ButtonClose_OnClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ButtonMinimize_OnClick(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
    }
}
