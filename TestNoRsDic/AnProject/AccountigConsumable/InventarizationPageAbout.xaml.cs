using AccountigConsumable.Properties;
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
    /// Логика взаимодействия для InventarizationPageAbout.xaml
    /// </summary>
    public partial class InventarizationPageAbout : Page
    {
        MaterialInInventarization _currentMat = new MaterialInInventarization();
        public InventarizationPageAbout(Inventarization currentInventarization)
        {
            InitializeComponent();
            CmbFIO.Text = currentInventarization.Worker.FIO;
            CmbPlace.Text = currentInventarization.Warehouse.id.ToString();
            CmbPosition.Text = currentInventarization.Worker.Position.PositionName;
            DGridConsumable.ItemsSource = AccountingForConsumablesEntities.GetContext().MaterialInInventarization.Where(w => w.FK_Inventarization == currentInventarization.id).ToList();

        }
        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {
            var EquipmentForRemoving = DGridConsumable.SelectedItems.Cast<MaterialInInventarization>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие {EquipmentForRemoving.Count} элементов?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    AccountingForConsumablesEntities.GetContext().MaterialInInventarization.RemoveRange(EquipmentForRemoving);
                    AccountingForConsumablesEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены");
                    DGridConsumable.ItemsSource = AccountingForConsumablesEntities.GetContext().Inventarization.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());

                }
            }
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            ManagerOfFrame.MainFrame.Navigate(new NewEquipInInvent(null));
        }



        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                AccountingForConsumablesEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGridConsumable.ItemsSource = AccountingForConsumablesEntities.GetContext().MaterialInInventarization.ToList();
            }
        }
        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            ManagerOfFrame.MainFrame.Navigate(new NewEquipInInvent((sender as Button).DataContext as MaterialInInventarization));
        }
    }
}