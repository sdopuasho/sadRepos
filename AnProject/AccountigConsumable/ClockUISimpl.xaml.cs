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
    /// Логика взаимодействия для ClockUISimpl.xaml
    /// </summary>
    public partial class ClockUISimpl : UserControl
    {
        public ClockUISimpl()
        {
            InitializeComponent();
            ClockUiStart();
            ClockTxtBlck.FontFamily = new FontFamily("Time New Roman");
            ClockTxtBlck.FontSize = 45;
        }
        public void ClockUiStart()
        {
            DispatcherTimer TimeToClock = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1)
            };

            TimeToClock.Tick += TickEvent;
            TimeToClock.Start();
        }

        private void TickEvent(object sender, EventArgs e)
        {
            ClockTxtBlck.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
