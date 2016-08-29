namespace ZooScenario
{
    /// <summary>
    /// The class which is used to represent a mammal.
    /// </summary>
    public abstract class Mammal : Animal
    {
        /// <summary>
        /// Initializes a new instance of the Mammal class.
        /// </summary>
        /// <param name="name">The name of the animal.</param>
        /// <param name="age">The age of the animal.</param>
        /// <param name="weight">The weight of the animal (in pounds).</param>
        public Mammal(string name, int age, double weight)
            : base(name, age, weight)
        {
        }

        /// <summary>
        /// Moves by pacing.
        /// </summary>
        public override void Move()
        {
            // Pace.
        }

        /// <summary>
        /// Creates another reproducer of its own type.
        /// </summary>
        /// <returns>The resulting baby reproducer.</returns>
        public override IReproducer Reproduce()
        {
            // Create a new reproducer.
            IReproducer baby = base.Reproduce();

            // If the baby is not a platypus...
            if (this.GetType() != typeof(Platypus))
            {
                // If the baby is an eater...
                if (baby is IEater)
                {
                    // Feed the baby.
                    this.FeedNewborn(baby as IEater);
                }

                // If the baby is a mover...
                if (baby is IMover)
                {
                    // Make the baby move.
                    (baby as IMover).Move();
                }
            }

            return baby;
        }

        /// <summary>
        /// Feeds a baby eater.
        /// </summary>
        /// <param name="newborn">The eater to feed.</param>
        private void FeedNewborn(IEater newborn)
        {
            // Determine milk weight.
            double milkWeight = this.Weight * 0.005;

            // Generate milk.
            Food milk = new Food(milkWeight);

            // Feed baby.
            newborn.Eat(milk);

            // Reduce parent's weight.
            this.Weight -= milkWeight;
        }
    }
}