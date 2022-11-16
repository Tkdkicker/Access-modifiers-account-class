namespace Access_modifiers_account_class
{
    public class Account
    {
        private string _accountNumber = "00378657";
        private DateTime _openingDate = DateTime.Now;
        private int _currentBalance = 10000;
        private float _interestRate = 2;

        /// <summary>
        /// Access the private variable
        /// </summary>
        /// <param name="currentBalance"></param>
        /// <returns></returns>
        public int CurrentBalanceVar(int currentBalance = 10000)
        {
            return _currentBalance = currentBalance;
        }

        /// <summary>
        /// See your unique account number on todays date
        /// </summary>
        public void GetAccountNumber()
        {
            Console.WriteLine($"Your account number is: {_accountNumber} at {_openingDate}");
            Console.WriteLine("________________________________________________________________________");
            Program menu = new Program();
            menu.ReturnToMenu();
        }

        /// <summary>
        /// Tells your balance.
        /// Then asks if you want to make a payment, if 'yes' you choose one, if 'not' you can choose to set up a mortgage amount
        /// Otherwise you go back to the menu
        /// </summary>
        public void GetCurrentBalance()
        {
            Console.WriteLine("________________________________________________________________________");
            Console.WriteLine($"Your current balance is: {_currentBalance}");
            Console.WriteLine("Do you want to make a payment?");
            string answer = Console.ReadLine();

            if (answer == "yes" || answer == "Yes")
            {
                Current current = new Current();
                current.SetPaymentType();
            }
            if (answer == "no" || answer == "No")
            {
                Console.Write("Do you want to take out a mortgage?");
                string userInput = Console.ReadLine();
                if (userInput == "Yes" || userInput == "yes")
                {
                    Mortgage mortgage = new Mortgage();
                    mortgage.GetEndDate();
                    mortgage.SetEndDate();
                    return;
                }
                Console.WriteLine("Ok, taking you back to the main menu");
                Console.WriteLine("________________________________________________________________________");
                Program menu = new Program();
                menu.Menu();
            }
        }

        /// <summary>
        /// See the interest rate of your money
        /// </summary>
        public void AddInterest()
        {
            Console.WriteLine("________________________________________________________________________");
            Console.WriteLine($"The interest rate is: {_interestRate}");
            Console.WriteLine("________________________________________________________________________");
            Program menu = new Program();
            menu.ReturnToMenu();
        }

        /// <summary>
        /// Set the interest rate of your money
        /// </summary>
        public void SetInterestRate()
        {
            Console.WriteLine("________________________________________________________________________");
            _interestRate = _currentBalance * _interestRate;
            Console.WriteLine("________________________________________________________________________");
            Program menu = new Program();
            menu.ReturnToMenu();
        }
    }
}