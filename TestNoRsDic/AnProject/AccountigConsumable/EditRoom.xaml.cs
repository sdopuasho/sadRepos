using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для EditRoom.xaml
    /// </summary>
    public partial class EditRoom : Page
    {
        Room _currentRoom = new Room();
        public EditRoom(Room selectedRoom)
        {
            InitializeComponent();
            if (selectedRoom != null)
                _currentRoom = selectedRoom;
            DataContext = _currentRoom;
            TypeOfRoomCmb.ItemsSource = AccountingForConsumablesEntities.GetContext().TypeOfRoom.ToList();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errorstring = new StringBuilder();
            if (TypeOfRoomCmb.SelectedItem == null)
                errorstring.AppendLine("Тип");
            if (string.IsNullOrEmpty(_currentRoom.NumberOfRoom.ToString()))
                errorstring.AppendLine("Номер");

            if (errorstring.Length > 0)
            {
                if (errorstring.ToString().Contains("Тип"))
                {
                    TypeOfRoomFail.Visibility = Visibility.Visible;
                    TypeOfRoomFail.Content = "Выберите тип помещения";
                }
                else
                {
                    TypeOfRoomFail.Visibility = Visibility.Collapsed;
                }
                if (errorstring.ToString().Contains("Номер"))
                {
                    NumberFail.Visibility = Visibility.Visible;
                    NumberFail.Content = "Введите номер";
                }
                else
                {
                    NumberFail.Visibility = Visibility.Collapsed;
                }
                return;
            }
            if (_currentRoom.id == 0)
                AccountingForConsumablesEntities.GetContext().Room.Add(_currentRoom);

            try
            {
                AccountingForConsumablesEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
                ManagerOfFrame.MainFrame.GoBack();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void TxtFname_TextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex(@"[^а-яА-Я0-9]");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
