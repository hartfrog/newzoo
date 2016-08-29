namespace ZooScenario
{
    /// <summary>
    /// The class which is used to represent a booth.
    /// </summary>
    public class Booth
    {
        /// <summary>
        /// The initial money balance of the booth.
        /// </summary>
        private readonly decimal initialMoneyBalance = 100.0m;

        /// <summary>
        /// The employee currently assigned to be the attendant of the booth.
        /// </summary>
        private Employee attendant;

        /// <summary>
        /// The amount of money currently in the booth.
        /// </summary>
        private decimal moneyBalance;

        /// <summary>
        /// The price of a ticket.
        /// </summary>
        private decimal ticketPrice;

        /// <summary>
        /// Initializes a new instance of the Booth class.
        /// </summary>
        /// <param name="attendant">The employee to be the booth's attendant.</param>
        /// <param name="ticketPrice">The price of a ticket.</param>
        public Booth(Employee attendant, decimal ticketPrice)
        {
            this.attendant = attendant;
            this.moneyBalance = this.initialMoneyBalance;
            this.ticketPrice = ticketPrice;
        }
    }
}