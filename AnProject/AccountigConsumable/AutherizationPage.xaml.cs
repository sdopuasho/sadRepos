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
    /// Логика взаимодействия для AutherizationPage.xaml
    /// </summary>
    public partial class AutherizationPage : Page
    {
        public string CodeResult;
        System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();
        SenderMail page = new SenderMail();
        /// <summary>
        /// Инициализация компонентов
        /// </summary>
        public AutherizationPage(string code)
        {
            InitializeComponent();
            CodeResult = code;
            timer.Tick += dispatcherTimer_Tick;
            timer.Interval = new TimeSpan(0, 0, 0, 0, 1000);
            timer.Start();
            lbltxt.MouseEnter -= lbltxt_MouseEnter;
        }

        public AutherizationPage()
        {
        }
        /// <summary>
        /// Блок принципа работы таймера
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            string a = (string)lbl.Content;
            if (a == "1")
            {
                lbl.Content = "";
                lbltxt.Content = "Выслать повторно";
                lbltxt.MouseEnter += lbltxt_MouseEnter;
                timer.Tick -= dispatcherTimer_Tick;

            }
            else
            {
                int time = Convert.ToInt32(lbl.Content);
                lbl.Content = Convert.ToString(time - 1);
            }
        }
        /// <summary>
        /// Блок сверки паролей
        /// </summary>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Auten.Text != CodeResult)
            {
                MessageBox.Show("Введен неверный код", "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            else
            {
                MainWindow win2 = new MainWindow();
                win2.ShowDialog();
            }
        }

        private void lbltxt_MouseEnter(object sender, MouseEventArgs e)
        {
            CodeResult = page.SenderCode();
            page.senderMAil("", CodeResult);
        }
    }
}
