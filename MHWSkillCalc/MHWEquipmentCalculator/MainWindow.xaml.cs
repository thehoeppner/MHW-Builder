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

namespace MHWEquipmentCalculator
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ViewModels.Main.MainViewModel vm;
        public MainWindow()
        {
            InitializeComponent();
            vm = new ViewModels.Main.MainViewModel(
                new Repositories.MHWUnitOfWork("https://mhw-db.com"),
                new IoC.Production.ProductionServicesFactory());
            DataContext = vm;
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
           await vm.LoadData();
        }
    }
}
