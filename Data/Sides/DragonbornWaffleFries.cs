/*
 * Author: Jerry Rizzo 
 * Class Name: DragonbornWaffleFries.cs
 * Purpose: Represents Dragonborn Waffle Fries side.
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;


namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Class for Dragonborn Waffle Fries side.
    /// </summary>
    public class DragonbornWaffleFries : Side, IOrderItem
    {
        private Size size = Size.Small;

        /// <summary>
        /// The side's price.
        /// </summary>
        public override double Price
        {
            get
            {
                switch (this.size)
                {
                    case Size.Small:
                        return 0.42;
                    case Size.Medium:
                        return 0.76;
                    default:
                        return 0.96;
                }
            }
        }

        /// <summary>
        /// The side's calories.
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (this.size)
                {
                    case Size.Small:
                        return 77;
                    case Size.Medium:
                        return 89;
                    default:
                        return 100;
                }
            }
        }


        /// <summary>
        /// The side's size.
        /// </summary>
        public override Size Size
        {
            get
            {
                return this.size;
            }
            set
            {
                this.size = value;
            }
        }

        /// <summary>
        /// List of special instructions.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                return new List<string>();
            }
        }

        /// <summary>
        /// The name of the side.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string sub1;
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
            return sub1 + " Dragonborn Waffle Fries";
        }
    }
}
