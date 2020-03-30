using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class JerkedSodaPropertyChangedTests
    {
        [Fact]
        public void JerkedSodaShouldImplementINotifyPropertyChanged()
        {
            var c = new JerkedSoda();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(c);
        }
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForSize()
        {
            var c = new JerkedSoda();
            Assert.PropertyChanged(c, "Size", () => {
                c.Size = Size.Medium;
            });
        }
        [Fact]
        public void ChangingSodaflavorPropertyShouldInvokePropertyChangedForSodaFlavor()
        {
            var c = new JerkedSoda();
            Assert.PropertyChanged(c, "Flavor", () => {
                c.Flavor = SodaFlavor.RootBeer;
            });
        }
        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangedForIce()
        {
            var c = new JerkedSoda();
            Assert.PropertyChanged(c, "Ice", () => {
                c.Ice = false;
            });
        }
    }
}
