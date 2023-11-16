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

namespace wpfTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAbout_Click(object sender, RoutedEventArgs e)
        {
            var aboutUC=new AboutUC();  
            secondGrid.Children.Clear();
            secondGrid.Children.Add(aboutUC);
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            var homeUC=new HomeUC();
            secondGrid.Children.Clear();
            secondGrid.Children.Add(homeUC);
        }
    }
}
