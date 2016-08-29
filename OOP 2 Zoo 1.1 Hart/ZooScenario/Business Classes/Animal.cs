using System;

namespace ZooScenario
{
    /// <summary>
    /// The class which is used to represent an animal.
    /// </summary>
    public abstract class Animal : IEater, IMover, IReproducer
    {
        /// <summary>
        /// The weight of a newborn baby (as a percentage of the parent's weight).
        /// </summary>
        private double babyWeightPercentage;

        /// <summary>
        /// The age of the animal.
        /// </summary>
        private int age;

        /// <summary>
        /// A value indicating whether or not the animal is pregnant.
        /// </summary>
        private bool isPregnant;

        /// <summary>
        /// The name of the animal.
        /// </summary>
        private string name;

        /// <summary>
        /// The weight of the animal (in pounds).
        /// </summary>
        private double weight;

        /// <summary>
        /// Initializes a new instance of the Animal class.
        /// </summary>
        /// <param name="name">The name of the animal.</param>
        /// <param name="age">The age of the animal.</param>
        /// <param name="weight">The weight of the animal (in pounds).</param>
        public Animal(string name, int age, double weight)
        {
            this.age = age;
            this.name = name;
            this.weight = weight;
        }

        /// <summary>
        /// Gets or sets the weight of a newborn baby (as a percentage of the parent's weight).
        /// </summary>
        public double BabyWeightPercentage
        {
            get
            {
                return this.babyWeightPercentage;
            }

            protected set
            {
                this.babyWeightPercentage = value;
            }
        }

        /// <summary>
        /// Gets a value indicating whether or not the animal is pregnant.
        /// </summary>
        public bool IsPregnant
        {
            get
            {
                return this.isPregnant;
            }
        }

        /// <summary>
        /// Gets or sets the animal's weight (in pounds).
        /// </summary>
        public double Weight
        {
            get
            {
                return this.weight;
            }

            protected set
            {
                this.weight = value;
            }
        }

        /// <summary>
        /// Eats the specified food.
        /// </summary>
        /// <param name="food">The food to eat.</param>
        public virtual void Eat(Food food)
        {
            // Increase the animal's weight by the weight of the food eaten.
            this.Weight += food.Weight;
        }

        /// <summary>
        /// Makes the animal pregnant.
        /// </summary>
        public void MakePregnant()
        {
            this.isPregnant = true;
        }

        /// <summary>
        /// Moves the animal.
        /// </summary>
        public abstract void Move();

        /// <summary>
        /// Creates another reproducer of its own type.
        /// </summary>
        /// <returns>The resulting baby reproducer.</returns>
        public virtual IReproducer Reproduce()
        {
            // Create a new reproducer.
            IReproducer baby = Activator.CreateInstance(this.GetType(), "Baby", 0, this.Weight * (this.BabyWeightPercentage / 100)) as IReproducer;

            // Reduce the parent's weight.
            this.Weight -= baby.Weight * 1.25;

            // Make the parent to be no longer pregnant.
            this.isPregnant = false;

            return baby;
        }

        /// <summary>
        /// Generates a string representation of the animal.
        /// </summary>
        /// <returns>A string representation of the animal.</returns>
        public override string ToString()
        {
            return this.name + ": " + this.GetType().Name + " (" + this.age + ", " + this.Weight + ")";
        }
    }
}