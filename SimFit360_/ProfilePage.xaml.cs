using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using SimFit360.Model;
using Windows.Media.Streaming.Adaptive;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace SimFit360_
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ProfilePage : Page
    { 
        private static User LoggedInUser { get; }   

        public ProfilePage()
        {
            this.InitializeComponent();

            using var db = new AppDbContext();

            var currentUser = LoggedInUser; 

            ProfileListView.ItemsSource = currentUser;
        }

        private void StatisticsNav_Click(object sender, RoutedEventArgs e)
        {
            //Frame.Navigate(typeof(StatisticsPage));
        }
    }
}
