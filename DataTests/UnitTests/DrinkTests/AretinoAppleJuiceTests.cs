/*
 * Author: Zachery Brunner
 * Class: AretinoAppleJuiceTests.cs
 * Purpose: Test the AretinoAppleJuice.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using NuGet.Frameworks;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    /// <summary>
    /// Unit Tests for AretinoAppleJuice.cs
    /// </summary>
    public class AretinoAppleJuiceTests
    {
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.False(aj.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.Equal(Size.Small, aj.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            aj.Ice = true;
            Assert.True(aj.Ice);
            aj.Ice = false;
            Assert.False(aj.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            aj.Size = Size.Large;
            Assert.Equal(Size.Large, aj.Size);
            aj.Size = Size.Medium;
            Assert.Equal(Size.Medium, aj.Size);
            aj.Size = Size.Small;
            Assert.Equal(Size.Small, aj.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0.62)]
        [InlineData(Size.Medium, 0.87)]
        [InlineData(Size.Large, 1.01)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            aj.Size = size;
            Assert.Equal(price, aj.Price);
        }

        [Theory]
        [InlineData(Size.Small, 44)]
        [InlineData(Size.Medium, 88)]
        [InlineData(Size.Large, 132)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            aj.Size = size;
            Assert.Equal(cal, aj.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            aj.Ice = includeIce;
            if (includeIce)
                Assert.Contains("Add ice", aj.SpecialInstructions);
            else
                Assert.Empty(aj.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, "Small Aretino Apple Juice")]
        [InlineData(Size.Medium, "Medium Aretino Apple Juice")]
        [InlineData(Size.Large, "Large Aretino Apple Juice")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            aj.Size = size;
            Assert.Equal(name, aj.ToString());
        }

        [Fact]
        public void ShouldBeAssignableToIOrderItem()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.IsAssignableFrom<IOrderItem>(aj);
        }

        [Fact]
        public void ShouldBeAssignableToBaseClass()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.IsAssignableFrom<Drink>(aj);
        }

        [Fact]
        public void ShouldNotifySizeChange()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();           
            Assert.PropertyChanged(aj, "Size", () => aj.Size = Size.Medium);
            Assert.PropertyChanged(aj, "Size", () => aj.Size = Size.Large);
            Assert.PropertyChanged(aj, "Size", () => aj.Size = Size.Small);
        }

        [Fact]
        public void ShouldNotifyPriceChange()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.PropertyChanged(aj, "Price", () => aj.Size = Size.Medium);
            Assert.PropertyChanged(aj, "Price", () => aj.Size = Size.Large);
            Assert.PropertyChanged(aj, "Price", () => aj.Size = Size.Small);
        }

        [Fact]
        public void ShouldNotifyCaloriesChange()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.PropertyChanged(aj, "Calories", () => aj.Size = Size.Medium);
            Assert.PropertyChanged(aj, "Calories", () => aj.Size = Size.Large);
            Assert.PropertyChanged(aj, "Calories", () => aj.Size = Size.Small);
        }

        [Fact]
        public void ShouldNotifyIceChange()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.PropertyChanged(aj, "Ice", () => aj.Ice = true);
            Assert.PropertyChanged(aj, "Ice", () => aj.Ice = false);
        }

        [Fact]
        public void ShouldNotifySpecialInstructionsChange()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.PropertyChanged(aj, "SpecialInstructions", () => aj.Ice = true);
            Assert.PropertyChanged(aj, "SpecialInstructions", () => aj.Ice = false);
        }

        [Fact]
        public void ShouldBeAssignableToINotifyPropertyChanged()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(aj);
        }
    }
}