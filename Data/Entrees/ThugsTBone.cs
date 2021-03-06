﻿/*
 * Author: Jerry Rizzo 
 * Class Name: ThugsTBone.cs
 * Purpose: Represents Thugs TBone entree.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;


namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class for Thugs TBone entree.
    /// </summary>
    public class ThugsTBone : Entree, IOrderItem
    {
        /// <summary>
        /// The entree price.
        /// </summary>
        public override double Price
        {
            get
            {
                return 6.44;
            }
        }

        /// <summary>
        /// The entree's calories.
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 982;
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
        /// A description of the item.
        /// </summary>
        public override string Description
        {
            get
            {
                return "Juicy T-Bone, not much else to say.";
            }
        }

        /// <summary>
        /// The name of the entree.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}
