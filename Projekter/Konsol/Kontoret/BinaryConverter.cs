using System;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace Kontoret
{
    public class BinaryConverter
    {
        public void Start()
        {
            string? tal;
            int svar;
            
            
            Console.WriteLine("Skriv et tal mellem 0 og 255");
            // Fra decimal til binær
            //Vi har lavet en class fom vi kalder for ipadresse, som vi kan gemme vores lister under
            IpAddress ipAddress = new IpAddress();

            //vi laver et while loop som kører mens den er true, det er den hele tiden
            while (true) {
                //vi spørger brugeren om at indtast den første octet
                Console.WriteLine("Indtast den første octet: ");
                //Vi gemmer brugerens input under variablen "tal"
                tal = Console.ReadLine();
                
                //tjekkker at vi har skrevet en int/tal.
                if (int.TryParse(tal, out svar))
                {
                    //Tjekker om vores tal er mellem 0-255
                    // Hvis ja så tilføjer den vores tal til vores liste
                    if (svar > -1 && svar < 256)
                    {
                        ipAddress.octets.Add(svar);
                    }
                    else
                    {
                        Console.WriteLine("Du skal skrive et tal mellem 0-255, start forfra.");
                        //Clear vores liste, så vi kan starte forfra
                        ipAddress.octets.Clear();
                        //starter loopet forfra
                        continue;
                    }
                }
                else
                {
                    //Hvis ikke vi har intastet et tal kører den denne fejlkode.
                    Console.WriteLine("Du skal skrive et tal, start forfra.");
                    ipAddress.octets.Clear();
                    continue;
                }
                
                Console.WriteLine("Indtast den anden octet: ");
                tal = Console.ReadLine();
                if (int.TryParse(tal, out svar))
                {
                    if (svar > -1 && svar < 256)
                    {
                        ipAddress.octets.Add(svar);
                    }
                    else
                    {
                        Console.WriteLine("Du skal skrive et tal mellem 0-255, start forfra.");
                        ipAddress.octets.Clear();
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Du skal skrive et tal, start forfra.");
                    ipAddress.octets.Clear();
                    continue;
                }
                Console.WriteLine("Indtast den tredje octet: ");
                tal = Console.ReadLine();
                if (int.TryParse(tal, out svar))
                {
                    if (svar > -1 && svar < 256)
                    {
                        ipAddress.octets.Add(svar);
                    }
                    else
                    {
                        Console.WriteLine("Du skal skrive et tal mellem 0-255, start forfra.");
                        ipAddress.octets.Clear();
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Du skal skrive et tal, start forfra.");
                    ipAddress.octets.Clear();
                    continue;
                }
                Console.WriteLine("Indtast den fjerde octet: ");
                tal = Console.ReadLine();
                if (int.TryParse(tal, out svar))
                {
                    if (svar > -1 && svar < 256)
                    {
                        ipAddress.octets.Add(svar);
                    }
                    else
                    {
                        Console.WriteLine("Du skal skrive et tal mellem 0-255, start forfra.");
                        ipAddress.octets.Clear();
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Du skal skrive et tal, start forfra.");
                    ipAddress.octets.Clear();
                    continue;
                }
               

                // List of power of two numbers 128, 64, 32, 16, 8, 4, 2, 1
                List<int> powerOfTwo = new List<int> { 128, 64, 32, 16, 8, 4, 2, 1 };
                string binary = "";                    

                foreach (int octet in ipAddress.octets)
                {

                    //En tempoary/middlertidig octet
                    int tempoctet = octet;
                    for (int i = 0; i < powerOfTwo.Count; i++)
                    {
                        //Den går iegnnem vores poweroftwo liste.
                        //Den starter fra venstre og ser om den kan trække 128 fra vores input.
                        //Hvis ja, så sætter den et 1 tal, hvis nej så sætter den et 0,
                        //Også går den vidre til næste tal i rækken
                        if (tempoctet >= powerOfTwo[i])
                        {
                           
                            binary += "1";
                            tempoctet -= powerOfTwo[i];
                        }
                        else
                        {
                            
                            binary += "0";
                        }
                    }
                    //Så vi kan få et punktum mellem hver octet 
                    binary += ".";
                }

                Console.WriteLine("Her er de i binær");
                Console.WriteLine(binary);

                //Vi tager vores binære streng og tilføjer den til vores liste, i dette tilfælde vores binær liste.
                Console.WriteLine("Indtast den første binære streng: ");
                ipAddress.binær.Add(Console.ReadLine());
                Console.WriteLine("Indtast den anden binære streng: ");
                ipAddress.binær.Add(Console.ReadLine());
                Console.WriteLine("Indtast den tredje binære streng: ");
                ipAddress.binær.Add(Console.ReadLine());
                Console.WriteLine("Indtast den fjerde binære streng: ");
                ipAddress.binær.Add(Console.ReadLine());

                // Fra binær til decimal 

                foreach (string binær in ipAddress.binær)
                {
                    //hvis vores binære input er 1, så skal den gå op i vores poweroftwo liste, og tilføje tallet der passer til 1-tallets position
                    //Hvis vore binære input er 0, skal den ikke tilføje noget.
                    int octetOutput = 0;
                    for (int i = 0; i < binær.Length; i++)
                    {

                        if (binær[i] == '1')
                        {
                            octetOutput += powerOfTwo[i];
                        }
                    }
                    //Vi tilføjer octetOutput til vores liste octetOutput.
                    ipAddress.octetOutput.Add(octetOutput);
                }
                Console.WriteLine("Her er de i hele tal");
                ipAddress.PrintOctetOutput();               
                Console.ReadKey();
                break;
            }                             
        }
        //lister
        public class IpAddress
        {
            //Octet er på 8 bits, altså fra punktum til punktum. 00000000-11111111.
            public List<int> octets = new List<int>();
            public List<string> binær = new List<string>();
            public List<int> octetOutput = new List<int>();

            public void PrintOctetOutput()
            {
                //Udskriver vores tal til sidst i konsollen, med punktum imellem.
                Console.WriteLine($"{octetOutput[0]}.{octetOutput[1]}.{octetOutput[2]}.{octetOutput[3]}");
            }
        }
    }
}
