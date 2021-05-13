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
    /// Логика взаимодействия для OrderConsumPage.xaml
    /// </summary>
    public partial class OrderConsumPage : Page
    {
        List<Worker> WorkerLst = new List<Worker>();
        /// <summary>
        /// Инициализация компонентов
        /// </summary>
        public OrderConsumPage()
        {
            InitializeComponent();
            DGridConsumable.ItemsSource = AccountingForConsumablesEntities.GetContext().WorkPlace.ToList();
        }

        /// <summary>
        /// Блок проверки разрешения на удаление данных
        /// </summary>
        public bool CheckForDel(int CountDelRange)
        {
            if (CountDelRange > 0 && SenderMail.PosName.Contains("Администратор"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Обработчик кнопки удаление данных
        /// Если блок проверки вернет положительный результат
        /// То появится сообщение с подтверждением удаления
        /// Если согласится то данные будут удалены
        /// </summary>
        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {
            var EquipmentForRemoving = DGridConsumable.SelectedItems.Cast<WorkPlace>().ToList();
            if (CheckForDel(EquipmentForRemoving.Count) == true)
            {
                if (MessageBox.Show($"Вы точно хотите удалить следующие {EquipmentForRemoving.Count} элементов?", "Внимание",
                    MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    try
                    {
                        AccountingForConsumablesEntities.GetContext().WorkPlace.RemoveRange(EquipmentForRemoving);
                        AccountingForConsumablesEntities.GetContext().SaveChanges();
                        MessageBox.Show("Данные удалены");
                        DGridConsumable.ItemsSource = AccountingForConsumablesEntities.GetContext().WorkPlace.ToList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());

                    }
                }
            }
            else
            {
                return;
            }
        }

        /// <summary>
        /// Блоки перехода к добавлению и редактированию данных
        /// </summary>
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            ManagerOfFrame.MainFrame.Navigate(new WorkWithOrder(null));
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            ManagerOfFrame.MainFrame.Navigate(new WorkWithOrder((sender as Button).DataContext as WorkPlace));

        }

        /// <summary>
        /// Блок перезагрузки сущности бд, для корректного отображения данных
        /// </summary>
        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                AccountingForConsumablesEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGridConsumable.ItemsSource = AccountingForConsumablesEntities.GetContext().WorkPlace.ToList();
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
        }

        /// <summary>
        /// Блоки сортировки и поиска данных по тексту
        /// </summary>
        private void BtnInventarization_Click(object sender, RoutedEventArgs e)
        {
            ManagerOfFrame.MainFrame.Navigate(new Inventarizationpage());
        }
        private void BtnOrder_Click(object sender, RoutedEventArgs e)
        {
            ManagerOfFrame.MainFrame.Navigate(new OrderConsumPage());
        }

        private void BtnSupplWarehouse_Click(object sender, RoutedEventArgs e)
        {
            ManagerOfFrame.MainFrame.Navigate(new OrderInWarehouse());
        }
    }
}
