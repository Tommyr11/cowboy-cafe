using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public static class Menu
    {
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> l = new List<IOrderItem>();
            l.Add(new AngryChicken());
            l.Add(new CowpokeChili());
            l.Add(new DakotaDoubleBurger());
            l.Add(new PecosPulledPork());
            l.Add(new RustlersRibs());
            l.Add(new TrailBurger());
            l.Add(new TexasTripleBurger());
            return l;
        }
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> l = new List<IOrderItem>();
            l.Add(new JerkedSoda());
            l.Add(new CowboyCoffee());
            l.Add(new TexasTea());
            l.Add(new Water());
            return l;
        }
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> l = new List<IOrderItem>();
            l.Add(new PanDeCampo());
            l.Add(new CornDodgers());
            l.Add(new BakedBeans());
            l.Add(new ChiliCheeseFries());
            return l;
        }
        public static IEnumerable<IOrderItem> CompleteMenu()
        {
            List<IOrderItem> l = new List<IOrderItem>();
            l.Add(new AngryChicken());
            l.Add(new CowpokeChili());
            l.Add(new DakotaDoubleBurger());
            l.Add(new PecosPulledPork());
            l.Add(new RustlersRibs());
            l.Add(new TrailBurger());
            l.Add(new TexasTripleBurger());
            l.Add(new PanDeCampo());
            l.Add(new CornDodgers());
            l.Add(new BakedBeans());
            l.Add(new ChiliCheeseFries());
            l.Add(new JerkedSoda());
            l.Add(new CowboyCoffee());
            l.Add(new TexasTea());
            l.Add(new Water());
            return l;
        }
    }
}
