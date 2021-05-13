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
    /// Логика взаимодействия для OrderInWarehouse.xaml
    /// </summary>
    public partial class OrderInWarehouse : Page
    {
        List<Worker> WorkerLst = new List<Worker>();
        public OrderInWarehouse()
        {
            InitializeComponent();
            WorkerLst = AccountingForConsumablesEntities.GetContext().Worker.ToList();
            WorkerLst.Insert(0, new Worker { FirstName = "All" });
            FIOCmb.ItemsSource = WorkerLst;
            DGridConsumable.ItemsSource = AccountingForConsumablesEntities.GetContext().ReplenishmentOfMaterials.ToList();
        }
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

        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {
            var OrderForRemoving = DGridConsumable.SelectedItems.Cast<ReplenishmentOfMaterials>().ToList();
            if (CheckForDel(OrderForRemoving.Count) == true)
            {

                if (MessageBox.Show($"Вы точно хотите удалить следующие {OrderForRemoving.Count} элементов?", "Внимание",
                    MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    try
                    {
                        AccountingForConsumablesEntities.GetContext().ReplenishmentOfMaterials.RemoveRange(OrderForRemoving);
                        AccountingForConsumablesEntities.GetContext().SaveChanges();
                        MessageBox.Show("Данные удалены");
                        DGridConsumable.ItemsSource = AccountingForConsumablesEntities.GetContext().WorkPlace.ToList();
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
            ManagerOfFrame.MainFrame.Navigate(new EditOrderInWarehouse(null));
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            ManagerOfFrame.MainFrame.Navigate(new EditOrderInWarehouse((sender as Button).DataContext as ReplenishmentOfMaterials));
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                AccountingForConsumablesEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGridConsumable.ItemsSource = AccountingForConsumablesEntities.GetContext().ReplenishmentOfMaterials.ToList();
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
        private void BtnOrder_Click(object sender, RoutedEventArgs e)
        {
            ManagerOfFrame.MainFrame.Navigate(new OrderConsumPage());
        }

        private void BtnSupplWarehouse_Click(object sender, RoutedEventArgs e)
        {
            ManagerOfFrame.MainFrame.Navigate(new OrderInWarehouse());
        }

        private void FIO_DropDownClosed(object sender, EventArgs e)
        {
            if(FIOCmb.SelectedIndex == 0)
            {
                DGridConsumable.ItemsSource = AccountingForConsumablesEntities.GetContext().ReplenishmentOfMaterials.ToList();
            }
            else
            {
                DGridConsumable.ItemsSource = AccountingForConsumablesEntities.GetContext().ReplenishmentOfMaterials.Where(w=>w.Worker.FIO.StartsWith(FIOCmb.Text.Substring(0, FIOCmb.Text.Length - 4))).ToList();
            }
        }

        private void RaportBtn_Click(object sender, RoutedEventArgs e)
        {
            if(DGridConsumable.SelectedItem == null)
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
                    Word.Document doc = word.Documents.Open(Environment.CurrentDirectory + @"\Tovarny_otchyot_-_materialy.doc");
                    var SelectedInfo = DGridConsumable.SelectedItems.Cast<ReplenishmentOfMaterials>().FirstOrDefault() as ReplenishmentOfMaterials;
                    var info = AccountingForConsumablesEntities.GetContext().MaterialsInDelivery.Where(w => w.FK_Replenishment == SelectedInfo.id).FirstOrDefault();
                    var XHuman1 = AccountingForConsumablesEntities.GetContext().Worker.Where(w => w.id == 1).Select(s => s.FirstName + " " + s.MiddleName.Substring(0, 1) + " " + s.LastName.Substring(0, 1)).FirstOrDefault();
                    var XHuman2 = AccountingForConsumablesEntities.GetContext().Worker.Where(w => w.id == 5).Select(s => s.FirstName + " " + s.MiddleName.Substring(0, 1) + " " + s.LastName.Substring(0, 1)).FirstOrDefault();
                    var XHuman3 = AccountingForConsumablesEntities.GetContext().Worker.Where(w => w.id == 9).Select(s => s.FirstName + " " + s.MiddleName.Substring(0, 1) + " " + s.LastName.Substring(0, 1)).FirstOrDefault();
                    var NameOfMaterial = info.MaterialCard.Materials.MaterialName;
                    var Date = DateTime.Now.ToShortDateString();
                    var date2 = DateTime.Now.AddDays(7).ToShortDateString();
                    var date3 = info.ReplenishmentOfMaterials.DateOfAcceptanceToTheWarehouse.ToShortDateString();
                    var Number = info.ReplenishmentOfMaterials.ContractNumber;
                    var Worker1 = AccountingForConsumablesEntities.GetContext().Worker.Where(w => w.id == 2).FirstOrDefault();
                    var Worker2 = AccountingForConsumablesEntities.GetContext().Worker.Where(w => w.id == 34).FirstOrDefault();
                    var GetDate = DateTime.Today.ToShortDateString();
                    try
                    {
                        ReplaceWordStub("{getdate1}", Date, doc);
                        ReplaceWordStub("{GetDate2}", Date, doc);
                        ReplaceWordStub("{FirstDate}", date2, doc);
                        ReplaceWordStub("{DateOfDelivery}", date3, doc);
                        ReplaceWordStub("{Number}", Number, doc);
                        ReplaceWordStub("{FirstName1}", Worker1.FirstName, doc);
                        ReplaceWordStub("{FirstName2}", Worker1.FirstName, doc);
                        ReplaceWordStub("{FirstName3}", Worker2.FirstName, doc);
                        ReplaceWordStub("{LastName1}", Worker1.LastName, doc);
                        ReplaceWordStub("{LastName2}", Worker1.LastName, doc);
                        ReplaceWordStub("{LastName3}", Worker2.LastName, doc);
                        ReplaceWordStub("{MiddleName1}", Worker1.MiddleName, doc);
                        ReplaceWordStub("{MiddleName2}", Worker1.MiddleName, doc);
                        ReplaceWordStub("{MiddleName3}", Worker2.MiddleName, doc);
                        ReplaceWordStub("{Position1}", Worker2.Position.PositionName, doc);
                        ReplaceWordStub("{Position2}", Worker1.Position.PositionName, doc);
                        ReplaceWordStub("{Position}", Worker1.Position.PositionName, doc);
                        ReplaceWordStub("{N}", info.id.ToString(), doc);
                        ReplaceWordStub("{N1}", info.id + 1000.ToString(), doc);
                        ReplaceWordStub("{NameOfMaterial}", NameOfMaterial, doc);

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
        private void ReplaceWordStub(string stubToReplace, string text, Word.Document wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);

        }

        private void RaportBtn2_Click(object sender, RoutedEventArgs e)
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
                    Word.Document doc = word.Documents.Open(Environment.CurrentDirectory + @"\Akt_priyoma_peredachi_materialov.docx");
                    var SelectedInfo = DGridConsumable.SelectedItems.Cast<ReplenishmentOfMaterials>().FirstOrDefault() as ReplenishmentOfMaterials;
                    var info = AccountingForConsumablesEntities.GetContext().MaterialsInDelivery.Where(w => w.FK_Replenishment == SelectedInfo.id).FirstOrDefault();
                    List<ReplenishmentOfMaterials> materialsInDeliverieLst = new List<ReplenishmentOfMaterials>();
                    materialsInDeliverieLst.AddRange(DGridConsumable.SelectedItems.Cast<ReplenishmentOfMaterials>().ToList());
                 
                   
                   
                    var Worker1 = AccountingForConsumablesEntities.GetContext().Worker.Where(w => w.id == 5).FirstOrDefault();
                    var GetDate = DateTime.Today.ToShortDateString();
                    MessageBox.Show("" + materialsInDeliverieLst.Count());
                    try
                    {
                        ReplaceWordStub("{DateOfDelivery}", info.ReplenishmentOfMaterials.DateOfAcceptanceToTheWarehouse.ToShortDateString(), doc);
                        ReplaceWordStub("{DateOfDelivery1}", info.ReplenishmentOfMaterials.DateOfAcceptanceToTheWarehouse.ToShortDateString(), doc);
                        ReplaceWordStub("{ GetDate }", DateTime.Now.ToShortDateString(), doc);
                        ReplaceWordStub("{Position}", AccountingForConsumablesEntities.GetContext().Worker.Where(w=>w.id==5).Select(s=>s.Position.PositionName).FirstOrDefault(), doc);
                        ReplaceWordStub("{FirstName}", Worker1.FirstName, doc);
                        ReplaceWordStub("{LastName}", Worker1.LastName, doc);
                        ReplaceWordStub("{MiddleName}", Worker1.MiddleName, doc);
                        ReplaceWordStub("{Manufacturer}", info.MaterialCard.Materials.Manufacturer.ManufacturerName, doc);
                        ReplaceWordStub("{Email}", Worker1.Email, doc);
                        ReplaceWordStub("{ContactPhone}", Worker1.PhoneNumber, doc); 
                        int i = 1;
                        foreach (var item in materialsInDeliverieLst)
                        {
                            var newItem = AccountingForConsumablesEntities.GetContext().MaterialsInDelivery.Where(w => w.FK_Replenishment == item.id).FirstOrDefault();
                            
                            ReplaceWordStub("{MaterialGroup"+ i+"}", newItem.MaterialCard.Materials.MaterialGroup.NameOfMaterialGroup, doc);
                            ReplaceWordStub("{MaterialName" + i + "}", newItem.MaterialCard.Materials.MaterialName, doc);
                            ReplaceWordStub("{InventNumber" + i + "}", newItem.MaterialCard.InventNumber, doc);
                            ReplaceWordStub("{DeliveryQuantity" + i + "}", newItem.MaterialQuantity.ToString(), doc);
                            i++;
                        };

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

        private void BtnInventarization_Click(object sender, RoutedEventArgs e)
        {
            ManagerOfFrame.MainFrame.Navigate(new Inventarizationpage());
        }
    }
}
