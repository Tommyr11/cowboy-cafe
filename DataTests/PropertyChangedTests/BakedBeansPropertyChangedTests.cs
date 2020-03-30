using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class BakedBeansPropertyChangedTests
    {
        [Fact]
        public void BakedBeansShouldImplementINotifyPropertyChanged()
        {
            var Beans = new BakedBeans();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(Beans);
        }
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForSize()
        {
            var Beans = new BakedBeans();
            Assert.PropertyChanged(Beans, "Size", () => {
                Beans.Size = Size.Medium;
            });
        }
    }
}
