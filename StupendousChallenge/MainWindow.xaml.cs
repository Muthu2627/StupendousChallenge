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
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            MainFrame.Navigate(typeof(BlankPage1));
        }

        private void DonutPageButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(BlankPage1));
        }

        private void CoffeePageButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(BlankPage2));
        }

        private void SchedulePageButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(BlankPage3));
        }

        private void CompletePageButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(BlankPage4));
        }

        private void MainPageNavigationButton_PointerMoved(object sender, PointerRoutedEventArgs e)
        {
            var ButtonSelected = (Button)sender;
            ButtonSelected.Background = new SolidColorBrush(Microsoft.UI.Colors.DarkGray);
        }

        private void MainPageNavigationButton_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            var ButtonSelected = (Button)sender;
            ButtonSelected.Background = new SolidColorBrush(Microsoft.UI.Colors.Black);
        }
    }
}
