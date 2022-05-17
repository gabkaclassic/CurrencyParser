using System;
using System.Diagnostics;

namespace CheckCurrency
{
    class Application
    {
        private static readonly string TEST_URL = Environment.GetEnvironmentVariable("TEST_URL");
        private static readonly string URL_JSON = Environment.GetEnvironmentVariable("URL_JSON");
        private static readonly string URL_XML =  Environment.GetEnvironmentVariable("URL_XML");

        private static readonly JsonParser<Curse> Parser = new JsonParser<Curse>();
        private static readonly Requestor requestor = new Requestor();

        public static void Main(string[] args)
        {
            Application app = new Application();

            // app.startJavaServer();
            app.startJson();
        }

        private void startJavaServer()
        {
            Console.WriteLine(Parser.Deserialize(requestor.GetRequest(TEST_URL)));
        }

        private void startJson()
        {
            
            Console.WriteLine(getCurse());
            Console.Read();
        }

        private Curse getCurse()
        {
            string request = requestor.GetRequest(URL_JSON);
            Curse curse =  Parser.Deserialize(request);
            
            return curse;
        }
    }
}
