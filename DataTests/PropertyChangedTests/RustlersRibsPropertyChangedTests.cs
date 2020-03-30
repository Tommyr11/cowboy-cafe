using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class RustlersRibsPropertyChangedTests
    {
        [Fact]
        public void RustlersRibsShouldImplementINotifyPropertyChanged()
        {
            var chicken = new RustlersRibs();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(chicken);
        }
    }
}
