using System;

namespace Opgaver
{
    public class ControlFlow
    {
        public static void Run()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine(
                @"Velkommen til opgaver omkring Control Flow med if, else if og else, 
            Switch og Ternary operator!"
            );
            //If1();
            //If2();

            //Switch1();
            //Ternary1();

            //MiniProjektQuiz();
            MiniProjektKarakterFeedback();
        }

        public static void If1()
        {
            Console.WriteLine(
                "Lav et program som tjekker om en given værdi er højere eller lavere end 18"
            );
            // Lav opgaven herunder!
            Console.WriteLine("skriv et heltal");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num);

            if(num > 18)
            {
                Console.WriteLine("tallet er større end 18");
            }
            else if(num < 18)
            {
                Console.WriteLine("tallet er mindre end 18");
            }
            else if (num == 18)
            {
                Console.WriteLine("tallet er lig med 18");
            }
           
        }

        public static void If2()
        {
            Console.WriteLine("Lav et program som tjekker om en given værdi er lige eller ulige");
            // Lav opgaven herunder!'
            Console.WriteLine("skriv et heltal");
            int ber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ber);

            if (ber % 2 == 0)
            {
                Console.WriteLine("nummeret er lige");
            }
            else
            {
                Console.WriteLine("nummeret er ulige");
            }

        }

        public static void Switch1()
        {
            Console.WriteLine("Lav et program som tjekker om en given værdi er lige eller ulige");
            // Lav opgaven herunder!
            Console.WriteLine("skriv et heltal");
            int okay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(okay);
            int sej = okay % 2;

            switch(sej)
            {
                case 0:
                    Console.WriteLine("talet er lige");
                    break;
                case 1:
                    Console.WriteLine("talet er ulige");
                    break;
            }
        }

        public static void Ternary1()
        {
            Console.WriteLine("Lav et program som tjekker om en given værdi er lige eller ulige");
            // Lav opgaven herunder!
            int good = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(good);
            int fine = good % 2;

            string result = (fine == good % 2) ? "ulige" : "lige";

            Console.WriteLine(result);
        }

        public static void MiniProjektQuiz()
        {
            Console.WriteLine("\nMini-projekt: Simpelt quiz-spil (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine(
                "Lav et program, der stiller brugeren tre spørgsmål (du vælger selv spørgsmål og svar)."
            );
            Console.WriteLine("Brugeren skal indtaste sit svar til hvert spørgsmål.");
            Console.WriteLine(
                "Programmet skal tjekke, om svaret er rigtigt eller forkert, og til sidst udskrive, hvor mange rigtige brugeren fik."
            );
            Console.WriteLine(
                "Tip: Brug variabler til at gemme point og svar, og if/else til at tjekke svarene."
            );
            // Lav opgaven herunder!
            int point = 0;
            Console.WriteLine("Hvad er hovedstaden i Japan?");
            string? capital = Console.ReadLine();
            if (capital == "Tokyo")
            {
                Console.WriteLine("Det rigtigt!");
                point =+ 1;
            }
            else if (capital == "tokyo")
            {
                Console.WriteLine("Det rigigt!");
                point =+ 1;
            }
            else
            {
                Console.WriteLine("Det er desværre forkert");
            }

            Console.WriteLine("Hvor mange mennesker bor der i Danmark?");
            Console.WriteLine(" A) 6milioner B) 5.9milioner C)6.2milioner");
            Console.WriteLine("Skriv A, B eller C");
            string? people= Console.ReadLine();
            if (people == "A")
            {
                Console.WriteLine("Det rigtigt!");
                point = +1;
            }
            else if (people == "a")
            {
                Console.WriteLine("Det rigtigt!");
                point = +1;
            }
            else
            {
                Console.WriteLine("Det forkert");
            }

            Console.WriteLine("unscramble det her ord aprty");
            string? word = Console.ReadLine();
            if (word == "party")
            {
                Console.WriteLine("Det rigtigt!");
                point = +1; 
            }
            else if (word == "Party")
            {
                Console.WriteLine("Det rigtigt!");
                point= +1;
            }
            else
            {
                Console.WriteLine("Det fokert");
            }

            Console.WriteLine("du har " + point + " rigtige");
            
        }

        public static void MiniProjektKarakterFeedback()
        {
            Console.WriteLine("\nMini-projekt: Karakter-feedback (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine(
                "Lav et program, hvor brugeren indtaster en karakter (fx 12, 10, 7, 4, 02, 00 eller -3)."
            );
            Console.WriteLine(
                @"Programmet skal give en passende feedback baseret på karakteren, 
            fx 'Super flot!', 'Godt klaret', 'Du kan gøre det bedre' osv."
            );
            Console.WriteLine("Brug if/else eller switch til at vælge feedbacken.");

            Console.WriteLine(
                @"Ekstra opgave: Lav så man indtaster flere karaktere 
            for en bruger og man regner gennemsnittet ud."
            );
            // Lav opgaven herunder!
            Console.WriteLine("indtast en karakter");
            string gradeinput = Console.ReadLine();
            int grade;

            if (int.TryParse(gradeinput, out grade))
            {
                if (grade == 12)
                {
                    Console.WriteLine("Fucking godt kalret!");
                }
                else if (grade == 10)
                {
                    Console.WriteLine("Skide godt!");
                }
                else if (grade == 7)
                {
                    Console.WriteLine("Godt!");
                }
                else if (grade == 4)
                {
                    Console.WriteLine("Okay, du kan gøre det bedre");
                }
                else if (grade == 02)
                {
                    Console.WriteLine("du er lige præcis bestået...du kan gøre det bedre");
                }
                else if (grade == 00)
                {
                    Console.WriteLine("oof du bestod ikke, kom på banen");
                }
                else if (grade == -3)
                {
                    Console.WriteLine("Sorry to say, men du fucking dårlig");
                }
                else
                {
                    Console.WriteLine("ikke en gyldig karakter");
                }
            }
            else
            {
                Console.WriteLine("Ugyldigt input! Sørg for at indtaste et heltal.");
            }
            
        }
    }
}
