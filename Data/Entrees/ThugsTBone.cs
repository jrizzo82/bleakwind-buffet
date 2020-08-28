/*
 * Author: Jerry Rizzo 
 * Class Name: ThugsTBone.cs
 * Purpose: Represents Thugs TBone entree.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class for Thugs TBone entree.
    /// </summary>
    public class ThugsTBone
    {
        /// <summary>
        /// The entree price.
        /// </summary>
        public double Price
        {
            get
            {
                return 6.44;
            }
        }

        /// <summary>
        /// The entree's calories.
        /// </summary>
        public uint Calories
        {
            get
            {
                return 982;
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
        /// The name of the entree.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}
