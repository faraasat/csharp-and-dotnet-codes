using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
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

namespace _49.Threads_In_WPF_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public static readonly DependencyProperty HtmlProperty = DependencyProperty.RegisterAttached(
            "HTML",
            typeof(string),
            typeof(MainWindow),
            new FrameworkPropertyMetadata(OnHtmlChanged));

        public MainWindow()
        {
            InitializeComponent();
        }

        private void myButton_Click(object sender, RoutedEventArgs e)
        {

            Debug.WriteLine($"Thread Number is {Thread.CurrentThread.ManagedThreadId}");
            Task.Run(() =>
            {
                Debug.WriteLine($"Thread Number is {Thread.CurrentThread.ManagedThreadId}");
                HttpClient webClient = new HttpClient();
                string html = webClient.GetStringAsync("https://google.com").Result;

                myButton.Dispatcher.Invoke(() =>
                {
                    Debug.WriteLine($"Thread Number is {Thread.CurrentThread.ManagedThreadId} owns my button");
                    myButton.Content = "Done";
                });

            });

        }

        private async void myButton_Click2(object sender, RoutedEventArgs e)
        {

            string myHtml = "Bla";

            Debug.WriteLine($"Thread Number is {Thread.CurrentThread.ManagedThreadId} before awaiting task");

            await Task.Run(async () => // To make button Asyncronous
            {
                Debug.WriteLine($"Thread Number is {Thread.CurrentThread.ManagedThreadId} during awaiting task");
                HttpClient webClient = new HttpClient();
                string html = webClient.GetStringAsync("https://google.com").Result;
                myHtml = html;
            });

            Debug.WriteLine($"Thread Number is {Thread.CurrentThread.ManagedThreadId} after awaiting task");
            myButton.Content = "Done Downloading";
            MyWebBrowser.SetValue(HtmlProperty, myHtml);

        }

        static void OnHtmlChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
        {
            WebBrowser webBrowser = dependencyObject as WebBrowser;
            if(webBrowser != null)
            {
                webBrowser.NavigateToString(e.NewValue as string);
            }
        }

    }
}
