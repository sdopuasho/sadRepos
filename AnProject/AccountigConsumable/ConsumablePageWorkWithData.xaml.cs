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
    /// Логика взаимодействия для ConsumablePageWorkWithData.xaml
    /// </summary>
    public partial class ConsumablePageWorkWithData : Page
    {
        MaterialCard _currentMaterialCard = new MaterialCard();
        /// <summary>
        /// Инициализация компонентов
        /// </summary>
        public ConsumablePageWorkWithData(MaterialCard SelectedMCard)
        {
            InitializeComponent();
            if (SelectedMCard != null)
                _currentMaterialCard = SelectedMCard;
            DataContext = _currentMaterialCard;
            CmbGroup.ItemsSource = AccountingForConsumablesEntities.GetContext().MaterialGroup.ToList();
            CmbManufacturer.ItemsSource = AccountingForConsumablesEntities.GetContext().Manufacturer.ToList();
            CmbUnit.ItemsSource = AccountingForConsumablesEntities.GetContext().Unit.ToList();
            CmbNameMaterial.ItemsSource = AccountingForConsumablesEntities.GetContext().Materials.ToList();
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
            _currentMaterialCard.DateOfDelivery = DateTime.Now;
            if (string.IsNullOrWhiteSpace(_currentMaterialCard.InventNumber))
                errorstring.AppendLine("Инвентаризация");
            if (CmbGroup.SelectedItem == null)
                errorstring.AppendLine("Группа");
            if (CmbManufacturer.SelectedItem == null)
                errorstring.AppendLine("Производитель");
            if (CmbNameMaterial.SelectedItem == null)
                errorstring.AppendLine("Материал");
            if (CmbUnit.SelectedItem == null)
                errorstring.AppendLine("Единица");

            if (errorstring.Length > 0)
            {
                if (errorstring.ToString().Contains("Инвентаризация"))
                {
                    InventNumberFail.Visibility = Visibility.Visible;
                    InventNumberFail.Content = "Укажите инвентаризационный номер";
                }
                else
                {
                    InventNumberFail.Visibility = Visibility.Collapsed;
                }
                if (errorstring.ToString().Contains("Группа"))
                {
                    MaterialGroupFail.Visibility = Visibility.Visible;
                    MaterialGroupFail.Content = "Выберите группу материала";
                }
                else
                {
                    MaterialGroupFail.Visibility = Visibility.Collapsed;
                }
                if (errorstring.ToString().Contains("Производитель"))
                {
                    ManufacturerFail.Visibility = Visibility.Visible;
                    ManufacturerFail.Content = "Выберите производителя";
                }
                else
                {
                    ManufacturerFail.Visibility = Visibility.Collapsed;
                }
                if (errorstring.ToString().Contains("Материал"))
                {
                    MaterialnameFail.Visibility = Visibility.Visible;
                    MaterialnameFail.Content = "Выберите материал";
                }
                else
                {
                    MaterialnameFail.Visibility = Visibility.Collapsed;
                }
                if (errorstring.ToString().Contains("Единица"))
                {
                    UnitFail.Visibility = Visibility.Visible;
                    UnitFail.Content = "Выберите единицу измерения";
                }
                else
                {
                    UnitFail.Visibility = Visibility.Collapsed;
                }
                return;
            }
            if (_currentMaterialCard.id == 0)
            {
                AccountingForConsumablesEntities.GetContext().MaterialCard.Add(_currentMaterialCard);
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
        /// Блок обработки вводимых данных в поля
        /// </summary>

        private void TxtInventNumber_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex(@"[^а-яА-Я0-9]");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
