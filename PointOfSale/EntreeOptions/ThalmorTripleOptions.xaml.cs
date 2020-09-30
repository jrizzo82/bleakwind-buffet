/*
 * Author: Jerry Rizzo 
 * Class Name: ThalmorTripleOptions.xaml.cs
 * Purpose: Represents the option menu for ThalmorTriple
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
    /// Interaction logic for ThalmorTripleOptions.xaml
    /// </summary>
    public partial class ThalmorTripleOptions : UserControl
    {
        /// <summary>
        /// Constructor for ThalmorTripleOptions
        /// </summary>
        public ThalmorTripleOptions()
        {
            InitializeComponent();
            ThalmorTriple tt = new ThalmorTriple();
            DataContext = tt;
            chkbxBacon.DataContext = tt.Bacon;
            chkbxBun.DataContext = tt.Bun;
            chkbxKetchup.DataContext = tt.Ketchup;
            chkbxMustard.DataContext = tt.Mustard;
            chkbxMayo.DataContext = tt.Mayo;
            chkbxTomato.DataContext = tt.Tomato;
            chkbxPickle.DataContext = tt.Pickle;
            chkbxLettuce.DataContext = tt.Lettuce;
            chkbxEgg.DataContext = tt.Egg;
            chkbxCheese.DataContext = tt.Cheese;
        }
    }
}
