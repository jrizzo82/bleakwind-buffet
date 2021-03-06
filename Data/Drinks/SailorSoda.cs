﻿/*
 * Author: Jerry Rizzo 
 * Class Name: SailorSoda.cs
 * Purpose: Represents Sailor Soda drink.
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;


namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class for Sailor Soda drink.
    /// </summary>
    public class SailorSoda : Drink, IOrderItem
    {
        private bool ice = true;
        private Size size = Size.Small;
        private SodaFlavor flavor = SodaFlavor.Cherry;

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
                        return 1.42;
                    case Size.Medium:
                        return 1.74;
                    default:
                        return 2.07;
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
                        return 117;
                    case Size.Medium:
                        return 153;
                    default:
                        return 205;
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
                    OnPropertyChanged(new PropertyChangedEventArgs("Ice"));
                    OnPropertyChanged(new PropertyChangedEventArgs("SpecialInstructions"));
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
                    OnPropertyChanged(new PropertyChangedEventArgs("Size"));
                    OnPropertyChanged(new PropertyChangedEventArgs("Price"));
                    OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
                    OnPropertyChanged(new PropertyChangedEventArgs("Name"));
                }
            }
        }

        /// <summary>
        /// The drink's flavor.
        /// </summary>
        public SodaFlavor Flavor
        {
            get
            {
                return this.flavor;
            }
            set
            {
                if (this.flavor != value)
                {
                    this.flavor = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("Flavor"));
                    OnPropertyChanged(new PropertyChangedEventArgs("Name"));
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
                if (!this.ice)
                    sInst.Add("Hold ice");

                return sInst;
            }
        }

        /// <summary>
        /// A description of the item.
        /// </summary>
        public override string Description
        {
            get
            {
                return "An old-fashioned jerked soda, carbonated water and flavored syrup poured over a bed of crushed ice.";
            }
        }

        /// <summary>
        /// The name of the drink.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string sub1;
            string sub2;
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
            switch (this.flavor)
            {
                case SodaFlavor.Blackberry:
                    sub2 = " Blackberry";
                    break;
                case SodaFlavor.Cherry:
                    sub2 = " Cherry";
                    break;
                case SodaFlavor.Grapefruit:
                    sub2 = " Grapefruit";
                    break;
                case SodaFlavor.Lemon:
                    sub2 = " Lemon";
                    break;
                case SodaFlavor.Peach:
                    sub2 = " Peach";
                    break;
                default:
                    sub2 = " Watermelon";
                    break;
            }
            return sub1 + sub2 + " Sailor Soda";
        }
    }
}
