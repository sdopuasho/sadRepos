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
using WPF_Base_Styling_App.UI;
using WPF_Base_Styling_App.UI.Theme;
using WPF_Base_Styling_App.UI.Windows;

namespace AccountigConsumable
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : StyledWindow 
    {
        public MainWindow()
        {
            InitializeComponent();
            
            ThemeManager.SetColorScheme(new OriginalColorScheme());
            ManagerOfFrame.MainFrame = FrameOfVision;
            loadWorker();
        }
        public void loadWorker()
        {
            Worker Wrk = AccountingForConsumablesEntities.GetContext().Worker.Where(w => w.id == SenderMail.IntId).FirstOrDefault();
            if (Wrk.Position.PositionName == "Менеджер по персоналу")
            {
                WorkerBtn.Visibility = Visibility.Visible;
                OrderBtn.Visibility = Visibility.Collapsed;
                ConsumableBtn.Visibility = Visibility.Collapsed;
                RoomBtn.Visibility = Visibility.Collapsed; 
                ManagerOfFrame.MainFrame.Navigate(new WorkersS());
            }
            else if(Wrk.Position.PositionName.Contains("Администратор"))
            {
                WorkerBtn.Visibility = Visibility.Visible;
                OrderBtn.Visibility = Visibility.Visible;
                ConsumableBtn.Visibility = Visibility.Visible;
                RoomBtn.Visibility = Visibility.Visible;
                FrameOfVision.Navigate(new ConsumPageAbout());
            }
            else 
            {
                WorkerBtn.Visibility = Visibility.Collapsed;
                OrderBtn.Visibility = Visibility.Visible;
                ConsumableBtn.Visibility = Visibility.Visible;
                RoomBtn.Visibility = Visibility.Visible;
                FrameOfVision.Navigate(new ConsumPageAbout());
            }
            if (Wrk.CheckFirstVisit == true)
            {
                PasswordWindow psd = new PasswordWindow();
                psd.ShowDialog();
            }
        }

        

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            ManagerOfFrame.MainFrame.GoBack();
        }

        private void ConsumableBtn_Click(object sender, RoutedEventArgs e)
        {
            ManagerOfFrame.MainFrame.Navigate(new ConsumablePage());
        }

        private void WorkerBtn_Click(object sender, RoutedEventArgs e)
        {
            ManagerOfFrame.MainFrame.Navigate(new WorkersS());
        }

        private void OrderBtn_Click(object sender, RoutedEventArgs e)
        {
            ManagerOfFrame.MainFrame.Navigate(new OrderConsumPage());
        }

        private void RoomBtn_Click(object sender, RoutedEventArgs e)
        {
            ManagerOfFrame.MainFrame.Navigate(new RoomPage());
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start("https://hitcom.pro/");
        }
    }
}
