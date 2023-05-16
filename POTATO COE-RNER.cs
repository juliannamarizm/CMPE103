// Marquez, Julianna Mariz D.

using System;
namespace potatoCorner {
    class Program {
        static void Main()
        {
            int quantity = 1;
            double = total = 0;
            Console.WriteLine("      Welcome to Potato Coe-ner!      ");
            Console.WriteLine("                                      ");
            Console.WriteLine("********** POTATO COE-NER ************");
            Console.WriteLine("                                      ");
            Console.WriteLine("------------- PRICE LIST -------------");
            Console.WriteLine("1. Regular                      P35.00");
            Console.WriteLine("2. Large                        P60.00");
            Console.WriteLine("3. Jumbo                        P90.00");
            Console.WriteLine("4. Mega                        P119.00");
            Console.WriteLine("5. Giga                        P189.00");
            Console.WriteLine("6. Tera                        P220.00");
            Console.WriteLine("--------------------------------------");

            Console.WriteLine("Select your order.");

            string userInput = Console.ReadLine();

            if (userInput == "1"); {
                Console.WriteLine("Regular                     P35.00");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("----------- FLAVOR LIST ----------");
                Console.WriteLine("a. Barbeque                       ");
                Console.WriteLine("b. Cheese                         ");
                Console.WriteLine("c. Sour and Cream                 ");

                Console.WriteLine("Choose your desired flavor.");

                string userEnter = Console.ReadLine();

                if (userEnter == "a") {
                    Console.WriteLine("Barbeque");
                }
                if (userEnter == "b") {
                    Console.WriteLine("Cheese");
                }
                if (userEnter == "c") {
                    Console.WriteLine("Sour and Cream");
                }

                 Console.WriteLine("Enter the quantity of your order.");
                 quantity = Convert.ToInt32(Console.ReadLine());
                 total = quantity * 35;
                 Console.WriteLine("Your total bill: P" + total);

                 Console.WriteLine("Thank you for purchasing. Please come again!");
            }
            if (userInput == "2"); {
                Console.WriteLine("Large                       P60.00");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("----------- FLAVOR LIST ----------");
                Console.WriteLine("a. Barbeque                       ");
                Console.WriteLine("b. Cheese                         ");
                Console.WriteLine("c. Sour and Cream                 ");

                Console.WriteLine("Choose your desired flavor.");

                string userEnter = Console.ReadLine();

                if (userEnter == "a") {
                    Console.WriteLine("Barbeque");
                }
                if (userEnter == "b") {
                    Console.WriteLine("Cheese");
                }
                if (userEnter == "c") {
                    Console.WriteLine("Sour and Cream");
                }

                 Console.WriteLine("Enter the quantity of your order.");
                 quantity = Convert.ToInt32(Console.ReadLine());
                 total = quantity * 60;
                 Console.WriteLine("Your total bill: P" + total);

                 Console.WriteLine("Thank you for purchasing. Please come again!");
            }
            if (userInput == "3"); {
                Console.WriteLine("Jumbo                       P90.00");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("----------- FLAVOR LIST ----------");
                Console.WriteLine("a. Barbeque                       ");
                Console.WriteLine("b. Cheese                         ");
                Console.WriteLine("c. Sour and Cream                 ");

                Console.WriteLine("Choose your desired flavor.");

                string userEnter = Console.ReadLine();

                if (userEnter == "a") {
                    Console.WriteLine("Barbeque");
                }
                if (userEnter == "b") {
                    Console.WriteLine("Cheese");
                }
                if (userEnter == "c") {
                    Console.WriteLine("Sour and Cream");
                }

                 Console.WriteLine("Enter the quantity of your order.");
                 quantity = Convert.ToInt32(Console.ReadLine());
                 total = quantity * 90;
                 Console.WriteLine("Your total bill: P" + total);

                 Console.WriteLine("Thank you for purchasing. Please come again!");
            }
            if (userInput == "4"); {
                Console.WriteLine("Mega                       P119.00");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("----------- FLAVOR LIST ----------");
                Console.WriteLine("a. Barbeque                       ");
                Console.WriteLine("b. Cheese                         ");
                Console.WriteLine("c. Sour and Cream                 ");

                Console.WriteLine("Choose your desired flavor.");

                string userEnter = Console.ReadLine();

                if (userEnter == "a") {
                    Console.WriteLine("Barbeque");
                }
                if (userEnter == "b") {
                    Console.WriteLine("Cheese");
                }
                if (userEnter == "c") {
                    Console.WriteLine("Sour and Cream");
                }

                 Console.WriteLine("Enter the quantity of your order.");
                 quantity = Convert.ToInt32(Console.ReadLine());
                 total = quantity * 119;
                 Console.WriteLine("Your total bill: P" + total);

                 Console.WriteLine("Thank you for purchasing. Please come again!");
            }
            if (userInput == "5"); {
                Console.WriteLine("Giga                       P189.00");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("----------- FLAVOR LIST ----------");
                Console.WriteLine("a. Barbeque                       ");
                Console.WriteLine("b. Cheese                         ");
                Console.WriteLine("c. Sour and Cream                 ");

                Console.WriteLine("Choose your desired flavor.");

                string userEnter = Console.ReadLine();

                if (userEnter == "a") {
                    Console.WriteLine("Barbeque");
                }
                if (userEnter == "b") {
                    Console.WriteLine("Cheese");
                }
                if (userEnter == "c") {
                    Console.WriteLine("Sour and Cream");
                }

                 Console.WriteLine("Enter the quantity of your order.");
                 quantity = Convert.ToInt32(Console.ReadLine());
                 total = quantity * 189;
                 Console.WriteLine("Your total bill: P" + total);

                 Console.WriteLine("Thank you for purchasing. Please come again!");
            }
            if (userInput == "6"); {
                Console.WriteLine("Tera                       P220.00");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("----------- FLAVOR LIST ----------");
                Console.WriteLine("a. Barbeque                       ");
                Console.WriteLine("b. Cheese                         ");
                Console.WriteLine("c. Sour and Cream                 ");

                Console.WriteLine("Choose your desired flavor.");

                string userEnter = Console.ReadLine();

                if (userEnter == "a") {
                    Console.WriteLine("Barbeque");
                }
                if (userEnter == "b") {
                    Console.WriteLine("Cheese");
                }
                if (userEnter == "c") {
                    Console.WriteLine("Sour and Cream");
                }

                 Console.WriteLine("Enter the quantity of your order.");
                 quantity = Convert.ToInt32(Console.ReadLine());
                 total = quantity * 220;
                 Console.WriteLine("Your total bill: P" + total);

                 Console.WriteLine("Thank you for purchasing. Please come again!");
            }
        }
    }
}
