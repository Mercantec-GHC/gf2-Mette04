using System.ComponentModel.Design;

namespace Hjemmet
{
    public class GuessANumber
    {
        public void Start()
        {
            Console.WriteLine("Gæt et tal mellem 1 og 100 .");

            Random random = new Random();
            int randomNumber = random.Next(101);

            Console.WriteLine("Indtast et tal");
            
            int point = 0;
            string? guess;
            int number;


               
                while (true)
                {
                    guess = Console.ReadLine();

                    // Guard Clause for at det er et rigtigt tal
                    if (int.TryParse(guess, out number))
                    { 
                    }
                    else
                    {
                        Console.WriteLine("Du skal skrive et tal.");
                        continue;
                    }

                    // Guard Clause for tallet skal være mellem 1 og 100
                    // contine starter loopet forfra

                    if (number < 0 || number > 100)
                    {
                        Console.WriteLine("Nummeret skal være mellem 1 og 100");
                        continue;
                    }
                
                    point += 1;
                    if (number == randomNumber)
                    {
                        Console.WriteLine("Du gjorde det!");
                        Console.WriteLine("nummeret var " + randomNumber);
                        Console.WriteLine("Du gættede det på " + point + " forsøg");

                    }
                    else if (number < randomNumber)
                    {
                        Console.WriteLine("Tallet er højere");

                    }
                    else if (number > randomNumber)
                    {
                        Console.WriteLine("Tallet er lavere");
                    }



                    
                }
                Console.ReadKey();
            }  
        }
}