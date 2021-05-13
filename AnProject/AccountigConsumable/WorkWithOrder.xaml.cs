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
    /// Логика взаимодействия для WorkWithOrder.xaml
    /// </summary>
    public partial class WorkWithOrder : Page
    {
        WorkPlace _currentWorkPlace = new WorkPlace();
        /// <summary>
        /// Инициализация компонентов
        /// </summary>
        public WorkWithOrder(WorkPlace SelectedWork)
        {
            InitializeComponent();
            if (SelectedWork != null)
                _currentWorkPlace = SelectedWork;
            DataContext = _currentWorkPlace;
            FIOBox.ItemsSource = AccountingForConsumablesEntities.GetContext().Worker.ToList();
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
            _currentWorkPlace.FK_Room = 15;
            if (string.IsNullOrEmpty(_currentWorkPlace.NumberPlace.ToString()))
                errorstring.AppendLine("Номер");
            if (FIOBox.SelectedItem == null)
                errorstring.AppendLine("ФИО");
            if (errorstring.Length > 0)
            {
                if (errorstring.ToString().Contains("ФИО"))
                {
                    FIOFail.Visibility = Visibility.Visible;
                    FIOFail.Content = "Выберите ФИО сотрудника";
                }
                else
                {
                    FIOFail.Visibility = Visibility.Collapsed;
                }
                if (errorstring.ToString().Contains("Номер"))
                {
                    WorkPlaceFail.Visibility = Visibility.Visible;
                    WorkPlaceFail.Content = "Введите номер рабочего места";
                }
                else
                {
                    WorkPlaceFail.Visibility = Visibility.Collapsed;
                }
                return;
            }
            if (_currentWorkPlace.id == 0)
            {
                AccountingForConsumablesEntities.GetContext().WorkPlace.Add(_currentWorkPlace);

                Operations = "Добавление нового помещения";
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
        /// Блок обработки вводимых данных в поля
        /// </summary>
        private void TxtWorkPlace_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
