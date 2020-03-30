using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class CowpokeChiliPropertyChangedTests
    {
        [Fact]
        public void JerkedSodaShouldImplementINotifyPropertyChanged()
        {
            var c = new CowpokeChili();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(c);
        }
        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForCheese()
        {
            var c = new CowpokeChili();
            Assert.PropertyChanged(c, "Cheese", () => {
                c.Cheese = false;
            });
        }
        [Fact]
        public void ChangingGreenOnionsPropertyShouldInvokePropertyChangedForGreenOnions()
        {
            var c = new CowpokeChili();
            Assert.PropertyChanged(c, "GreenOnions", () => {
                c.GreenOnions = false;
            });
        }
        [Fact]
        public void ChangingSourCreamPropertyShouldInvokePropertyChangedForSourCream()
        {
            var c = new CowpokeChili();
            Assert.PropertyChanged(c, "SourCream", () => {
                c.SourCream = false;
            });
        }
        [Fact]
        public void ChangingTortillaStripsPropertyShouldInvokePropertyChangedForTortillaStrips()
        {
            var c = new CowpokeChili();
            Assert.PropertyChanged(c, "TortillaStrips", () => {
                c.TortillaStrips = false;
            });
        }
        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var c = new CowpokeChili();
            Assert.PropertyChanged(c, "SpecialInstructions", () => {
                c.Cheese = false;
            });
        }
        [Fact]
        public void ChangingSourCreamPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var c = new CowpokeChili();
            Assert.PropertyChanged(c, "SpecialInstructions", () => {
                c.SourCream = false;
            });
        }
        [Fact]
        public void ChangingGreenOnionsPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var c = new CowpokeChili();
            Assert.PropertyChanged(c, "SpecialInstructions", () => {
                c.Cheese = false;
            });
        }
        [Fact]
        public void ChangingTortillaStripsPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var c = new CowpokeChili();
            Assert.PropertyChanged(c, "SpecialInstructions", () => {
                c.SourCream = false;
            });
        }
    }
}
