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
    /// Логика взаимодействия для OrderMorePage.xaml
    /// </summary>
    public partial class OrderMorePage : Page
    {
        Order _currentMat = new Order();
        public OrderMorePage(Order SelectedMat)
        {
            InitializeComponent();
            DGridConsumable.ItemsSource = AccountingForConsumablesEntities.GetContext().OrderedMaterial.Where(w=>w.FK_Order == SelectedMat.id).ToList();
            _currentMat = SelectedMat;
            DataContext = _currentMat;
            CmbFIO.ItemsSource = AccountingForConsumablesEntities.GetContext().Worker.ToList();
            CmbPlace.ItemsSource = AccountingForConsumablesEntities.GetContext().WorkPlace.ToList();
            CmbPosition.ItemsSource = AccountingForConsumablesEntities.GetContext().Position.ToList();
        }
    }
}
