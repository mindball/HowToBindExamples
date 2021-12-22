using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SpecifyBindingSource
{
    public class NetIncome : INotifyPropertyChanged
    {
        private int totalIncome = 5000;
        private int rent = 2000;
        private int food = 0;
        private int misc = 0;
        private int savings = 0;

        public NetIncome()
        {
            savings = totalIncome - (rent + food + misc);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public int TotalIncome
        {
            get
            {
                return totalIncome;
            }
            set
            {
                if (TotalIncome != value)
                {
                    totalIncome = value;
                    OnPropertyChanged();
                }
            }
        }

        public int Rent
        {
            get
            {
                return rent;
            }
            set
            {
                if (Rent != value)
                {
                    rent = value;
                    OnPropertyChanged();
                    UpdateSavings();
                }
            }
        }

        public int Food
        {
            get
            {
                return food;
            }
            set
            {
                if (Food != value)
                {
                    food = value;
                    OnPropertyChanged("Food");
                    UpdateSavings();
                }
            }
        }

        public int Misc
        {
            get
            {
                return misc;
            }
            set
            {
                if (Misc != value)
                {
                    misc = value;
                    OnPropertyChanged("Misc");
                    UpdateSavings();
                }
            }
        }

        public int Savings
        {
            get
            {
                return savings;
            }
            set
            {
                if (Savings != value)
                {
                    savings = value;
                    OnPropertyChanged("Savings");
                    UpdateSavings();
                }
            }
        }

        private void UpdateSavings()
        {
            Savings = TotalIncome - (Rent + Misc + Food);
            if (Savings < 0)
            { }
            else if (Savings >= 0)
            { }
        }

        private void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
