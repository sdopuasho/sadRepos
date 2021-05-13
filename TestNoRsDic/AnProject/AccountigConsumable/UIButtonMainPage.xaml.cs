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

namespace AccountigConsumable
{
    /// <summary>
    /// Логика взаимодействия для UIButtonMainPage.xaml
    /// </summary>
    public partial class UIButtonMainPage : UserControl
    {
        public  string Header { get; set; }
        public  ImageSource IMageSrc { get; set; }
        public  ClickMode Click { get; set; }
        public UIButtonMainPage()
        {
            InitializeComponent();
            DataContext = this;
        }
    }
}
