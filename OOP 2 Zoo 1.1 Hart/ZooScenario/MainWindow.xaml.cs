using System.Windows;

namespace ZooScenario
{
    /// <summary>
    /// Contains interaction logic for MainWindow.xaml.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.NamingRules", "SA1300:ElementMustBeginWithUpperCaseLetter", Justification = "Event handlers may begin with lower-case letters.")]
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Minnesota's Como Zoo.
        /// </summary>
        private Zoo comoZoo;

        /// <summary>
        /// Initializes a new instance of the MainWindow class.
        /// </summary>
        public MainWindow()
        {
            this.InitializeComponent();

#if DEBUG
            this.Title += " [DEBUG]";
#endif
        }

        /// <summary>
        /// Creates a zoo and related objects.
        /// </summary>
        /// <param name="sender">The object that initiated the event.</param>
        /// <param name="e">The event arguments for the event.</param>
        private void newZooButton_Click(object sender, RoutedEventArgs e)
        {
            // Create an instance of the Zoo class.
            this.comoZoo = new Zoo("Como Zoo", 1000, 4, 0.75m, 15.0m, new Employee("Sam", 42), new Employee("Flora", 98));

            // Set the initial money balance of the animal snack machine.
            this.comoZoo.AnimalSnackMachine.AddMoney(42.75m);

            // Define an animal variable.
            Animal animal;

            // Create Dolly.
            animal = new Dingo("Dolly", 4, 35.3);

            // Make Dolly pregnant.
            animal.MakePregnant();

            // Add Dolly to the zoo's animal list.
            this.comoZoo.AddAnimal(animal);

            // Create Dixie.
            animal = new Dingo("Dixie", 3, 33.8);

            // Make Dixie pregnant.
            animal.MakePregnant();

            // Add Dixie to the zoo's animal list.
            this.comoZoo.AddAnimal(animal);

            // Create Patty.
            animal = new Platypus("Patty", 2, 15.5);

            // Make Patty pregnant.
            animal.MakePregnant();

            // Add Patty to the zoo's animal list.
            this.comoZoo.AddAnimal(animal);

            // Create Harold.
            animal = new Hummingbird("Harold", 1, 0.008);

            // Add Harold to the zoo's animal list.
            this.comoZoo.AddAnimal(animal);

            // Create Greg and add him to the zoo's guest list.
            this.comoZoo.AddGuest(new Guest("Greg", 44, 150.35m, "Brown"));

            // Create Darla and add her to the zoo's guest list.
            this.comoZoo.AddGuest(new Guest("Darla", 11, 5.25m, "Salmon"));
        }
    }
}