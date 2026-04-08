namespace Kontoret
{
    public class BinaryConverter
    {
        public void Start()
        {
            Console.WriteLine("Skriv et tal mellem 0 og 255");
            int octet = int.Parse(Console.ReadLine());
            // List of power of two numbers 128, 64, 32, 16, 8, 4, 2, 1
            List<int> powerOfTwo = new List<int> { 128, 64, 32, 16, 8, 4, 2, 1 };
            string binary = "";

            for (int i = 0; i < powerOfTwo.Count; i++) {
                
                if (octet >= powerOfTwo[i])
                {
                    binary += "1";
                    octet -= powerOfTwo[i];
                }
                else
                {
                    binary += "0";
                }
            }

            Console.WriteLine(binary);


            Console.WriteLine("Skriv en binær streng her!");

            string? binaryInput = Console.ReadLine(); //10101010
            int octetOutput = 0;

            for (int i = 0; i < binaryInput.Length; i++) {
                
                if (binaryInput[i] == '1')
                {
                    octetOutput += powerOfTwo[i];
                }               
            }

            Console.WriteLine(octetOutput);
            Console.ReadKey();
        }

    }
}
