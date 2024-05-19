namespace Currency_Rate_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] CurrencyCodes = { "USD","EUR", "AUD", "ARS", "BYN", "BRL", "AED" };
            decimal[] CurrencyRates = { 1.7000M, 1.8455M, 1.1325M, 0.0019M, 0.5195M, 0.3314M, 0.4628M };

            while (true)
            {
                Console.WriteLine("Current commands");
                Console.WriteLine("Show recent currency rates");
                Console.WriteLine("Find currency rate by code");
                Console.WriteLine("Calculate amount by currecy");
                Console.WriteLine("Enter one command: ");
                string command = Console.ReadLine();
                if (command == "Show recent currency rates")
                {
                    Console.WriteLine("Show recent currency rates are: ");
                    int i = 0;
                    while (i < CurrencyCodes.Length)
                    {
                        Console.WriteLine($"{CurrencyCodes[i]}: {CurrencyRates[i]}");
                        i++;
                    }

                }

           
        }
    }
}
