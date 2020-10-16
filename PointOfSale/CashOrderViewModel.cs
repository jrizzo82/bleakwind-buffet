using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using RoundRegister;
using System.Globalization;
using BleakwindBuffet.Data;
using System.Windows;

namespace PointOfSale
{
    class CashOrderViewModel : INotifyPropertyChanged
    {
        private int paidHundreds = 0;
        private int paidFifties = 0;
        private int paidTwenties = 0;
        private int paidTens = 0;
        private int paidFives = 0;
        private int paidOnes = 0;
        private int paidTwos = 0;
        private int paidDollars = 0;
        private int paidHalfDollars = 0;
        private int paidQuarters = 0;
        private int paidDimes = 0;
        private int paidNickels = 0;
        private int paidPennies = 0;
        private int changeHundreds = 0;
        private int changeFifties = 0;
        private int changeTwenties = 0;
        private int changeTens = 0;
        private int changeFives = 0;
        private int changeTwos = 0;
        private int changeOnes = 0;
        private int changeDollars = 0;
        private int changeHalfDollars = 0;
        private int changeQuarters = 0;
        private int changeDimes = 0;
        private int changeNickels = 0;
        private int changePennies = 0;
        private double amountDue = 0.0;
        private double change = 0.0;
        private double given = 0.0;

        public event PropertyChangedEventHandler PropertyChanged;

        public double OrderTotal { get; set; }

        public double AmountDue
        {
            get { return amountDue; }
            set
            {
                amountDue = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDueString"));
            }
        }

        public string AmountDueString
        {
            get => AmountDue.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
        }

        public double Change
        {
            get { return change; }
            set
            {
                change = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Change"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeString"));
            }
        }

        public string ChangeString
        {
            get => Change.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
        }

        public double Given
        {
            get { return given; }
            set
            {
                given= value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Given"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GivenString"));
            }
        }

        public string GivenString
        {
            get => Given.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
        }

        public int Hundreds
        {
            get
            {
                return CashDrawer.Hundreds;
            }
            set
            {
                CashDrawer.Hundreds = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Hundreds"));
            }
        }

        public int Fifties
        {
            get => CashDrawer.Fifties;
            set
            {
                CashDrawer.Fifties = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Fifties"));
            }
        }

        public int Twenties
        {
            get => CashDrawer.Twenties;
            set
            {
                CashDrawer.Twenties = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Twenties"));
            }
        }

        public int Tens
        {
            get => CashDrawer.Tens;
            set
            {
                CashDrawer.Tens = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tens"));
            }
        }

        public int Fives
        {
            get => CashDrawer.Fives;
            set
            {
                CashDrawer.Fives = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Fives"));
            }
        }

        public int Twos
        {
            get => CashDrawer.Ones;
            set
            {
                CashDrawer.Ones = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ones"));
            }
        }

        public int Ones
        {
            get => CashDrawer.Ones;
            set
            {
                CashDrawer.Ones = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ones"));
            }
        }

        public int Dollars
        {
            get => CashDrawer.Dollars;
            set
            {
                CashDrawer.Dollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Dollars"));
            }
        }

        public int HalfDollars
        {
            get => CashDrawer.HalfDollars;
            set
            {
                CashDrawer.HalfDollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HalfDollars"));
            }
        }

        public int Quarters
        {
            get => CashDrawer.Quarters;
            set
            {
                CashDrawer.Quarters = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Quarters"));
            }
        }

        public int Dimes
        {
            get => CashDrawer.Dimes;
            set
            {
                CashDrawer.Dimes = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Dimes"));
            }
        }

        public int Nickels
        {
            get => CashDrawer.Nickels;
            set
            {
                CashDrawer.Nickels = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Nickels"));
            }
        }

        public int Pennies
        {
            get => CashDrawer.Pennies;
            set
            {
                CashDrawer.Pennies = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pennies"));
            }
        }

        public int PaidHundreds
        {
            get
            {
                return paidHundreds;
            }
            set
            {
                paidHundreds = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PaidHundreds"));
            }
        }

        public int PaidFifties
        {
            get => paidFifties;
            set
            {
                paidFifties = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PaidFifties"));
            }
        }

        public int PaidTwenties
        {
            get => paidTwenties;
            set
            {
                paidTwenties = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PaidTwenties"));
            }
        }

        public int PaidTens
        {
            get => paidTens;
            set
            {
                paidTens = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PaidTens"));
            }
        }

        public int PaidFives
        {
            get => paidFives;
            set
            {
                paidFives = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PaidFives"));
            }
        }

        public int PaidTwos
        {
            get => paidTwos;
            set
            {
                paidTwos = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PaidTwos"));
            }
        }

        public int PaidOnes
        {
            get => paidOnes;
            set
            {
                paidOnes = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PaidOnes"));
            }
        }

        public int PaidDollars
        {
            get => paidDollars;
            set
            {
                paidDollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PaidDollars"));
            }
        }

        public int PaidHalfDollars
        {
            get => paidHalfDollars;
            set
            {
                paidHalfDollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PaidHalfDollars"));
            }
        }

        public int PaidQuarters
        {
            get => paidQuarters;
            set
            {
                paidQuarters = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PaidQuarters"));
            }
        }

        public int PaidDimes
        {
            get => paidDimes;
            set
            {
                paidDimes = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PaidDimes"));
            }
        }

        public int PaidNickels
        {
            get => paidNickels;
            set
            {
                paidNickels = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PaidNickels"));
            }
        }

        public int PaidPennies
        {
            get => paidPennies;
            set
            {
                paidPennies = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PaidPennies"));
            }
        }

        public int ChangeHundreds
        {
            get
            {
                return changeHundreds;
            }
            set
            {
                changeHundreds = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeHundreds"));
            }
        }

        public int ChangeFifties
        {
            get => changeFifties;
            set
            {
                changeFifties = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeFifties"));
            }
        }

        public int ChangeTwenties
        {
            get => changeTwenties;
            set
            {
                changeTwenties = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTwenties"));
            }
        }

        public int ChangeTens
        {
            get => changeTens;
            set
            {
                changeTens = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTens"));
            }
        }

        public int ChangeFives
        {
            get => changeFives;
            set
            {
                changeFives = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeFives"));
            }
        }

        public int ChangeTwos
        {
            get => changeTwos;
            set
            {
                changeTwos = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTwos"));
            }
        }

        public int ChangeOnes
        {
            get => changeOnes;
            set
            {
                changeOnes = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOnes"));
            }
        }

        public int ChangeDollars
        {
            get => changeDollars;
            set
            {
                changeDollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDollars"));
            }
        }

        public int ChangeHalfDollars
        {
            get => changeHalfDollars;
            set
            {
                changeHalfDollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeHalfDollars"));
            }
        }

        public int ChangeQuarters
        {
            get => changeQuarters;
            set
            {
                changeQuarters = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeQuarters"));
            }
        }

        public int ChangeDimes
        {
            get => changeDimes;
            set
            {
                changeDimes = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDimes"));
            }
        }

        public int ChangeNickels
        {
            get => changeNickels;
            set
            {
                changeNickels = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeNickels"));
            }
        }

        public int ChangePennies
        {
            get => changePennies;
            set
            {
                changePennies = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangePennies"));
            }
        }

        public void SetAmountDue()
        {
            AmountDue = OrderTotal;
        }


        public void CalculateChange()
        {
            AmountDue = OrderTotal;
            Given = PaidHundreds*100.0 + PaidFifties*50.0 + PaidTwenties*20.0 + PaidTens*10.0 + PaidFives*5.0 + PaidTwos*2.0 + PaidOnes*1.0 +
                                PaidDollars *1.0 + PaidHalfDollars*0.5 + PaidQuarters*0.25 + PaidDimes*0.1 + PaidNickels*0.05 + PaidPennies*0.01;

            double diff = OrderTotal - Given;

            if (diff > 0.0)
            {
                AmountDue -= Given;
                Change = 0.0;
            }
            else if (diff == 0.0)
            {
                AmountDue = 0.0;
                Change = 0.0;
            }
            else
            {
                AmountDue = 0.0;
                Change = -diff;
            }

            Change = Math.Round(Change, 2);

            double billAmounts = Change;
             
            if (Change > 0.0)
            {
                ChangeHundreds = (int)Math.Floor(billAmounts / 100.0);
                billAmounts -= ChangeHundreds * 100.0;
                ChangeFifties = (int)Math.Floor(billAmounts / 50.0);
                billAmounts -= ChangeFifties * 50.0;
                ChangeTwenties = (int)Math.Floor(billAmounts / 20.0);
                billAmounts -= ChangeTwenties * 20.0;
                ChangeTens = (int)Math.Floor(billAmounts / 10.0);
                billAmounts -= ChangeTens * 10.0;
                ChangeFives = (int)Math.Floor(billAmounts / 5.0);
                billAmounts -= ChangeFives * 5.0;
                ChangeTwos = (int)Math.Floor(billAmounts / 2.0);
                billAmounts -= ChangeTwos * 2.0;
                ChangeOnes = (int)Math.Floor(billAmounts / 1.0);
                billAmounts -= ChangeOnes * 1.0;
                ChangeHalfDollars = (int)Math.Floor(billAmounts / 0.5);
                billAmounts -= ChangeHalfDollars * 0.5;
                ChangeQuarters = (int)Math.Floor(Math.Round(billAmounts, 2) / 0.25);
                billAmounts -= ChangeQuarters * 0.25;
                ChangeDimes = (int)Math.Floor(Math.Round(billAmounts, 2) / 0.1);
                billAmounts -= ChangeDimes * 0.1;
                ChangeNickels = (int)Math.Floor(Math.Round(billAmounts, 2) / 0.05);
                billAmounts -= ChangeNickels * 0.05;
                ChangePennies = (int)Math.Floor(Math.Round(billAmounts, 2) / 0.01);
            }
        }

        /// <summary>
        /// Completes the cash order
        /// </summary>
        /// <param name="order">The order to be completed</param>
        /// <returns>true if sufficient funds, false otherwise</returns>
        public bool Finalize(Order order)
        {
            if (Change >= 0.0 && AmountDue <= 0.0)
            {
                Hundreds += PaidHundreds;
                Hundreds -= ChangeHundreds;
                Fifties += PaidFifties;
                Fifties -= ChangeFifties;
                Twenties += PaidTwenties;
                Twenties -= ChangeTwenties;
                Tens += PaidTens;
                Tens -= ChangeTens;
                Fives += PaidFives;
                Fives -= ChangeFives;
                Twos += PaidTwos;
                Twos -= ChangeTwos;
                Ones += PaidOnes;
                Ones -= ChangeOnes;
                Dollars += PaidDollars;
                HalfDollars += PaidHalfDollars;
                HalfDollars -= ChangeHalfDollars;
                Quarters += PaidQuarters;
                Quarters -= ChangeQuarters;
                Dimes += PaidDimes;
                Dimes -= ChangeDimes;
                Nickels += PaidNickels;
                Nickels -= ChangeNickels;
                Pennies += PaidPennies;
                Pennies -= PaidPennies;
                
                RecieptPrinter.PrintLine("Order #" + order.Number.ToString());
                RecieptPrinter.PrintLine(DateTime.Now.ToString() + "\n");
                foreach (IOrderItem io in order)
                {
                    RecieptPrinter.PrintLine(io.ToString() + "\t" + io.Price.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
                    foreach (string str in io.SpecialInstructions)
                        RecieptPrinter.PrintLine(str);
                }
                RecieptPrinter.PrintLine("\nSubtotal: " + order.Subtotal.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
                RecieptPrinter.PrintLine("Tax: " + order.Tax.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
                RecieptPrinter.PrintLine("Total: " + order.Total.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
                RecieptPrinter.PrintLine("Payment Method: Cash");
                RecieptPrinter.PrintLine("Cash Paid: " + GivenString);
                RecieptPrinter.PrintLine("Change: " + ChangeString);
                RecieptPrinter.CutTape();
                MessageBox.Show("Transaction Complete!");
                return true;
            }
            else
            {
                MessageBox.Show("Insufficient Funds to cover cost of the order.");
                return false;
            }
        }
    }
}
