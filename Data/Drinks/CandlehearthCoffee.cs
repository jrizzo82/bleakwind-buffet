/*
 * Author: Jerry Rizzo 
 * Class Name: CandlehearthCoffee.cs
 * Purpose: Represents Candlehearth Coffee drink.
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;


namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class for Candlehearth Coffee drink.
    /// </summary>
    public class CandlehearthCoffee : Drink, IOrderItem, INotifyPropertyChanged
    {
        private bool ice = false;
        private Size size = Size.Small;
        private bool roomForCream = false;
        private bool decaf = false;

        /// <summary>
        /// The drink's price.
        /// </summary>
        public override double Price
        {
            get
            {
                switch (this.size)
                {
                    case Size.Small:
                        return 0.75;
                    case Size.Medium:
                        return 1.25;
                    default:
                        return 1.75;
                }
            }
        }

        /// <summary>
        /// The drink's calories.
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (this.size)
                {
                    case Size.Small:
                        return 7;
                    case Size.Medium:
                        return 10;
                    default:
                        return 20;
                }
            }
        }

        /// <summary>
        /// Whether the drink has ice or not.
        /// </summary>
        public bool Ice
        {
            get
            {
                return this.ice;
            }
            set
            {
                if (this.ice != value)
                {
                    this.ice = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        /// <summary>
        /// Whether the drink has room for cream or not.
        /// </summary>
        public bool RoomForCream
        {
            get
            {
                return this.roomForCream;
            }
            set
            {
                if (this.roomForCream != value)
                {
                    this.roomForCream = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RoomForCream"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        /// <summary>
        /// Whether the drink is decaf or not.
        /// </summary>
        public bool Decaf
        {
            get
            {
                return this.decaf;
            }
            set
            {
                if (this.decaf != value)
                {
                    this.decaf = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Decaf"));
                }
            }
        }

        /// <summary>
        /// The drink's size.
        /// </summary>
        public override Size Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (this.size != value)
                {
                    this.size = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                }
            }
        }

        /// <summary>
        /// List of special instructions.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> sInst = new List<string>();
                if (this.ice)
                    sInst.Add("Add ice");
                if (this.roomForCream)
                    sInst.Add("Add cream");

                return sInst;
            }
        }

        /// <summary>
        /// Event handler for when a property is changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The name of the drink.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string sub1;
            string sub2 = this.decaf ? " Decaf" : "";
            switch (this.size)
            {
                case Size.Small:
                    sub1 = "Small";
                    break;
                case Size.Medium:
                    sub1 = "Medium";
                    break;
                default:
                    sub1 = "Large";
                    break;
            }
            return sub1 + sub2 + " Candlehearth Coffee";
        }
    }
}
