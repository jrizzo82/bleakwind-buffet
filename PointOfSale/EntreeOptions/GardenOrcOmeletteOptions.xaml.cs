/*
 * Author: Jerry Rizzo 
 * Class Name: GardenOrcOmeletteOptions.xaml.cs
 * Purpose: Represents the option menu for GardenOrcOmelette
 */

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
using BleakwindBuffet.Data.Entrees;

namespace PointOfSale.EntreeOptions
{
    /// <summary>
    /// Interaction logic for GardenOrcOmeletteOptions.xaml
    /// </summary>
    public partial class GardenOrcOmeletteOptions : UserControl
    {
        /// <summary>
        /// Constructor for GardenOrcOmeletteOptions
        /// </summary>
        public GardenOrcOmeletteOptions()
        {
            InitializeComponent();
            GardenOrcOmelette go = new GardenOrcOmelette();
            DataContext = go;
            chkbxBroccoli.DataContext = go.Broccoli;
            chkbxMushrooms.DataContext = go.Mushrooms;
            chkbxTomato.DataContext = go.Tomato;
            chkbxCheddar.DataContext = go.Cheddar;
        }
    }
}
