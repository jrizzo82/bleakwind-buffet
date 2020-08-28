﻿/*
 * Author: Jerry Rizzo 
 * Class Name: FriedMiraak.cs
 * Purpose: Represents Fried Miraak side.
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;


namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Class for Fried Miraak side.
    /// </summary>
    public class FriedMiraak
    {
        private Size size = Size.Small;

        /// <summary>
        /// The side's price.
        /// </summary>
        public double Price
        {
            get
            {
                switch (this.size)
                {
                    case Size.Small:
                        return 1.78;
                    case Size.Medium:
                        return 2.01;
                    default:
                        return 2.88;
                }
            }
        }

        /// <summary>
        /// The side's calories.
        /// </summary>
        public uint Calories
        {
            get
            {
                switch (this.size)
                {
                    case Size.Small:
                        return 151;
                    case Size.Medium:
                        return 236;
                    default:
                        return 306;
                }
            }
        }


        /// <summary>
        /// The side's size.
        /// </summary>
        public Size Size
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
        public List<string> SpecialInstructions
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
            return sub1 + " Fried Miraak";
        }
    }
}
