using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;
using System.Windows;

namespace PointOfSale.ExtensionMethods
{
    public static class ExtensionMethods
    {
        public static T FindAncestor<T>(this DependencyObject element) where T: DependencyObject
        {
            var parent = VisualTreeHelper.GetParent(element);
            if (parent == null) return null;
            if (parent is T) return parent as T;
            return parent.FindAncestor<T>();
        }
    }
}
