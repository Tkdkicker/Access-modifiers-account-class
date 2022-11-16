namespace Access_modifiers_account_class
{
    public class Current : Account
    {
        private string _paymentType;
        private bool _overdraft;

        private int _amount;

        /// <summary>
        /// Choose a payment type then depending on the amount in the bank is where an overdraft opens
        /// </summary>
        public void SetPaymentType()
        {
            Console.WriteLine("________________________________________________________________________");
            Console.WriteLine("What payment type do you want to use?\nPaypal/Debit card/Credit card");
            _paymentType = Console.ReadLine();
            Console.WriteLine($"Ok, you chose {_paymentType}");
            Console.WriteLine("________________________________________________________________________");
            Console.WriteLine("How much money do you want to pay with?");
            _amount = int.Parse(Console.ReadLine());

            if (_paymentType == "Paypal" || _paymentType == "Debit card" || _paymentType == "Credit card")
            {
                Account account = new Account();
                if (account.CurrentBalanceVar(1000) > _amount)
                {
                    SetOverdraft();
                    GetOverdraft();
                }
                else
                {
                    Program menu = new Program();
                    menu.ReturnToMenu();
                }
            }
        }

        /// <summary>
        /// Sets the overdraft to true
        /// </summary>
        public void SetOverdraft()
        {
            Console.WriteLine("________________________________________________________________________");
            _overdraft = true;
            Console.WriteLine("________________________________________________________________________");
        }

        /// <summary>
        /// Tells you how much over you are over
        /// </summary>
        public void GetOverdraft()
        {
            Console.WriteLine("________________________________________________________________________");
            Console.WriteLine($"Your overdraft which is set to {_overdraft} is over by {_amount}.");
            Console.WriteLine("________________________________________________________________________");
        }
    }
}