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
using System.Windows.Shapes;
using WPF_Base_Styling_App.UI.Windows;

namespace AccountigConsumable
{
    /// <summary>
    /// Логика взаимодействия для PasswordWindow.xaml
    /// </summary>
    public partial class PasswordWindow : Window
    {
        public PasswordWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var WorkerFPs = AccountingForConsumablesEntities.GetContext().Worker.Where(w => w.id == SenderMail.IntId).FirstOrDefault();
            if (FirstEnterPass.Password != SecondEnterPass.Password)
            {
                MessageBox.Show("Введеные пароли не совпадают", "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                WorkerFPs.Password = FirstEnterPass.Password;
                WorkerFPs.CheckFirstVisit = false;
                AccountingForConsumablesEntities.GetContext().SaveChanges(); 
                AccountingForConsumablesEntities.GetContext().OperationHystory.Add(new OperationHystory() { FK_Worker = SenderMail.IntId, Operation = "Первичное изменение пароля", DateTimeOfOperation = DateTime.Now });
                AccountingForConsumablesEntities.GetContext().SaveChanges();
                this.Close();
            }
        }
    }
}
