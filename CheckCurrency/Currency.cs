using System;
using Newtonsoft.Json;

namespace CheckCurrency
{
    public class Currency
    {
        public Currency()
        {
        }

        public Currency(string name, float cost, string definition)
        {
            Name = name;
            Cost = cost;
            Definition = definition;
        }

        [JsonProperty("CharCode")]
        public string Name { get; set; }
        
        [JsonProperty("Value")]
        public float Cost { get; set; }

        [JsonProperty("Name")]
        public string Definition { get; set; }

        public override string ToString()
        {
            return String.Format("Currency: [ name: {0}; Cost in rubles: {1}; Short definition: {2} ]", Name, Cost, Definition);
        }
    }
}