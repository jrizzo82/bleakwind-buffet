using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using RoundRegister;

namespace PointOfSale
{
    class CashOrderViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public int Hundreds
        {
            get
            {
                return CashDrawer.Hundreds;
            }
            set
            {
                CashDrawer.Hundreds = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Hundreds"));
            }
        }
    }
}
