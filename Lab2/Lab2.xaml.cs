using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using T2010A_UWP.Models;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace T2010A_UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Lab2 : Page
    {
        public Lab2()
        {
            this.InitializeComponent();
            MainFrame.Navigate(typeof(NewFolder2.Home));
            var item1 = new MenuItem() { Name = "Home", MenuPage = "homepage", Icon = "\uE80F" };
            var item2 = new MenuItem() { Name = "Contact", MenuPage = "contact", Icon = "\uE77B" };
            var item3 = new MenuItem() { Name = "Customer", MenuPage = "customer", Icon = "\uEE57" };
            var item4 = new MenuItem() { Name = "Email", MenuPage = "email", Icon = "\uEA57" };
            Menu.Items.Add(item1);
            Menu.Items.Add(item2);
            Menu.Items.Add(item3);
            Menu.Items.Add(item4);
        }
        private void IconClick_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Page.IsPaneOpen = !Page.IsPaneOpen;
        }
        private void ListViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MenuItem selected = (MenuItem)Menu.SelectedItem;
            switch (selected.MenuPage)
            {
                case "homepage": MainFrame.Navigate(typeof(NewFolder2.Home)); break;
                case "contact": MainFrame.Navigate(typeof(NewFolder2.Home)); break;
                case "customer": MainFrame.Navigate(typeof(NewFolder2.Home)); break;
                case "email": MainFrame.Navigate(typeof(NewFolder2.DemoForm)); break;
            }
        }
    }
}
