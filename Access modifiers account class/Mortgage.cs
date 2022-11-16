namespace Access_modifiers_account_class
{
    public class Mortgage : Account
    {
        private DateTime _endDate;

        /// <summary>
        /// Tells you the current date of taking out the mortgage
        /// </summary>
        public void GetEndDate()
        {
            Console.WriteLine("________________________________________________________________________");
            _endDate = DateTime.Now;
            Console.WriteLine($"You have taken this out on the date: {_endDate}");
        }

        /// <summary>
        /// Tells you the changed date
        /// </summary>
        public void SetEndDate()
        {
            Console.WriteLine("________________________________________________________________________");
            Console.WriteLine("Enter the new date in the format of dd/mm/yyyy hh:mm: ");
            DateTime dateTime = DateTime.Parse(Console.ReadLine());
            _endDate = dateTime;
            Console.WriteLine($"And changed the date to: {dateTime}");
        }
    }
}