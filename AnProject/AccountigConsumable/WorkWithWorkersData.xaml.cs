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
    /// Логика взаимодействия для WorkWithWorkersData.xaml
    /// </summary>
    public partial class WorkWithWorkersData : Page
    {
        Worker _currentWorker = new Worker();
        /// <summary>
        /// Инициализация компонентов
        /// </summary>
        public WorkWithWorkersData(Worker SelectedWork)
        {
            InitializeComponent();
            if (SelectedWork != null)
                _currentWorker = SelectedWork;
            DataContext = _currentWorker;
            ComboPosition.ItemsSource = AccountingForConsumablesEntities.GetContext().Position.ToList();
            ComboStatus.ItemsSource = AccountingForConsumablesEntities.GetContext().StatusOfWorker.ToList();
            GenderBox.ItemsSource = AccountingForConsumablesEntities.GetContext().Gender.ToList();
        }
        /// <summary>
        /// Обработка нажатие на кнопку сохранить
        /// Производится проверка на пустые поля и выборы из списков
        /// После успешной проверки добавляется либо новая запись либо редактируется существующая
        /// </summary>

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            string Operations = "Редкатирование данных";
            StringBuilder errorstring = new StringBuilder();
            _currentWorker.Login = "New2Q^";
            _currentWorker.Password = "AbcdW23#";
            if (string.IsNullOrWhiteSpace(_currentWorker.FirstName))
                errorstring.AppendLine("Имя");
            if (string.IsNullOrWhiteSpace(_currentWorker.LastName))
                errorstring.AppendLine("Фамилия");
            if (string.IsNullOrWhiteSpace(_currentWorker.MiddleName))
                errorstring.AppendLine("Отчество");
            if (string.IsNullOrWhiteSpace(_currentWorker.PhoneNumber))
                errorstring.AppendLine("Телефон");
            if (string.IsNullOrWhiteSpace(_currentWorker.Email))
                errorstring.AppendLine("Почта");
            if (ComboStatus.SelectedItem == null)
                errorstring.AppendLine("Статус");
            if (GenderBox.SelectedItem == null)
                errorstring.AppendLine("Пол");
            if (ComboPosition.SelectedItem == null)
                errorstring.AppendLine("Должность");
            if (errorstring.Length > 0)
            {
                if (errorstring.ToString().Contains("Имя"))
                {
                    FNameFail.Visibility = Visibility.Visible;
                    FNameFail.Content = "Введите имя";
                }
                else
                {
                    FNameFail.Visibility = Visibility.Collapsed;
                }
                if (errorstring.ToString().Contains("Фамилия"))
                {
                    LNameFail.Visibility = Visibility.Visible;
                    LNameFail.Content = "Введите фамилию";
                }
                else
                {
                    LNameFail.Visibility = Visibility.Collapsed;
                }
                if (errorstring.ToString().Contains("Отчество"))
                {
                    MNameFail.Visibility = Visibility.Visible;
                    MNameFail.Content = "Введите отчество";
                }
                else
                {
                    MNameFail.Visibility = Visibility.Collapsed;
                }
                if (errorstring.ToString().Contains("Телефон"))
                {
                    PhoneFail.Visibility = Visibility.Visible;
                    PhoneFail.Content = "Введите телефон";
                }
                else
                {
                    PhoneFail.Visibility = Visibility.Collapsed;
                }
                if (errorstring.ToString().Contains("Почта"))
                {
                    EmailFail.Visibility = Visibility.Visible;
                    EmailFail.Content = "Введите почту";
                }
                else
                {
                    EmailFail.Visibility = Visibility.Collapsed;
                }
                if (errorstring.ToString().Contains("Статус"))
                {
                    ComboStatisFail.Visibility = Visibility.Visible;
                    ComboStatisFail.Content = "Выберите статус";
                }
                else
                {
                    ComboStatisFail.Visibility = Visibility.Collapsed;
                }
                if (errorstring.ToString().Contains("Должность"))
                {
                    GenderFail.Visibility = Visibility.Visible;
                    GenderFail.Content = "Выберите должность";
                }
                else
                {
                    ComboPositionFail.Visibility = Visibility.Collapsed;
                }
                if (errorstring.ToString().Contains("Пол"))
                {
                    GenderFail.Visibility = Visibility.Visible;
                    GenderFail.Content = "Выберите пол";
                }
                else
                {
                    GenderFail.Visibility = Visibility.Collapsed;
                }
                return;
            }
            if (_currentWorker.id == 0)
            {
                AccountingForConsumablesEntities.GetContext().Worker.Add(_currentWorker);
                Operations = "Добавление нового пользователя";
            }
            try
            {
                AccountingForConsumablesEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена"); 
                AccountingForConsumablesEntities.GetContext().OperationHystory.Add(new OperationHystory() { FK_Worker = SenderMail.IntId, Operation = Operations, DateTimeOfOperation = DateTime.Now });
                AccountingForConsumablesEntities.GetContext().SaveChanges();
                ManagerOfFrame.MainFrame.GoBack();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        /// <summary>
        /// Блоки обработки вводимых данных в поля
        /// </summary>
        private void EmailTxt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9.(.).+.-.@]");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void PhoneTxt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9.(.).+.-]");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void TxtMName_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex(@"[^а-яА-Я]");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void TxtLastName_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex(@"[^а-яА-Я]");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void TxtFname_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex(@"[^а-яА-Я]");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
