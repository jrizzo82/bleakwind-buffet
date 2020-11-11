/*
 * Author: Jerry Rizzo
 * Class: WarriorWaterTests.cs
 * Purpose: Test the WarriorWater.cs class in the Data library
 */

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    /// <summary>
    /// Unit Tests for WarriorWater.cs
    /// </summary>
    public class WarriorWaterTests
    {
        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            WarriorWater ww = new WarriorWater();
            Assert.True(ww.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            WarriorWater ww = new WarriorWater();
            Assert.Equal(Size.Small, ww.Size);
        }

        [Fact]
        public void ShouldNotHaveLemonByDefault()
        {
            WarriorWater ww = new WarriorWater();
            Assert.False(ww.Lemon);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            WarriorWater ww = new WarriorWater();
            ww.Ice = true;
            Assert.True(ww.Ice);
            ww.Ice = false;
            Assert.False(ww.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetLemon()
        {
            WarriorWater ww = new WarriorWater();
            ww.Lemon = true;
            Assert.True(ww.Lemon);
            ww.Lemon = false;
            Assert.False(ww.Lemon);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            WarriorWater ww = new WarriorWater();
            ww.Size = Size.Large;
            Assert.Equal(Size.Large, ww.Size);
            ww.Size = Size.Medium;
            Assert.Equal(Size.Medium, ww.Size);
            ww.Size = Size.Small;
            Assert.Equal(Size.Small, ww.Size);
        }

        [Theory]
        [InlineData(0.0)]        
        public void ShouldHaveCorrectPrice(double price)
        {
            WarriorWater ww = new WarriorWater();       
            Assert.Equal(price, ww.Price);
        }

        [Theory]
        [InlineData(0)]
        public void ShouldHaveCorrectCalories(uint calories)
        {
            WarriorWater ww = new WarriorWater();
            Assert.Equal(calories, ww.Calories);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeLemon)
        {
            WarriorWater ww = new WarriorWater();
            ww.Ice = includeIce;
            ww.Lemon = includeLemon;
            if (!includeIce)
                Assert.Contains("Hold ice", ww.SpecialInstructions);
            if (includeLemon)
                Assert.Contains("Add lemon", ww.SpecialInstructions);
            if (includeIce && !includeLemon)
                Assert.Empty(ww.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, "Small Warrior Water")]
        [InlineData(Size.Medium, "Medium Warrior Water")]
        [InlineData(Size.Large, "Large Warrior Water")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            WarriorWater ww = new WarriorWater();
            ww.Size = size;
            Assert.Equal(name, ww.ToString());
        }

        [Fact]
        public void ShouldBeAssignableToIOrderItem()
        {
            WarriorWater ww = new WarriorWater();
            Assert.IsAssignableFrom<IOrderItem>(ww);
        }

        [Fact]
        public void ShouldBeAssignableToBaseClass()
        {
            WarriorWater ww = new WarriorWater();
            Assert.IsAssignableFrom<Drink>(ww);
        }

        [Fact]
        public void ShouldNotifySizeChange()
        {
            WarriorWater ww = new WarriorWater();
            Assert.PropertyChanged(ww, "Size", () => ww.Size = Size.Medium);
            Assert.PropertyChanged(ww, "Size", () => ww.Size = Size.Large);
            Assert.PropertyChanged(ww, "Size", () => ww.Size = Size.Small);
        }

        [Fact]
        public void ShouldNotifyIceChange()
        {
            WarriorWater ww = new WarriorWater();
            Assert.PropertyChanged(ww, "Ice", () => ww.Ice = false);
            Assert.PropertyChanged(ww, "Ice", () => ww.Ice = true);
        }

        [Fact]
        public void ShouldNotifyLemonChange()
        {
            WarriorWater ww = new WarriorWater();
            Assert.PropertyChanged(ww, "Lemon", () => ww.Lemon = true);
            Assert.PropertyChanged(ww, "Lemon", () => ww.Lemon = false);
        }

        [Fact]
        public void ShouldNotifyNameChange()
        {
            WarriorWater ww = new WarriorWater();
            Assert.PropertyChanged(ww, "Name", () => ww.Size = Size.Medium);
            Assert.PropertyChanged(ww, "Name", () => ww.Size = Size.Large);
        }

        [Fact]
        public void ShouldNotifySpecialInstructionsChange()
        {
            WarriorWater ww = new WarriorWater();
            Assert.PropertyChanged(ww, "SpecialInstructions", () => ww.Ice = false);
            Assert.PropertyChanged(ww, "SpecialInstructions", () => ww.Ice = true);
            Assert.PropertyChanged(ww, "SpecialInstructions", () => ww.Lemon = true);
            Assert.PropertyChanged(ww, "SpecialInstructions", () => ww.Lemon = false);
        }

        [Fact]
        public void ShouldBeAssignableToINotifyPropertyChanged()
        {
            WarriorWater ww = new WarriorWater();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(ww);
        }

        [Fact]
        public void ShouldReturnCorrectDescription()
        {
            WarriorWater ww = new WarriorWater();
            Assert.Equal("It’s water. Just water.", ww.Description);
        }
    }
}
