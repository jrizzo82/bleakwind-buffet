/*
 * Author: Jerry Rizzo 
 * Class Name: Menu.cs
 * Purpose: Represents Bleakwind Buffet Menu
 */

using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
//using System.Linq;
using System.Runtime;
using System.Linq;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Class for Bleakwind Buffet Menu
    /// </summary>
    public static class Menu
    {
        /// <summary>
        /// The entrees on the menu
        /// </summary>
        /// <returns>enumeration containing each entree</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> entrees = new List<IOrderItem>();

            entrees.Add(new BriarheartBurger());
            entrees.Add(new DoubleDraugr());
            entrees.Add(new GardenOrcOmelette());
            entrees.Add(new PhillyPoacher());
            entrees.Add(new SmokehouseSkeleton());
            entrees.Add(new ThalmorTriple());
            entrees.Add(new ThugsTBone());

            foreach (IOrderItem oi in entrees)
                yield return oi;
        }

        /// <summary>
        /// The sides on the menu
        /// </summary>
        /// <returns>enumeration containing each side</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sides = new List<IOrderItem>();

            DragonbornWaffleFries dwm = new DragonbornWaffleFries();
            dwm.Size = Size.Medium;
            DragonbornWaffleFries dwl = new DragonbornWaffleFries();
            dwl.Size = Size.Large;

            sides.Add(new DragonbornWaffleFries());
            sides.Add(dwm);
            sides.Add(dwl);

            FriedMiraak fmm = new FriedMiraak();
            fmm.Size = Size.Medium;
            FriedMiraak fml = new FriedMiraak();
            fml.Size = Size.Large;

            sides.Add(new FriedMiraak());
            sides.Add(fmm);
            sides.Add(fml);

            MadOtarGrits mom = new MadOtarGrits();
            mom.Size = Size.Medium;
            MadOtarGrits mol = new MadOtarGrits();
            mol.Size = Size.Large;

            sides.Add(new MadOtarGrits());
            sides.Add(mom);
            sides.Add(mol);

            VokunSalad vsm = new VokunSalad();
            vsm.Size = Size.Medium;
            VokunSalad vsl = new VokunSalad();
            vsl.Size = Size.Large;

            sides.Add(new VokunSalad());
            sides.Add(vsm);
            sides.Add(vsl);

            foreach (IOrderItem oi in sides)
                yield return oi;
        }

        /// <summary>
        /// The drinks on the menu
        /// </summary>
        /// <returns>enumeration containing each drink</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drinks = new List<IOrderItem>();

            AretinoAppleJuice ajm = new AretinoAppleJuice();
            ajm.Size = Size.Medium;
            AretinoAppleJuice ajl = new AretinoAppleJuice();
            ajl.Size = Size.Large;

            drinks.Add(new AretinoAppleJuice());
            drinks.Add(ajm);
            drinks.Add(ajl);

            CandlehearthCoffee chm = new CandlehearthCoffee();
            chm.Size = Size.Medium;
            CandlehearthCoffee chl = new CandlehearthCoffee();
            chl.Size = Size.Large;
            CandlehearthCoffee chds = new CandlehearthCoffee();
            chds.Decaf = true;
            CandlehearthCoffee chdm = new CandlehearthCoffee();
            chdm.Decaf = true;
            chdm.Size = Size.Medium;
            CandlehearthCoffee chdl = new CandlehearthCoffee();
            chdl.Decaf = true;
            chdl.Size = Size.Large;

            drinks.Add(new CandlehearthCoffee());
            drinks.Add(chm);
            drinks.Add(chl);
            drinks.Add(chds);
            drinks.Add(chdm);
            drinks.Add(chdl);

            MarkarthMilk mmm = new MarkarthMilk();
            mmm.Size = Size.Medium;
            MarkarthMilk mml = new MarkarthMilk();
            mml.Size = Size.Large;

            drinks.Add(new MarkarthMilk());
            drinks.Add(mmm);
            drinks.Add(mml);

            SailorSoda ssmc = new SailorSoda();
            ssmc.Size = Size.Medium;
            SailorSoda sslc = new SailorSoda();
            sslc.Size = Size.Large;

            SailorSoda sssb = new SailorSoda();
            sssb.Flavor = SodaFlavor.Blackberry;
            SailorSoda ssmb = new SailorSoda();
            ssmb.Size = Size.Medium;
            ssmb.Flavor = SodaFlavor.Blackberry;
            SailorSoda sslb = new SailorSoda();
            sslb.Size = Size.Large;
            sslb.Flavor = SodaFlavor.Blackberry;

            SailorSoda sssg = new SailorSoda();
            sssg.Flavor = SodaFlavor.Grapefruit;
            SailorSoda ssmg = new SailorSoda();
            ssmg.Size = Size.Medium;
            ssmg.Flavor = SodaFlavor.Grapefruit;
            SailorSoda sslg = new SailorSoda();
            sslg.Size = Size.Large;
            sslg.Flavor = SodaFlavor.Grapefruit;

            SailorSoda sssl = new SailorSoda();
            sssl.Flavor = SodaFlavor.Lemon;
            SailorSoda ssml = new SailorSoda();
            ssml.Size = Size.Medium;
            ssml.Flavor = SodaFlavor.Lemon;
            SailorSoda ssll = new SailorSoda();
            ssll.Size = Size.Large;
            ssll.Flavor = SodaFlavor.Lemon;

            SailorSoda sssp = new SailorSoda();
            sssp.Flavor = SodaFlavor.Peach;
            SailorSoda ssmp = new SailorSoda();
            ssmp.Size = Size.Medium;
            ssmp.Flavor = SodaFlavor.Peach;
            SailorSoda sslp = new SailorSoda();
            sslp.Size = Size.Large;
            sslp.Flavor = SodaFlavor.Peach;

            SailorSoda sssw = new SailorSoda();
            sssw.Flavor = SodaFlavor.Watermelon;
            SailorSoda ssmw = new SailorSoda();
            ssmw.Size = Size.Medium;
            ssmw.Flavor = SodaFlavor.Watermelon;
            SailorSoda sslw = new SailorSoda();
            sslw.Size = Size.Large;
            sslw.Flavor = SodaFlavor.Watermelon;

            drinks.Add(new SailorSoda());
            drinks.Add(ssmc);
            drinks.Add(sslc);
            drinks.Add(sssb);
            drinks.Add(ssmb);
            drinks.Add(sslb);
            drinks.Add(sssg);
            drinks.Add(ssmg);
            drinks.Add(sslg);
            drinks.Add(sssl);
            drinks.Add(ssml);
            drinks.Add(ssll);
            drinks.Add(sssp);
            drinks.Add(ssmp);
            drinks.Add(sslp);
            drinks.Add(sssw);
            drinks.Add(ssmw);
            drinks.Add(sslw);

            WarriorWater wwm = new WarriorWater();
            wwm.Size = Size.Medium;
            WarriorWater wwl = new WarriorWater();
            wwl.Size = Size.Large;

            drinks.Add(new WarriorWater());
            drinks.Add(wwm);
            drinks.Add(wwl);

            foreach (IOrderItem oi in drinks)
                yield return oi;
        }

        /// <summary>
        /// All the items on the menu
        /// </summary>
        /// <returns>enumeration containing each item on the menu</returns>
        public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> menu = new List<IOrderItem>();

            menu.AddRange(Drinks());
            menu.AddRange(Sides());
            menu.AddRange(Entrees());

            foreach (IOrderItem oi in menu)
                yield return oi;
        }

        /// <summary>
        /// Searches for the menu items that match the search criteria
        /// </summary>
        /// <param name="terms">string with which to filter the search</param>
        /// <returns>the order items that match the search</returns>
        public static IEnumerable<IOrderItem> Search(string terms)
        {
            List<IOrderItem> results = new List<IOrderItem>();

            // null check
            if (terms == null) return FullMenu();

            foreach (IOrderItem io in FullMenu())
            {
                // Add the item if the name is a match
                if (io.Name != null && io.Name.Contains(terms))
                {
                    results.Add(io);
                }
            }

            return results;
        }

        /// <summary>
        /// Filters the provided collection of order items
        /// </summary>
        /// <param name="items">The collection of order items to filter</param>
        /// <param name="menuTypes">The menu types to include</param>
        /// <returns>A collection containing only order items that match the filter</returns>
        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> items, IEnumerable<string> menuTypes)
        {
            // If no filter is specified, just return the provided collection
            if (menuTypes == null || menuTypes.Count() == 0) return items;

            // Filter the supplied collection of movies
            List<IOrderItem> results = new List<IOrderItem>();
            foreach (IOrderItem io in items)
            {
                if ((menuTypes.Contains("Entrees") && io is Entree) || (menuTypes.Contains("Sides") && io is Side)
                    || (menuTypes.Contains("Drinks") && io is Drink))
                {
                    results.Add(io);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters the provided collection of order items
        /// to those with their price falling within
        /// the specified range
        /// </summary>
        /// <param name="items">The collection of order items to filter</param>
        /// <param name="min">The minimum range value</param>
        /// <param name="max">The maximum range value</param>
        /// <returns>The filtered order item collection</returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> items, double? min, double? max)
        {
            if (min == null && max == null) return items;

            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem io in items)
                {
                    if (io.Price <= max) results.Add(io);
                }
                return results;
            }

            if (max == null)
            {
                foreach (IOrderItem io in items)
                {
                    if (io.Price >= min) results.Add(io);
                }
                return results;
            }

            // Both minimum and maximum specified
            foreach (IOrderItem io in items)
            {
                if (io.Price >= min && io.Price <= max)
                {
                    results.Add(io);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters the provided collection of order items
        /// to those with calories falling within
        /// the specified range
        /// </summary>
        /// <param name="items">The collection of movies to filter</param>
        /// <param name="min">The minimum range value</param>
        /// <param name="max">The maximum range value</param>
        /// <returns>The filtered order item collection</returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> items, int? min, int? max)
        {
            if (min == null && max == null) return items;

            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem io in items)
                {
                    if (io.Calories <= max) results.Add(io);
                }
                return results;
            }

            if (max == null)
            {
                foreach (IOrderItem io in items)
                {
                    if (io.Calories >= min) results.Add(io);
                }
                return results;
            }

            // Both minimum and maximum specified
            foreach (IOrderItem io in items)
            {
                if (io.Calories >= min && io.Calories <= max)
                {
                    results.Add(io);
                }
            }
            return results;
        }
    }
}
