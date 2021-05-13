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
    /// Логика взаимодействия для NewInventPAge.xaml
    /// </summary>
    public partial class NewInventPAge : Page
    {
        Inventarization _currentInventarization = new Inventarization() { Date = DateTime.Now };
        /// <summary>
        /// Инициализация компонентов
        /// </summary>
        public NewInventPAge(Inventarization SelectedInvent)
        {
            InitializeComponent();
            if (SelectedInvent != null)
                _currentInventarization = SelectedInvent;
            DataContext = _currentInventarization;
            WarehouseCmb.ItemsSource = AccountingForConsumablesEntities.GetContext().Warehouse.ToList();
            FIOCmb.ItemsSource = AccountingForConsumablesEntities.GetContext().Worker.ToList();
        }
        /// <summary>
        /// Обработка нажатие на кнопку сохранить
        /// Производится проверка на пустые поля и выборы из списков
        /// После успешной проверки добавляется либо новая запись либо редактируется существующая
        /// </summary>
        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            string Operations = "Добавление новой инвентаризации";
            StringBuilder errors = new StringBuilder();
            if (WarehouseCmb.SelectedItem == null)
                errors.AppendLine("Хранилище");
            if (FIOCmb.SelectedItem == null)
                errors.AppendLine("ФИО");
            if (errors.ToString().Length > 0)
            {
                if (errors.ToString().Contains("Хранилище"))
                {
                    WarehouseFail.Visibility = Visibility.Visible;
                    WarehouseFail.Content = "Выберите номер хранилища";
                }
                else
                {
                    WarehouseFail.Visibility = Visibility.Collapsed;
                }
                if (errors.ToString().Contains("ФИО"))
                {
                    FIOFail.Visibility = Visibility.Visible;
                    FIOFail.Content = "Выберите сотрудника";
                }
                else
                {
                    FIOFail.Visibility = Visibility.Collapsed;
                }
                return;
            }
            try
            {
                AccountingForConsumablesEntities.GetContext().Inventarization.Add(_currentInventarization);
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
    }
}