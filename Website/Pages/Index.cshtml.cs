/*
 * Author: Jerry Rizzo 
 * Class Name: Index.cshtml.cs
 * Purpose: Logic for the Index Page
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Globalization;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;

namespace Website.Pages
{
    /// <summary>
    /// Logic for Index Page
    /// </summary>
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        /// <summary>
        /// List of order items
        /// </summary>
        public IEnumerable<IOrderItem> Items { get; set; }

        /// <summary>
        /// List of entrees
        /// </summary>
        public List<IOrderItem> Entrees { get; set; }

        /// <summary>
        /// List of sides
        /// </summary>
        public List<IOrderItem> Sides { get; set; }

        /// <summary>
        /// List of drinks
        /// </summary>
        public List<IOrderItem> Drinks { get; set; }

        /// <summary>
        /// Minimum price in search filter
        /// </summary>
        public double? PriceMin { get; set; }

        /// <summary>
        /// Maximum price in search filter
        /// </summary>
        public double? PriceMax { get; set; }

        /// <summary>
        /// Minimum calories in search filter
        /// </summary>
        public int? CalMin { get; set; }

        /// <summary>
        /// Maximum calories in search filter
        /// </summary>
        public int? CalMax { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// The term to search for in the filter
        /// </summary>
        public string SearchTerms { get; set; }

        /// <summary>
        /// The menu categories
        /// </summary>
        public string[] MenuTypes { get; set; }

        /// <summary>
        /// Called upon loading the page
        /// </summary>
        public void OnGet()
        {
            SearchTerms = Request.Query["SearchTerms"];
            MenuTypes = Request.Query["MenuTypes"];
            string priceMinstr = Request.Query["PriceMin"];
            string priceMaxstr = Request.Query["PriceMax"];
            string calMinstr = Request.Query["CalMin"];
            string calMaxstr = Request.Query["CalMax"];

            if (priceMinstr == null || priceMinstr == "")
                PriceMin = null;
            else
                PriceMin = double.Parse(Request.Query["PriceMin"]);

            if (priceMaxstr == null || priceMaxstr == "")
                PriceMax = null;
            else
                PriceMax = double.Parse(Request.Query["PriceMax"]);

            if (calMinstr == null || calMinstr == "")
                CalMin = null;
            else
                CalMin = int.Parse(Request.Query["CalMin"]);

            if (calMaxstr == null || calMaxstr == "")
                CalMax = null;
            else
                CalMax = int.Parse(Request.Query["CalMax"]);

            Items = Menu.Search(SearchTerms);
            Items = Menu.FilterByCategory(Items, MenuTypes);
            Items = Menu.FilterByPrice(Items, PriceMin, PriceMax);
            Items = Menu.FilterByCalories(Items, CalMin, CalMax);
            Entrees = new List<IOrderItem>();
            Sides = new List<IOrderItem>();
            Drinks = new List<IOrderItem>();
            foreach (IOrderItem io in Items)
            {
                if (io is Entree)
                    Entrees.Add(io);
                else if (io is Side)
                    Sides.Add(io);
                else if (io is Drink)
                    Drinks.Add(io);
            }
        }
    }
}
