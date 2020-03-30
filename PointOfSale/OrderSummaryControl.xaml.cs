using System;
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
using PointOfSale.ExtensionMethods;
using PointOfSale.Customization_Screens;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        public OrderSummaryControl()
        {
            
            InitializeComponent();
            
        }

        private void PList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(DataContext is Order order)
            {
                if(sender is ListBox box)
                {
                    var ordercontrol = this.FindAncestor<MainWindow>();
                    if(box.SelectedItem is IOrderItem i)
                    {
                        if(i is AngryChicken)
                        {
                            var screen = new AngryChickenCustomization();
                            screen.DataContext = i;
                            ordercontrol?.SwapScreen(screen);
                        }
                        if (i is BakedBeans)
                        {
                            var screen = new BakedBeansCustomization(order);
                            screen.DataContext = i;
                            ordercontrol?.SwapScreen(screen);
                        }
                        if (i is ChiliCheeseFries)
                        {
                            var screen = new ChiliCheeseFriesCustomization(order);
                            screen.DataContext = i;
                            ordercontrol?.SwapScreen(screen);
                        }
                        if (i is CornDodgers)
                        {
                            var screen = new CornDodgersCustomization(order);
                            screen.DataContext = i;
                            ordercontrol?.SwapScreen(screen);
                        }
                        if (i is CowboyCoffee)
                        {
                            var screen = new CowboyCoffeeCustomization(order);
                            screen.DataContext = i;
                            ordercontrol?.SwapScreen(screen);
                        }
                        if (i is CowpokeChili)
                        {
                            var screen = new CowpokeChiliCustomization();
                            screen.DataContext = i;
                            ordercontrol?.SwapScreen(screen);
                        }
                        if (i is DakotaDoubleBurger)
                        {
                            var screen = new DakotaDoubleBurgerCustomization();
                            screen.DataContext = i;
                            ordercontrol?.SwapScreen(screen);
                        }
                        if (i is JerkedSoda)
                        {
                            var screen = new JerkedSodaCustomization(order);
                            screen.DataContext = i;
                            ordercontrol?.SwapScreen(screen);
                        }
                        if (i is PanDeCampo)
                        {
                            var screen = new PanDeCampoCustomization(order);
                            screen.DataContext = i;
                            ordercontrol?.SwapScreen(screen);
                        }
                        if (i is TexasTea)
                        {
                            var screen = new TexasTeaCustomization(order);
                            screen.DataContext = i;
                            ordercontrol?.SwapScreen(screen);
                        }
                        if (i is TexasTripleBurger)
                        {
                            var screen = new TexasTripleBurgerCustomization();
                            screen.DataContext = i;
                            ordercontrol?.SwapScreen(screen);
                        }
                        if (i is TrailBurger)
                        {
                            var screen = new TrailBurgerCustomization();
                            screen.DataContext = i;
                            ordercontrol?.SwapScreen(screen);
                        }
                        if (i is Water)
                        {
                            var screen = new WaterCustomization(order);
                            screen.DataContext = i;
                            ordercontrol?.SwapScreen(screen);
                        }
                    }
                }
            }
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if(sender is Button button)
                {
                    if(button.DataContext is IOrderItem i)
                    {
                        order.Remove(i);
                    }
                }
            }
        }

        
    }
}
