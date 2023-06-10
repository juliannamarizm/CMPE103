// Marquez, Julianna Mariz D.

using System;
using System.Collections.Generic;

namespace potatoCoerner
{
    class Program
    {
        static void Main()
        {
            int quantity = 1;
            string purchaseAgain;
            var menu = true;
            double total = 0;
            Console.WriteLine("        Welcome to Potato Coe-rner!        ");

            while (menu)
            {
                potatoMenu();

                int userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput == 1)
                {
                    conditionOne();
                    int userEnter = Convert.ToInt32(Console.ReadLine());

                    switch (userEnter)
                    {
                        case 1:
                            Console.WriteLine("Barbeque");

                            Console.WriteLine("Enter the quantity of your order.");
                            quantity = Convert.ToInt32(Console.ReadLine());
                            total = quantity * 35;
                            Console.WriteLine("Your total bill: P" + total);

                            Console.WriteLine("Do you want to order?");
                            Console.WriteLine("Type Y if you want to order, N if not.");
                            purchaseAgain = Console.ReadLine();

                            if (purchaseAgain != "Y")
                                menu = false;
                            Console.WriteLine();
                            if (purchaseAgain == "N")
                            {
                                Console.WriteLine("Thank you for purchasing. Pleasse come agan!");
                                break;
                            }
                            break;
                        case 2:
                            Console.WriteLine("Cheese");
                            Console.WriteLine("Enter the quantity of your order.");
                            quantity = Convert.ToInt32(Console.ReadLine());
                            total = quantity * 35;
                            Console.WriteLine("Your total bill: P" + total);

                            Console.WriteLine("Do you want to order?");
                            Console.WriteLine("Type Y if you want to order, N if not.");
                            purchaseAgain = Console.ReadLine();

                            if (purchaseAgain != "Y")
                                menu = false;
                            Console.WriteLine();
                            if (purchaseAgain == "N")
                            {
                                Console.WriteLine("Thank you for purchasing. Pleasse come agan!");
                                break;
                            }
                            break;
                        case 3:
                            Console.WriteLine("Sour and Cream");
                            Console.WriteLine("Enter the quantity of your order.");
                            quantity = Convert.ToInt32(Console.ReadLine());
                            total = quantity * 35;
                            Console.WriteLine("Your total bill: P" + total);

                            Console.WriteLine("Do you want to order?");
                            Console.WriteLine("Type Y if you want to order, N if not.");
                            purchaseAgain = Console.ReadLine();

                            if (purchaseAgain != "Y")
                                menu = false;
                            Console.WriteLine();
                            if (purchaseAgain == "N")
                            {
                                Console.WriteLine("Thank you for purchasing. Pleasse come agan!");
                                break;
                            }
                            break;
                    }
                }
                if (userInput == 2)
                {
                    conditionTwo();
                    int userEnter = Convert.ToInt32(Console.ReadLine());

                    switch (userEnter)
                    {
                        case 1:
                            Console.WriteLine("Barbeque");

                            Console.WriteLine("Enter the quantity of your order.");
                            quantity = Convert.ToInt32(Console.ReadLine());
                            total = quantity * 60;
                            Console.WriteLine("Your total bill: P" + total);

                            Console.WriteLine("Do you want to order?");
                            Console.WriteLine("Type Y if you want to order, N if not.");
                            purchaseAgain = Console.ReadLine();

                            if (purchaseAgain != "Y")
                                menu = false;
                            Console.WriteLine();
                            if (purchaseAgain == "N")
                            {
                                Console.WriteLine("Thank you for purchasing. Pleasse come agan!");
                                break;
                            }
                            break;
                        case 2:
                            Console.WriteLine("Cheese");
                            Console.WriteLine("Enter the quantity of your order.");
                            quantity = Convert.ToInt32(Console.ReadLine());
                            total = quantity * 60;
                            Console.WriteLine("Your total bill: P" + total);

                            Console.WriteLine("Do you want to order?");
                            Console.WriteLine("Type Y if you want to order, N if not.");
                            purchaseAgain = Console.ReadLine();

                            if (purchaseAgain != "Y")
                                menu = false;
                            Console.WriteLine();
                            if (purchaseAgain == "N")
                            {
                                Console.WriteLine("Thank you for purchasing. Pleasse come agan!");
                                break;
                            }
                            break;
                        case 3:
                            Console.WriteLine("Sour and Cream");
                            Console.WriteLine("Enter the quantity of your order.");
                            quantity = Convert.ToInt32(Console.ReadLine());
                            total = quantity * 60;
                            Console.WriteLine("Your total bill: P" + total);

                            Console.WriteLine("Do you want to order?");
                            Console.WriteLine("Type Y if you want to order, N if not.");
                            purchaseAgain = Console.ReadLine();

                            if (purchaseAgain != "Y")
                                menu = false;
                            Console.WriteLine();
                            if (purchaseAgain == "N")
                            {
                                Console.WriteLine("Thank you for purchasing. Pleasse come agan!");
                                break;
                            }
                            break;
                    }
                }
                if (userInput == 3)
                {
                    conditionThree();
                    int userEnter = Convert.ToInt32(Console.ReadLine());

                    switch (userEnter)
                    {
                        case 1:
                            Console.WriteLine("Barbeque");

                            Console.WriteLine("Enter the quantity of your order.");
                            quantity = Convert.ToInt32(Console.ReadLine());
                            total = quantity * 90;
                            Console.WriteLine("Your total bill: P" + total);

                            Console.WriteLine("Do you want to order?");
                            Console.WriteLine("Type Y if you want to order, N if not.");
                            purchaseAgain = Console.ReadLine();

                            if (purchaseAgain != "Y")
                                menu = false;
                            Console.WriteLine();
                            if (purchaseAgain == "N")
                            {
                                Console.WriteLine("Thank you for purchasing. Pleasse come agan!");
                                break;
                            }
                            break;
                        case 2:
                            Console.WriteLine("Cheese");
                            Console.WriteLine("Enter the quantity of your order.");
                            quantity = Convert.ToInt32(Console.ReadLine());
                            total = quantity * 90;
                            Console.WriteLine("Your total bill: P" + total);

                            Console.WriteLine("Do you want to order?");
                            Console.WriteLine("Type Y if you want to order, N if not.");
                            purchaseAgain = Console.ReadLine();

                            if (purchaseAgain != "Y")
                                menu = false;
                            Console.WriteLine();
                            if (purchaseAgain == "N")
                            {
                                Console.WriteLine("Thank you for purchasing. Pleasse come agan!");
                                break;
                            }
                            break;
                        case 3:
                            Console.WriteLine("Sour and Cream");
                            Console.WriteLine("Enter the quantity of your order.");
                            quantity = Convert.ToInt32(Console.ReadLine());
                            total = quantity * 90;
                            Console.WriteLine("Your total bill: P" + total);

                            Console.WriteLine("Do you want to order?");
                            Console.WriteLine("Type Y if you want to order, N if not.");
                            purchaseAgain = Console.ReadLine();

                            if (purchaseAgain != "Y")
                                menu = false;
                            Console.WriteLine();
                            if (purchaseAgain == "N")
                            {
                                Console.WriteLine("Thank you for purchasing. Pleasse come agan!");
                                break;
                            }
                            break;
                    }
                }
                if (userInput == 4)
                {
                    conditionFour();
                    int userEnter = Convert.ToInt32(Console.ReadLine());

                    switch (userEnter)
                    {
                        case 1:
                            Console.WriteLine("Barbeque");

                            Console.WriteLine("Enter the quantity of your order.");
                            quantity = Convert.ToInt32(Console.ReadLine());
                            total = quantity * 119;
                            Console.WriteLine("Your total bill: P" + total);

                            Console.WriteLine("Do you want to order?");
                            Console.WriteLine("Type Y if you want to order, N if not.");
                            purchaseAgain = Console.ReadLine();

                            if (purchaseAgain != "Y")
                                menu = false;
                            Console.WriteLine();
                            if (purchaseAgain == "N")
                            {
                                Console.WriteLine("Thank you for purchasing. Pleasse come agan!");
                                break;
                            }
                            break;
                        case 2:
                            Console.WriteLine("Cheese");
                            Console.WriteLine("Enter the quantity of your order.");
                            quantity = Convert.ToInt32(Console.ReadLine());
                            total = quantity * 119;
                            Console.WriteLine("Your total bill: P" + total);

                            Console.WriteLine("Do you want to order?");
                            Console.WriteLine("Type Y if you want to order, N if not.");
                            purchaseAgain = Console.ReadLine();

                            if (purchaseAgain != "Y")
                                menu = false;
                            Console.WriteLine();
                            if (purchaseAgain == "N")
                            {
                                Console.WriteLine("Thank you for purchasing. Pleasse come agan!");
                                break;
                            }
                            break;
                        case 3:
                            Console.WriteLine("Sour and Cream");
                            Console.WriteLine("Enter the quantity of your order.");
                            quantity = Convert.ToInt32(Console.ReadLine());
                            total = quantity * 119;
                            Console.WriteLine("Your total bill: P" + total);

                            Console.WriteLine("Do you want to order?");
                            Console.WriteLine("Type Y if you want to order, N if not.");
                            purchaseAgain = Console.ReadLine();

                            if (purchaseAgain != "Y")
                                menu = false;
                            Console.WriteLine();
                            if (purchaseAgain == "N")
                            {
                                Console.WriteLine("Thank you for purchasing. Pleasse come agan!");
                                break;
                            }
                            break;
                    }
                }
                if (userInput == 5)
                {
                    conditionFive();
                    int userEnter = Convert.ToInt32(Console.ReadLine());

                    switch (userEnter)
                    {
                        case 1:
                            Console.WriteLine("Barbeque");

                            Console.WriteLine("Enter the quantity of your order.");
                            quantity = Convert.ToInt32(Console.ReadLine());
                            total = quantity * 189;
                            Console.WriteLine("Your total bill: P" + total);

                            Console.WriteLine("Do you want to order?");
                            Console.WriteLine("Type Y if you want to order, N if not.");
                            purchaseAgain = Console.ReadLine();

                            if (purchaseAgain != "Y")
                                menu = false;
                            Console.WriteLine();
                            if (purchaseAgain == "N")
                            {
                                Console.WriteLine("Thank you for purchasing. Pleasse come agan!");
                                break;
                            }
                            break;
                        case 2:
                            Console.WriteLine("Cheese");
                            Console.WriteLine("Enter the quantity of your order.");
                            quantity = Convert.ToInt32(Console.ReadLine());
                            total = quantity * 189;
                            Console.WriteLine("Your total bill: P" + total);

                            Console.WriteLine("Do you want to order?");
                            Console.WriteLine("Type Y if you want to order, N if not.");
                            purchaseAgain = Console.ReadLine();

                            if (purchaseAgain != "Y")
                                menu = false;
                            Console.WriteLine();
                            if (purchaseAgain == "N")
                            {
                                Console.WriteLine("Thank you for purchasing. Pleasse come agan!");
                                break;
                            }
                            break;
                        case 3:
                            Console.WriteLine("Sour and Cream");
                            Console.WriteLine("Enter the quantity of your order.");
                            quantity = Convert.ToInt32(Console.ReadLine());
                            total = quantity * 189;
                            Console.WriteLine("Your total bill: P" + total);

                            Console.WriteLine("Do you want to order?");
                            Console.WriteLine("Type Y if you want to order, N if not.");
                            purchaseAgain = Console.ReadLine();

                            if (purchaseAgain != "Y")
                                menu = false;
                            Console.WriteLine();
                            if (purchaseAgain == "N")
                            {
                                Console.WriteLine("Thank you for purchasing. Pleasse come agan!");
                                break;
                            }
                            break;
                    }
                }
                if (userInput == 6)
                {
                    conditionSix();
                    int userEnter = Convert.ToInt32(Console.ReadLine());

                    switch (userEnter)
                    {
                        case 1:
                            Console.WriteLine("Barbeque");

                            Console.WriteLine("Enter the quantity of your order.");
                            quantity = Convert.ToInt32(Console.ReadLine());
                            total = quantity * 220;
                            Console.WriteLine("Your total bill: P" + total);

                            Console.WriteLine("Do you want to order?");
                            Console.WriteLine("Type Y if you want to order, N if not.");
                            purchaseAgain = Console.ReadLine();

                            if (purchaseAgain != "Y")
                                menu = false;
                            Console.WriteLine();
                            if (purchaseAgain == "N")
                            {
                                Console.WriteLine("Thank you for purchasing. Pleasse come agan!");
                                break;
                            }
                            break;
                        case 2:
                            Console.WriteLine("Cheese");
                            Console.WriteLine("Enter the quantity of your order.");
                            quantity = Convert.ToInt32(Console.ReadLine());
                            total = quantity * 220;
                            Console.WriteLine("Your total bill: P" + total);

                            Console.WriteLine("Do you want to order?");
                            Console.WriteLine("Type Y if you want to order, N if not.");
                            purchaseAgain = Console.ReadLine();

                            if (purchaseAgain != "Y")
                                menu = false;
                            Console.WriteLine();
                            if (purchaseAgain == "N")
                            {
                                Console.WriteLine("Thank you for purchasing. Pleasse come agan!");
                                break;
                            }
                            break;
                        case 3:
                            Console.WriteLine("Sour and Cream");
                            Console.WriteLine("Enter the quantity of your order.");
                            quantity = Convert.ToInt32(Console.ReadLine());
                            total = quantity * 220;
                            Console.WriteLine("Your total bill: P" + total);

                            Console.WriteLine("Do you want to order?");
                            Console.WriteLine("Type Y if you want to order, N if not.");
                            purchaseAgain = Console.ReadLine();

                            if (purchaseAgain != "Y")
                                menu = false;
                            Console.WriteLine();
                            if (purchaseAgain == "N")
                            {
                                Console.WriteLine("Thank you for purchasing. Pleasse come agan!");
                                break;
                            }
                            break;
                    }
                }
            }
        }
        static void potatoMenu()
        {
            var menu = new List<string>()
            {
                "            POTATO COE-RNER            ",
                "------------- PRICE LIST -------------",
                "1. Regular                      P35.00",
                "2. Large                        P60.00",
                "3. Jumbo                        P90.00",
                "4. Mega                        P119.00",
                "5. Giga                        P189.00",
                "6. Tera                        P220.00",
                "--------------------------------------",
                "                                      ",
                "Select your order.",
            };
            foreach (string i in menu)
            {
                Console.WriteLine(i);
            }
        }
        static void conditionOne()
        {
            var conditionOne = new List<string>()
            {
                "                                  ",
                "Regular                     P35.00",
                "----------- FLAVOR LIST ----------",
                "1. Barbeque                       ",
                "2. Cheese                         ",
                "3. Sour and Cream                 ",
                "                                  ",
                "Choose your desired flavor.",
            };
            foreach (string i in conditionOne)
            {
                Console.WriteLine(i);
            }
        }
        static void conditionTwo()
        {
            var conditionTwo = new List<string>()
            {
                "                                  ",
                "Regular                     P60.00",
                "----------- FLAVOR LIST ----------",
                "1. Barbeque                       ",
                "2. Cheese                         ",
                "3. Sour and Cream                 ",
                "                                  ",
                "Choose your desired flavor.",
            };
            foreach (string i in conditionTwo)
            {
                Console.WriteLine(i);
            }
        }
        static void conditionThree()
        {
            var conditionThree = new List<string>()
            {
                "                                  ",
                "Regular                     P90.00",
                "----------- FLAVOR LIST ----------",
                "1. Barbeque                       ",
                "2. Cheese                         ",
                "3. Sour and Cream                 ",
                "                                  ",
                "Choose your desired flavor.",
            };
            foreach (string i in conditionThree)
            {
                Console.WriteLine(i);
            }
        }
        static void conditionFour()
        {
            var conditionFour = new List<string>()
            {
                "                                  ",
                "Regular                    P119.00",
                "----------- FLAVOR LIST ----------",
                "1. Barbeque                       ",
                "2. Cheese                         ",
                "3. Sour and Cream                 ",
                "                                  ",
                "Choose your desired flavor.",
            };
            foreach (string i in conditionFour)
            {
                Console.WriteLine(i);
            }
        }
        static void conditionFive()
        {
            var conditionFive = new List<string>()
            {
                "                                  ",
                "Regular                    P189.00",
                "----------- FLAVOR LIST ----------",
                "1. Barbeque                       ",
                "2. Cheese                         ",
                "3. Sour and Cream                 ",
                "                                  ",
                "Choose your desired flavor.",
            };
            foreach (string i in conditionFive)
            {
                Console.WriteLine(i);
            }
        }
        static void conditionSix()
        {
            var conditionSix = new List<string>()
            {
                "                                  ",
                "Regular                    P220.00",
                "----------- FLAVOR LIST ----------",
                "1. Barbeque                       ",
                "2. Cheese                         ",
                "3. Sour and Cream                 ",
                "                                  ",
                "Choose your desired flavor.",
            };
            foreach (string i in conditionSix)
            {
                Console.WriteLine(i);
            }
        }
    }
}