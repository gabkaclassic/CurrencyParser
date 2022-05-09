using System;

namespace CheckCurrency
{
    class Application
    {
        private const string TEST_URL = "http://localhost:8080/currency";
        private const string URL = "https://www.cbr-xml-daily.ru/daily_json.js";
        
        private static readonly JsonParser<Curse> Parser = new JsonParser<Curse>();
        private static readonly Requestor requestor = new Requestor();

        public static void Main(string[] args)
        {
            Application app = new Application();
            
            // app.test();
            Console.WriteLine(app.getCurse());
        }

        private void test()
        {
            Console.WriteLine(Parser.Deserialize(requestor.GetRequest(TEST_URL)));
        }

        private Curse getCurse()
        {

            string request = requestor.GetRequest(URL);
            Curse curse =  Parser.Deserialize(request);
            return curse;
        }
    }

    class Person
    {
        public string name { get; set; }
        public int age { get; set; }

        public override string ToString()
        {
            return String.Format("Person [name: {0}, age: {1}]", name, age);
        }
    }
}
