using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Level 1

            //generated random number
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 100);

            
            Console.WriteLine(randomNumber);
            Console.WriteLine("Pick a number between 1 and hundred you uncultured swine");
            var userNumber = int.Parse(Console.ReadLine());
            var counter = 0;
            var guessBool = false;
            
            while (guessBool == false && counter < 4)
            {
                if (userNumber < randomNumber)
                {
                    Console.WriteLine($"You guessed {userNumber} which is too low, please try again you heathen");
                    userNumber = int.Parse(Console.ReadLine());
                    
                }
                else if (userNumber > randomNumber)
                {
                   
                    Console.WriteLine($"You guessed {userNumber} which was too high you peasant. TRY AGAIN!.");
                    userNumber = int.Parse(Console.ReadLine());
                    
                }
                else
                {
                    Console.WriteLine($"Not bad for an idiot. You guessed {userNumber}!");
                    guessBool = true;
                    
                }
                counter++;
               
            }
            if (counter == 4)
            {
                Console.WriteLine("That was 5 tries, you lose!");

            }









        }
    }
}
