using CookingBook.Pages;
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

namespace CookingBook
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    { 
        public Page1 homePage;
        public Page2 pervojePage;
        public vtorojePage vtorojePage;
        public desserts desserts;
        public Drinks drinks;

    
        public MainWindow()
        {
            InitializeComponent();
            homePage = new Page1();
            pervojePage = new Page2();
            vtorojePage = new vtorojePage();
            drinks = new Drinks();
            desserts = new desserts();
        }

        private void First_Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.Navigate(new Page1());
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.Content = homePage;

        }
        private void Home_MouseEnter(object sender, MouseEventArgs e)
        {
            Home.Width = 100;
        }

        private void Home_MouseLeave(object sender, MouseEventArgs e)
        {
            Home.Width = 90;
        }

        private void pervoje_Click(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.Content = pervojePage;

        }
        private void pervoje_MouseEnter(object sender, MouseEventArgs e)
        {
            pervoje.Width = 100;
        }

        private void pervoje_MouseLeave(object sender, MouseEventArgs e)
        {
            pervoje.Width = 90;
        }

        private void vtoroje_Click(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.Content = vtorojePage;
        }

        private void vtoroje_MouseEnter(object sender, MouseEventArgs e)
        {
            vtoroje.Width = 100;
        }

        private void vtoroje_MouseLeave(object sender, MouseEventArgs e)
        {
            vtoroje.Width = 90;
        }

        private void deserti_Click(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.Content = desserts;

        }
        private void deserti_MouseEnter(object sender, MouseEventArgs e)
        {
            deserti.Width = 100;
        }

        private void deserti_MouseLeave(object sender, MouseEventArgs e)
        {
            deserti.Width = 90;
        }

        private void napitki_Click(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.Content = drinks;

        }
        private void napitki_MouseEnter(object sender, MouseEventArgs e)
        {
            napitki.Width = 100;
        }

        private void napitki_MouseLeave(object sender, MouseEventArgs e)
        {
            napitki.Width = 90;
        }

      

      
    }
}
