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
    /// Логика взаимодействия для WorkWithInvent.xaml
    /// </summary>
    public partial class WorkWithInvent : Page
    {
        Inventarization _currentWorkPlace = new Inventarization();
        /// <summary>
        /// Инициализация компонентов
        /// </summary>
        public WorkWithInvent(Inventarization SelectedWork)
        {
            InitializeComponent();
            if (SelectedWork != null)
                _currentWorkPlace = SelectedWork;
            DataContext = _currentWorkPlace;
            FIOBox.ItemsSource = AccountingForConsumablesEntities.GetContext().Worker.ToList();
            WarehouseCmb.ItemsSource = AccountingForConsumablesEntities.GetContext().Warehouse.ToList();
        }

        /// <summary>
        /// Обработка нажатие на кнопку сохранить
        /// Производится проверка на пустые поля и выборы из списков
        /// После успешной проверки добавляется либо новая запись либо редактируется существующая
        /// </summary>

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errorstring = new StringBuilder();

            string Operations = "Редкатирование данных"; 
            if (string.IsNullOrEmpty(_currentWorkPlace.Warehouse.ToString()))
                errorstring.AppendLine("Хранилище");
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
                if (errorstring.ToString().Contains("Хранилище"))
                {
                    WarehouseFail.Visibility = Visibility.Visible;
                    WarehouseFail.Content = "Введите номер хранилища";
                }
                else
                {
                    WarehouseFail.Visibility = Visibility.Collapsed;
                }
                return;
            }
            if (_currentWorkPlace.id == 0) 
            { 
                AccountingForConsumablesEntities.GetContext().Inventarization.Add(_currentWorkPlace);
                Operations = "Добавление нового заказа";
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
    }
}
