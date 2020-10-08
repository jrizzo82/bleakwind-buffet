/*
 * Author: Zachery Brunner
 * Class: MadOtarGritsTests.cs
 * Purpose: Test the MadOtarGrits.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    /// <summary>
    /// Unit Tests for MadOtarGrits.cs
    /// </summary>
    public class MadOtarGritsTests
    {
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            MadOtarGrits mo = new MadOtarGrits();
            Assert.Equal(Size.Small, mo.Size);
        }
                
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MadOtarGrits mo = new MadOtarGrits();
            mo.Size = Size.Large;
            Assert.Equal(Size.Large, mo.Size);
            mo.Size = Size.Medium;
            Assert.Equal(Size.Medium, mo.Size);
            mo.Size = Size.Small;
            Assert.Equal(Size.Small, mo.Size);
        }

        [Fact]
        public void ShouldReturnCorrectStringOnSpecialInstructions()
        {
            MadOtarGrits mo = new MadOtarGrits();
            Assert.Empty(mo.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 1.22)]
        [InlineData(Size.Medium, 1.58)]
        [InlineData(Size.Large, 1.93)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            MadOtarGrits mo = new MadOtarGrits();
            mo.Size = size;
            Assert.Equal(price, mo.Price);
        }

        [Theory]
        [InlineData(Size.Small, 105)]
        [InlineData(Size.Medium, 142)]
        [InlineData(Size.Large, 179)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            MadOtarGrits mo = new MadOtarGrits();
            mo.Size = size;
            Assert.Equal(calories, mo.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Mad Otar Grits")]
        [InlineData(Size.Medium, "Medium Mad Otar Grits")]
        [InlineData(Size.Large, "Large Mad Otar Grits")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            MadOtarGrits mo = new MadOtarGrits();
            mo.Size = size;
            Assert.Equal(name, mo.ToString());
        }

        [Fact]
        public void ShouldBeAssignableToIOrderItem()
        {
            MadOtarGrits mo = new MadOtarGrits();
            Assert.IsAssignableFrom<IOrderItem>(mo);
        }

        [Fact]
        public void ShouldBeAssignableToBaseClass()
        {
            MadOtarGrits mo = new MadOtarGrits();
            Assert.IsAssignableFrom<Side>(mo);
        }

        [Fact]
        public void ShouldNotifySizeChange()
        {
            MadOtarGrits mo = new MadOtarGrits();
            Assert.PropertyChanged(mo, "Size", () => mo.Size = Size.Medium);
            Assert.PropertyChanged(mo, "Size", () => mo.Size = Size.Large);
            Assert.PropertyChanged(mo, "Size", () => mo.Size = Size.Small);
        }

        [Fact]
        public void ShouldNotifyPriceChange()
        {
            MadOtarGrits mo = new MadOtarGrits();
            Assert.PropertyChanged(mo, "Price", () => mo.Size = Size.Medium);
            Assert.PropertyChanged(mo, "Price", () => mo.Size = Size.Large);
            Assert.PropertyChanged(mo, "Price", () => mo.Size = Size.Small);
        }

        [Fact]
        public void ShouldNotifyCaloriesChange()
        {
            MadOtarGrits mo = new MadOtarGrits();
            Assert.PropertyChanged(mo, "Calories", () => mo.Size = Size.Medium);
            Assert.PropertyChanged(mo, "Calories", () => mo.Size = Size.Large);
            Assert.PropertyChanged(mo, "Calories", () => mo.Size = Size.Small);
        }

        [Fact]
        public void ShouldNotifyNameChange()
        {
            MadOtarGrits mo = new MadOtarGrits();
            Assert.PropertyChanged(mo, "Name", () => mo.Size = Size.Medium);
            Assert.PropertyChanged(mo, "Name", () => mo.Size = Size.Large);
        }

        [Fact]
        public void ShouldBeAssignableToINotifyPropertyChanged()
        {
            MadOtarGrits mo = new MadOtarGrits();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(mo);
        }
    }
}