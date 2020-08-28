﻿/*
 * Author: Jerry Rizzo 
 * Class Name: WarriorWater.cs
 * Purpose: Represents Warrior Water drink.
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;


namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class for Warrior Water drink.
    /// </summary>
    public class WarriorWater
    {
        private bool ice = true;
        private Size size = Size.Small;
        private bool lemon = false;
        
        /// <summary>
        /// The drink's price.
        /// </summary>
        public double Price
        {
            get
            {
                return 0.0;               
            }
        }

        /// <summary>
        /// The drink's calories.
        /// </summary>
        public uint Calories
        {
            get
            {
                return 0;
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
                this.ice = value;
            }
        }

        /// <summary>
        /// Whether the drink has lemon or not.
        /// </summary>
        public bool Lemon
        {
            get
            {
                return this.lemon;
            }
            set
            {
                this.lemon = value;
            }
        }

        /// <summary>
        /// The drink's size.
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
                List<string> sInst = new List<string>();
                if (!this.ice)
                    sInst.Add("Hold ice");
                if (this.lemon)
                    sInst.Add("Add lemon");

                return sInst;
            }
        }

        /// <summary>
        /// The name of the drink.
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
            return sub1 + " Warrior Water";
        }
    }
}
