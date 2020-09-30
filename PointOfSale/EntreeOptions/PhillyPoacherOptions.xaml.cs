/*
 * Author: Jerry Rizzo 
 * Class Name: PhillyPoacherOptions.xaml.cs
 * Purpose: Represents the option menu for PhillyPoacher
 */

using BleakwindBuffet.Data.Entrees;
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

namespace PointOfSale.EntreeOptions
{
    /// <summary>
    /// Interaction logic for PhillyPoacherOptions.xaml
    /// </summary>
    public partial class PhillyPoacherOptions : UserControl
    {
        /// <summary>
        /// Constructor for PhillyPoacherOptions
        /// </summary>
        public PhillyPoacherOptions()
        {
            InitializeComponent();
            PhillyPoacher pp = new PhillyPoacher();
            DataContext = pp;
            chkbxOnion.DataContext = pp.Onion;
            chkbxRoll.DataContext = pp.Roll;
            chkbxSirloin.DataContext = pp.Sirloin;
        }
    }
}
