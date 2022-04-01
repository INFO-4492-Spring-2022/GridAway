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
using SharedItems;

namespace GridAway {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        private int count = 0;
        public MainWindow() {
            InitializeComponent();

            Superhero sup = new Superhero("Bob");
            Lair<string> hallOfJustice = new Lair<string>();
            //hallOfJustice.Add(new Superhero());

            //hallOfJustice.Add(new Villian("Sally","Super"));

            //hallOfJustice.Add(new Citizen("Wally","Woofer"));

            //hallOfJustice.Add();

            //List<string> lst;


            SpaceShip<Citizen,Superhero,string> ship = new SpaceShip<Citizen,Superhero, string>();
            Citizen cit = new Citizen("", "");
            ship.Pilot = cit;
            ship.Passengers.Add(sup);
            ship.Title = "Boo";

            SpaceShip<Citizen,Citizen, bool> normShip = new SpaceShip<Citizen,Citizen, bool>();
            normShip.Pilot = cit;
            normShip.Passengers.Add(cit);
            normShip.Title = true;

            SpaceShip<Witch,Broom, int> broomShip = new SpaceShip<Witch, Broom, int>();
            broomShip.Pilot = new Witch("hilda","Broomwich");
            broomShip.Passengers.Add(new Broom(broomShip.Pilot,"Brown"));
            broomShip.Title = 23;


        }

        private void btnShowStuff_Click(object sender, RoutedEventArgs e) {
            Button btn = new Button();
            btn.Content = "New Button";
            grdButtons.Children.Add(btn);
        }

        private void btnAddRandom_Click(object sender, RoutedEventArgs e) {
            count++;
            TextBlock btn = new TextBlock();
            btn.Text = "Item " + count;
            grdButtons.Children.Add(btn);

            int maxRow = grdButtons.RowDefinitions.Count();
            int maxCol = grdButtons.ColumnDefinitions.Count();
            Random rnd = new Random();
            Grid.SetRow(btn, rnd.Next(maxRow));
            Grid.SetColumn(btn, rnd.Next(maxCol));

        }
    }
}
