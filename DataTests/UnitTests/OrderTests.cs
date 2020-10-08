/*
 * Author: Jerry Rizzo
 * Class: OrderTests.cs
 * Purpose: Test the Order.cs class in the Data library
 */
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using Xunit.Abstractions;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using System.Collections.ObjectModel;

namespace BleakwindBuffet.DataTests.UnitTests
{
    /// <summary>
    /// Unit tests for Order.cs
    /// </summary>
    public class OrderTests
    {
        [Fact]
        public void ShouldReturnCorrectSubtotal()
        {
            Order order = new Order(1);
            order.Add(new BriarheartBurger());
            order.Add(new SailorSoda());
            order.Add(new VokunSalad());
            Assert.Equal(8.67, order.Subtotal);
        }

        [Fact]
        public void ShouldReturnCorrectTax()
        {
            Order order = new Order(1);
            order.Add(new BriarheartBurger());
            order.Add(new SailorSoda());
            order.Add(new VokunSalad());
            Assert.Equal(1.04, order.Tax);
        }

        [Fact]
        public void ShouldReturnCorrectTotal()
        {
            Order order = new Order(1);
            order.Add(new BriarheartBurger());
            order.Add(new SailorSoda());
            order.Add(new VokunSalad());
            Assert.Equal(9.71, order.Total);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            Order order = new Order(1);
            order.Add(new BriarheartBurger());
            order.Add(new SailorSoda());
            order.Add(new VokunSalad());
            Assert.Equal<uint>(901, order.Calories);
        }

        [Fact]
        public void ShouldReturnCorrectNumber()
        {
            Order order = new Order(1);
            Assert.Equal<uint>(1, order.Number);
        }

        [Fact]
        public void ShouldAddAndRemoveItemsCorrectly()
        {
            Order order = new Order(1);
            DoubleDraugr dd = new DoubleDraugr();
            order.Add(dd);
            Assert.Contains(dd, order);
            order.Remove(dd);
            Assert.Empty(order);
        }

        [Fact]
        public void ShouldNotifyOnSubtotalChanged()
        {
            Order order = new Order(1);
            ThugsTBone tt = new ThugsTBone();
            Assert.PropertyChanged(order, "Subtotal", () => order.Add(tt));
            Assert.PropertyChanged(order, "Subtotal", () => order.Remove(tt));
        }

        [Fact]
        public void ShouldNotifyOnTaxChanged()
        {
            Order order = new Order(1);
            ThugsTBone tt = new ThugsTBone();
            Assert.PropertyChanged(order, "Tax", () => order.Add(tt));
            Assert.PropertyChanged(order, "Tax", () => order.Remove(tt));
        }

        [Fact]
        public void ShouldNotifyOnTotalChanged()
        {
            Order order = new Order(1);
            ThugsTBone tt = new ThugsTBone();
            Assert.PropertyChanged(order, "Total", () => order.Add(tt));
            Assert.PropertyChanged(order, "Total", () => order.Remove(tt));
        }

        [Fact]
        public void ShouldNotifySubtotalChangeOnItemPriceChange()
        {
            Order order = new Order(1);
            CandlehearthCoffee cc = new CandlehearthCoffee();
            order.Add(cc);
            Assert.PropertyChanged(order, "Subtotal", () => cc.Size = Data.Enums.Size.Medium);
            Assert.PropertyChanged(order, "Subtotal", () => cc.Size = Data.Enums.Size.Large);
        }

        [Fact]
        public void ShouldNotifyTaxChangeOnItemPriceChange()
        {
            Order order = new Order(1);
            CandlehearthCoffee cc = new CandlehearthCoffee();
            order.Add(cc);
            Assert.PropertyChanged(order, "Tax", () => cc.Size = Data.Enums.Size.Medium);
            Assert.PropertyChanged(order, "Tax", () => cc.Size = Data.Enums.Size.Large);
        }

        [Fact]
        public void ShouldNotifyTotalChangeOnItemPriceChange()
        {
            Order order = new Order(1);
            CandlehearthCoffee cc = new CandlehearthCoffee();
            order.Add(cc);
            Assert.PropertyChanged(order, "Total", () => cc.Size = Data.Enums.Size.Medium);
            Assert.PropertyChanged(order, "Total", () => cc.Size = Data.Enums.Size.Large);
        }

        [Fact]
        public void ShouldNotifyCaloriesChangeOnItemSizeChange()
        {
            Order order = new Order(1);
            CandlehearthCoffee cc = new CandlehearthCoffee();
            order.Add(cc);
            Assert.PropertyChanged(order, "Calories", () => cc.Size = Data.Enums.Size.Medium);
            Assert.PropertyChanged(order, "Calories", () => cc.Size = Data.Enums.Size.Large);
        }

        [Fact]
        public void ShouldNotifyCaloriesChangeOnAddandRemoveItems()
        {
            Order order = new Order(1);
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.PropertyChanged(order, "Calories", () => order.Add(cc));
            Assert.PropertyChanged(order, "Calories", () => order.Remove(cc));
        }

        [Fact]
        public void ShouldBeAssignableToBaseClass()
        {
            Order order = new Order(1);
            Assert.IsAssignableFrom<ObservableCollection<IOrderItem>>(order);
        }
    }
}
