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

namespace WpfEventsApp
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

        private void Button_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string message = e.Source.ToString() + "\n";
            message += e.OriginalSource.ToString() + "\n";
            message += e.RoutedEvent.ToString() + "\n";
            MessageBox.Show($"Button event handler\n{message}");
            //e.Handled = true;
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string message = e.Source.ToString() + "\n";
            message += e.OriginalSource.ToString() + "\n";
            message += e.RoutedEvent.ToString() + "\n";
            MessageBox.Show($"Stack Panel event handler\n{message}");
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string message = e.Source.ToString() + "\n";
            message += e.OriginalSource.ToString() + "\n";
            message += e.RoutedEvent.ToString() + "\n";
            MessageBox.Show($"Window event handler\n{message}");
        }

        private void Button_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            string message = e.Source.ToString() + "\n";
            message += e.OriginalSource.ToString() + "\n";
            message += e.RoutedEvent.ToString() + "\n";
            MessageBox.Show($"Button event handler\n{message}");
        }

        private void StackPanel_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            string message = e.Source.ToString() + "\n";
            message += e.OriginalSource.ToString() + "\n";
            message += e.RoutedEvent.ToString() + "\n";
            MessageBox.Show($"Stack Panel event handler\n{message}");
        }

        private void Window_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            string message = e.Source.ToString() + "\n";
            message += e.OriginalSource.ToString() + "\n";
            message += e.RoutedEvent.ToString() + "\n";
            MessageBox.Show($"Window event handler\n{message}");
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton rb = (RadioButton)e.Source;
            txt.Text = rb.Content.ToString();
        }

        private void txt2_KeyDown(object sender, KeyEventArgs e)
        {
            txt3.Text += e.Key.ToString();
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            txt3.Text = e.GetPosition(txt2).ToString();
        }

        private void btn_Drop(object sender, DragEventArgs e)
        {
            btn.Content = e.Data.GetData(DataFormats.Text);
        }

        private void txt2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragDrop.DoDragDrop(txt2, txt2.Text, DragDropEffects.Copy);
        }
    }
}
