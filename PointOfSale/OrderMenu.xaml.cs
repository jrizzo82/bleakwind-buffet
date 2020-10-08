/*
 * Author: Jerry Rizzo 
 * Class Name: OrderMenu.xaml.cs
 * Purpose: Logic for Bleakwind Buffet Menu
 */

using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using PointOfSale.DrinkOptions;
using System.Windows;
using System.Windows.Controls;
using PointOfSale.EntreeOptions;
using PointOfSale.SideOptions;
using BleakwindBuffet.Data;
using System.Printing;
using BleakwindBuffet.Data.Sides;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderMenu.xaml
    /// </summary>
    public partial class OrderMenu : UserControl
    {
        private Order order;

        private uint nextOrderNumber = 1;

        /// <summary>
        /// Constructor for OrderMenu
        /// </summary>
        public OrderMenu()
        {
            InitializeComponent();
            order = new Order(nextOrderNumber);
            DataContext = order;

            menuListView.SelectionChanged += MenuListView_SelectionChanged;
        }

        /// <summary>
        /// Event listener when a menu item is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (menuListView.SelectedItem is AretinoAppleJuice)
            {
                AretinoAppleJuiceOptions ao = new AretinoAppleJuiceOptions();
                ao.DataContext = menuListView.SelectedItem;
                menuBorder.Child = ao;
            }
            else if (menuListView.SelectedItem is CandlehearthCoffee)
            {
                CandlehearthCoffeeOptions co = new CandlehearthCoffeeOptions();
                co.DataContext = menuListView.SelectedItem;
                menuBorder.Child = co;
            }
            else if (menuListView.SelectedItem is MarkarthMilk)
            {
                MarkarthMilkOptions mo = new MarkarthMilkOptions();
                mo.DataContext = menuListView.SelectedItem;
                menuBorder.Child = mo;
            }
            else if (menuListView.SelectedItem is SailorSoda)
            {
                SailorSoadOptions so = new SailorSoadOptions();
                so.DataContext = menuListView.SelectedItem;
                menuBorder.Child = so;
            }
            else if (menuListView.SelectedItem is WarriorWater)
            {
                WarriorWaterOptions wo = new WarriorWaterOptions();
                wo.DataContext = menuListView.SelectedItem;
                menuBorder.Child = wo;
            }
            else if (menuListView.SelectedItem is BriarheartBurger)
            {
                BriarheartBurgerOptions bo = new BriarheartBurgerOptions();
                bo.DataContext = menuListView.SelectedItem;
                menuBorder.Child = bo;
            }
            else if (menuListView.SelectedItem is DoubleDraugr)
            {
                DoubleDraugrOptions dd = new DoubleDraugrOptions();
                dd.DataContext = menuListView.SelectedItem;
                menuBorder.Child = dd;
            }
            else if (menuListView.SelectedItem is GardenOrcOmelette)
            {
                GardenOrcOmeletteOptions go = new GardenOrcOmeletteOptions();
                go.DataContext = menuListView.SelectedItem;
                menuBorder.Child = go;
            }
            else if (menuListView.SelectedItem is PhillyPoacher)
            {
                PhillyPoacherOptions po = new PhillyPoacherOptions();
                po.DataContext = menuListView.SelectedItem;
                menuBorder.Child = po;
            }
            else if (menuListView.SelectedItem is SmokehouseSkeleton)
            {
                SmokehouseSkeletonOptions so = new SmokehouseSkeletonOptions();
                so.DataContext = menuListView.SelectedItem;
                menuBorder.Child = so;
            }
            else if (menuListView.SelectedItem is ThalmorTriple)
            {
                ThalmorTripleOptions to = new ThalmorTripleOptions();
                to.DataContext = menuListView.SelectedItem;
                menuBorder.Child = to;
            }
            else if (menuListView.SelectedItem is ThugsTBone)
            {
                ThugsTBoneOptions to = new ThugsTBoneOptions();
                to.DataContext = menuListView.SelectedItem;
                menuBorder.Child = to;
            }
            else if (menuListView.SelectedItem is DragonbornWaffleFries)
            {
                DragonbornWaffleFriesOptions dw = new DragonbornWaffleFriesOptions();
                dw.DataContext = menuListView.SelectedItem;
                menuBorder.Child = dw;
            }
            else if (menuListView.SelectedItem is FriedMiraak)
            {
                FriedMiraakOptions fo = new FriedMiraakOptions();
                fo.DataContext = menuListView.SelectedItem;
                menuBorder.Child = fo;
            }
            else if (menuListView.SelectedItem is MadOtarGrits)
            {
                MadOtarGritsOptions mo = new MadOtarGritsOptions();
                mo.DataContext = menuListView.SelectedItem;
                menuBorder.Child = mo;
            }
            else if (menuListView.SelectedItem is VokunSalad)
            {
                VokunSaladOptions vo = new VokunSaladOptions();
                vo.DataContext = menuListView.SelectedItem;
                menuBorder.Child = vo;
            }
            else
                menuBorder.Child = null;
        }

        /// <summary>
        /// Click event handler for Philly Poacher
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void PhillyPoacherClick(object sender, RoutedEventArgs e)
        {
            menuBorder.Child = new PhillyPoacherOptions();
        }

        /// <summary>
        /// Click event handler for Smokehouse Skeleton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SmokehouseSkeletonClick(object sender, RoutedEventArgs e)
        {
            menuBorder.Child = new SmokehouseSkeletonOptions();
        }

        /// <summary>
        /// Click event handler for Thalmor Triple
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ThalmorTripleClick(object sender, RoutedEventArgs e)
        {
            menuBorder.Child = new ThalmorTripleOptions();
        }

        /// <summary>
        /// Click event handler for Garden Orc Omelette
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void GardenOrcClick(object sender, RoutedEventArgs e)
        {
            menuBorder.Child = new GardenOrcOmeletteOptions();
        }

        /// <summary>
        /// Click event handler for Double Draugr
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DoubleDraugrClick(object sender, RoutedEventArgs e)
        {
            menuBorder.Child = new DoubleDraugrOptions();
        }

        /// <summary>
        /// Click event handler for Briarheart Burger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void BriarHeartBurgerClick(object sender, RoutedEventArgs e)
        {
            menuBorder.Child = new BriarheartBurgerOptions();
        }

        /// <summary>
        /// Click event handler for Vokun Salad
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void VokunSaladClick(object sender, RoutedEventArgs e)
        {
            menuBorder.Child = new VokunSaladOptions();
        }

        /// <summary>
        /// Click event handler for Mad Otar Grits
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void MadOtarGritsClick(object sender, RoutedEventArgs e)
        {
            menuBorder.Child = new MadOtarGritsOptions();
        }

        /// <summary>
        /// Click event handler for Fried Miraak
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void FriedMiraakClick(object sender, RoutedEventArgs e)
        {
            menuBorder.Child = new FriedMiraakOptions();
        }

        /// <summary>
        /// Click event handler for Dragonborn Waffle Fries
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DragonbornClick(object sender, RoutedEventArgs e)
        {
            menuBorder.Child = new DragonbornWaffleFriesOptions();
        }

        /// <summary>
        /// Click event handler for Thugs T-Bone
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ThugsTBoneClick(object sender, RoutedEventArgs e)
        {
            menuBorder.Child = new ThugsTBoneOptions();
        }

        /// <summary>
        /// Click event handler for Aretino Apple Juice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AretinoAppleJuiceClick(object sender, RoutedEventArgs e)
        {
            menuBorder.Child = new AretinoAppleJuiceOptions();
        }

        /// <summary>
        /// Click event handler for Candlehearth Coffee
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CandlehearthCoffeeClick(object sender, RoutedEventArgs e)
        {
            menuBorder.Child = new CandlehearthCoffeeOptions();
        }

        /// <summary>
        /// Click event handler for Markarth Milk
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void MarkarthMilkClick(object sender, RoutedEventArgs e)
        {
            menuBorder.Child = new MarkarthMilkOptions();
        }

        /// <summary>
        /// Click event handler for Sailor Soda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SailorSodaClick(object sender, RoutedEventArgs e)
        {
            menuBorder.Child = new SailorSoadOptions();
        }

        /// <summary>
        /// Click event handler for Warrior Water
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void WarriorWaterClick(object sender, RoutedEventArgs e)
        {
            menuBorder.Child = new WarriorWaterOptions();
        }

        /// <summary>
        /// Click event handler for Add Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void btnAddClk(object sender, RoutedEventArgs e)
        {
           if (menuBorder.Child is UserControl uc)
            {
                if (uc.DataContext is IOrderItem io && !order.Contains(io))
                    order.Add(io);                
            }
            menuBorder.Child = null;
        }

        /// <summary>
        /// Click event handler for Cancel Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CancelClick(object sender, RoutedEventArgs e)
        {
            order = new Order(nextOrderNumber);
            menuBorder.Child = null;
            DataContext = order;
        }

        /// <summary>
        /// Click event listener for Check Out Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CheckOutClick(object sender, RoutedEventArgs e)
        {
            if (order.Count > 0)
            {
                order = new Order(++nextOrderNumber);
                menuBorder.Child = null;
                DataContext = order;
            }
        }

        /// <summary>
        /// Click event listener for Remove Item Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void RemoveClk(object sender, RoutedEventArgs e)
        {
            int i = menuListView.Items.IndexOf(menuListView.SelectedItem);
            if (i >= 0)
                order.Remove(order[i]);
        }
    }
}
