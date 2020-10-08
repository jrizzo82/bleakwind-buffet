/*
 * Author: Jerry Rizzo 
 * Class Name: GardenOrcOmelette.cs
 * Purpose: Represents Garden Orc Omelette entree.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class for Garden Orc Omelette entree.
    /// </summary>
    public class GardenOrcOmelette : Entree, IOrderItem
    {
        private bool broccoli = true;
        private bool mushrooms = true;
        private bool tomato = true;
        private bool cheddar = true;

        /// <summary>
        /// The entree price.
        /// </summary>
        public override double Price
        {
            get
            {
                return 4.57;
            }
        }

        /// <summary>
        /// The entree's calories.
        /// </summary>
        public override uint Calories
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
                if (this.broccoli != value)
                {
                    this.broccoli = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("Broccoli"));
                    OnPropertyChanged(new PropertyChangedEventArgs("SpecialInstructions"));
                }
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
                if (this.mushrooms != value)
                {
                    this.mushrooms = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("Mushrooms"));
                    OnPropertyChanged(new PropertyChangedEventArgs("SpecialInstructions"));
                }
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
                if (this.tomato != value)
                {
                    this.tomato = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("Tomato"));
                    OnPropertyChanged(new PropertyChangedEventArgs("SpecialInstructions"));
                }
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
                if (this.cheddar != value)
                {
                    this.cheddar = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("Cheddar"));
                    OnPropertyChanged(new PropertyChangedEventArgs("SpecialInstructions"));
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
