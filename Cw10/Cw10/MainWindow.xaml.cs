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

namespace Cw10
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double a;
        double b;
        double w;
        public MainWindow()
        {
            InitializeComponent();

            
        }


        /* public void Dodaj()
         {
             a = Convert.ToDouble(liczbaA.Text);
             b = Convert.ToDouble(liczbaB.Text);
             w = a + b;
             wynik.Content = w.ToString();

         }

          private void Odejmij(object sender, RoutedEventArgs e)
         {
             a = Convert.ToDouble(liczbaA.Text);
             b = Convert.ToDouble(liczbaB.Text);
             w = a - b;
             wynik.Content = w.ToString();

         }

         private void Pomnoz(object sender, RoutedEventArgs e)
         {
             a = Convert.ToDouble(liczbaA.Text);
             b = Convert.ToDouble(liczbaB.Text);
             w = a * b;
             wynik.Content = w.ToString();

         }

         private void Podziel(object sender, RoutedEventArgs e)
         {
             a = Convert.ToDouble(liczbaA.Text);
             b = Convert.ToDouble(liczbaB.Text);
             w = a/b;
             wynik.Content = w.ToString();

         }
         */

        string var;
        
        public void ComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> data = new List<string>();
            data.Add("Dod");
            data.Add("Ode");
            data.Add("Pomn");
            data.Add("Podzi");

            var comboBox = sender as ComboBox;
            comboBox.ItemsSource = data;
            comboBox.SelectedIndex = 1;

           
            string value = comboBox.SelectedItem as string;
            this.Title = "Selected: " + value;




        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        public void Wyk(object sender, RoutedEventArgs e)
        {
            if ( ComboBox_Loaded.value == "Dod")
            {
                a = Convert.ToDouble(liczbaA.Text);
                b = Convert.ToDouble(liczbaB.Text);
                w = a + b;
                var = w.ToString();
                MessageBox.Show(var);
            }

            else if (value == "Ode")
            {
                a = Convert.ToDouble(liczbaA.Text);
                b = Convert.ToDouble(liczbaB.Text);
                w = a - b;
                var = w.ToString();
                MessageBox.Show(var);
            }

            else if (value == "Pomn")
            {
                a = Convert.ToDouble(liczbaA.Text);
                b = Convert.ToDouble(liczbaB.Text);
                w = a * b;
                var = w.ToString();
                MessageBox.Show(var);
            }

            else if (value == "Podzi")
            {
                a = Convert.ToDouble(liczbaA.Text);
                b = Convert.ToDouble(liczbaB.Text);
                w = a / b;
                var = w.ToString();
                MessageBox.Show(var);
            }
        }
    }
}
