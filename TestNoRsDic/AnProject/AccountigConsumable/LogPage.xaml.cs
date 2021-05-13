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
    /// Логика взаимодействия для LogPage.xaml
    /// </summary>
    public partial class LogPage : Page
    {
        SenderMail Class = new SenderMail();
        AuthorizationDataCheck AuPage = new AuthorizationDataCheck();
        public LogPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var idCheck = AccountingForConsumablesEntities.GetContext().Worker.Where(w => w.Login.Equals(LoginTextBX.Text) && w.Password.Equals(PasswordTextBX.Password)).Select(s => s.id).FirstOrDefault();
            var idChecklogin = AccountingForConsumablesEntities.GetContext().Worker.Where(w => w.Login.Equals(LoginTextBX.Text)).Select(s => s.id).FirstOrDefault();
            if (AuPage.LoginCheck(LoginTextBX.Text)&& AuPage.PasswordCheck(PasswordTextBX.Password))
            {

                Fail1.Visibility = Visibility.Visible;
                Fail1.Content = "Введите логин";
                Fail2.Visibility = Visibility.Visible;
                Fail2.Content = "Введите пароль";
            }
            else if (AuPage.LoginCheck(LoginTextBX.Text))
            {

                Fail1.Visibility = Visibility.Visible;
                Fail1.Content = "Введите логин";
            }
            else if (AuPage.PasswordCheck(PasswordTextBX.Password))
            {

                Fail2.Content = "Введите пароль";
                Fail2.Visibility = Visibility.Visible;
            }
            else
            {
                if (idChecklogin == 0)
                {
                    GlobarFail.Visibility = Visibility.Visible;
                    GlobarFail.Content = "Пользователь не найден";
                }
                else
                {
                    if (idCheck == 0)
                    {

                        GlobarFail.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        string Code = Class.SenderCode();
                        Class.senderMAil(AccountingForConsumablesEntities.GetContext().Worker.Where(w => w.id == idCheck).Select(s => s.Email).FirstOrDefault(), Code);
                        SenderMail.IntId = AccountingForConsumablesEntities.GetContext().Worker.Where(w => w.id == idCheck).Select(s => s.id).FirstOrDefault();
                        SenderMail.PosName = AccountingForConsumablesEntities.GetContext().Worker.Where(w => w.id == idCheck).Select(s => s.Position.PositionName).FirstOrDefault();
                        AccountingForConsumablesEntities.GetContext().OperationHystory.Add(new OperationHystory() { FK_Worker = SenderMail.IntId, Operation = "Авторизация в системе", DateTimeOfOperation = DateTime.Now });
                        AccountingForConsumablesEntities.GetContext().SaveChanges();
                        ManagerOfFrame.LogFrame.Navigate(new AutherizationPage(Code));
                    }
                }

            }
        }
    }
}
