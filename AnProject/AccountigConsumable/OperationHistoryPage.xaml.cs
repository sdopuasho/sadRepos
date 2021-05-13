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
    /// Логика взаимодействия для OperationHistoryPage.xaml
    /// </summary>
    public partial class OperationHistoryPage : Page
    {
        List<Worker> WorkerLst = new List<Worker>();
        /// <summary>
        /// Инициализация компонентов
        /// </summary>
        public OperationHistoryPage()
        {
            InitializeComponent();
            WorkerLst = AccountingForConsumablesEntities.GetContext().Worker.ToList();
            WorkerLst.Insert(0, new Worker { FirstName = "All" });
            FIOCmb.ItemsSource = WorkerLst;
            DGridConsumable.ItemsSource = AccountingForConsumablesEntities.GetContext().OperationHystory.ToList();
        }
        /// <summary>
        /// Блоки сортировки и поиска данных по тексту
        /// </summary>
        private void BtnHistory_Click(object sender, RoutedEventArgs e)
        {
            ManagerOfFrame.MainFrame.Navigate(new OperationHistoryPage());
        }

        private void BtnWorker_Click(object sender, RoutedEventArgs e)
        {
            ManagerOfFrame.MainFrame.Navigate(new WorkersS());
        }

        /// <summary>
        /// Блоки кнопок навигации
        /// </summary>
        private void FIOCmb_DropDownClosed(object sender, EventArgs e)
        {
            if(FIOCmb.SelectedIndex == 0)
            {
                DGridConsumable.ItemsSource = AccountingForConsumablesEntities.GetContext().OperationHystory.ToList();
            }
            else
            {
                DGridConsumable.ItemsSource = AccountingForConsumablesEntities.GetContext().OperationHystory.Where(w => w.Worker.FirstName.StartsWith(FIOCmb.Text.Substring(0, FIOCmb.Text.Length - 4))).ToList();
            }
        }
    }
}
