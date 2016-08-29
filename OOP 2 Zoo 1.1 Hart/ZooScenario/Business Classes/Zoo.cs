using System;
using System.Collections.Generic;

namespace ZooScenario
{
    /// <summary>
    /// The class which is used to represent a zoo.
    /// </summary>
    public class Zoo
    {
        /// <summary>
        /// A list of all animals currently residing within the zoo.
        /// </summary>
        private List<Animal> animals;

        /// <summary>
        /// The zoo's vending machine which allows guests to buy snacks for animals.
        /// </summary>
        private VendingMachine animalSnackMachine;

        /// <summary>
        /// The zoo's room for birthing animals.
        /// </summary>
        private BirthingRoom b168;

        /// <summary>
        /// The maximum number of guests the zoo can accommodate at a given time.
        /// </summary>
        private int capacity;

        /// <summary>
        /// A list of all guests currently visiting the zoo.
        /// </summary>
        private List<Guest> guests;

        /// <summary>
        /// The zoo's ladies' restroom.
        /// </summary>
        private Restroom ladiesRoom;

        /// <summary>
        /// The zoo's men's restroom.
        /// </summary>
        private Restroom mensRoom;

        /// <summary>
        /// The name of the zoo.
        /// </summary>
        private string name;

        /// <summary>
        /// The zoo's ticket booth.
        /// </summary>
        private Booth ticketBooth;

        /// <summary>
        /// Initializes a new instance of the Zoo class.
        /// </summary>
        /// <param name="name">The name of the zoo.</param>
        /// <param name="capacity">The maximum number of guests the zoo can accommodate at a given time.</param>
        /// <param name="restroomCapacity">The capacity of the zoo's restrooms.</param>
        /// <param name="animalFoodPrice">The price of a pound of food from the zoo's animal snack machine.</param>
        /// <param name="ticketPrice">The price of an admission ticket to the zoo.</param>
        /// <param name="attendant">The zoo's ticket booth attendant.</param>
        /// <param name="vet">The zoo's birthing room vet.</param>
        public Zoo(string name, int capacity, int restroomCapacity, decimal animalFoodPrice, decimal ticketPrice, Employee attendant, Employee vet)
        {
            this.animals = new List<Animal>();
            this.animalSnackMachine = new VendingMachine(animalFoodPrice);
            this.b168 = new BirthingRoom(vet);
            this.capacity = capacity;
            this.guests = new List<Guest>();
            this.ladiesRoom = new Restroom(restroomCapacity, "Female");
            this.mensRoom = new Restroom(restroomCapacity, "Male");
            this.name = name;
            this.ticketBooth = new Booth(attendant, ticketPrice);
        }

        /// <summary>
        /// Gets the zoo's animal snack machine.
        /// </summary>
        public VendingMachine AnimalSnackMachine
        {
            get
            {
                return this.animalSnackMachine;
            }
        }

        /// <summary>
        /// Gets the temperature of the zoo's birthing room.
        /// </summary>
        public double BirthingRoomTemperature
        {
            get
            {
                return this.b168.Temperature;
            }
        }

        /// <summary>
        /// Gets the total weight of all animals in the zoo.
        /// </summary>
        public double TotalAnimalWeight
        {
            get
            {
                double totalWeight = 0;

                // Loop through the zoo's list of animals.
                foreach (Animal a in this.animals)
                {
                    // Add the current animal's weight to the total.
                    totalWeight += a.Weight;
                }

                return totalWeight;
            }
        }

        /// <summary>
        /// Adds an animal to the zoo.
        /// </summary>
        /// <param name="animal">The animal to add.</param>
        public void AddAnimal(Animal animal)
        {
            this.animals.Add(animal);
        }

        /// <summary>
        /// Adds a guest to the zoo.
        /// </summary>
        /// <param name="guest">The guest to add.</param>
        public void AddGuest(Guest guest)
        {
            this.guests.Add(guest);
        }

        /// <summary>
        /// Aids a reproducer in giving birth.
        /// </summary>
        /// <param name="reproducer">The reproducer that is to give birth.</param>
        public void BirthAnimal(IReproducer reproducer)
        {
            // Birth animal.
            IReproducer baby = this.b168.BirthAnimal(reproducer);

            // If the baby is an animal...
            if (baby is Animal)
            {
                // Add the baby to the zoo's list of animals.
                this.AddAnimal(baby as Animal);
            }
        }

        /// <summary>
        /// Find an animal based on type.
        /// </summary>
        /// <param name="type">The type of the animal to find.</param>
        /// <returns>The first matching animal.</returns>
        public Animal FindAnimal(Type type)
        {
            Animal animal = null;

            // Loop through the zoo's list of animals.
            foreach (Animal a in this.animals)
            {
                // If the type matches...
                if (a.GetType() == type)
                {
                    // Get the matching animal.
                    animal = a;

                    break;
                }
            }

            return animal;
        }

        /// <summary>
        /// Finds an animal based on type and pregnancy status.
        /// </summary>
        /// <param name="type">The type of the animal to find.</param>
        /// <param name="isPregnant">The pregnancy status of the animal to find.</param>
        /// <returns>The first matching animal.</returns>
        public Animal FindAnimal(Type type, bool isPregnant)
        {
            Animal animal = null;

            // Loop through the zoo's list of animals.
            foreach (Animal a in this.animals)
            {
                // If the type and pregnancy status match...
                if (a.GetType() == type && a.IsPregnant == isPregnant)
                {
                    // Get the matching animal.
                    animal = a;

                    break;
                }
            }

            return animal;
        }

        /// <summary>
        /// Finds a guest based on name.
        /// </summary>
        /// <param name="name">The name of the guest to find.</param>
        /// <returns>The first matching guest.</returns>
        public Guest FindGuest(string name)
        {
            Guest guest = null;

            // Loop through the zoo's list of guests.
            foreach (Guest g in this.guests)
            {
                // If the name matches...
                if (g.Name == name)
                {
                    // Get the matching guest.
                    guest = g;

                    break;
                }
            }

            return guest;
        }
    }
}