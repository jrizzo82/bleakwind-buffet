/*
 * Author: Jerry Rizzo 
 * Class Name: ThugsTBoneOptions.xaml.cs
 * Purpose: Represents the option menu for ThugsTBone
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
    /// Interaction logic for ThugsTBoneOptions.xaml
    /// </summary>
    public partial class ThugsTBoneOptions : UserControl
    {
        public ThugsTBoneOptions()
        {
            InitializeComponent();
            ThugsTBone tt = new ThugsTBone();
            DataContext = tt;
        }
    }
}
