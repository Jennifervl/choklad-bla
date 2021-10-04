using System;

namespace h5chocolate_teambla
{
    class Chocolate : Product
    {
        //koda properties
        private int cocoa; //10-90%
        private string filling; //t.ex. guldflarn eller ingen fyllning, ska man kunna ha flera 
        private bool TestCheck;
        // private int AmountOfBars;
        private string UserInput;
        private int Choice;
        private int CocoaAmount;

        public int Cocoa
        {
            get
            {
                return cocoa;
            }
            set
            {
                cocoa = value;
            }
        }

        public string Filling
        {
            get
            {
                return filling;
            }
            set
            {
                filling = value;
            }
        }

        public Chocolate(int Cocoa, string Filling, double Price, string ProductType = "Chocolate") : base(ProductType, Price)
        {

        }


        public Chocolate CreateChocolate()
        {
            while (true)
            {
                Console.WriteLine("How much cocoa content would you like your chocolate bar to have? Enter an amount (10-90%).");
                TestCheck = int.TryParse(UserInput = Console.ReadLine(), out CocoaAmount);

                if (CocoaAmount > 9 && CocoaAmount < 91)
                {
                    while (TestCheck)
                        TestCheck = false;

                    Console.WriteLine("Which filling do you want?\n[1]: Orangutan Orange\n[2]: Powerful Peanutbutter\n[3]: Masterful Maple Syrup\n[4]: Nice Nectarine Surprise\n[5]: No filling, thank you!");
                    TestCheck = int.TryParse(UserInput = Console.ReadLine(), out Choice);

                    switch (Choice)
                    {
                        case 1:
                            Filling = "Orangutan Orange";
                            Price = (CocoaAmount * 2 + 75);
                            break;

                        case 2:
                            Filling = "Powerful Peanutbutter";
                            Price = (CocoaAmount * 2 + 50);
                            break;

                        case 3:
                            Filling = "Master Maple Syrup";
                            Price = (CocoaAmount * 2 + 100);
                            break;

                        case 4:
                            Filling = "Nice Nectarine Surprise";
                            Price = (CocoaAmount * 2 + 60);
                            break;

                        case 5:
                            Filling = "No filling";
                            Price = (CocoaAmount * 2);
                            break;

                        default:
                            Console.WriteLine("You have entered an invalid choice.");
                            break;
                    }
                    Cocoa = CocoaAmount;
                    break;
                }

                else Console.WriteLine("You have entered an invalid amount of cocoa content. Only use values between 10 and 90, please.");

            }

            Chocolate newChocolate = new(Cocoa, Filling, Price, "Chocolate");
            Console.WriteLine($"{Cocoa.ToString()}+{Filling}+{Price}+{ProductType = "Chocolate"}");
            return newChocolate;
        }
        //sätt standardvariabler, ska metod SOM HETER CREATECHOCOLATE(), koppla ihop med Menu för att sätta övriga chokladspecifika variabler med while loop eller switch, med en submeny, skicka tillbaka med return till menyn
    }
}
