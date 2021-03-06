﻿/*
 * Author: Zachery Brunner
 * Class: DragonbornWaffleFriesTests.cs
 * Purpose: Test the DragonbornWaffleFries.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    /// <summary>
    /// Unit Tests for DragonbornWaffleFries.cs
    /// </summary>
    public class DragonbornWaffleFriesTests
    {
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            DragonbornWaffleFries dw = new DragonbornWaffleFries();
            Assert.Equal(Size.Small, dw.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            DragonbornWaffleFries dw = new DragonbornWaffleFries();
            dw.Size = Size.Large;
            Assert.Equal(Size.Large, dw.Size);
            dw.Size = Size.Medium;
            Assert.Equal(Size.Medium, dw.Size);
            dw.Size = Size.Small;
            Assert.Equal(Size.Small, dw.Size);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            DragonbornWaffleFries dw = new DragonbornWaffleFries();
            Assert.Empty(dw.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 0.42)]
        [InlineData(Size.Medium, 0.76)]
        [InlineData(Size.Large, 0.96)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            DragonbornWaffleFries dw = new DragonbornWaffleFries();
            dw.Size = size;
            Assert.Equal(price, dw.Price);
        }

        [Theory]
        [InlineData(Size.Small, 77)]
        [InlineData(Size.Medium, 89)]
        [InlineData(Size.Large, 100)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            DragonbornWaffleFries dw = new DragonbornWaffleFries();
            dw.Size = size;
            Assert.Equal(calories, dw.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Dragonborn Waffle Fries")]
        [InlineData(Size.Medium, "Medium Dragonborn Waffle Fries")]
        [InlineData(Size.Large, "Large Dragonborn Waffle Fries")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            DragonbornWaffleFries dw = new DragonbornWaffleFries();
            dw.Size = size;
            Assert.Equal(name, dw.ToString());
        }

        [Fact]
        public void ShouldBeAssignableToIOrderItem()
        {
            DragonbornWaffleFries dw = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<IOrderItem>(dw);
        }

        [Fact]
        public void ShouldBeAssignableToBaseClass()
        {
            DragonbornWaffleFries dw = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<Side>(dw);
        }

        [Fact]
        public void ShouldNotifySizeChange()
        {
            DragonbornWaffleFries dw = new DragonbornWaffleFries();
            Assert.PropertyChanged(dw, "Size", () => dw.Size = Size.Medium);
            Assert.PropertyChanged(dw, "Size", () => dw.Size = Size.Large);
            Assert.PropertyChanged(dw, "Size", () => dw.Size = Size.Small);
        }

        [Fact]
        public void ShouldNotifyPriceChange()
        {
            DragonbornWaffleFries dw = new DragonbornWaffleFries();
            Assert.PropertyChanged(dw, "Price", () => dw.Size = Size.Medium);
            Assert.PropertyChanged(dw, "Price", () => dw.Size = Size.Large);
            Assert.PropertyChanged(dw, "Price", () => dw.Size = Size.Small);
        }

        [Fact]
        public void ShouldNotifyCaloriesChange()
        {
            DragonbornWaffleFries dw = new DragonbornWaffleFries();
            Assert.PropertyChanged(dw, "Calories", () => dw.Size = Size.Medium);
            Assert.PropertyChanged(dw, "Calories", () => dw.Size = Size.Large);
            Assert.PropertyChanged(dw, "Calories", () => dw.Size = Size.Small);
        }

        [Fact]
        public void ShouldNotifyNameChange()
        {
            DragonbornWaffleFries dw = new DragonbornWaffleFries();
            Assert.PropertyChanged(dw, "Name", () => dw.Size = Size.Medium);
            Assert.PropertyChanged(dw, "Name", () => dw.Size = Size.Large);
        }

        [Fact]
        public void ShouldBeAssignableToINotifyPropertyChanged()
        {
            DragonbornWaffleFries dw = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(dw);
        }

        [Fact]
        public void ShouldReturnCorrectDescription()
        {
            DragonbornWaffleFries dw = new DragonbornWaffleFries();
            Assert.Equal("Crispy fried potato waffle fries.", dw.Description);
        }
    }
}