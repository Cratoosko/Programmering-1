using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndraDagen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            int numberone = int.Parse(Console.ReadLine());
            //Ber användaren om ett nummer, deklarerar en variabel som heter "numberone".
            //Värdet av variabeln blir numret som användaren angav.
            //Parse används för att koden ska läsa efter integers istället för strings vilket Console.ReadLine vanligtvis gör


            Console.WriteLine("Enter the second number: ");
            int numbertwo = int.Parse(Console.ReadLine());
            //Samma princip som överstående kod, den andra variabeln heter numbertwo


            int average = (numberone + numbertwo) / 2;
            //Bestämmer medelvärdet av de två numren som användaren matade in.
            //Medelvärdet får en egen variabel som heter "average" som deklareras i samma rad.


            Console.WriteLine("The average of the numbers {0} and {1} is {2}.", numberone, numbertwo, average);
            //Skriver ut första talet där platshållaren {0} är, andra talet där platshållaren {1} är och sist skrivs summan ut där platshållaren {2}är.

            Console.ReadLine();
            //Ser till att konsolen inte stängs ner automatiskt efter koden körs. Väntar istället på att användaren klickar "Enter" för att avsluta koden
        }
    }
}