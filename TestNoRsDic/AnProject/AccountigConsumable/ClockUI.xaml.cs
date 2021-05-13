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
using System.Windows.Threading;

namespace AccountigConsumable
{
    /// <summary>
    /// Логика взаимодействия для ClockUI.xaml
    /// </summary>
    public partial class ClockUI : UserControl
    {
        DispatcherTimer TimeToClock = new DispatcherTimer
        {
            Interval = TimeSpan.FromSeconds(1)
        };
        public ClockUI()
        {
            InitializeComponent();
            ClockUiStart();
            ClockTxtBlck.FontFamily = new FontFamily("Time New Roman");
            ClockTxtBlck.FontSize = 45;
        }
        public void ClockUiStart()
        {
           
            TimeToClock.Tick += TickEvent;
            TimeToClock.Start();
        }

        private void TickEvent(object sender, EventArgs e)
        {
            ClockTxtBlck.Text = DateTime.Now.ToLongTimeString();
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {

            TimeToClock.Start();
        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            TimeToClock.Stop();
        }
    }
}
