using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class OrderPropertyChangedTests
    {
        [Fact]
        public void OrderShouldImplementINotifyPropertyChanged()
        {
            var c = new Order();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(c);
        }
        [Fact]
        public void ChangingSubtotalPropertyShouldInvokePropertyChangedForSubtotal()
        {
            var c = new Order();
            Assert.PropertyChanged(c, "Subtotal", () => {
                c.Subtotal += 1;
            });
        }

        [Fact]
        public void AddingItemsPropertyShouldInvokePropertyChangedForItems()
        {
            var c = new Order();
            AngryChicken a = new AngryChicken();
            Assert.PropertyChanged(c, "Items", () => {
                c.Add(a);
            });
        }
        [Fact]
        public void RemovingItemsPropertyShouldInvokePropertyChangedForItems()
        {
            var c = new Order();
            AngryChicken a = new AngryChicken();
            Assert.PropertyChanged(c, "Items", () => {
                c.Remove(a);
            });
        }
    }
}
