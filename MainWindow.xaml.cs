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

namespace SideMenuListControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //this is to set default page on application startup such as dashboard...etc..
            frame.Navigate(new Uri("Page1.xaml", UriKind.RelativeOrAbsolute));
        }

        private void SideMenuControl_SelectionChanged(object sender, EventArgs e)
        {
            switch (MenuList.SelectedIndex)
            {
                case 0:
                    frame.Navigate(new Uri("Page1.xaml", UriKind.RelativeOrAbsolute));
                    break;
                case 1:
                    frame.Navigate(new Uri("Page2.xaml", UriKind.RelativeOrAbsolute));
                    break;
            }
        }
    }
}
