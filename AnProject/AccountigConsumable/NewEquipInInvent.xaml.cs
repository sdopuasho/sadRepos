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

namespace AccountigConsumable.Properties
{
    /// <summary>
    /// Логика взаимодействия для NewEquipInInvent.xaml
    /// </summary>
    public partial class NewEquipInInvent : Page
    {
        MaterialInInventarization _currentMatInInvent = new MaterialInInventarization();
        /// <summary>
        /// Инициализация компонентов
        /// </summary>
        public NewEquipInInvent(MaterialInInventarization SelectedMatInInent)
        {
            InitializeComponent();
            if (SelectedMatInInent != null)
                _currentMatInInvent = SelectedMatInInent;
            DataContext = _currentMatInInvent;
            DelCmb.ItemsSource = AccountingForConsumablesEntities.GetContext().Inventarization.ToList();
            MatCmb.ItemsSource = AccountingForConsumablesEntities.GetContext().Materials.ToList();
        }

        /// <summary>
        /// Обработка нажатие на кнопку сохранить
        /// Производится проверка на пустые поля и выборы из списков
        /// После успешной проверки добавляется либо новая запись либо редактируется существующая
        /// </summary>
        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (DelCmb.SelectedItem == null)
                errors.AppendLine("Инвент");
            if (MatCmb.SelectedItem == null)
                errors.AppendLine("Материал");
            if (string.IsNullOrEmpty(_currentMatInInvent.Amount.ToString()))
                errors.AppendLine("");
            string Operations = "Количество";
            if (errors.ToString().Length > 0)
            {
                if (errors.ToString().Contains("Инвент"))
                {
                    DelFail.Visibility = Visibility.Visible;
                    DelFail.Content = "Выберите инвентаризацию";
                }
                else
                {
                    DelFail.Visibility = Visibility.Collapsed;
                }
                if (errors.ToString().Contains("Материал"))
                {
                    MaterialFail.Visibility = Visibility.Visible;
                    MaterialFail.Content = "Выберите материал";
                }
                else
                {
                    MaterialFail.Visibility = Visibility.Collapsed;
                }
                if (errors.ToString().Contains("Количество"))
                {
                    QuantityFail.Visibility = Visibility.Visible;
                    QuantityFail.Content = "Укажите количество";
                }
                else
                {
                    QuantityFail.Visibility = Visibility.Collapsed;
                }
                return;
            }
            if (_currentMatInInvent.id == 0)
            {
                AccountingForConsumablesEntities.GetContext().MaterialInInventarization.Add(_currentMatInInvent);
                Operations = "Добавление нового материала в инвентаризацию";
            }
            AccountingForConsumablesEntities.GetContext().SaveChanges();
            MessageBox.Show("Информация сохранена");
            AccountingForConsumablesEntities.GetContext().OperationHystory.Add(new OperationHystory() { FK_Worker = SenderMail.IntId, Operation = Operations, DateTimeOfOperation = DateTime.Now });
            AccountingForConsumablesEntities.GetContext().SaveChanges();
            ManagerOfFrame.MainFrame.GoBack();
        }

        /// <summary>
        /// Блоки обработки вводимых данных в поля
        /// </summary>
        private void QuantityTxt_TextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex(@"[^а-яА-Я0-9]");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}