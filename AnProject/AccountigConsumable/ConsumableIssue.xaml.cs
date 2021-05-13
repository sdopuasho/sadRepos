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
    /// Логика взаимодействия для ConsumableIssue.xaml
    /// </summary>
    public partial class ConsumableIssue : Page
    {
        /// <summary>
        /// Инициализация компонентов
        /// </summary>
        public ConsumableIssue()
        {
            InitializeComponent();
            DGridConsumable.ItemsSource = AccountingForConsumablesEntities.GetContext().Order.ToList();
        }


        /// <summary>
        /// Блок перезагрузки сущности бд, для корректного отображения данных
        /// </summary>
        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                AccountingForConsumablesEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGridConsumable.ItemsSource = AccountingForConsumablesEntities.GetContext().Order.ToList();
            }
        }

        /// <summary>
        /// Блок перехода к добавлению данных
        /// </summary>
        private void BtnMore_Click_1(object sender, RoutedEventArgs e)
        {

            ManagerOfFrame.MainFrame.Navigate(new OrderMorePage((sender as Button).DataContext as Order));
        }
        /// <summary>
        /// Блоки кнопок навигации
        /// </summary>
        private void BtnConsumable_Click(object sender, RoutedEventArgs e)
        {
            ManagerOfFrame.MainFrame.Navigate(new ConsumablePage());
        }

        private void BtnIssue_Click(object sender, RoutedEventArgs e)
        {
            ManagerOfFrame.MainFrame.Navigate(new ConsumPageAbout());
        }

        private void BtnIssue_Click_1(object sender, RoutedEventArgs e)
        {
            ManagerOfFrame.MainFrame.Navigate(new ConsumableIssue());
        }
    }
}
