using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class CowboyCoffeePropertyChangedTests
    {
        [Fact]
        public void CowboyCoffeeShouldImplementINotifyPropertyChanged()
        {
            var c = new CowboyCoffee();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(c);
        }
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForSize()
        {
            var c = new CowboyCoffee();
            Assert.PropertyChanged(c, "Size", () => {
                c.Size = Size.Medium;
            });
        }
        [Fact]
        public void ChangingDecafPropertyShouldInvokePropertyChangedForDecaf()
        {
            var c = new CowboyCoffee();
            Assert.PropertyChanged(c, "Decaf", () => {
                c.Decaf = false;
            });
        }
        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangedForIce()
        {
            var c = new CowboyCoffee();
            Assert.PropertyChanged(c, "Ice", () => {
                c.Ice = true;
            });
        }
        [Fact]
        public void ChangingCreamPropertyShouldInvokePropertyChangedForCream()
        {
            var c = new CowboyCoffee();
            Assert.PropertyChanged(c, "RoomForCream", () => {
                c.RoomForCream = true;
            });
        }
        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var c = new CowboyCoffee();
            Assert.PropertyChanged(c, "SpecialInstructions", () => {
                c.Ice = true;
            });
        }
        [Fact]
        public void ChangingCreamPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var c = new CowboyCoffee();
            Assert.PropertyChanged(c, "SpecialInstructions", () => {
                c.RoomForCream = true;
            });
        }
    }
}
