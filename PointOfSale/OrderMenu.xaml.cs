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



namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderMenu.xaml
    /// </summary>
    public partial class OrderMenu : UserControl
    {
        /// <summary>
        /// Constructor for OrderMenu
        /// </summary>
        public OrderMenu()
        {
            InitializeComponent();
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
        void BriarHeartBurgerClick(object sneder, RoutedEventArgs e)
        {
            menuBorder.Child = new BriarheartBurgerOptions();
        }

        /// <summary>
        /// Click event handler for Vokun Salad
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void VokunSaladClick(object sneder, RoutedEventArgs e)
        {
            menuBorder.Child = new VokunSaladOptions();
        }

        /// <summary>
        /// Click event handler for Mad Otar Grits
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void MadOtarGritsClick(object sneder, RoutedEventArgs e)
        {
            menuBorder.Child = new VokunSaladOptions();
        }

        /// <summary>
        /// Click event handler for Fried Miraak
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void FriedMiraakClick(object sneder, RoutedEventArgs e)
        {
            menuBorder.Child = new FriedMiraakOptions();
        }

        /// <summary>
        /// Click event handler for Dragonborn Waffle Fries
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DragonbornClick(object sneder, RoutedEventArgs e)
        {
            menuBorder.Child = new DragonbornWaffleFriesOptions();
        }

        /// <summary>
        /// Click event handler for Thugs T-Bone
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ThugsTBoneClick(object sneder, RoutedEventArgs e)
        {
            menuBorder.Child = null;
        }

        /// <summary>
        /// Click event handler for Aretino Apple Juice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AretinoAppleJuiceClick(object sneder, RoutedEventArgs e)
        {
            menuBorder.Child = new AretinoAppleJuiceOptions();
        }

        /// <summary>
        /// Click event handler for Candlehearth Coffee
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CandlehearthCoffeeClick(object sneder, RoutedEventArgs e)
        {
            menuBorder.Child = new CandlehearthCoffeeOptions();
        }

        /// <summary>
        /// Click event handler for Markarth Milk
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void MarkarthMilkClick(object sneder, RoutedEventArgs e)
        {
            menuBorder.Child = new MarkarthMilkOptions();
        }

        /// <summary>
        /// Click event handler for Sailor Soda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SailorSodaClick(object sneder, RoutedEventArgs e)
        {
            menuBorder.Child = new SailorSoadOptions();
        }

        /// <summary>
        /// Click event handler for Warrior Water
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void WarriorWaterClick(object sneder, RoutedEventArgs e)
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

        }

        /// <summary>
        /// Click event handler for Cancel Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CancelClick(object sender, RoutedEventArgs e)
        {
            menuListView.Items.Clear();
        }
    }
}
