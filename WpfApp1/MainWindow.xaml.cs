using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static List<classszeleromu> szeleromuadatok = new List<classszeleromu>(); 
        public MainWindow()
        {
            InitializeComponent();
            Beolvasas();
            
        }

        static void Beolvasas()
        {

            StreamReader olvas = new StreamReader("szeleromu.txt");
            olvas.ReadLine();
            while (!olvas.EndOfStream)
            {
                string[] adat = olvas.ReadLine().Split(';');

                szeleromuadatok.Add(
                    adat[0], int.Parse(adat[1]), int.Parse(adat[2]), int.Parse(adat[3]));
            }

            

            olvas.Close();
            dataGridSzeleromu.ItemsSource = szeleromuadatok;


        }


        private void Btnegysegszam_Click(object sender, RoutedEventArgs e)
        {
            //lblegysegszam.Content =
        }

        private void Btnosszes_Click(object sender, RoutedEventArgs e)
        {
           lblosszes.Content = szeleromuadatok.Count();
        }

        private void Btnkategoria_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Btnatlagteljesitmeny_Click(object sender, RoutedEventArgs e)
        {
            lblatlagteljesitmeny.Content = Math.Round(szeleromuadatok.Average()[2], 2) ;

        }

        private void Btnlegnagyobbteljesitmeny_Click(object sender, RoutedEventArgs e)
        {
            lbllegnagyobbteljesitmeny.Content = szeleromuadatok.Max();
        }

        private void Btnjelentes_Click(object sender, RoutedEventArgs e)
        {
           // lbljelentes.Content =

        }


        private void lbadatok(object sender, SelectionChangedEventArgs e)
        {

        }
    }

}
