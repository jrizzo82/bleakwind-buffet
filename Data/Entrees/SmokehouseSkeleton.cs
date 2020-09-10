/*
 * Author: Jerry Rizzo 
 * Class Name: SmokehouseSkeleton.cs
 * Purpose: Represents Smokehouse Skeleton entree.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class for Smokehouse Skeleton entree.
    /// </summary>
    public class SmokehouseSkeleton : Entree, IOrderItem
    {
        private bool sausageLink = true;
        private bool egg = true;
        private bool hashBrowns = true;
        private bool pancake = true;

        /// <summary>
        /// The entree price.
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.62;
            }
        }

        /// <summary>
        /// The entree's calories.
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 602;
            }
        }

        /// <summary>
        /// Whether the burger is to have sausage or not.
        /// </summary>
        public bool SausageLink
        {
            get
            {
                return this.sausageLink;
            }
            set
            {
                this.sausageLink = value;
            }
        }

        /// <summary>
        /// Whether the burger is to have egg or not.
        /// </summary>
        public bool Egg
        {
            get
            {
                return this.egg;
            }
            set
            {
                this.egg = value;
            }
        }

        /// <summary>
        /// Whether the burger is to have hashbrowns or not.
        /// </summary>
        public bool HashBrowns
        {
            get
            {
                return this.hashBrowns;
            }
            set
            {
                this.hashBrowns = value;
            }
        }

        /// <summary>
        /// Whether the burger is to have pancake or not.
        /// </summary>
        public bool Pancake
        {
            get
            {
                return this.pancake;
            }
            set
            {
                this.pancake = value;
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
                if (!this.sausageLink)
                    sInst.Add("Hold sausage");
                if (!this.egg)
                    sInst.Add("Hold eggs");
                if (!this.hashBrowns)
                    sInst.Add("Hold hash browns");
                if (!this.pancake)
                    sInst.Add("Hold pancakes");
                
                return sInst;
            }
        }

        /// <summary>
        /// The name of the entree.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
