using System;

namespace h5chocolate_teambla
{
    class Chocolate : Product
    {
        //attribut - fyllning, kakaomängd, 
        private byte Cocoa; //10-90%
        private string Filling; //t.ex. guldflarn eller ingen fyllning, ska man kunna ha flera 
        private bool TestCheck;
        private byte AmountOfBars;
        private string UserInput;

        public Chocolate CreateChocolate(byte Cocoa,string Filling, byte AmountOfBars)
        {
            while (true)
            {
                Console.WriteLine("How much cocoa content would you like your chocolate bar to have? Enter an amount (10-90%).");
                TestCheck = byte.TryParse(UserInput=Console.ReadLine(), out Cocoa);
                Console.WriteLine(Cocoa);
                break;
            }
            Chocolate newChocolate = new();
            return newChocolate;
        }
       //sätt standardvariabler, ska metod SOM HETER CREATECHOCOLATE(), koppla ihop med Menu för att sätta övriga chokladspecifika variabler med while loop eller switch, med en submeny, skicka tillbaka med return till menyn
    }
}
