/*
 * Author: Zachery Brunner
 * Class: SmokehouseSkeletonTests.cs
 * Purpose: Test the SmokehouseSkeleton.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// Unit Tests for SmokehouseSkeleton.cs
    /// </summary>
    public class SmokehouseSkeletonTests
    {        
        [Fact]
        public void ShouldInlcudeSausageByDefault()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.True(ss.SausageLink);
        }

        [Fact]
        public void ShouldInlcudeEggByDefault()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.True(ss.Egg);
        }

        [Fact]
        public void ShouldInlcudeHashbrownsByDefault()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.True(ss.HashBrowns);
        }

        [Fact]
        public void ShouldInlcudePancakeByDefault()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.True(ss.Pancake);
        }

        [Fact]
        public void ShouldBeAbleToSetSausage()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.SausageLink = false;
            Assert.False(ss.SausageLink);
            ss.SausageLink = true;
            Assert.True(ss.SausageLink);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.Egg = false;
            Assert.False(ss.Egg);
            ss.Egg = true;
            Assert.True(ss.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetHashbrowns()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.HashBrowns = false;
            Assert.False(ss.HashBrowns);
            ss.HashBrowns = true;
            Assert.True(ss.HashBrowns);
        }

        [Fact]
        public void ShouldBeAbleToSetPancake()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.Pancake = false;
            Assert.False(ss.Pancake);
            ss.Pancake = true;
            Assert.True(ss.Pancake);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.Equal(5.62, ss.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.Equal<uint>(602, ss.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSausage, bool includeEgg,
                                                            bool includeHashbrowns, bool includePancake)
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.SausageLink = includeSausage;
            ss.Egg = includeEgg;
            ss.HashBrowns = includeHashbrowns;
            ss.Pancake = includePancake;
            if (!includeSausage)
                Assert.Contains("Hold sausage", ss.SpecialInstructions);
            if (!includeEgg)
                Assert.Contains("Hold eggs", ss.SpecialInstructions);
            if (!includeHashbrowns)
                Assert.Contains("Hold hash browns", ss.SpecialInstructions);
            if (!includePancake)
                Assert.Contains("Hold pancakes", ss.SpecialInstructions);
            if (includeSausage && includePancake && includeHashbrowns && includeEgg)
                Assert.Empty(ss.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.Equal("Smokehouse Skeleton", ss.ToString());
        }

        [Fact]
        public void ShouldBeAssignableToIOrderItem()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<IOrderItem>(ss);
        }

        [Fact]
        public void ShouldBeAssignableToBaseClass()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<Entree>(ss);
        }

        [Fact]
        public void ShouldNotifySausageLinkChange()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.PropertyChanged(ss, "SausageLink", () => ss.SausageLink = false);
            Assert.PropertyChanged(ss, "SausageLink", () => ss.SausageLink = true);
        }

        [Fact]
        public void ShouldNotifyEggChange()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.PropertyChanged(ss, "Egg", () => ss.Egg = false);
            Assert.PropertyChanged(ss, "Egg", () => ss.Egg = true);
        }

        [Fact]
        public void ShouldNotifyHashBrownsChange()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.PropertyChanged(ss, "HashBrowns", () => ss.HashBrowns = false);
            Assert.PropertyChanged(ss, "HashBrowns", () => ss.HashBrowns = true);
        }

        [Fact]
        public void ShouldNotifyPancakeChange()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.PropertyChanged(ss, "Pancake", () => ss.Pancake = false);
            Assert.PropertyChanged(ss, "Pancake", () => ss.Pancake = true);
        }

        [Fact]
        public void ShouldNotifySpecialInstructionsChange()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.PropertyChanged(ss, "SpecialInstructions", () => ss.SausageLink = false);
            Assert.PropertyChanged(ss, "SpecialInstructions", () => ss.SausageLink = true);
            Assert.PropertyChanged(ss, "SpecialInstructions", () => ss.Egg = false);
            Assert.PropertyChanged(ss, "SpecialInstructions", () => ss.Egg = true);
            Assert.PropertyChanged(ss, "SpecialInstructions", () => ss.HashBrowns = false);
            Assert.PropertyChanged(ss, "SpecialInstructions", () => ss.HashBrowns = true);
            Assert.PropertyChanged(ss, "SpecialInstructions", () => ss.Pancake = false);
            Assert.PropertyChanged(ss, "SpecialInstructions", () => ss.Pancake = true);
        }

        [Fact]
        public void ShouldBeAssignableToINotifyPropertyChanged()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(ss);
        }

        [Fact]
        public void ShouldReturnCorrectDescription()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.Equal("Put some meat on those bones with a " +
                "small stack of pancakes. Includes sausage links, " +
                "eggs, and hash browns on the side. Topped with the " +
                "syrup of your choice.", ss.Description);
        }
    }
}