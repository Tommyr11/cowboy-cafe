using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class PanDeCampoPropertyChangedTests
    {
        [Fact]
        public void PanDeCampoShouldImplementINotifyPropertyChanged()
        {
            var c = new PanDeCampo();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(c);
        }
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForSize()
        {
            var c = new PanDeCampo();
            Assert.PropertyChanged(c, "Size", () => {
                c.Size = Size.Medium;
            });
        }
    }
}
