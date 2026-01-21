using System;
namespace BankProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********Bank Application***********");
            Console.WriteLine("Enter login details::");

            string username = "",password = null;

            Console.WriteLine("Please enter the username :: ");
            username = Console.ReadLine();
            if (username != "")
            {
                Console.WriteLine("Please enter the password :: ");
                password = Console.ReadLine();

                if(username == "system" && password == "admin")
                {
                    int mainMenuChoice = -1;
                    do
                    {
                        Console.WriteLine("\n::Main Menu::");
                        Console.WriteLine("1. Customer");
                        Console.WriteLine("2. Accounts");
                        Console.WriteLine("3. Funds Transfer");
                        Console.WriteLine("4. Funds Transfer Statement");
                        Console.WriteLine("5. Account Statement");
                        Console.WriteLine("0.  Exit");

                        Console.WriteLine("Enter the choice :: ");
                        mainMenuChoice = int.Parse(Console.ReadLine());

                        switch (mainMenuChoice)
                        {
                            case 0: break;
                            case 1: CustomerMenu(); 
                                break;
                            case 2: AccountsMenu(); 
                                break;
                            case 3: //Display Funds Transfer Menu
                                break;
                            case 4: //Display Funds transfer statement
                                break;
                            case 5: //Display Accounts Statement
                                break;

                        }
                    } while (mainMenuChoice!=0);
                }
                else
                {
                    Console.WriteLine("Invalid credentials!!");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid username!");
            }
            Console.WriteLine("Application closed");
        }
        static void CustomerMenu()
        {
            //variable to store customers menu
            int customerMenuChoice = -1;

            do
            {
                Console.WriteLine("\n::Customer Menu::");
                Console.WriteLine("1. Add Customer");
                Console.WriteLine("2. Delete Customer");
                Console.WriteLine("3. Update Customer");
                Console.WriteLine("4. View Customer");
                Console.WriteLine("0. Back to Main Menu");

                //accept customer choice
                Console.WriteLine("Enter choice :: ");
                customerMenuChoice = Convert.ToInt32(Console.ReadLine());

            } while (customerMenuChoice!=0);
            
        }

        static void AccountsMenu()
        {
            int accountMenuChoice = -1;
            do
            {
                Console.WriteLine("\n::Accounts Menu::");
                Console.WriteLine("1. Add Account");
                Console.WriteLine("2. Delete Account");
                Console.WriteLine("3. Update Account");
                Console.WriteLine("4. View Accounts");
                Console.WriteLine("0. Back to Main Menu");

                Console.WriteLine("Enter the choice :: ");
                accountMenuChoice = Convert.ToInt32(Console.ReadLine());

            } while (accountMenuChoice!=0);
        }
    }
}
