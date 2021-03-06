﻿/*
 * Author: Zachery Brunner
 * Class: CandlehearthCoffeeTests.cs
 * Purpose: Test the CandlehearthCoffee.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    /// <summary>
    /// Unit Tests for CandlehearthCoffee.cs
    /// </summary>
    public class CandlehearthCoffeeTests
    {
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            CandlehearthCoffee ch = new CandlehearthCoffee();
            Assert.False(ch.Ice);
        }

        [Fact]
        public void ShouldNotBeDecafByDefault()
        {
            CandlehearthCoffee ch = new CandlehearthCoffee();
            Assert.False(ch.Decaf);
        }

        [Fact]
        public void ShouldNotHaveRoomForCreamByDefault()
        {
            CandlehearthCoffee ch = new CandlehearthCoffee();
            Assert.False(ch.RoomForCream);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            CandlehearthCoffee ch = new CandlehearthCoffee();
            Assert.Equal(Size.Small, ch.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            CandlehearthCoffee ch = new CandlehearthCoffee();
            ch.Ice = true;
            Assert.True(ch.Ice);
            ch.Ice = false;
            Assert.False(ch.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetDecaf()
        {
            CandlehearthCoffee ch = new CandlehearthCoffee();
            ch.Decaf = true;
            Assert.True(ch.Decaf);
            ch.Decaf = false;
            Assert.False(ch.Decaf);
        }

        [Fact]
        public void ShouldBeAbleToSetRoomForCream()
        {
            CandlehearthCoffee ch = new CandlehearthCoffee();
            ch.RoomForCream = true;
            Assert.True(ch.RoomForCream);
            ch.RoomForCream = false;
            Assert.False(ch.RoomForCream);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            CandlehearthCoffee ch = new CandlehearthCoffee();
            ch.Size = Size.Large;
            Assert.Equal(Size.Large, ch.Size);
            ch.Size = Size.Medium;
            Assert.Equal(Size.Medium, ch.Size);
            ch.Size = Size.Small;
            Assert.Equal(Size.Small, ch.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0.75)]
        [InlineData(Size.Medium, 1.25)]
        [InlineData(Size.Large, 1.75)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            CandlehearthCoffee ch = new CandlehearthCoffee();
            ch.Size = size;
            Assert.Equal(price, ch.Price);
        }

        [Theory]
        [InlineData(Size.Small, 7)]
        [InlineData(Size.Medium, 10)]
        [InlineData(Size.Large, 20)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            CandlehearthCoffee ch = new CandlehearthCoffee();
            ch.Size = size;
            Assert.Equal(cal, ch.Calories);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeCream)
        {
            CandlehearthCoffee ch = new CandlehearthCoffee();
            ch.Ice = includeIce;
            ch.RoomForCream = includeCream;
            if (includeIce)
                Assert.Contains("Add ice", ch.SpecialInstructions);
            if (includeCream)
                Assert.Contains("Add cream", ch.SpecialInstructions);
            if (!includeIce && !includeCream)
                Assert.Empty(ch.SpecialInstructions);
        }

        [Theory]
        [InlineData(true, Size.Small, "Small Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Medium, "Medium Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Large, "Large Decaf Candlehearth Coffee")]
        [InlineData(false, Size.Small, "Small Candlehearth Coffee")]
        [InlineData(false, Size.Medium, "Medium Candlehearth Coffee")]
        [InlineData(false, Size.Large, "Large Candlehearth Coffee")]
        public void ShouldReturnCorrectToStringBasedOnSize(bool decaf, Size size, string name)
        {
            CandlehearthCoffee ch = new CandlehearthCoffee();
            ch.Size = size;
            ch.Decaf = decaf;
            Assert.Equal(name, ch.ToString());
        }

        [Fact]
        public void ShouldBeAssignableToIOrderItem()
        {
            CandlehearthCoffee ch = new CandlehearthCoffee();
            Assert.IsAssignableFrom<IOrderItem>(ch);
        }

        [Fact]
        public void ShouldBeAssignableToBaseClass()
        {
            CandlehearthCoffee ch = new CandlehearthCoffee();
            Assert.IsAssignableFrom<Drink>(ch);
        }

        [Fact]
        public void ShouldNotifySizeChange()
        {
            CandlehearthCoffee ch = new CandlehearthCoffee();
            Assert.PropertyChanged(ch, "Size", () => ch.Size = Size.Medium);
            Assert.PropertyChanged(ch, "Size", () => ch.Size = Size.Large);
            Assert.PropertyChanged(ch, "Size", () => ch.Size = Size.Small);
        }

        [Fact]
        public void ShouldNotifyPriceChange()
        {
            CandlehearthCoffee ch = new CandlehearthCoffee();
            Assert.PropertyChanged(ch, "Price", () => ch.Size = Size.Medium);
            Assert.PropertyChanged(ch, "Price", () => ch.Size = Size.Large);
            Assert.PropertyChanged(ch, "Price", () => ch.Size = Size.Small);
        }

        [Fact]
        public void ShouldNotifyCaloriesChange()
        {
            CandlehearthCoffee ch = new CandlehearthCoffee();
            Assert.PropertyChanged(ch, "Calories", () => ch.Size = Size.Medium);
            Assert.PropertyChanged(ch, "Calories", () => ch.Size = Size.Large);
            Assert.PropertyChanged(ch, "Calories", () => ch.Size = Size.Small);
        }

        [Fact]
        public void ShouldNotifyIceChange()
        {
            CandlehearthCoffee ch = new CandlehearthCoffee();
            Assert.PropertyChanged(ch, "Ice", () => ch.Ice = true);
            Assert.PropertyChanged(ch, "Ice", () => ch.Ice = false);
        }

        [Fact]
        public void ShouldNotifyRoomForCreamChange()
        {
            CandlehearthCoffee ch = new CandlehearthCoffee();
            Assert.PropertyChanged(ch, "RoomForCream", () => ch.RoomForCream = true);
            Assert.PropertyChanged(ch, "RoomForCream", () => ch.RoomForCream = false);
        }

        [Fact]
        public void ShouldNotifyDecafChange()
        {
            CandlehearthCoffee ch = new CandlehearthCoffee();
            Assert.PropertyChanged(ch, "Decaf", () => ch.Decaf = true);
            Assert.PropertyChanged(ch, "Decaf", () => ch.Decaf = false);
        }

        [Fact]
        public void ShouldNotifyNameChange()
        {
            CandlehearthCoffee ch = new CandlehearthCoffee();
            Assert.PropertyChanged(ch, "Name", () => ch.Size = Size.Medium);
            Assert.PropertyChanged(ch, "Name", () => ch.Decaf = true);
            Assert.PropertyChanged(ch, "Name", () => ch.Decaf = false);
        }

        [Fact]
        public void ShouldNotifySpecialInstructionsChange()
        {
            CandlehearthCoffee ch = new CandlehearthCoffee();
            Assert.PropertyChanged(ch, "SpecialInstructions", () => ch.Ice = true);
            Assert.PropertyChanged(ch, "SpecialInstructions", () => ch.Ice = false);
            Assert.PropertyChanged(ch, "SpecialInstructions", () => ch.RoomForCream = true);
            Assert.PropertyChanged(ch, "SpecialInstructions", () => ch.RoomForCream = false);
        }

        [Fact]
        public void ShouldBeAssignableToINotifyPropertyChanged()
        {
            CandlehearthCoffee ch = new CandlehearthCoffee();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(ch);
        }

        [Fact]
        public void ShouldReturnCorrectDescription()
        {
            CandlehearthCoffee ch = new CandlehearthCoffee();
            Assert.Equal("Fair trade, fresh ground dark roast coffee.", ch.Description);
        }
    }
}
