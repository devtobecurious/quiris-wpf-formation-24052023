using CarteMaraudeurSW.Core.Models;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CarteMaraudeurSW.WPF.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static Random random = new();

        public MainWindow()
        {
            InitializeComponent();
            this.btnOpen.Click += btnOpen_Click;
            this.btnOpen.Click += AfficherMaraudeur;

            this.btnOpen.Content = "Open maraudeur";
            this.btnOpen.Style = this.Resources["VioletSmallButton"] as Style;

            this.lstWookies.ItemsSource = new List<Wookiee>()
            {
                new () { Libelle = "Chewie", Id = 1, Avatar = "pack://application:,,,/Images/wookie.png" },
                new () { Libelle = "Chewa", Id = 2 }
            };


        }

        private void btnMove_Click(object sender, RoutedEventArgs e)
        {
            this.btnPerso.RenderTransform = new TranslateTransform(random.Next(-500, 500), random.Next(-500, 500));
        }

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Coucou");
        }

        private void AfficherMaraudeur(object sender, RoutedEventArgs e)
        {
            Maraudeur maraudeur = new();
            // maraudeur.Show();
            maraudeur.ShowDialog();
        }

        private void btnChangeStyleButton_Click(object sender, RoutedEventArgs e)
        {
            //this.btnOpen.Foreground = new SolidColorBrush(Colors.Red);
            this.Resources["ForeGroundButton"] = new SolidColorBrush(Colors.Red);
        }

        private void Label_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        
    }
}