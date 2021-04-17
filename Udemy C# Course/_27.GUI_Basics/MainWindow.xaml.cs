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

namespace _27.GUI_Basics
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // To Create same button as XAML
            /*Grid grid = new Grid();
            this.Content = grid;
            Button btn = new Button();
            btn.FontSize = 26;
            btn.Width = 150;
            btn.Height = 50;
            btn.Background = Brushes.Lime;
            WrapPanel wp = new WrapPanel();

            TextBlock tb = new TextBlock();
            tb.Text = "Text";
            tb.Foreground = Brushes.BlueViolet;
            wp.Children.Add(tb);

            tb = new TextBlock();
            tb.Text = "By";
            tb.Foreground = Brushes.Chocolate;
            wp.Children.Add(tb);

            tb = new TextBlock();
            tb.Text = "Code";
            tb.Foreground = Brushes.Lavender;
            wp.Children.Add(tb);

            btn.Content = wp;
            grid.Children.Add(btn);*/

        }
    }
}
