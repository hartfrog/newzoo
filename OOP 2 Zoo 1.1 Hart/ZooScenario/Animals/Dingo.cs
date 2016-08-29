﻿namespace ZooScenario
{
    /// <summary>
    /// The class which is used to represent a dingo.
    /// </summary>
    public class Dingo : Mammal
    {
        /// <summary>
        /// Initializes a new instance of the Dingo class.
        /// </summary>
        /// <param name="name">The name of the animal.</param>
        /// <param name="age">The age of the animal.</param>
        /// <param name="weight">The weight of the animal (in pounds).</param>
        public Dingo(string name, int age, double weight)
            : base(name, age, weight)
        {
            this.BabyWeightPercentage = 10.0;
        }

        /// <summary>
        /// Eats the specified food.
        /// </summary>
        /// <param name="food">The food to eat.</param>
        public override void Eat(Food food)
        {
            base.Eat(food);

            this.BuryBone(food);

            this.DigUpAndEatBone();

            this.Bark();
        }

        /// <summary>
        /// Makes a barking noise.
        /// </summary>
        private void Bark()
        {
            // Bark in excitement.
        }

        /// <summary>
        /// Buries the specified bone.
        /// </summary>
        /// <param name="bone">The bone to be buried.</param>
        private void BuryBone(Food bone)
        {
            // Bury bone.
        }

        /// <summary>
        /// Digs up an existing bone and eats it.
        /// </summary>
        private void DigUpAndEatBone()
        {
            // Dig up bone.

            // Eat bone.
        }
    }
}