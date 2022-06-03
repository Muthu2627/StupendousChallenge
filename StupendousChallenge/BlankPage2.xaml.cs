using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace StupendousChallenge
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BlankPage2 : Page
    {
        private string Roast = null;
        private string Sweetner = null;
        private string Cream = null;
        public BlankPage2()
        {
            this.InitializeComponent();
        }

        private void RoastItem_Click(object sender, RoutedEventArgs e)
        {
            var item = (MenuFlyoutItem)sender;
            Roast = item.Text;
            Display();
        }

        private void SweetnerItem_Click(object sender, RoutedEventArgs e)
        {
            var item = (MenuFlyoutItem)sender;
            Sweetner = item.Text;
            if(Sweetner == "None"){ Sweetner = null; }
            Display();
        }

        private void CreamItem_Click(object sender, RoutedEventArgs e)
        {
            var item = (MenuFlyoutItem)sender;
            Cream = item.Text;
            if(Cream == "None") { Cream = null; }
            Display();
        }

        private void Display()
        {
            if(Roast == null || Roast == "None")
            {
                CoffeePageChosenText.Text = "None";
                return;
            }
            CoffeePageChosenText.Text = Roast;
            if(Sweetner != null && Sweetner != "None")
            {
                CoffeePageChosenText.Text += " + " + Sweetner;
            }
            if(Cream != null && Cream != "None")
            {
                CoffeePageChosenText.Text += " + " + Cream;
            }
        }
    }
}
