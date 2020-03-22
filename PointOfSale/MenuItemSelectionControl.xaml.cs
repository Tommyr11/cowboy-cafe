﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CowboyCafe.Data;
using PointOfSale.Customization_Screens;
using PointOfSale.ExtensionMethods;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        public MenuItemSelectionControl()
        {
            InitializeComponent();
            
        }
        public Order order = new Order();

        /// <summary>
        /// Adds Jerked Soda to the listview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddJerkedSoda_Click(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                order.Add(new JerkedSoda());
            }
        }
        /// <summary>
        /// Adds Texas Tea to the listview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTexasTea_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new TexasTea());
            }
        }
        /// <summary>
        /// Adds Cowboy Coffee to the listview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCowboyCoffee_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new CowboyCoffee());
            }
        }
        /// <summary>
        /// Adds Water to the ListView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddWater_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new Water());
            }
        }
        /// <summary>
        /// Adds Chili Cheese Fries to the ListView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddChiliCheeseFries_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new ChiliCheeseFries());
            }
        }
        /// <summary>
        /// Adds Corn Dodgers to the ListView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCornDodgers_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new CornDodgers());
            }
        }
        /// <summary>
        /// Adds Pan De Campo to the ListView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPanDeCampo_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new PanDeCampo());
            }
        }
        /// <summary>
        /// Adds Baked Beans to the ListView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBakedBeans_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new BakedBeans());
            }
        }
        /// <summary>
        /// Adds Angry Chicken to the ListView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddAngryChicken_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            if (DataContext is Order order)
            {
                var item = new AngryChicken();
                var screen = new AngryChickenCustomization();
                screen.DataContext = item;
                order.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }
        /// <summary>
        /// Adds Rustlers Ribs to the ListView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddRustlersRibs_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new RustlersRibs());
            }
        }
        /// <summary>
        /// Adds Pecos Pulled Pork to the ListView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPecosPulledPork_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            if (DataContext is Order order)
            {
                var item = new PecosPulledPork();
                var screen = new PecosPulledPorkCustomization();
                screen.DataContext = item;
                order.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }
        /// <summary>
        /// Adds Trail Burger to the ListView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTrailBurger_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            if (DataContext is Order order)
            {
                var item = new TrailBurger();
                var screen = new TrailBurgerCustomization();
                screen.DataContext = item;
                order.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }
        /// <summary>
        /// Adds Dakota Double Burger to the ListView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddDakotaDoubleBurger_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            if (DataContext is Order order)
            {
                var item = new DakotaDoubleBurger();
                var screen = new DakotaDoubleBurgerCustomization();
                screen.DataContext = item;
                order.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }
        /// <summary>
        /// Adds Texas Triple Burger to the ListView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTexasTripleBurger_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            if (DataContext is Order order)
            {
                var item = new TexasTripleBurger();
                var screen = new TexasTripleBurgerCustomization();
                screen.DataContext = item;
                order.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }
        /// <summary>
        /// Adds Cowpoke Chili to the ListView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCowpokeChili_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            if (DataContext is Order order)
            {
                var item = new CowpokeChili();
                var screen = new CowpokeChiliCustomization();
                screen.DataContext = item;
                order.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }
    }
}
