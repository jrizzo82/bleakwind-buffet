/*
 * Author: Jerry Rizzo 
 * Class Name: Order.cs
 * Purpose: Represents an Order of menu items
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Class for an order at the Blearwind Buffet
    /// </summary>
    public class Order : ObservableCollection<IOrderItem>
    {
        /// <summary>
        /// The Order's sales tax rate
        /// </summary>
        public double SalesTaxRate { get; set; } = 0.12;

        /// <summary>
        /// The total price of the order before tax
        /// </summary>
        public double Subtotal
        {
            get
            {
                double total = 0.0;
                foreach (IOrderItem item in this)
                    total += item.Price;
                return Math.Round(total, 2);
            }
        }

        /// <summary>
        /// The tax on the order
        /// </summary>
        public double Tax
        {
            get
            {
                return Math.Round(Subtotal*SalesTaxRate, 2);
            }
        }

        /// <summary>
        /// The total price including tax
        /// </summary>
        public double Total
        {
            get
            { 
                return Math.Round(Tax+Subtotal, 2);
            }
        }

        /// <summary>
        /// The amount of calories in the order
        /// </summary>
        public uint Calories
        {
            get
            {
                uint total = 0;
                foreach (IOrderItem item in this)
                    total += item.Calories;
                return total;
            }
        }

        /// <summary>
        /// The order number
        /// </summary>
        public uint Number { get; private set; }

        /// <summary>
        /// Constructor for an order
        /// </summary>
        /// <param name="number">The order number</param>
        public Order(uint number)
        {
            Number = number;
        }

        /// <summary>
        /// Removes an item from the order
        /// </summary>
        /// <param name="item"></param>
        public new void Remove(IOrderItem item)
        {
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, item));
            base.Remove(item);
            item.PropertyChanged -= Order_PropertyChanged;
            OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
            OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
            OnPropertyChanged(new PropertyChangedEventArgs("Total"));
            OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
        }

        /// <summary>
        /// Adds an item to the order
        /// </summary>
        /// <param name="item"></param>
        public new void Add(IOrderItem item)
        {
            base.Add(item);
            item.PropertyChanged += Order_PropertyChanged;
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item));
            OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
            OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
            OnPropertyChanged(new PropertyChangedEventArgs("Total"));
            OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
        }

        /// <summary>
        /// Event listener for changes to the order items
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Order_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Price")
            {
                OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
                OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
                OnPropertyChanged(new PropertyChangedEventArgs("Total"));
            }

            if (e.PropertyName == "Calories")
                OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
            
        }
    }
}
