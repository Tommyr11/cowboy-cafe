using System;
using System.Collections.Generic;
using System.Text;
using CashRegister;
using System.ComponentModel;

namespace PointOfSale
{
    public class CashRegisterMV
    {
        /// <summary>
        /// Event handler for property changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// cashdrawer variable/instance
        /// </summary>
        CashDrawer drawer = new CashDrawer();

        /// <summary>
        /// private backing
        /// </summary>
        private double totalValue = 0;

        /// <summary>
        /// Keeps track of total amount of money in cash register
        /// </summary>
        public double TotalValue => totalValue;

        /// <summary>
        /// property that declares if the user has provided sufficient funds
        /// </summary>
        public bool SufficientFunds
        {
            get
            {
                return TotalValue > TotalOwed;
            }
        }
        /// <summary>
        /// Property for total money owed
        /// </summary>
        public double TotalOwed { get; set; }

        /// <summary>
        /// count for pennies
        /// </summary>
        private int countPennies = 0;
        /// <summary>
        /// Gets or sets the number of pennies in the cash register
        /// </summary>
        public int Pennies
        {
            get => drawer.Pennies;

            set
            {
                if (drawer.Pennies == value || value < 0) return;
                var quantity = value - drawer.Pennies;
                if (quantity > 0)
                {
                    totalValue += .01;
                    countPennies++;
                    drawer.AddCoin(Coins.Penny, quantity);
                }
                else
                {
                    totalValue -= .01;
                    countPennies++;
                    drawer.RemoveCoin(Coins.Penny, -quantity);
                }
                InvokePropertyChanged("Pennies");
            }
        }
        /// <summary>
        /// count for nickels
        /// </summary>
        private int countNickels = 0;

        /// <summary>
        /// Gets or sets the number of pennies in the cash register
        /// </summary>
        public int Nickels
        {
            get => drawer.Nickels;

            set
            {
                if (drawer.Nickels == value || value < 0) return;
                var quantity = value - drawer.Nickels;
                if (quantity > 0)
                {
                    totalValue += .05;
                    countNickels++;
                    drawer.AddCoin(Coins.Nickel, quantity);
                }
                else
                {
                    totalValue -= .05;
                    countNickels++;
                    drawer.RemoveCoin(Coins.Nickel, -quantity);
                }
                InvokePropertyChanged("Nickels");
            }
        }

        /// <summary>
        /// count for dimes
        /// </summary>
        private int countDimes = 0;

        /// <summary>
        /// Gets or sets the number of pennies in the cash register
        /// </summary>
        public int Dimes
        {
            get => drawer.Dimes;

            set
            {
                if (drawer.Dimes == value || value < 0) return;
                var quantity = value - drawer.Dimes;
                if (quantity > 0)
                {
                    totalValue += .10;
                    countDimes++;
                    drawer.AddCoin(Coins.Dime, quantity);
                }
                else
                {
                    totalValue -= .10;
                    countDimes++;
                    drawer.RemoveCoin(Coins.Dime, -quantity);
                }
                InvokePropertyChanged("Dimes");
            }
        }

        /// <summary>
        /// count for quarters
        /// </summary>
        private int countQuarters = 0;
        /// <summary>
        /// Gets or sets the number of pennies in the cash register
        /// </summary>
        public int Quarters
        {
            get => drawer.Quarters;

            set
            {
                if (drawer.Quarters == value || value < 0) return;
                var quantity = value - drawer.Quarters;
                if (quantity > 0)
                {
                    totalValue += .25;
                    countQuarters++;
                    drawer.AddCoin(Coins.Quarter, quantity);
                }
                else
                {
                    totalValue -= .25;
                    countQuarters++;
                    drawer.RemoveCoin(Coins.Quarter, -quantity);
                }
                InvokePropertyChanged("Pennies");
            }
        }

        /// <summary>
        /// count for half dollar
        /// </summary>
        private int countHalfDollars = 0;
        /// <summary>
        /// Gets or sets the number of pennies in the cash register
        /// </summary>
        public int HalfDollars
        {
            get => drawer.HalfDollars;

            set
            {
                if (drawer.HalfDollars == value || value < 0) return;
                var quantity = value - drawer.HalfDollars;
                if (quantity > 0)
                {
                    totalValue += .5;
                    countHalfDollars++;
                    drawer.AddCoin(Coins.HalfDollar, quantity);
                }
                else
                {
                    totalValue -= .5;
                    countHalfDollars++;
                    drawer.RemoveCoin(Coins.HalfDollar, -quantity);
                }
                InvokePropertyChanged("HalfDollars");
            }
        }

        /// <summary>
        /// count for dollars
        /// </summary>
        private int countDollars = 0;
        /// <summary>
        /// Gets or sets the number of pennies in the cash register
        /// </summary>
        public int Dollars
        {
            get => drawer.Dollars;

            set
            {
                if (drawer.Dollars == value || value < 0) return;
                var quantity = value - drawer.Dollars;
                if (quantity > 0)
                {
                    totalValue += 1;
                    countDollars++;
                    drawer.AddCoin(Coins.Dollar, quantity);
                }
                else
                {
                    totalValue -= 1;
                    countDollars++;
                    drawer.RemoveCoin(Coins.Dollar, -quantity);
                }
                InvokePropertyChanged("Dollars");
            }
        }

        /// <summary>
        /// count for ones
        /// </summary>
        private int countOnes = 0;
        /// <summary>
        /// Gets or sets the number of Fiftys in the cash register
        /// </summary>
        public int Ones
        {
            get => drawer.Ones;

            set
            {
                if (drawer.Ones == value || value < 0) return;
                var quantity = value - drawer.Ones;
                if (quantity > 0)
                {
                    totalValue += 1;
                    countOnes++;
                    drawer.AddBill(Bills.One, quantity);
                }
                else
                {
                    totalValue -= 1;
                    countOnes++;
                    drawer.RemoveBill(Bills.One, -quantity);
                }
                InvokePropertyChanged("Ones");
            }
        }

        /// <summary>
        /// count for twos
        /// </summary>
        private int countTwos = 0;
        /// <summary>
        /// Gets or sets the number of Fiftys in the cash register
        /// </summary>
        public int Twos
        {
            get => drawer.Twos;

            set
            {
                if (drawer.Twos == value || value < 0) return;
                var quantity = value - drawer.Twos;
                if (quantity > 0)
                {
                    totalValue += 2;
                    countTwos++;
                    drawer.AddBill(Bills.Two, quantity);
                }
                else
                {
                    totalValue -= 2;
                    countTwos++;
                    drawer.RemoveBill(Bills.Two, -quantity);
                }
                InvokePropertyChanged("Twos");
            }
        }

        /// <summary>
        /// count for fives
        /// </summary>
        private int countFives = 0;
        /// <summary>
        /// Gets or sets the number of Fiftys in the cash register
        /// </summary>
        public int Fives
        {
            get => drawer.Fives;

            set
            {
                if (drawer.Fives == value || value < 0) return;
                var quantity = value - drawer.Fives;
                if (quantity > 0)
                {
                    totalValue += 5;
                    countFives++;
                    drawer.AddBill(Bills.Five, quantity);
                }
                else
                {
                    totalValue -= 5;
                    countFives++;
                    drawer.RemoveBill(Bills.Five, -quantity);
                }
                InvokePropertyChanged("Fives");
            }
        }

        private int countTens = 0;
        /// <summary>
        /// Gets or sets the number of Fiftys in the cash register
        /// </summary>
        public int Tens
        {
            get => drawer.Tens;

            set
            {
                if (drawer.Tens == value || value < 0) return;
                var quantity = value - drawer.Tens;
                if (quantity > 0)
                {
                    totalValue += 10;
                    countTens++;
                    drawer.AddBill(Bills.Ten, quantity);
                }
                else
                {
                    totalValue -= 10;
                    countTens++;
                    drawer.RemoveBill(Bills.Ten, -quantity);
                }
                InvokePropertyChanged("Tens");
            }
        }

        private int countTwenties = 0;
        /// <summary>
        /// Gets or sets the number of pennies in the cash register
        /// </summary>
        public int Twenties
        {
            get => drawer.Twenties;

            set
            {
                if (drawer.Twenties == value || value < 0) return;
                var quantity = value - drawer.Twenties;
                if (quantity > 0)
                {
                    totalValue += 20;
                    countTwenties++;
                    drawer.AddBill(Bills.Twenty, quantity);
                }
                else
                {
                    totalValue -= 20;
                    countTwenties++;
                    drawer.RemoveBill(Bills.Twenty, -quantity);
                }
                InvokePropertyChanged("Twenties");
            }
        }

        private int countFiftys = 0;
        /// <summary>
        /// Gets or sets the number of Fiftys in the cash register
        /// </summary>
        public int Fiftys
        {
            get => drawer.Fifties;

            set
            {
                if (drawer.Fifties == value || value < 0) return;
                var quantity = value - drawer.Fifties;
                if (quantity > 0)
                {
                    totalValue += 50;
                    countFiftys++;
                    drawer.AddBill(Bills.Fifty, quantity);
                }
                else
                {
                    totalValue -= 50;
                    countFiftys++;
                    drawer.RemoveBill(Bills.Fifty, -quantity);
                }
                InvokePropertyChanged("Fiftys");
            }
        }

        private int countHundreds = 0;
        /// <summary>
        /// Gets or sets the number of Fiftys in the cash register
        /// </summary>
        public int Hundreds
        {
            get => drawer.Hundreds;

            set
            {
                if (drawer.Hundreds == value || value < 0) return;
                var quantity = value - drawer.Hundreds;
                if (quantity > 0)
                {
                    totalValue += 100;
                    countHundreds++;
                    drawer.AddBill(Bills.Hundred, quantity);
                }
                else
                {
                    totalValue -= 100;
                    countHundreds++;
                    drawer.RemoveBill(Bills.Hundred, -quantity);
                }
                InvokePropertyChanged("Hundreds");
            }
        }

        /// <summary>
        /// Invokes the PropertyChanged event for denomination properties
        /// and the TotalValue
        /// </summary>
        /// <param name="denomination">The property that is changing</param>
        void InvokePropertyChanged(string denomination)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(denomination));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalValue"));
        }
    }
}
