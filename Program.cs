using System.ComponentModel.Design;

namespace Currency_Rate_system
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] CurrencyCodes = { "USD", "EUR", "AUD", "ARS", "BYN", "BRL", "AED" };
            decimal[] CurrencyRates = { 1.7000M, 1.8455M, 1.1325M, 0.0019M, 0.5195M, 0.3314M, 0.4628M };
            bool runningOfSystem = true;

            while (runningOfSystem)
            {
                Console.WriteLine("Current commands");
                Console.WriteLine("Show recent currency rates");
                Console.WriteLine("Find currency rate by code");
                Console.WriteLine("Calculate amount by currecy");
                Console.WriteLine("exit");
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
                else if (command == "Find currency rate by code")
                {
                    Console.WriteLine("Enter code of currency: ");
                    string codeOfCurrency = Console.ReadLine().ToUpper();
                    bool founded = false;
                    int i = 0;
                    
                    while (i < CurrencyCodes.Length)
                    {
                        if (CurrencyCodes[i] == codeOfCurrency)
                        {
                            Console.WriteLine($"{codeOfCurrency}: {CurrencyRates[i]}");
                            founded = true;
                            break;
                        }
                        i++;

                    }
                    if (!founded)
                    {
                        Console.WriteLine($"{codeOfCurrency} not found on system. ");
                    }
                }
                else if(command == "Calculate amount by currecy")
                {
                    Console.WriteLine("enter amount: ");
                    int amount = int.Parse(Console.ReadLine());
                    if (amount>0)
                    {
                        Console.WriteLine("enter code of currency");
                        string codeOfCurrency = Console.ReadLine().ToUpper();
                        int i = 0;
                        bool founded = false;
                        while(i< CurrencyCodes.Length)
                        {
                            if (CurrencyCodes[i] == codeOfCurrency)
                            {
                                decimal rate = CurrencyRates[i];
                                decimal convertAmount = rate*amount;
                                Console.WriteLine( convertAmount + "AZN");
                                founded = true;
                                break;
                            }
                            i++;
                        }
                        if (!founded)
                        {
                            Console.WriteLine("currency not founded");
                        }
                    }
                    else
                    {
                        Console.WriteLine("entered false amount");
                    }
                }
                else if(command == "exit")
                {
                    runningOfSystem = false;
                }
                else
                {
                    Console.WriteLine("entered wrong command");
                }


            }
        }
    }
}
    

