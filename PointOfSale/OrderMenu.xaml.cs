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
using RoundRegister;
using System;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderMenu.xaml
    /// </summary>
    public partial class OrderMenu : UserControl
    {
        public Order Order { get; set; }

        private uint nextOrderNumber = 1;

        private Combo combo;

        private ComboOptions comOp;

        private bool choosingCombo = false;

        /// <summary>
        /// Constructor for OrderMenu
        /// </summary>
        public OrderMenu()
        {
            InitializeComponent();
            Order = new Order(nextOrderNumber);
            DataContext = Order;

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
            else if (menuListView.SelectedItem is Combo com)
            {
                comOp = new ComboOptions(com);
                combo = com;
                menuBorder.Child = comOp;
                choosingCombo = true;
                btnEditCombo.IsEnabled = true;
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
            if (choosingCombo)
            {
                PhillyPoacherOptions po = new PhillyPoacherOptions();
                PhillyPoacher pp = new PhillyPoacher();
                po.DataContext = pp;
                comOp.SetOptionScreen(po);
                combo.Entree = pp;
            }
            else
                menuBorder.Child = new PhillyPoacherOptions();
        }

        /// <summary>
        /// Click event handler for Smokehouse Skeleton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SmokehouseSkeletonClick(object sender, RoutedEventArgs e)
        {
            if (choosingCombo)
            {
                SmokehouseSkeletonOptions so = new SmokehouseSkeletonOptions();
                SmokehouseSkeleton ss = new SmokehouseSkeleton();
                so.DataContext = ss;
                comOp.SetOptionScreen(so);
                combo.Entree = ss;
            }
            else
                menuBorder.Child = new SmokehouseSkeletonOptions();
        }

        /// <summary>
        /// Click event handler for Thalmor Triple
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ThalmorTripleClick(object sender, RoutedEventArgs e)
        {
            if (choosingCombo)
            {
                ThalmorTripleOptions to = new ThalmorTripleOptions();
                ThalmorTriple tt = new ThalmorTriple();
                to.DataContext = tt;
                comOp.SetOptionScreen(to);
                combo.Entree = tt;
            }
            else
                menuBorder.Child = new ThalmorTripleOptions();
        }

        /// <summary>
        /// Click event handler for Garden Orc Omelette
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void GardenOrcClick(object sender, RoutedEventArgs e)
        {
            if (choosingCombo)
            {
                GardenOrcOmeletteOptions go = new GardenOrcOmeletteOptions();
                GardenOrcOmelette gardenOrc = new GardenOrcOmelette();
                go.DataContext = gardenOrc;
                comOp.SetOptionScreen(go);
                combo.Entree = gardenOrc;
            }
            else
                menuBorder.Child = new GardenOrcOmeletteOptions();
        }

        /// <summary>
        /// Click event handler for Double Draugr
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DoubleDraugrClick(object sender, RoutedEventArgs e)
        {
            if (choosingCombo)
            {
                DoubleDraugrOptions ddo = new DoubleDraugrOptions();
                DoubleDraugr dd = new DoubleDraugr();
                ddo.DataContext = dd;
                comOp.SetOptionScreen(ddo);
                combo.Entree = dd;
            }
            else
                menuBorder.Child = new DoubleDraugrOptions();
        }

        /// <summary>
        /// Click event handler for Briarheart Burger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void BriarHeartBurgerClick(object sender, RoutedEventArgs e)
        {
            if (choosingCombo)
            {
                BriarheartBurgerOptions bo = new BriarheartBurgerOptions();
                BriarheartBurger bb = new BriarheartBurger();
                bo.DataContext = bb;
                comOp.SetOptionScreen(bo);
                combo.Entree = bb;
            }
            else
                menuBorder.Child = new BriarheartBurgerOptions();
        }

        /// <summary>
        /// Click event handler for Vokun Salad
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void VokunSaladClick(object sender, RoutedEventArgs e)
        {
            if (choosingCombo)
            {
                VokunSaladOptions vo = new VokunSaladOptions();
                VokunSalad vs = new VokunSalad();
                vo.DataContext = vs;
                comOp.SetOptionScreen(vo);
                combo.Side = vs;
            }
            else
                menuBorder.Child = new VokunSaladOptions();
        }

        /// <summary>
        /// Click event handler for Mad Otar Grits
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void MadOtarGritsClick(object sender, RoutedEventArgs e)
        {
            if (choosingCombo)
            {
                MadOtarGritsOptions mo = new MadOtarGritsOptions();
                MadOtarGrits mg = new MadOtarGrits();
                mo.DataContext = mg;
                comOp.SetOptionScreen(mo);
                combo.Side = mg;
            }
            else
                menuBorder.Child = new MadOtarGritsOptions();
        }

        /// <summary>
        /// Click event handler for Fried Miraak
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void FriedMiraakClick(object sender, RoutedEventArgs e)
        {
            if (choosingCombo)
            {
                FriedMiraakOptions fo = new FriedMiraakOptions();
                FriedMiraak fm = new FriedMiraak();
                fo.DataContext = fm;
                comOp.SetOptionScreen(fo);
                combo.Side = fm;
            }
            else
                menuBorder.Child = new FriedMiraakOptions();
        }

        /// <summary>
        /// Click event handler for Dragonborn Waffle Fries
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DragonbornClick(object sender, RoutedEventArgs e)
        {
            if (choosingCombo)
            {
                DragonbornWaffleFriesOptions dwo = new DragonbornWaffleFriesOptions();
                DragonbornWaffleFries dw = new DragonbornWaffleFries();
                dwo.DataContext = dw;
                comOp.SetOptionScreen(dwo);
                combo.Side = dw;
            }
            else
                menuBorder.Child = new DragonbornWaffleFriesOptions();
        }

        /// <summary>
        /// Click event handler for Thugs T-Bone
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ThugsTBoneClick(object sender, RoutedEventArgs e)
        {
            if (choosingCombo)
            {
                ThugsTBoneOptions tto = new ThugsTBoneOptions();
                ThugsTBone tt = new ThugsTBone();
                tto.DataContext = tt;
                comOp.SetOptionScreen(tto);
                combo.Entree = tt;
            }
            else
                menuBorder.Child = new ThugsTBoneOptions();
        }

        /// <summary>
        /// Click event handler for Aretino Apple Juice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AretinoAppleJuiceClick(object sender, RoutedEventArgs e)
        {
            if (choosingCombo)
            {
                AretinoAppleJuiceOptions ao = new AretinoAppleJuiceOptions();
                AretinoAppleJuice aj = new AretinoAppleJuice();
                ao.DataContext = aj;
                comOp.SetOptionScreen(ao);
                combo.Drink = aj;
            }
            else
                menuBorder.Child = new AretinoAppleJuiceOptions();
        }

        /// <summary>
        /// Click event handler for Candlehearth Coffee
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CandlehearthCoffeeClick(object sender, RoutedEventArgs e)
        {
            if (choosingCombo)
            {
                CandlehearthCoffeeOptions co = new CandlehearthCoffeeOptions();
                CandlehearthCoffee cc = new CandlehearthCoffee();
                co.DataContext = cc;
                comOp.SetOptionScreen(co);
                combo.Drink = cc;
            }
            else
                menuBorder.Child = new CandlehearthCoffeeOptions();
        }

        /// <summary>
        /// Click event handler for Markarth Milk
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void MarkarthMilkClick(object sender, RoutedEventArgs e)
        {
            if (choosingCombo)
            {
                MarkarthMilkOptions mo = new MarkarthMilkOptions();
                MarkarthMilk mm = new MarkarthMilk();
                mo.DataContext = mm;
                comOp.SetOptionScreen(mo);
                combo.Drink = mm;
            }
            else
                menuBorder.Child = new MarkarthMilkOptions();
        }

        /// <summary>
        /// Click event handler for Sailor Soda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SailorSodaClick(object sender, RoutedEventArgs e)
        {
            if (choosingCombo)
            {
                SailorSoadOptions so = new SailorSoadOptions();
                SailorSoda ss = new SailorSoda();
                so.DataContext = ss;
                comOp.SetOptionScreen(so);
                combo.Drink = ss;
            }
            else
                menuBorder.Child = new SailorSoadOptions();
        }

        /// <summary>
        /// Click event handler for Warrior Water
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void WarriorWaterClick(object sender, RoutedEventArgs e)
        {
            if (choosingCombo)
            {
                WarriorWaterOptions wo = new WarriorWaterOptions();
                WarriorWater ww = new WarriorWater();
                wo.DataContext = ww;
                comOp.SetOptionScreen(wo);
                combo.Drink = ww;
            }
            else
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
                if (uc.DataContext is IOrderItem io && !Order.Contains(io))
                    Order.Add(io);                
            }
            menuBorder.Child = null;
            choosingCombo = false;
            btnCancelCombo.IsEnabled = false;
            combo = new Combo();
        }

        /// <summary>
        /// Click event handler for Cancel Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CancelClick(object sender, RoutedEventArgs e)
        {
            Order = new Order(nextOrderNumber);
            menuBorder.Child = null;
            DataContext = Order;
            DisOrEnableButtons(true);
        }

        /// <summary>
        /// Click event listener for Check Out Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CheckOutClick(object sender, RoutedEventArgs e)
        {
            if (Order.Count > 0)
            {
                menuBorder.Child = new PaymentOptions();
                DisOrEnableButtons(false);
            }
        }

        /// <summary>
        /// Starts a new order
        /// </summary>
        public void NewOrder()
        {
            Order = new Order(++nextOrderNumber);
            DataContext = Order;
            DisOrEnableButtons(true);
            menuBorder.Child = null;
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
                Order.Remove(Order[i]);            
        }

        /// <summary>
        /// Handles clicking the add combo button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddComboClk(object sender, RoutedEventArgs e)
        {
            combo = new Combo();
            comOp = new ComboOptions(combo);
            menuBorder.Child = comOp;
            choosingCombo = true;
            btnCancelCombo.IsEnabled = true;
        }

        /// <summary>
        /// Handles clicking the cancel combo button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CancelComboClick(object sender, RoutedEventArgs e)
        {
            combo = new Combo();
            menuBorder.Child = null;
            choosingCombo = false;
            btnCancelCombo.IsEnabled = false;
        }

        /// <summary>
        /// Handles clicking the done editing combo button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DoneEditingComboClick(object sender, RoutedEventArgs e)
        {
            combo = new Combo();
            menuBorder.Child = null;
            choosingCombo = false;
            btnEditCombo.IsEnabled = false;
            menuListView.SelectedItem = null;
        }

        /// <summary>
        /// Disables or Enables order buttons so a payment
        /// can't be altered while taking payment
        /// </summary>
        /// <param name="disOrEn">true will enable the buttons, false disables</param>
        public void DisOrEnableButtons(bool disOrEn)
        {
            btnAdd.IsEnabled = disOrEn;
            btnRemove.IsEnabled = disOrEn;
            btnBriarHeart.IsEnabled = disOrEn;
            btnFried.IsEnabled = disOrEn;
            btnCandlehearth.IsEnabled = disOrEn;
            btnDouble.IsEnabled = disOrEn;
            btnThalmor.IsEnabled = disOrEn;
            btnThugs.IsEnabled = disOrEn;
            btnPhilly.IsEnabled = disOrEn;
            btnAretino.IsEnabled = disOrEn;
            btnMadOtar.IsEnabled = disOrEn;
            btnSmokehouse.IsEnabled = disOrEn;
            btnWarrior.IsEnabled = disOrEn;
            btnSailor.IsEnabled = disOrEn;
            btnMarkarth.IsEnabled = disOrEn;
            btnVokun.IsEnabled = disOrEn;
            btnDragonborn.IsEnabled = disOrEn;
            btnGarden.IsEnabled = disOrEn;
            btnCheckOut.IsEnabled = disOrEn;
            btnChooseCombo.IsEnabled = disOrEn;
        }
    }
}
