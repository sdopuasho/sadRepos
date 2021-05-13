using AccountigConsumable.Properties;
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
    /// Логика взаимодействия для Inventarizationpage.xaml
    /// </summary>
    public partial class Inventarizationpage : Page
    {
        /// <summary>
        /// Инициализация компонентов
        /// </summary>
        public Inventarizationpage()
        {
            InitializeComponent();
            DGridConsumable.ItemsSource = AccountingForConsumablesEntities.GetContext().Inventarization.ToList();
        }
        /// <summary>
        /// Обработчик кнопки удаление данных
        /// То появится сообщение с подтверждением удаления
        /// Если согласится то данные будут удалены
        /// </summary>
        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {
            var EquipmentForRemoving = DGridConsumable.SelectedItems.Cast<Inventarization>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие {EquipmentForRemoving.Count} элементов?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    AccountingForConsumablesEntities.GetContext().Inventarization.RemoveRange(EquipmentForRemoving);
                    AccountingForConsumablesEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены");
                    DGridConsumable.ItemsSource = AccountingForConsumablesEntities.GetContext().Inventarization.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());

                }
            }
        }

        /// <summary>
        /// Блоки перехода к добавлению и редактированию данных
        /// </summary>
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            ManagerOfFrame.MainFrame.Navigate(new NewInventPAge(null));
        }


        private void BtnEdit_Click_1(object sender, RoutedEventArgs e)
        {
            ManagerOfFrame.MainFrame.Navigate(new InventarizationPageAbout((sender as Button).DataContext as Inventarization));
        }

        private void BtnEdit_Click_2(object sender, RoutedEventArgs e)
        {
            ManagerOfFrame.MainFrame.Navigate(new NewInventPAge((sender as Button).DataContext as Inventarization));
        }


        /// <summary>
        /// Блок перезагрузки сущности бд, для корректного отображения данных
        /// </summary>
        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                AccountingForConsumablesEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGridConsumable.ItemsSource = AccountingForConsumablesEntities.GetContext().Inventarization.ToList();
            }
        }
        /// <summary>
        /// Блоки кнопок навигации
        /// </summary>
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnOrder_Click(object sender, RoutedEventArgs e)
        {
            ManagerOfFrame.MainFrame.Navigate(new OrderConsumPage());
        }

        private void BtnSupplWarehouse_Click(object sender, RoutedEventArgs e)
        {
            ManagerOfFrame.MainFrame.Navigate(new OrderInWarehouse());
        }

        private void BtnInventarization_Click(object sender, RoutedEventArgs e)
        {
            ManagerOfFrame.MainFrame.Navigate(new Inventarizationpage());
        }
    }
}
