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
using Word = Microsoft.Office.Interop.Word;
using Microsoft.Win32;

namespace AccountigConsumable
{
    /// <summary>
    /// Логика взаимодействия для ConsumablePage.xaml
    /// </summary>
    public partial class ConsumablePage : Page
    {
        List<Manufacturer> ManufacturerLst = new List<Manufacturer>();
        /// <summary>
        /// Инициализация компонентов
        /// </summary>
        public ConsumablePage()
        {
            InitializeComponent();
            DGridConsumable.ItemsSource = AccountingForConsumablesEntities.GetContext().MaterialCard.ToList();
            ManufacturerLst = AccountingForConsumablesEntities.GetContext().Manufacturer.ToList();
            ManufacturerLst.Insert(0, new Manufacturer { ManufacturerName = "All" });
            ManufacturerCmb.ItemsSource = ManufacturerLst;


        }
        /// <summary>
        /// Блок проверки разрешения на удаление данных
        /// </summary>
        public bool CheckForDel(int CountDelRange)
        {
            if (CountDelRange > 0 && SenderMail.PosName.Contains("Администратор"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Обработчик кнопки удаление данных
        /// Если блок проверки вернет положительный результат
        /// То появится сообщение с подтверждением удаления
        /// Если согласится то данные будут удалены
        /// </summary>
        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {
            var EquipmentForRemoving = DGridConsumable.SelectedItems.Cast<MaterialCard>().ToList();
            if (CheckForDel(EquipmentForRemoving.Count) == true)
            {
                if (MessageBox.Show($"Вы точно хотите удалить следующие {EquipmentForRemoving.Count} элементов?", "Внимание",
                    MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    try
                    {
                        AccountingForConsumablesEntities.GetContext().MaterialCard.RemoveRange(EquipmentForRemoving);
                        AccountingForConsumablesEntities.GetContext().SaveChanges();
                        MessageBox.Show("Данные удалены");
                        DGridConsumable.ItemsSource = AccountingForConsumablesEntities.GetContext().MaterialCard.ToList();
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

        /// <summary>
        /// Блоки перехода к добавлению и редактированию данных
        /// </summary>
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            ManagerOfFrame.MainFrame.Navigate(new ConsumablePageWorkWithData(null));
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            ManagerOfFrame.MainFrame.Navigate(new ConsumablePageWorkWithData((sender as Button).DataContext as MaterialCard));
        }

        /// <summary>
        /// Блок перезагрузки сущности бд, для корректного отображения данных
        /// </summary>
        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                AccountingForConsumablesEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGridConsumable.ItemsSource = AccountingForConsumablesEntities.GetContext().MaterialCard.ToList();
            }
        }
        /// <summary>
        /// Блоки кнопок навигации
        /// </summary>

        private void BtnConsumable_Click(object sender, RoutedEventArgs e)
        {
            ManagerOfFrame.MainFrame.Navigate(new ConsumablePage());
        }

        private void BtnIssue_Click(object sender, RoutedEventArgs e)
        {
            ManagerOfFrame.MainFrame.Navigate(new ConsumPageAbout());
        }

        private void BtnIssue_Click_1(object sender, RoutedEventArgs e)
        {
            ManagerOfFrame.MainFrame.Navigate(new ConsumableIssue());
        }

        /// <summary>
        /// Блоки сортировки и поиска данных по тексту
        /// </summary>
        private void NameTxt_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (NameTxt.Text == "")
            {
                DGridConsumable.ItemsSource = AccountingForConsumablesEntities.GetContext().MaterialCard.ToList();
            }
            else if (ManufacturerCmb.SelectedIndex == 0)
            {
                DGridConsumable.ItemsSource = AccountingForConsumablesEntities.GetContext().MaterialCard.Where(w => w.Materials.MaterialName.StartsWith(NameTxt.Text)).ToList();
            }
            else
            {
                DGridConsumable.ItemsSource = AccountingForConsumablesEntities.GetContext().
                    MaterialCard.Where(w => w.Materials.MaterialName.StartsWith(NameTxt.Text) && w.Materials.Manufacturer.ManufacturerName == ManufacturerCmb.Text).ToList();
            }
        }

        private void Manufacturer_DropDownClosed(object sender, EventArgs e)
        {
            if (ManufacturerCmb.SelectedIndex == 0)
            {
                DGridConsumable.ItemsSource = DGridConsumable.ItemsSource = AccountingForConsumablesEntities.GetContext().MaterialCard.ToList();
            }
            else if (NameTxt.Text == "")
            {
                DGridConsumable.ItemsSource = AccountingForConsumablesEntities.GetContext().MaterialCard.
                    Where(w => w.Materials.Manufacturer.ManufacturerName == ManufacturerCmb.Text).ToList();
            }
            else
            {
                DGridConsumable.ItemsSource = AccountingForConsumablesEntities.GetContext().
                    MaterialCard.Where(w => w.Materials.MaterialName.StartsWith(NameTxt.Text) && w.Materials.Manufacturer.ManufacturerName == ManufacturerCmb.Text).ToList();
            }
        }
        /// <summary>
        /// Блок составления отчета
        /// </summary>
        private void ReportBtn_Click(object sender, RoutedEventArgs e)
        {
            if (DGridConsumable.SelectedItem == null)
            {
                return;
            }
            else
            {
                SaveFileDialog openDlg = new SaveFileDialog();
                openDlg.FileName = "Отчет №";
                openDlg.Filter = "Word (.doc)|*.doc |Word (.docx)|*.docx |All files (*.*)|*.*";
                openDlg.FilterIndex = 2;
                openDlg.RestoreDirectory = true;
                if (openDlg.ShowDialog() == true)
                {
                    Word.Application word = new Microsoft.Office.Interop.Word.Application();
                    Word.Document doc = word.Documents.Open(Environment.CurrentDirectory + @"\Kartochka_materialov.docx");
                    var SelectedInfo = DGridConsumable.SelectedItems.Cast<MaterialCard>().FirstOrDefault() as MaterialCard;
                    
                    var Date = DateTime.Now.ToShortDateString();
                    var Worker1 = AccountingForConsumablesEntities.GetContext().Worker.Where(w => w.id == 2).FirstOrDefault();
                    try
                    {
                        ReplaceWordStub("{GetDate}", Date, doc);
                        ReplaceWordStub("{N}", SelectedInfo.id.ToString(), doc);
                        ReplaceWordStub("{InventNumber}", SelectedInfo.InventNumber, doc);
                        ReplaceWordStub("{idUnit}", SelectedInfo.Materials.Unit.id.ToString(), doc);
                        ReplaceWordStub("{Unit}", SelectedInfo.Materials.Unit.UnitName, doc);
                        ReplaceWordStub("{MaterialGroup}", SelectedInfo.Materials.MaterialGroup.NameOfMaterialGroup, doc);
                        ReplaceWordStub("{DateOfDelivery}", SelectedInfo.DateOfDelivery.ToShortDateString(), doc);
                        ReplaceWordStub("{Manufacturer}", SelectedInfo.Materials.Manufacturer.ManufacturerName, doc);
                        ReplaceWordStub("{MaterialName}", SelectedInfo.Materials.MaterialName, doc);
                        ReplaceWordStub("{Position}", Worker1.Position.PositionName, doc);
                        ReplaceWordStub("{FirstName}", Worker1.FirstName, doc);
                        ReplaceWordStub("{LastName}", Worker1.LastName, doc);
                        ReplaceWordStub("{MiddleName}", Worker1.MiddleName, doc);
                        ReplaceWordStub("{GetDate1}", Date, doc);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex);
                    }
                    doc.SaveAs2(openDlg.FileName);
                    doc.Close();
                }
            }
            
        }
        /// <summary>
        /// Блок замены данных в документе
        /// </summary>
        private void ReplaceWordStub(string stubToReplace, string text, Word.Document wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);

        }
    }
}
