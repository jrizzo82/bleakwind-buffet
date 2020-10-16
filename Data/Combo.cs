/*
 * Author: Jerry Rizzo 
 * Class Name: Combo.cs
 * Purpose: Represents a Combo on the Bleakwind Buffet Menu
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Class for a Combo on the menu
    /// </summary>
    public class Combo : IOrderItem
    {
        private Drink drink = new AretinoAppleJuice();
        private Side side = new DragonbornWaffleFries();
        private Entree entree = new BriarheartBurger();

        /// <summary>
        /// The drink in the combo
        /// </summary>
        public Drink Drink
        {
            get { return drink; }
            set
            {
                drink.PropertyChanged -= Combo_PropertyChanged;
                drink = value;
                drink.PropertyChanged += Combo_PropertyChanged;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Drink"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DrinkName"));
            }
        }

        /// <summary>
        /// The side in the combo
        /// </summary>
        public Side Side
        {
            get { return side; }
            set
            {
                side.PropertyChanged -= Combo_PropertyChanged;
                side = value;
                side.PropertyChanged += Combo_PropertyChanged;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Side"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SideName"));
            }
        }

        /// <summary>
        /// The entree in the combo
        /// </summary>
        public Entree Entree
        {
            get { return entree; }
            set
            {
                entree.PropertyChanged -= Combo_PropertyChanged;
                entree = value;
                entree.PropertyChanged += Combo_PropertyChanged;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Entree"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("EntreeName"));
            }
        }

        
        /// <summary>
        /// The price of the combo
        /// </summary>
        public double Price
        {
            get
            {
                double price = 0.0;                 
                price += drink.Price;
                price += side.Price;                
                price += entree.Price;
                return Math.Round(price - 1.0, 2);
            }
        }

        /// <summary>
        /// The calories in the combo
        /// </summary>
        public uint Calories
        {
            get
            {
                uint calories = 0;
                if (drink != null)
                    calories += drink.Calories;
                if (side != null)
                    calories += side.Calories;
                if (entree != null)
                    calories += entree.Calories;
                return calories;
            }
        }

        /// <summary>
        /// The special instructions for the combo
        /// </summary>
        public List<string> SpecialInstructions
        {
            get 
            {
                List<string> list = new List<string>();

                if (entree != null)
                {
                    list.Add(entree.ToString());
                    foreach (string str in entree.SpecialInstructions)
                        list.Add(str);
                }

                if (side != null)
                {
                    list.Add(side.ToString());
                    foreach (string str in side.SpecialInstructions)
                        list.Add(str);
                }
                if (drink != null)
                {
                    list.Add(drink.ToString());
                    foreach (string str in drink.SpecialInstructions)
                        list.Add(str);
                }

                return list;
            }
        }

        /// <summary>
        /// Generic label for a combo
        /// </summary>
        public string Name
        {
            get => "Combo";
        }

        /// <summary>
        /// The name of the combo's entree
        /// </summary>
        public string EntreeName
        {
            get => Entree.Name;
        }

        /// <summary>
        /// The name of the combo's side
        /// </summary>
        public string SideName
        {
            get => Side.Name;
        }

        /// <summary>
        /// The name of the combo's drink
        /// </summary>
        public string DrinkName
        {
            get => Drink.Name;
        }

        /// <summary>
        /// Property changed event handler for combo
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Constructor for Combo
        /// </summary>
        public Combo()
        {
            drink.PropertyChanged += Combo_PropertyChanged;
            side.PropertyChanged += Combo_PropertyChanged;
            entree.PropertyChanged += Combo_PropertyChanged;
        }

        /// <summary>
        /// Event listener for side, drink, and entree property changes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Combo_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {            
            if (e.PropertyName == "Price")
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            if (e.PropertyName == "Calories")
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            if (e.PropertyName == "SpecialInstructions")
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            if (e.PropertyName == "Size" || e.PropertyName == "Flavor" || e.PropertyName == "Decaf")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SideName"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DrinkName"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
