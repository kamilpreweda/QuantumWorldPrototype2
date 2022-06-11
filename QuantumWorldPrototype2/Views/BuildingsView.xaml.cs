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
using QuantumWorldPrototype2.ViewModels;
using QuantumWorldPrototype2.Models;

namespace QuantumWorldPrototype2.Views
{
    /// <summary>
    /// Logika interakcji dla klasy BuildingsView.xaml
    /// </summary>
    public partial class BuildingsView : UserControl
    {
        public BuildingsView()
        {
            InitializeComponent();
        }

        private void CarbonFiberBuildingUpgradeButton_Click(object sender, RoutedEventArgs e)
        {
            if(CarbonFiberModel.Value > CarbonFiberBuilding.Cost)
            {
                CarbonFiberModel.Value -= CarbonFiberBuilding.Cost;
                CarbonFiberBuilding.lvl++;
                CarbonFiberBuilding.Cost *= CarbonFiberBuilding.lvl;
                CarbonFiberBuildingCostValueLabel.Content = CarbonFiberBuilding.Cost;

            }
        }
    }
}
