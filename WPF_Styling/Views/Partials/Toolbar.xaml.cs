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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Styling.Views.Partials
{
    /// <summary>
    /// Interaction logic for Toolbar.xaml
    /// </summary>
    public partial class Toolbar : UserControl
    {
        public string Title { get; set; }
        public string BgColor { get; set; }

        public int Length { get; set; }

        public Toolbar()
        {

            //toolbarcontainer.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0x24, 0x63, 0xAE));
            InitializeComponent();
        }
    }
}
