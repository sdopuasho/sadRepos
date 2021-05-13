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
    /// Логика взаимодействия для RoomPage.xaml
    /// </summary>
    public partial class RoomPage : Page
    {
        /// <summary>
        /// Инициализация компонентов
        /// </summary>
        public RoomPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Блок проверки разрешения на удаление данных
        /// </summary>
        public bool CheckForDel(int CountDelRange)
        {
            if (CountDelRange < 0)
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
            var RoomForRemoving = DGridConsumable.SelectedItems.Cast<Room>().ToList();
            if (CheckForDel(RoomForRemoving.Count) == true)
            {
                if (MessageBox.Show($"Вы точно хотите удалить следующие {RoomForRemoving.Count} элементов?", "Внимание",
                    MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    try
                    {
                        AccountingForConsumablesEntities.GetContext().Room.RemoveRange(RoomForRemoving);
                        AccountingForConsumablesEntities.GetContext().SaveChanges();
                        MessageBox.Show("Данные удалены");
                        DGridConsumable.ItemsSource = AccountingForConsumablesEntities.GetContext().Worker.ToList();
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
            ManagerOfFrame.MainFrame.Navigate(new EditRoom(null));
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            ManagerOfFrame.MainFrame.Navigate(new EditRoom((sender as Button).DataContext as Room));
        }

        /// <summary>
        /// Блок перезагрузки сущности бд, для корректного отображения данных
        /// </summary>
        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                AccountingForConsumablesEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGridConsumable.ItemsSource = AccountingForConsumablesEntities.GetContext().Room.ToList();
            }
        }
    }
}
