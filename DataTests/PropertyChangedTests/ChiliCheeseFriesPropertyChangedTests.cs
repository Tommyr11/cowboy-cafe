using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class ChiliCheeseFriesPropertyChangedTests
    {
        [Fact]
        public void BakedBeansShouldImplementINotifyPropertyChanged()
        {
            var chili = new ChiliCheeseFries();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(chili);
        }
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForSize()
        {
            var chili = new ChiliCheeseFries();
            Assert.PropertyChanged(chili, "Size", () => {
                chili.Size = Size.Medium;
            });
        }
    }
}
