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

namespace CookingBook.Pages
{
    /// <summary>
    /// Interaction logic for DynamicPage.xaml
    /// </summary>
    public partial class DynamicPage : Page
    {
        public DynamicPage(string header, string content, string category)
        {
            InitializeComponent();
            DataContext = header;
            recipeHeaderDynamic.Text = header;
            recipeMethodDynamic.Text = content;


        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
