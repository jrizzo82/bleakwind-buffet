/*
 * Author: Jerry Rizzo 
 * Class Name: GardenOrcOmelette.cs
 * Purpose: Represents Garden Orc Omelette entree.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class for Garden Orc Omelette entree.
    /// </summary>
    public class GardenOrcOmelette
    {
        private bool broccoli = true;
        private bool mushrooms = true;
        private bool tomato = true;
        private bool cheddar = true;

        /// <summary>
        /// The entree price.
        /// </summary>
        public double Price
        {
            get
            {
                return 4.57;
            }
        }

        /// <summary>
        /// The entree's calories.
        /// </summary>
        public uint Calories
        {
            get
            {
                return 404;
            }
        }

        /// <summary>
        /// Whether the entree is to have broccoli or not.
        /// </summary>
        public bool Broccoli
        {
            get
            {
                return this.broccoli;
            }
            set
            {
                this.broccoli = value;
            }
        }

        /// <summary>
        /// Whether the entree is to have mushrooms or not.
        /// </summary>
        public bool Mushrooms
        {
            get
            {
                return this.mushrooms;
            }
            set
            {
                this.mushrooms = value;
            }
        }

        /// <summary>
        /// Whether the entree is to have tomato or not.
        /// </summary>
        public bool Tomato
        {
            get
            {
                return this.tomato;
            }
            set
            {
                this.tomato = value;
            }
        }

        /// <summary>
        /// Whether the entree is to have cheddar or not.
        /// </summary>
        public bool Cheddar
        {
            get
            {
                return this.cheddar;
            }
            set
            {
                this.cheddar = value;
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
                if (!this.broccoli)
                    sInst.Add("Hold broccoli");
                if (!this.mushrooms)
                    sInst.Add("Hold mushrooms");                
                if (!this.tomato)
                    sInst.Add("Hold tomato");
                if (!this.cheddar)
                    sInst.Add("Hold cheddar");
               
                return sInst;
            }
        }

        /// <summary>
        /// The name of the entree.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
