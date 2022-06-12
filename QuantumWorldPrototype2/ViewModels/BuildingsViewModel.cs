using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuantumWorldPrototype2.Models;

namespace QuantumWorldPrototype2.ViewModels
{

    using Models;
    using System.Windows.Input;

    public class BuildingsViewModel : INotifyPropertyChanged
    {

        public int CarbonFiberValue
        {
            get
            {
                return CarbonFiberModel.Value;
            }
            set
            {
                CarbonFiberModel.Value = value;
                onPropertyChanged(nameof(CarbonFiberValue));
            }
        }

        public int CarbonFiberBuildingCost
        {
            get
            {
                return CarbonFiberBuilding.Cost;
            }
            set
            {
                CarbonFiberBuilding.Cost = value;
                onPropertyChanged(nameof(CarbonFiberBuildingCost));
            }
        }


        private ICommand buildingUpgrade = null;
        public ICommand BuildingUpgrade
        {
            get
            {
                if (buildingUpgrade == null) buildingUpgrade = new  RelayCommand(
                    (object o) =>
                    {
                        CarbonFiberValue -= CarbonFiberBuildingCost;
                        CarbonFiberBuilding.lvl++;
                        CarbonFiberBuildingCost *= CarbonFiberBuilding.lvl;
                    },
                    (object o) =>
                    {
                        return CarbonFiberValue > CarbonFiberBuildingCost;
                    }
                    );
                return buildingUpgrade;
            }
        }




        public event PropertyChangedEventHandler? PropertyChanged;

        private void onPropertyChanged(string fieldName)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(fieldName));
        }
    }
}
