using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace CowboyCafe.Data
{
    public static class Menu
    {
        /// <summary>
        /// Gets the possible MPAARatings
        /// </summary>
        public static string[] types
        {
            get => new string[]
            {
            "Entree",
            "Side",
            "Drink"
            };
        }
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
        public static IEnumerable<IOrderItem> All()
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
        public static IEnumerable<IOrderItem> Search(string terms)
        {
            List<IOrderItem> results = new List<IOrderItem>();
            // Return all movies if there are no search terms
            if (terms == null) return All();
            foreach (IOrderItem item in All())
            {
                if (item.ToString() != null && item.ToString().Contains(terms, StringComparison.InvariantCultureIgnoreCase))
                {
                    results.Add(item);
                }
            }
            return results;
        }
        /// <summary>
        /// Filters the provided collection of movies
        /// </summary>
        /// <param name="movies">The collection of movies to filter</param>
        /// <param name="ratings">The ratings to include</param>
        /// <returns>A collection containing only movies that match the filter</returns>
        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> items, IEnumerable<string> ratings)
        {
            // If no filter is specified, just return the provided collection
            if (ratings == null || ratings.Count() == 0) return items;
            List<IOrderItem> results = new List<IOrderItem>();
            foreach (IOrderItem item in items)
            {
                if(item is Entree)
                {
                    if (ratings.Contains("Entree"))
                    {
                        results.Add(item);
                    }
                }
                if (item is Side)
                {
                    if (ratings.Contains("Side"))
                    {
                        results.Add(item);
                    }
                }
                if (item is Drink)
                {
                    if (ratings.Contains("Drink"))
                    {
                        results.Add(item);
                    }
                }
            }
            return results;
        }


        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> item, double? min, double? max)
        {
            if (min == null && max == null) return item;
            List<IOrderItem> results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem i in item)
                {
                    if (i is Entree)
                    {
                        Entree e = (Entree)i;
                        if (e.Calories <= max) results.Add(i);
                    }
                    if (i is Side)
                    {
                        Side e = (Side)i;
                        if (e.Calories <= max) results.Add(i);
                    }
                    if (i is Drink)
                    {
                        Drink e = (Drink)i;
                        if (e.Calories <= max) results.Add(i);
                    }

                }
                return results;
            }
            if (max == null)
            {
                foreach (IOrderItem i in item)
                {
                    if (i is Entree)
                    {
                        Entree e = (Entree)i;
                        if (e.Calories >= min) results.Add(i);
                    }
                    if (i is Side)
                    {
                        Side e = (Side)i;
                        if (e.Calories >= min) results.Add(i);
                    }
                    if (i is Drink)
                    {
                        Drink e = (Drink)i;
                        if (e.Calories >= min) results.Add(i);
                    }

                }
                return results;
            }
            // Both minimum and maximum specified
            foreach (IOrderItem i in item)
            {
                if (i is Entree)
                {
                    Entree e = (Entree)i;
                    if (e.Calories >= min && e.Calories <= max) results.Add(i);
                }
                if (i is Side)
                {
                    Side e = (Side)i;
                    if (e.Calories >= min && e.Calories <= max) results.Add(i);
                }
                if (i is Drink)
                {
                    Drink e = (Drink)i;
                    if (e.Calories >= min && e.Calories <= max) results.Add(i);
                }
            }
            return results;
        }
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> item, double? min, double? max)
        {
            if (min == null && max == null) return item;
            List<IOrderItem> results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem i in item)
                {
                    if (i is Entree)
                    {
                        Entree e = (Entree)i;
                        if (e.Price <= max) results.Add(i);
                    }
                    if (i is Side)
                    {
                        Side e = (Side)i;
                        if (e.Price <= max) results.Add(i);
                    }
                    if (i is Drink)
                    {
                        Drink e = (Drink)i;
                        if (e.Price <= max) results.Add(i);
                    }

                }
                return results;
            }
            if (max == null)
            {
                foreach (IOrderItem i in item)
                {
                    if (i is Entree)
                    {
                        Entree e = (Entree)i;
                        if (e.Price >= min) results.Add(i);
                    }
                    if (i is Side)
                    {
                        Side e = (Side)i;
                        if (e.Price >= min) results.Add(i);
                    }
                    if (i is Drink)
                    {
                        Drink e = (Drink)i;
                        if (e.Price >= min) results.Add(i);
                    }

                }
                return results;
            }
            // Both minimum and maximum specified
            foreach (IOrderItem i in item)
            {
                if (i is Entree)
                {
                    Entree e = (Entree)i;
                    if (e.Price >= min && e.Price <= max) results.Add(i);
                }
                if (i is Side)
                {
                    Side e = (Side)i;
                    if (e.Price >= min && e.Price <= max) results.Add(i);
                }
                if (i is Drink)
                {
                    Drink e = (Drink)i;
                    if (e.Price >= min && e.Price <= max) results.Add(i);
                }
            }
            return results;
        }
    }
}
