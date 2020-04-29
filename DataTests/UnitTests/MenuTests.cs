using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.Linq;

namespace CowboyCafe.DataTests.UnitTests
{
    public class MenuTests
    {
        [Fact]
        public void SideShouldContain()
        {
            Assert.Collection
            (
                Menu.Sides(),
                (pdc) => { Assert.IsType<PanDeCampo>(pdc); },
                (cd) => { Assert.IsType<CornDodgers>(cd); },
                (bb) => { Assert.IsType<BakedBeans>(bb); },
                (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf); }
                
            );
        }
        [Fact]
        public void DrinkShouldContain()
        {
            Assert.Collection
            (
                Menu.Drinks(),
                (pdc) => { Assert.IsType<JerkedSoda>(pdc); },
                (cd) => { Assert.IsType<CowboyCoffee>(cd); },
                (bb) => { Assert.IsType<TexasTea>(bb); },
                (ccf) => { Assert.IsType<Water>(ccf); }

            );
        }
        [Fact]
        public void EntreeShouldContain()
        {
            Assert.Collection
            (
                Menu.Entrees(),
                (pdc) => { Assert.IsType<AngryChicken>(pdc); },
                (cd) => { Assert.IsType<CowpokeChili>(cd); },
                (cd) => { Assert.IsType<DakotaDoubleBurger>(cd); },
                (bb) => { Assert.IsType<PecosPulledPork>(bb); },
                (ccf) => { Assert.IsType<RustlersRibs>(ccf); },
                (cd) => { Assert.IsType<TrailBurger>(cd); },
                (bb) => { Assert.IsType<TexasTripleBurger>(bb); }

            );
        }
        [Fact]
        public void AllShouldContain()
        {
            Assert.Collection
            (
                Menu.Entrees(),
                (pdc) => { Assert.IsType<AngryChicken>(pdc); },
                (cd) => { Assert.IsType<CowpokeChili>(cd); },
                (cd) => { Assert.IsType<DakotaDoubleBurger>(cd); },
                (bb) => { Assert.IsType<PecosPulledPork>(bb); },
                (ccf) => { Assert.IsType<RustlersRibs>(ccf); },
                (cd) => { Assert.IsType<TrailBurger>(cd); },
                (bb) => { Assert.IsType<TexasTripleBurger>(bb); }

            );
            Assert.Collection
            (
                Menu.Sides(),
                (pdc) => { Assert.IsType<PanDeCampo>(pdc); },
                (cd) => { Assert.IsType<CornDodgers>(cd); },
                (bb) => { Assert.IsType<BakedBeans>(bb); },
                (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf); }

            );
            Assert.Collection
            (
                Menu.Drinks(),
                (pdc) => { Assert.IsType<JerkedSoda>(pdc); },
                (cd) => { Assert.IsType<CowboyCoffee>(cd); },
                (bb) => { Assert.IsType<TexasTea>(bb); },
                (ccf) => { Assert.IsType<Water>(ccf); }

            );
        }
        [Theory]
        [InlineData(typeof(ChiliCheeseFries))]
        [InlineData(typeof(BakedBeans))]
        [InlineData(typeof(CornDodgers))]
        [InlineData(typeof(PanDeCampo))]
        public void SidesShouldContainTypes(Type type)
        {
            var types = new List<Type>();
            foreach(IOrderItem item in Menu.Sides())
            {
                types.Add(item.GetType());
            }
            Assert.Contains(type, types);
        }
        [Theory]
        [InlineData(typeof(TexasTripleBurger))]
        [InlineData(typeof(TrailBurger))]
        [InlineData(typeof(PecosPulledPork))]
        [InlineData(typeof(RustlersRibs))]
        [InlineData(typeof(CowpokeChili))]
        [InlineData(typeof(DakotaDoubleBurger))]
        public void EntreesShouldContainTypes(Type type)
        {
            var types = new List<Type>();
            foreach (IOrderItem item in Menu.Entrees())
            {
                types.Add(item.GetType());
            }
            Assert.Contains(type, types);
        }
        [Theory]
        [InlineData(typeof(JerkedSoda))]
        [InlineData(typeof(CowboyCoffee))]
        [InlineData(typeof(TexasTea))]
        [InlineData(typeof(Water))]
        public void DrinksShouldContainTypes(Type type)
        {
            var types = new List<Type>();
            foreach (IOrderItem item in Menu.Drinks())
            {
                types.Add(item.GetType());
            }
            Assert.Contains(type, types);
        }
        [Theory]
        [InlineData(0,20,3)]
        [InlineData(200,400,3)]
        [InlineData(0,1000,15)]
        [InlineData(null,null,15)]
        public void ShouldFilterCal(double? min, double? max, double exp)
        {
            Assert.Equal(exp, Menu.FilterByCalories(Menu.All(), min, max).Count());
        }
        [Theory]
        [InlineData(0, 1, 3)]
        [InlineData(1, 5, 7)]
        [InlineData(2, 4, 0)]
        [InlineData(null, null, 15)]
        public void ShouldFilterPrice(double? min, double? max, double exp)
        {
            Assert.Equal(exp, Menu.FilterByPrice(Menu.All(), min, max).Count());
        }
        [Theory]
        [InlineData(null,15)]
        [InlineData(new string[] {"Drink","Entree" }, 11)]
        [InlineData(new string[] { "Drink", "Side" }, 8)]
        [InlineData(new string[] { "Side" }, 4)]

        public void ShouldFilterCategories(string [] options, int expected)
        {
            var item = Menu.All();
            var results = Menu.FilterByCategory(Menu.All(), options);
            if(results is List<IOrderItem> val)
            {
                Assert.Equal(expected, val.Count);
            }
        }
    }
}
