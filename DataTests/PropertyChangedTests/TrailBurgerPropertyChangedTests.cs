using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class TrailBurgerPropertyChangedTests
    {
        [Fact]
        public void TrailBurgerShouldImplementINotifyPropertyChanged()
        {
            var d = new TrailBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(d);
        }
        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForCheese()
        {
            var d = new TrailBurger();
            Assert.PropertyChanged(d, "Cheese", () => {
                d.Cheese = false;
            });
        }
        [Fact]
        public void ChangingBunPropertyShouldInvokePropertyChangedForBun()
        {
            var d = new TrailBurger();
            Assert.PropertyChanged(d, "Bun", () => {
                d.Bun = false;
            });
        }
        [Fact]
        public void ChangingKetchupPropertyShouldInvokePropertyChangedForKetchup()
        {
            var d = new TrailBurger();
            Assert.PropertyChanged(d, "Ketchup", () => {
                d.Ketchup = false;
            });
        }
        [Fact]
        public void ChangingMustardPropertyShouldInvokePropertyChangedForMustard()
        {
            var d = new TrailBurger();
            Assert.PropertyChanged(d, "Mustard", () => {
                d.Mustard = false;
            });
        }
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForPickle()
        {
            var d = new TrailBurger();
            Assert.PropertyChanged(d, "Pickle", () => {
                d.Pickle = true;
            });
        }
        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var d = new TrailBurger();
            Assert.PropertyChanged(d, "SpecialInstructions", () => {
                d.Cheese = false;
            });
        }
        [Fact]
        public void ChangingBunPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var d = new TrailBurger();
            Assert.PropertyChanged(d, "SpecialInstructions", () => {
                d.Bun = false;
            });
        }
        [Fact]
        public void ChangingKetchupPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var d = new TrailBurger();
            Assert.PropertyChanged(d, "SpecialInstructions", () => {
                d.Ketchup = false;
            });
        }
        [Fact]
        public void ChangingMustardPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var d = new TrailBurger();
            Assert.PropertyChanged(d, "SpecialInstructions", () => {
                d.Mustard = false;
            });
        }
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var d = new TrailBurger();
            Assert.PropertyChanged(d, "SpecialInstructions", () => {
                d.Pickle = true;
            });
        }
    }
}
