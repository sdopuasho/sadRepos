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
    /// Логика взаимодействия для EditOrderInWarehouse.xaml
    /// </summary>
    public partial class EditOrderInWarehouse : Page
    {
        ReplenishmentOfMaterials _currentMat = new ReplenishmentOfMaterials();
        /// <summary>
        /// Инициализация компонентов
        /// </summary>
        public EditOrderInWarehouse(ReplenishmentOfMaterials selectedMat)
        {
            InitializeComponent();
            if (selectedMat != null)
                _currentMat = selectedMat;
            DataContext = _currentMat;
            Fasds.ItemsSource = AccountingForConsumablesEntities.GetContext().Worker.ToList();
            DPDeliver.SelectedDate = DateTime.Now;
        }

        /// <summary>
        /// Обработка нажатие на кнопку сохранить
        /// Производится проверка на пустые поля и выборы из списков
        /// После успешной проверки добавляется либо новая запись либо редактируется существующая
        /// </summary>
        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            string Operations = "Редкатирование данных";
            if (Fasds.SelectedItem == null)
                errors.AppendLine("Рабочий");
            if (string.IsNullOrEmpty(_currentMat.Warehouse.NumberOfWarehouse))
                errors.AppendLine("Номер хранилища");
            if (string.IsNullOrEmpty(_currentMat.Warehouse.ContactNumber))
                errors.AppendLine("Телефон");
            if (string.IsNullOrEmpty(_currentMat.ContractNumber))
                errors.AppendLine("Контракт");
            if (errors.Length > 0)
            {
                if (errors.ToString().Contains("Рабочий"))
                {
                    WorkerFail.Visibility = Visibility.Visible;
                    WorkerFail.Content = "Выберите Работника";
                }
                else
                {
                    WorkerFail.Visibility = Visibility.Collapsed;
                }
                if (errors.ToString().Contains("Номер хранилища"))
                {
                    NumberWarehouseFail.Visibility = Visibility.Visible;
                    NumberWarehouseFail.Content = "Введие номер хранилища";
                }
                else
                {
                    NumberWarehouseFail.Visibility = Visibility.Collapsed;
                }
                if (errors.ToString().Contains("Телефон"))
                {
                    ContactPhoneFail.Visibility = Visibility.Visible;
                    ContactPhoneFail.Content = "Контактный номер";
                }
                else
                {
                    ContactPhoneFail.Visibility = Visibility.Collapsed;
                }
                if (errors.ToString().Contains("Контракт"))
                {
                    ContractFail.Visibility = Visibility.Visible;
                    ContractFail.Content = "Введите номер контракта";
                }
                else
                {
                    ContractFail.Visibility = Visibility.Collapsed;
                }
                return;
            }
            if (_currentMat.id == 0)
            {
                AccountingForConsumablesEntities.GetContext().ReplenishmentOfMaterials.Add(_currentMat);
                Operations = "Добавление новой поставки";
            }
            try
            {
                AccountingForConsumablesEntities.GetContext().SaveChanges();
                AccountingForConsumablesEntities.GetContext().OperationHystory.Add(new OperationHystory() { FK_Worker = SenderMail.IntId, Operation = Operations, DateTimeOfOperation = DateTime.Now });
                AccountingForConsumablesEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
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

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex(@"[^а-яА-Я0-9]");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void TextBox_PreviewTextInput_1(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex(@"[^а-яА-Я0-9]");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void TextBox_PreviewTextInput_2(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex(@"[^а-яА-Я0-9]");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
