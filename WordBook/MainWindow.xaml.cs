using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;
using System.IO;
using System.Data;

namespace WordBook
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Dictionary<string, Uri> allViews = new Dictionary<string, Uri>();
        
        public MainWindow()
        {
            InitializeComponent();                     
            allViews.Add("ViewPage", new Uri("FunctionUI/ViewPage.xaml", UriKind.Relative));
            allViews.Add("Summary", new Uri("FunctionUI/Summary.xaml", UriKind.Relative));
            allViews.Add("WritePage", new Uri("FunctionUI/WritePage.xaml", UriKind.Relative));
            allViews.Add("SessionPage", new Uri("FunctionUI/CardList.xaml", UriKind.Relative));
            NavigateFun("Summary");
          
            
        }

        public void NavigateFun(string pageName)
        {
            
            this.fraMain.Navigate(allViews[pageName]);
        }

       
        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                DragMove();
            }
            catch { }
        }
        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;
        }

        private void StackPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            NavigateFun("Summary");
        }

        private void StackPanel_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            NavigateFun("ViewPage");
        }

        private void StackPanel_MouseLeftButtonDown_2(object sender, MouseButtonEventArgs e)
        {
            NavigateFun("WritePage");
        }

        private void StackPanel_MouseLeftButtonDown_3(object sender, MouseButtonEventArgs e)
        {
            NavigateFun("SessionPage");
        }

        

    }
}
