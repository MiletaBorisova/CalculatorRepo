using System.Runtime.CompilerServices;

namespace Calculator
{
    internal class StartUp
    {
        private static bool CheckCredentials()
        {
            Console.Write("Enter password to gain access: ");
            string password =  Console.ReadLine();
            Console.Clear();

            return password == Password;

        }

        private const string Password = "abcd1234";
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Console Calculator App");
                Console.WriteLine(new string('-', 15));

                Console.Write("a = ");
                double a = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

                Console.Write("b = ");
                double b = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

                Console.WriteLine("Choose one from the listed options:");
                foreach (string option in OptionsManager.OptionsList)
                {
                    Console.WriteLine($"\t{option}");
                }
                try
                {
                    Console.Write("Option: ");
                    string choice = Console.ReadLine();

                    if (choice == "ex")
                    {
                        break;
                    }
                    switch (choice)
                    {
                        case "a":
                            Console.WriteLine(OptionsManager.Add(a, b));
                            break;
                        case "s":
                            Console.WriteLine(OptionsManager.Subtract(a, b));
                            break;
                        case "m":
                            Console.WriteLine(OptionsManager.Multiply(a, b));
                            break;
                    }
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey(true);

                
            }
        }
    }
}
