/*
 * Author: Jerry Rizzo 
 * Class Name: DragonbornWaffleFriesOptions.xaml.cs
 * Purpose: Represents the option menu for DragonbornWaffleFries
 */

using BleakwindBuffet.Data.Sides;
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

namespace PointOfSale.SideOptions
{
    /// <summary>
    /// Interaction logic for DragonbornWaffleFriesOptions.xaml
    /// </summary>
    public partial class DragonbornWaffleFriesOptions : UserControl
    {
        /// <summary>
        /// Constructor for DragonbornWaffleFriesOptions
        /// </summary>
        public DragonbornWaffleFriesOptions()
        {
            InitializeComponent();
            DragonbornWaffleFries dw = new DragonbornWaffleFries();
            DataContext = dw;
        }
    }
}
