﻿/*
 * Author: Zachery Brunner
 * Class: ThalmorTripleTests.cs
 * Purpose: Test the ThalmorTriple.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// Unit Tests for ThalmorTriple.cs
    /// </summary>
    public class ThalmorTripleTests
    {
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Mayo);
        }

        [Fact]
        public void ShouldIncludeBaconByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Bacon);
        }

        [Fact]
        public void ShouldIncludeEggByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Bun = false;
            Assert.False(tt.Bun);
            tt.Bun = true;
            Assert.True(tt.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Ketchup = false;
            Assert.False(tt.Ketchup);
            tt.Ketchup = true;
            Assert.True(tt.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Mustard = false;
            Assert.False(tt.Mustard);
            tt.Mustard = true;
            Assert.True(tt.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Pickle = false;
            Assert.False(tt.Pickle);
            tt.Pickle = true;
            Assert.True(tt.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Cheese = false;
            Assert.False(tt.Cheese);
            tt.Cheese = true;
            Assert.True(tt.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Tomato = false;
            Assert.False(tt.Tomato);
            tt.Tomato = true;
            Assert.True(tt.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Lettuce = false;
            Assert.False(tt.Lettuce);
            tt.Lettuce = true;
            Assert.True(tt.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Mayo = false;
            Assert.False(tt.Mayo);
            tt.Mayo = true;
            Assert.True(tt.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Bacon = false;
            Assert.False(tt.Bacon);
            tt.Bacon = true;
            Assert.True(tt.Bacon);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Egg = false;
            Assert.False(tt.Egg);
            tt.Egg = true;
            Assert.True(tt.Egg);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.Equal(8.32, tt.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.Equal<uint>(943, tt.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo,
                                                                    bool includeBacon, bool includeEgg)
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Bun = includeBun;
            tt.Ketchup = includeKetchup;
            tt.Mustard = includeMustard;
            tt.Pickle = includePickle;
            tt.Cheese = includeCheese;
            tt.Tomato = includeTomato;
            tt.Lettuce = includeLettuce;
            tt.Mayo = includeMayo;
            tt.Bacon = includeBacon;
            tt.Egg = includeEgg;
            if (!includeBun)
                Assert.Contains("Hold bun", tt.SpecialInstructions);
            if (!includeKetchup)
                Assert.Contains("Hold ketchup", tt.SpecialInstructions);
            if (!includeMustard)
                Assert.Contains("Hold mustard", tt.SpecialInstructions);
            if (!includePickle)
                Assert.Contains("Hold pickle", tt.SpecialInstructions);
            if (!includeCheese)
                Assert.Contains("Hold cheese", tt.SpecialInstructions);
            if (!includeTomato)
                Assert.Contains("Hold tomato", tt.SpecialInstructions);
            if (!includeLettuce)
                Assert.Contains("Hold lettuce", tt.SpecialInstructions);
            if (!includeMayo)
                Assert.Contains("Hold mayo", tt.SpecialInstructions);
            if (!includeBacon)
                Assert.Contains("Hold bacon", tt.SpecialInstructions);
            if (!includeEgg)
                Assert.Contains("Hold egg", tt.SpecialInstructions);
            if (includeBun && includeKetchup && includeMustard && includePickle && includeCheese && includeTomato
                && includeLettuce && includeMayo && includeBacon && includeEgg)
                Assert.Empty(tt.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.Equal("Thalmor Triple", tt.ToString());
        }

        [Fact]
        public void ShouldBeAssignableToIOrderItem()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.IsAssignableFrom<IOrderItem>(tt);
        }

        [Fact]
        public void ShouldBeAssignableToBaseClass()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.IsAssignableFrom<Entree>(tt);
        }

        [Fact]
        public void ShouldNotifyBunChange()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "Bun", () => tt.Bun = false);
            Assert.PropertyChanged(tt, "Bun", () => tt.Bun = true);
        }

        [Fact]
        public void ShouldNotifyKetchupChange()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "Ketchup", () => tt.Ketchup = false);
            Assert.PropertyChanged(tt, "Ketchup", () => tt.Ketchup = true);
        }

        [Fact]
        public void ShouldNotifyMustardChange()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "Mustard", () => tt.Mustard = false);
            Assert.PropertyChanged(tt, "Mustard", () => tt.Mustard = true);
        }

        [Fact]
        public void ShouldNotifyPickleChange()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "Pickle", () => tt.Pickle = false);
            Assert.PropertyChanged(tt, "Pickle", () => tt.Pickle = true);
        }

        [Fact]
        public void ShouldNotifyCheeseChange()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "Cheese", () => tt.Cheese = false);
            Assert.PropertyChanged(tt, "Cheese", () => tt.Cheese = true);
        }

        [Fact]
        public void ShouldNotifyTomatoChange()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "Tomato", () => tt.Tomato = false);
            Assert.PropertyChanged(tt, "Tomato", () => tt.Tomato = true);
        }

        [Fact]
        public void ShouldNotifyLettuceChange()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "Lettuce", () => tt.Lettuce = false);
            Assert.PropertyChanged(tt, "Lettuce", () => tt.Lettuce = true);
        }

        [Fact]
        public void ShouldNotifyMayoChange()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "Mayo", () => tt.Mayo = false);
            Assert.PropertyChanged(tt, "Mayo", () => tt.Mayo = true);
        }

        [Fact]
        public void ShouldNotifyBaconChange()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "Bacon", () => tt.Bacon = false);
            Assert.PropertyChanged(tt, "Bacon", () => tt.Bacon = true);
        }

        [Fact]
        public void ShouldNotifyEggChange()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "Egg", () => tt.Egg = false);
            Assert.PropertyChanged(tt, "Egg", () => tt.Egg = true);
        }

        [Fact]
        public void ShouldNotifySpecialInstructionsChange()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "SpecialInstructions", () => tt.Bun = false);
            Assert.PropertyChanged(tt, "SpecialInstructions", () => tt.Bun = true);
            Assert.PropertyChanged(tt, "SpecialInstructions", () => tt.Ketchup = false);
            Assert.PropertyChanged(tt, "SpecialInstructions", () => tt.Ketchup = true);
            Assert.PropertyChanged(tt, "SpecialInstructions", () => tt.Mustard = false);
            Assert.PropertyChanged(tt, "SpecialInstructions", () => tt.Mustard = true);
            Assert.PropertyChanged(tt, "SpecialInstructions", () => tt.Pickle = false);
            Assert.PropertyChanged(tt, "SpecialInstructions", () => tt.Pickle = true);
            Assert.PropertyChanged(tt, "SpecialInstructions", () => tt.Cheese = false);
            Assert.PropertyChanged(tt, "SpecialInstructions", () => tt.Cheese = true);
            Assert.PropertyChanged(tt, "SpecialInstructions", () => tt.Tomato = false);
            Assert.PropertyChanged(tt, "SpecialInstructions", () => tt.Tomato = true);
            Assert.PropertyChanged(tt, "SpecialInstructions", () => tt.Lettuce = false);
            Assert.PropertyChanged(tt, "SpecialInstructions", () => tt.Lettuce = true);
            Assert.PropertyChanged(tt, "SpecialInstructions", () => tt.Mayo = false);
            Assert.PropertyChanged(tt, "SpecialInstructions", () => tt.Mayo = true);
            Assert.PropertyChanged(tt, "SpecialInstructions", () => tt.Bacon = false);
            Assert.PropertyChanged(tt, "SpecialInstructions", () => tt.Bacon = true);
            Assert.PropertyChanged(tt, "SpecialInstructions", () => tt.Egg = false);
            Assert.PropertyChanged(tt, "SpecialInstructions", () => tt.Egg = true);
        }

        [Fact]
        public void ShouldBeAssignableToINotifyPropertyChanged()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(tt);
        }

        [Fact]
        public void ShouldReturnCorrectDescription()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.Equal("Think you are strong enough to take on " +
                "the Thalmor? Inlcudes two 1/4lb patties with a 1/2lb" +
                " patty inbetween with ketchup, mustard, pickle, cheese, tomato, " +
                "lettuce, mayo, bacon, and an egg.", tt.Description);
        }
    }
}