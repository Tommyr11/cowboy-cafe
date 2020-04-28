using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using CowboyCafe.Data;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        public IEnumerable<IOrderItem> order { get; set; }
        /// <summary>
        /// The filtered MPAA Ratings
        /// </summary>
        public string[] Categories { get; set; }
        private readonly ILogger<IndexModel> _logger;
        public string SearchTerms { get; set; }
        /// <summary>
        /// The minimum IMDB Rating
        /// </summary>
        
        public double? Caloriesmin { get; set; }

        /// <summary>
        /// The maximum IMDB Rating
        /// </summary>
        
        public double? Caloriesmax { get; set; }
        /// <summary>
        /// The minimum IMDB Rating
        /// </summary>
        
        public double? Pricemin { get; set; }

        /// <summary>
        /// The maximum IMDB Rating
        /// </summary>
        
        public double? Pricemax { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(double? Caloriesmin, double? Caloriesmax, double? Pricemax, double? Pricemin)
        {
            this.Caloriesmax = Caloriesmax;
            this.Caloriesmin = Caloriesmin;
            this.Pricemax = Pricemax;
            this.Pricemin = Pricemin;
            SearchTerms = Request.Query["SearchTerms"];
            Categories = Request.Query["Categories"];
            order = Menu.Search(SearchTerms);
            order = Menu.FilterByCategory(order, Categories);
            order = Menu.FilterByCalories(order, Caloriesmin, Caloriesmax);
            order = Menu.FilterByPrice(order, Pricemin, Pricemax);
        }
    }
}
