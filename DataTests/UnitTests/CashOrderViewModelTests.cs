/*
 * Author: Jerry Rizzo
 * Class: CashOrderViewModelTests.cs
 * Purpose: Tests the CashOrderViewModel.cs class in the PointOfSale library
 */
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using Xunit.Abstractions;
using PointOfSale;
using RoundRegister;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class CashOrderViewModelTests
    {
        [Theory]
        [InlineData(5)]
        [InlineData(44)]
        [InlineData(112)]
        public void ShouldSetAmountOfHundreds(int amount)
        {
            CashDrawer.ResetDrawer();
            CashOrderViewModel cvm = new CashOrderViewModel();
            cvm.Hundreds = amount;
            Assert.Equal(amount, CashDrawer.Hundreds);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(44)]
        [InlineData(112)]
        public void ShouldSetAmountOfFifties(int amount)
        {
            CashDrawer.ResetDrawer();
            CashOrderViewModel cvm = new CashOrderViewModel();
            cvm.Fifties = amount;
            Assert.Equal(amount, CashDrawer.Fifties);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(44)]
        [InlineData(112)]
        public void ShouldSetAmountOfTwenties(int amount)
        {
            CashDrawer.ResetDrawer();
            CashOrderViewModel cvm = new CashOrderViewModel();
            cvm.Twenties = amount;
            Assert.Equal(amount, CashDrawer.Twenties);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(44)]
        [InlineData(112)]
        public void ShouldSetAmountOfTens(int amount)
        {
            CashDrawer.ResetDrawer();
            CashOrderViewModel cvm = new CashOrderViewModel();
            cvm.Tens = amount;
            Assert.Equal(amount, CashDrawer.Tens);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(44)]
        [InlineData(112)]
        public void ShouldSetAmountOfFives(int amount)
        {
            CashDrawer.ResetDrawer();
            CashOrderViewModel cvm = new CashOrderViewModel();
            cvm.Fives = amount;
            Assert.Equal(amount, CashDrawer.Fives);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(44)]
        [InlineData(112)]
        public void ShouldSetAmountOfTwos(int amount)
        {
            CashDrawer.ResetDrawer();
            CashOrderViewModel cvm = new CashOrderViewModel();
            cvm.Twos = amount;
            Assert.Equal(amount, CashDrawer.Twos);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(44)]
        [InlineData(112)]
        public void ShouldSetAmountOfOnes(int amount)
        {
            CashDrawer.ResetDrawer();
            CashOrderViewModel cvm = new CashOrderViewModel();
            cvm.Ones = amount;
            Assert.Equal(amount, CashDrawer.Ones);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(44)]
        [InlineData(112)]
        public void ShouldSetAmountOfDollars(int amount)
        {
            CashDrawer.ResetDrawer();
            CashOrderViewModel cvm = new CashOrderViewModel();
            cvm.Dollars = amount;
            Assert.Equal(amount, CashDrawer.Dollars);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(44)]
        [InlineData(112)]
        public void ShouldSetAmountOfHalfDollars(int amount)
        {
            CashDrawer.ResetDrawer();
            CashOrderViewModel cvm = new CashOrderViewModel();
            cvm.HalfDollars = amount;
            Assert.Equal(amount, CashDrawer.HalfDollars);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(44)]
        [InlineData(112)]
        public void ShouldSetAmountOfQuarters(int amount)
        {
            CashDrawer.ResetDrawer();
            CashOrderViewModel cvm = new CashOrderViewModel();
            cvm.Quarters = amount;
            Assert.Equal(amount, CashDrawer.Quarters);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(44)]
        [InlineData(112)]
        public void ShouldSetAmountOfDimes(int amount)
        {
            CashDrawer.ResetDrawer();
            CashOrderViewModel cvm = new CashOrderViewModel();
            cvm.Dimes = amount;
            Assert.Equal(amount, CashDrawer.Dimes);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(44)]
        [InlineData(112)]
        public void ShouldSetAmountOfNickels(int amount)
        {
            CashDrawer.ResetDrawer();
            CashOrderViewModel cvm = new CashOrderViewModel();
            cvm.Nickels = amount;
            Assert.Equal(amount, CashDrawer.Nickels);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(44)]
        [InlineData(112)]
        public void ShouldSetAmountOfPennies(int amount)
        {
            CashDrawer.ResetDrawer();
            CashOrderViewModel cvm = new CashOrderViewModel();
            cvm.Pennies = amount;
            Assert.Equal(amount, CashDrawer.Pennies);
        }

        [Fact]
        public void ShouldBeAssignableToINotifyPropertyChanged()
        {
            CashOrderViewModel cvm = new CashOrderViewModel();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(cvm);
        }

        [Theory]
        [InlineData(5.0, 0.0, 0, 1, 0, 0, 0, 0, 0)]
        [InlineData(5.99, 4.01, 1, 0, 0, 2, 0, 0, 1)]
        [InlineData(112.43, 1.57, 10, 2, 4, 0, 1, 1, 2)]
        [InlineData(48.11, 7.89, 4, 2, 6, 1, 0, 1, 4)]
        public void ShouldMakeCorrectChange(double ot, double change, int paidTens, int paidFives, int paidOnes,
                                            int changeTwos, int changeOnes, int changeHalfDollars, int changePennies)
        {
            CashDrawer.ResetDrawer();
            CashOrderViewModel cvm = new CashOrderViewModel();
            cvm.OrderTotal = ot;
            cvm.PaidTens = paidTens;
            cvm.PaidFives = paidFives;
            cvm.PaidOnes = paidOnes;
            cvm.PaidFives = paidFives;
            cvm.CalculateChange();
            Assert.Equal(change, cvm.Change);
            Assert.Equal(changeTwos, cvm.ChangeTwos);
            Assert.Equal(changeHalfDollars, cvm.ChangeHalfDollars);
            Assert.Equal(changeOnes, cvm.ChangeOnes);
            Assert.Equal(changePennies, cvm.ChangePennies);
        }

        [Theory]
        [InlineData(5, 4, 3, 4, 2, 1)]
        [InlineData(44, 12, 1, 6, 7, 5)]
        [InlineData(112, 23, 54, 16, 0, 7)]
        public void ShouldFinalizeOrder(int paidFives, int paidOnes, int paidQuarters,
                                        int changeFives, int changeOnes, int changeQuarters)
        {
            CashDrawer.ResetDrawer();
            CashDrawer.OpenDrawer();
            CashOrderViewModel cvm = new CashOrderViewModel();
            cvm.PaidFives = paidFives;
            cvm.PaidOnes = paidOnes;
            cvm.PaidQuarters = paidQuarters;
            cvm.ChangeFives = changeFives;
            cvm.ChangeOnes = changeOnes;
            cvm.ChangeQuarters = changeQuarters;
            int prevFiveValue = CashDrawer.Fives;
            int prevOnesValue = CashDrawer.Ones;
            int prevQuartersValue = CashDrawer.Quarters;
            cvm.Finalize(new Order(1));
            Assert.Equal(prevFiveValue + paidFives - changeFives, CashDrawer.Fives);
            Assert.Equal(prevOnesValue + paidOnes - changeOnes, CashDrawer.Ones);
            Assert.Equal(prevQuartersValue + paidQuarters - changeQuarters, CashDrawer.Quarters);
        }
    }
}
