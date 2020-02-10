using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests
{
    public class PanDeCampoTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            PandeCampo pdc = new PandeCampo();
            Assert.Equal(1.59, pdc.Price);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            PandeCampo pdc = new PandeCampo();
            Assert.Equal<uint>(227, pdc.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            PandeCampo pdc = new PandeCampo();
            Assert.Equal<Size>(Size.Small, pdc.Size);
        }

        [Theory]
        [InlineData(Size.Small, 1.59)]
        [InlineData(Size.Medium, 1.79)]
        [InlineData(Size.Large, 1.99)]
        public void ShouldUseCorrectPriceForSize(Size size, double price)
        {
            PandeCampo pdc = new PandeCampo();
            pdc.Size = Size.Medium;
            pdc.Size = size;
            Assert.Equal(price, pdc.Price);
        }

        [Theory]
        [InlineData(Size.Small, 227)]
        [InlineData(Size.Medium, 269)]
        [InlineData(Size.Large, 367)]
        public void ShouldUseCorrectCaloriesForSize(Size size, uint calories)
        {
            PandeCampo pdc = new PandeCampo();
            pdc.Size = Size.Medium;
            pdc.Size = size;
            Assert.Equal<uint>(calories, pdc.Calories);
        }
    }
}
