using QuantumWorldPrototype2.ViewModels;
using QuantumWorldPrototype2.Models;
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
using System.Windows.Threading;

namespace QuantumWorldPrototype2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();

        int carbonFiberValue = CarbonFiberModel.DefaultValue;

        public MainWindow()
        {
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;

            InitializeComponent();
            
         
            DataContext = new OverviewViewModel();
            timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            
            carbonFiberValue += CarbonFiberModel.Multiplier;
            CarbonFiberValueLabel.Content = $"{carbonFiberValue}";
        }

        private void Buildings_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new BuildingsViewModel();
        }

        private void Overview_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new OverviewViewModel();
        }
    }
}
