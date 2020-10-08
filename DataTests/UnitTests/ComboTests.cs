/*
 * Author: Jerry Rizzo
 * Class: ComboTests.cs
 * Purpose: Test the Combo.cs class in the Data library
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


namespace BleakwindBuffet.DataTests.UnitTests
{
    /// <summary>
    /// Unit tests for Combo.cs
    /// </summary>
    public class ComboTests
    {
        
        [Fact]
        public void ShouldBeAbleToSetDrinks()
        {
            Combo combo = new Combo();
            CandlehearthCoffee cc = new CandlehearthCoffee();
            combo.Drink = cc;
            Assert.Equal(cc.ToString(), combo.Drink.ToString());
            MarkarthMilk mm = new MarkarthMilk();
            combo.Drink = mm;
            Assert.Equal(mm.ToString(), combo.Drink.ToString());
        }

        [Fact]
        public void ShouldBeAbleToSetSide()
        {
            Combo combo = new Combo();
            combo.Side = new VokunSalad();
            Assert.Equal(new VokunSalad().ToString(), combo.Side.ToString());
            combo.Side = new DragonbornWaffleFries();
            Assert.Equal(new DragonbornWaffleFries().ToString(), combo.Side.ToString());
            combo.Side = new FriedMiraak();
            Assert.Equal(new FriedMiraak().ToString(), combo.Side.ToString());
        }

        [Fact]
        public void ShouldBeAbleToSetEntree()
        {
            Combo combo = new Combo();
            combo.Entree = new BriarheartBurger();
            Assert.Equal(new BriarheartBurger().ToString(), combo.Entree.ToString());
            combo.Entree = new ThugsTBone();
            Assert.Equal(new ThugsTBone().ToString(), combo.Entree.ToString());
            combo.Entree = new ThalmorTriple();
            Assert.Equal(new ThalmorTriple().ToString(), combo.Entree.ToString());
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            Combo combo = new Combo();
            BriarheartBurger bb = new BriarheartBurger();
            VokunSalad vs = new VokunSalad();
            WarriorWater ww = new WarriorWater();
            combo.Entree = bb;
            combo.Side = vs;
            combo.Drink = ww;
            Assert.Equal(bb.Price + vs.Price + ww.Price - 1.0, combo.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            Combo combo = new Combo();
            BriarheartBurger bb = new BriarheartBurger();
            VokunSalad vs = new VokunSalad();
            WarriorWater ww = new WarriorWater();
            combo.Entree = bb;
            combo.Side = vs;
            combo.Drink = ww;
            Assert.Equal(bb.Calories + vs.Calories + ww.Calories, combo.Calories);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            Combo combo = new Combo();
            BriarheartBurger bb = new BriarheartBurger();
            bb.Ketchup = false;
            VokunSalad vs = new VokunSalad();
            vs.Size = Data.Enums.Size.Large;
            WarriorWater ww = new WarriorWater();
            ww.Ice = false;
            combo.Entree = bb;
            combo.Side = vs;
            combo.Drink = ww;
            Assert.Collection(combo.SpecialInstructions,
                item => Assert.Equal("Briarheart Burger", item),
                item => Assert.Equal("Hold ketchup", item),
                item => Assert.Equal("Large Vokun Salad", item),
                item => Assert.Equal("Small Warrior Water", item),
                item => Assert.Equal("Hold ice", item));
        }

        [Fact]
        public void ShouldNotifyEntreeChanged()
        {
            Combo combo = new Combo();
            Assert.PropertyChanged(combo, "Entree", () => combo.Entree = new PhillyPoacher());
            Assert.PropertyChanged(combo, "Entree", () => combo.Entree = new DoubleDraugr());
            Assert.PropertyChanged(combo, "Entree", () => combo.Entree = new GardenOrcOmelette());
        }

        [Fact]
        public void ShouldNotifySideChanged()
        {
            Combo combo = new Combo();
            Assert.PropertyChanged(combo, "Side", () => combo.Side = new FriedMiraak());
            Assert.PropertyChanged(combo, "Side", () => combo.Side = new VokunSalad());
            Assert.PropertyChanged(combo, "Side", () => combo.Side = new MadOtarGrits());
        }

        [Fact]
        public void ShouldNotifyDrinkChanged()
        {
            Combo combo = new Combo();
            Assert.PropertyChanged(combo, "Drink", () => combo.Drink = new SailorSoda());
            Assert.PropertyChanged(combo, "Drink", () => combo.Drink = new MarkarthMilk());
            Assert.PropertyChanged(combo, "Drink", () => combo.Drink = new WarriorWater());
        }

        [Fact]
        public void ShouldNotifyPriceChangedOnAssigningProperties()
        {
            Combo combo = new Combo();
            WarriorWater ww = new WarriorWater();
            Assert.PropertyChanged(combo, "Price", () => combo.Drink = ww);
            Assert.PropertyChanged(combo, "Price", () => combo.Side = new VokunSalad());
        }

        [Fact]
        public void ShouldNotifyPriceChangedOnChangeSize()
        {
            Combo combo = new Combo();
            Assert.PropertyChanged(combo, "Price", () => combo.Drink.Size = Data.Enums.Size.Medium);
            Assert.PropertyChanged(combo, "Price", () => combo.Drink.Size = Data.Enums.Size.Large);
            Assert.PropertyChanged(combo, "Price", () => combo.Side.Size = Data.Enums.Size.Medium);
            Assert.PropertyChanged(combo, "Price", () => combo.Side.Size = Data.Enums.Size.Large);
        }

        [Fact]
        public void ShouldNotifyCaloriesChangedOnAssigningProperties()
        {
            Combo combo = new Combo();
            Assert.PropertyChanged(combo, "Calories", () => combo.Drink = new WarriorWater());
            Assert.PropertyChanged(combo, "Calories", () => combo.Side = new MadOtarGrits());
            Assert.PropertyChanged(combo, "Calories", () => combo.Entree = new PhillyPoacher());
        }

        [Fact]
        public void ShouldNotifyCaloriesChangedOnChangingSize()
        {
            Combo combo = new Combo();
            Assert.PropertyChanged(combo, "Calories", () => combo.Drink.Size = Data.Enums.Size.Medium);
            Assert.PropertyChanged(combo, "Calories", () => combo.Drink.Size = Data.Enums.Size.Large);
            Assert.PropertyChanged(combo, "Calories", () => combo.Side.Size = Data.Enums.Size.Medium);
            Assert.PropertyChanged(combo, "Calories", () => combo.Side.Size = Data.Enums.Size.Large);
        }

        [Fact]
        public void ShouldBeAssignableToIOrderItem()
        {
            Combo combo = new Combo();
            Assert.IsAssignableFrom<IOrderItem>(combo);
        }
    }
}
