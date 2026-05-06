using System.DirectoryServices.Protocols;
using System.Net;

namespace Enterprice
{
    public class ADService
    {
        private static string _server = "10.133.71.100";
        private static string _username = "adReader";
        private static string _password = "Merc1234!";
        private static string _domain = "mags.local";
        public void Start()
        {
            Console.WriteLine("Forbinder til AD,,,,");
            var credential = new NetworkCredential($"{_username}@{_domain}", _password);
            Console.WriteLine($"Forbinder til AD på {_server} med bruger {_username}@{_domain}");
            var connection = new LdapConnection(_server)
            {
                Credential = credential,
                AuthType = AuthType.Negotiate
            };

            Console.WriteLine("Forbinder til AD....");
            connection.Bind(); // Test connection

            Console.WriteLine("Forbundet til AD!");
            Console.WriteLine("Hvornår skal vi spille Buzz????????");

            Console.ReadKey();

        }
    }
}
