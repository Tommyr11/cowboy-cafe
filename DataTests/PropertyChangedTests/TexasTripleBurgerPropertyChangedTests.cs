using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class TexasTripleBurgerPropertyChangedTests
    {
        [Fact]
        public void TexasTripleBurgerShouldImplementINotifyPropertyChanged()
        {
            var d = new TexasTripleBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(d);
        }
        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForCheese()
        {
            var d = new TexasTripleBurger();
            Assert.PropertyChanged(d, "Cheese", () => {
                d.Cheese = false;
            });
        }
        [Fact]
        public void ChangingBunPropertyShouldInvokePropertyChangedForBun()
        {
            var d = new TexasTripleBurger();
            Assert.PropertyChanged(d, "Bun", () => {
                d.Bun = false;
            });
        }
        [Fact]
        public void ChangingKetchupPropertyShouldInvokePropertyChangedForKetchup()
        {
            var d = new TexasTripleBurger();
            Assert.PropertyChanged(d, "Ketchup", () => {
                d.Ketchup = false;
            });
        }
        [Fact]
        public void ChangingMustardPropertyShouldInvokePropertyChangedForMustard()
        {
            var d = new TexasTripleBurger();
            Assert.PropertyChanged(d, "Mustard", () => {
                d.Mustard = false;
            });
        }
        [Fact]
        public void ChangingTomatoPropertyShouldInvokePropertyChangedForTomato()
        {
            var d = new TexasTripleBurger();
            Assert.PropertyChanged(d, "Tomato", () => {
                d.Tomato = false;
            });
        }
        [Fact]
        public void ChangingMayoPropertyShouldInvokePropertyChangedForMayo()
        {
            var d = new TexasTripleBurger();
            Assert.PropertyChanged(d, "Mayo", () => {
                d.Mayo = true;
            });
        }
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForPickle()
        {
            var d = new TexasTripleBurger();
            Assert.PropertyChanged(d, "Pickle", () => {
                d.Pickle = true;
            });
        }
        [Fact]
        public void ChangingLettucePropertyShouldInvokePropertyChangedForLettuce()
        {
            var d = new TexasTripleBurger();
            Assert.PropertyChanged(d, "Lettuce", () => {
                d.Lettuce = true;
            });
        }
        [Fact]
        public void ChangingBaconPropertyShouldInvokePropertyChangedForBacon()
        {
            var d = new TexasTripleBurger();
            Assert.PropertyChanged(d, "Bacon", () => {
                d.Bacon = true;
            });
        }
        [Fact]
        public void ChangingEggPropertyShouldInvokePropertyChangedForEgg()
        {
            var d = new TexasTripleBurger();
            Assert.PropertyChanged(d, "Egg", () => {
                d.Egg = true;
            });
        }
        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var d = new TexasTripleBurger();
            Assert.PropertyChanged(d, "SpecialInstructions", () => {
                d.Cheese = false;
            });
        }
        [Fact]
        public void ChangingBunPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var d = new TexasTripleBurger();
            Assert.PropertyChanged(d, "SpecialInstructions", () => {
                d.Bun = false;
            });
        }
        [Fact]
        public void ChangingKetchupPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var d = new TexasTripleBurger();
            Assert.PropertyChanged(d, "SpecialInstructions", () => {
                d.Ketchup = false;
            });
        }
        [Fact]
        public void ChangingMustardPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var d = new TexasTripleBurger();
            Assert.PropertyChanged(d, "SpecialInstructions", () => {
                d.Mustard = false;
            });
        }
        [Fact]
        public void ChangingTomatoPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var d = new TexasTripleBurger();
            Assert.PropertyChanged(d, "SpecialInstructions", () => {
                d.Tomato = false;
            });
        }
        [Fact]
        public void ChangingMayoPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var d = new TexasTripleBurger();
            Assert.PropertyChanged(d, "SpecialInstructions", () => {
                d.Mayo = true;
            });
        }
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var d = new TexasTripleBurger();
            Assert.PropertyChanged(d, "SpecialInstructions", () => {
                d.Pickle = true;
            });
        }
        [Fact]
        public void ChangingLettucePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var d = new TexasTripleBurger();
            Assert.PropertyChanged(d, "SpecialInstructions", () => {
                d.Lettuce = true;
            });
        }
        [Fact]
        public void ChangingEggPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var d = new TexasTripleBurger();
            Assert.PropertyChanged(d, "SpecialInstructions", () => {
                d.Egg = true;
            });
        }
        [Fact]
        public void ChangingBaconPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var d = new TexasTripleBurger();
            Assert.PropertyChanged(d, "SpecialInstructions", () => {
                d.Bacon = true;
            });
        }
    }
}
