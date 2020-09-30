/*
 * Author: Jerry Rizzo 
 * Class Name: MadOtarGritsOptions.xaml.cs
 * Purpose: Represents the option menu for MadOtarGrits
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
    /// Interaction logic for MadOtarGritsOptions.xaml
    /// </summary>
    public partial class MadOtarGritsOptions : UserControl
    {
        /// <summary>
        /// Constructor for MadOtarGritsOptions
        /// </summary>
        public MadOtarGritsOptions()
        {
            InitializeComponent();
            MadOtarGrits mo = new MadOtarGrits();
            DataContext = mo;
            rbtnSmall.DataContext = mo.Size;
            rbtnMedium.DataContext = mo.Size;
            rbtnLarge.DataContext = mo.Size;
        }
    }
}
