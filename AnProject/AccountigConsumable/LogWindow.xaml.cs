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
    /// Логика взаимодействия для LogWindow.xaml
    /// </summary>
    public partial class LogWindow : StyledWindow
    {
        SenderMail Class = new SenderMail();
        public LogWindow()
        {
            InitializeComponent();
            ManagerOfFrame.LogFrame = FrameLogin;
            ManagerOfFrame.LogFrame.Navigate(new LogPage());
        }
    }
}
