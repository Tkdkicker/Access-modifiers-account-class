namespace Access_modifiers_account_class
{
    internal class Program
    {
        Account account = new Account();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your bank account");
            Program menu = new Program();
            menu.Menu();
        }

        /// <summary>
        /// The instructions of how to get to parts of seeing your bank
        /// </summary>
        public void Menu()
        {
            Console.WriteLine("________________________________________________________________________");
            Console.WriteLine("What do you want to do today?:" +
                    "\nSee your 'account', 'balance', 'add interest' or 'set interest' (current balance times the interest rate which is 2)");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "account":
                    account.GetAccountNumber();
                    break;

                case "balance":
                    account.GetCurrentBalance();
                    break;

                case "add interest":
                    account.AddInterest();
                    break;

                case "set interest":
                    account.SetInterestRate();
                    break;
            }
            Console.WriteLine("________________________________________________________________________");
        }

        /// <summary>
        /// Takes you back to the menu
        /// </summary>
        public void ReturnToMenu()
        {
            Console.WriteLine("Taking you back to the menu");
            Program menu = new Program();
            menu.Menu();
        }
    }
}