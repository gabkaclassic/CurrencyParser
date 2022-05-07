using System;

namespace CheckCurrency
{
    class Application
    {
        private static readonly JsonParser<Currency> Parser = new JsonParser<Currency>();
        private static readonly Requestor requestor = new Requestor();

        public static void Main(string[] args)
        {
            Application app = new Application();
            
            app.test();
        }

        private void test()
        {
            Console.WriteLine(Parser.Deserialize(requestor.GetRequest("http://localhost:8080/currency")));
        }
    }
}