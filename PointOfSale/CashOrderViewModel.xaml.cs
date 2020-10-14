using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using RoundRegister;


namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CashOrderViewModel.xaml
    /// </summary>
    public partial class CashOrderViewModel : UserControl, INotifyPropertyChanged
    {
        public CashOrderViewModel()
        {
            InitializeComponent();
        }

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
