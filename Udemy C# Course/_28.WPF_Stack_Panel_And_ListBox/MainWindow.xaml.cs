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

namespace _28.WPF_Stack_Panel_And_ListBox
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hi There, Whats Up?\nThis is a Direct Event", "My Window");
        }

        // There are two types of events
        // Routed Events => WPF Mechanism to Handlle Events
        // Direct Routed Events => handled by the item by itself e.g. click
        private void Button_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Right Click of Mouse was realeased - Bubling Event\nThe Bubbling Event goes up to the " +
                "visual tree", "Bubbling Event");
        }

        private void Button_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Click of Mouse was realeased - Tunneling Event\nThe Tunneling Event goes down to the " +
                "visual tree", "Tunneling Event");
        }

        private void Button_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Mouse Button Went Down", "Button_PreviewMouseLeftButtonDown");
        }

        private void Button_PreviewMouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Mouse Button Went Up", "Button_PreviewMouseRightButtonUp");
        }
    }
}
