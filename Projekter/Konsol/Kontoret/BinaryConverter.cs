using System.Security.Cryptography.X509Certificates;

namespace Kontoret
{
    public class BinaryConverter
    {

        public void Start()
        {
            

            Console.WriteLine("Skriv et tal mellem 0 og 255");
            // Fra decimal til binær
            IpAddress ipAddress = new IpAddress();

            Console.WriteLine("Indtast den første octet: ");
            ipAddress.octets.Add(int.Parse(Console.ReadLine()));
            Console.WriteLine("Indtast den anden octet: ");
            ipAddress.octets.Add(int.Parse(Console.ReadLine()));
            Console.WriteLine("Indtast den tredje octet: ");
            ipAddress.octets.Add(int.Parse(Console.ReadLine()));
            Console.WriteLine("Indtast den fjerde octet: ");
            ipAddress.octets.Add(int.Parse(Console.ReadLine()));


            // List of power of two numbers 128, 64, 32, 16, 8, 4, 2, 1
            List<int> powerOfTwo = new List<int> { 128, 64, 32, 16, 8, 4, 2, 1 };
            string binary = "";

            foreach(int octet in ipAddress.octets)
            {
                int tempoctet = octet;
                for (int i = 0; i < powerOfTwo.Count; i++)
                {

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
                binary += ".";
            }


            Console.WriteLine("Her er de i binær");
            Console.WriteLine(binary);

            Console.WriteLine("Indtast den første binære streng: ");
            ipAddress.binær.Add(Console.ReadLine());
            Console.WriteLine("Indtast den anden binære streng: ");
            ipAddress.binær.Add(Console.ReadLine());
            Console.WriteLine("Indtast den tredje binære streng: ");
            ipAddress.binær.Add(Console.ReadLine());
            Console.WriteLine("Indtast den fjerde binære streng: ");
            ipAddress.binær.Add(Console.ReadLine());

            
            // Fra binær til decimal 


            foreach(string binær in ipAddress.binær)
            {
                int octetOutput = 0;
                for (int i = 0; i < binær.Length; i++) {
                
                    if (binær[i] == '1')
                    {
                        octetOutput += powerOfTwo[i];
                    }               
                }
                ipAddress.octetOutput.Add(octetOutput);
            }

            Console.WriteLine("Her er de i hele tal");
            ipAddress.PrintOctetOutput();
            Console.ReadKey();
        }

        public class IpAddress
        {
            public List<int> octets = new List<int>();
            public List<string> binær = new List<string>();
            public List<int> octetOutput = new List<int>();

            public void PrintOctetOutput()
            {
                Console.WriteLine($"{octetOutput[0]}.{octetOutput[1]}.{octetOutput[2]}.{octetOutput[3]}");
            }
        }


    }
}
