using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace CheckCurrency
{
    
    public class Curse
    {
        public Currency baseCurrency { get; set; }

        private string date;
        [JsonProperty("@Date")] 
        public string Date
        {
            get => date;
            set
            {
                date = DateTime.Parse(value).ToString("dd.MM.yyyy");
            }
        }

        [JsonProperty("Valute")]
        public Dictionary<String, Currency> rates { get; set; }

        public Curse()
        {
            
            baseCurrency = new Currency("RUB", 1f, "Российский рубль");
        }

        public override string ToString()
        {

            string result = String.Format("Curse to {0}: \n (on {1})\n", baseCurrency, date);
            foreach (var rate in rates.Values)
                result += rate + "\n";

            return result;
        }
    }
}