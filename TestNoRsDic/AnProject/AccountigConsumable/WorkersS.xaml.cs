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
    /// Логика взаимодействия для WorkersS.xaml
    /// </summary>
    public partial class WorkersS : Page
    {
        List<Gender> GenderLst = new List<Gender>();
        public WorkersS()
        {
            InitializeComponent();
            DGridConsumable.ItemsSource = AccountingForConsumablesEntities.GetContext().Worker.ToList();
            GenderLst = AccountingForConsumablesEntities.GetContext().Gender.ToList();
            GenderLst.Insert(0, new Gender { GenderName = "All"});
            GenderCmb.ItemsSource = GenderLst;
        }
        public bool CheckForDel(int CountDelRange)
        {

            if (CountDelRange > 0 && SenderMail.PosName== "Администратор")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {
            var EquipmentForRemoving = DGridConsumable.SelectedItems.Cast<Worker>().ToList();
            if (CheckForDel(EquipmentForRemoving.Count) == true)
            {
                if (MessageBox.Show($"Вы точно хотите удалить следующие {EquipmentForRemoving.Count} элементов?", "Внимание",
                    MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    try
                    {
                        AccountingForConsumablesEntities.GetContext().Worker.RemoveRange(EquipmentForRemoving);
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

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            ManagerOfFrame.MainFrame.Navigate(new WorkWithWorkersData(null));
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            ManagerOfFrame.MainFrame.Navigate(new WorkWithWorkersData((sender as Button).DataContext as Worker));
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                AccountingForConsumablesEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGridConsumable.ItemsSource = AccountingForConsumablesEntities.GetContext().Worker.ToList();
            }
        }

        private void GenderCmb_DropDownClosed(object sender, EventArgs e)
        {
            if (GenderCmb.SelectedIndex == 0)
            {
                DGridConsumable.ItemsSource = DGridConsumable.ItemsSource = AccountingForConsumablesEntities.GetContext().Worker.ToList();
            }
            else if (PostionTxt.Text == "")
            {
                DGridConsumable.ItemsSource = AccountingForConsumablesEntities.GetContext().Worker.
                    Where(w => w.Gender.GenderName == GenderCmb.Text).ToList();
            }
            else
            {
                DGridConsumable.ItemsSource = AccountingForConsumablesEntities.GetContext().Worker.
                    Where(w => w.Position.PositionName.StartsWith(PostionTxt.Text) && w.Gender.GenderName == GenderCmb.Text).ToList();
            }
           
        }

        private void PostionTxt_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (PostionTxt.Text == "")
            {
                DGridConsumable.ItemsSource = AccountingForConsumablesEntities.GetContext().Worker.ToList();
            }
            else if (GenderCmb.SelectedIndex == 0)
            {
                DGridConsumable.ItemsSource = AccountingForConsumablesEntities.GetContext().Worker.Where(w => w.Position.PositionName.StartsWith(PostionTxt.Text)).ToList();
            }
            else
            {
                DGridConsumable.ItemsSource = AccountingForConsumablesEntities.GetContext().Worker.Where(w => w.Position.PositionName.StartsWith(PostionTxt.Text) && w.Gender.GenderName == GenderCmb.Text).ToList();
            }
        }

        private void BtnHistory_Click(object sender, RoutedEventArgs e)
        {
            ManagerOfFrame.MainFrame.Navigate(new OperationHistoryPage());
        }

        private void BtnWorker_Click(object sender, RoutedEventArgs e)
        {
            ManagerOfFrame.MainFrame.Navigate(new WorkersS());
        }
    }
}
