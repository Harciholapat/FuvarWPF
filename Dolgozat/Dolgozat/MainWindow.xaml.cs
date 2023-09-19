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
using System.IO;

namespace Dolgozat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static List<Fuvar> fuvarokLista = new List<Fuvar>();
        public MainWindow()
        {
            InitializeComponent();

            string fajlNeve = "fuvar.csv";
            StreamReader sr = new StreamReader(fajlNeve);
            

            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                sor.Split(';');
                fuvarokLista.Add(new Fuvar(Convert.ToInt32(sor[0]), Convert.ToString(sor[1]), Convert.ToInt32(sor[2]), Convert.ToDouble(sor[3]),
                    Convert.ToDouble(sor[4]), Convert.ToDouble(sor[5]), Convert.ToString(sor[6])));
            }
            sr.Close();
            fuvarokLista.RemoveAt(0);
        }

        private void btn3Feladat_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Feljegzésre került utazások száma: {fuvarokLista.Count()}");
        }

        private void btn4feladat_Click(object sender, RoutedEventArgs e)
        {
            foreach(var item in  fuvarokLista.Where(i => i = 6185)) 
            {
                MessageBox.Show(fuvarokLista.Where(i => i == 6185)[4], fuvarokLista.Where(i => i == 6185)[5]);
            }
        }

        private void btn5feladat_Click(object sender, RoutedEventArgs e)
        {
            int kartya = 0;
            int kp = 0;

            foreach (var item in fuvarokLista)
            {
                if (item == "bankkárta" )
                {
                    kartya++;
                }
                if (item == "készpénz")
                {
                    kp++;
                }
            }

            MessageBox.Show($"Kártyás fizetések: {kartya}, Készpénzes fizetések: {kp}");

        }

        private void btn6feladat_Click(object sender, RoutedEventArgs e)
        {
            List<int> km = new List<int>();

            foreach (var item in fuvarokLista)
            {
                if (feladom)
                {
                    MessageBox.Show(fuvarokLista[item] * 1.6);
                }
            }
        }
    }
}
