using System;
using Newtonsoft.Json;

namespace CheckCurrency
{
    public class Currency
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("cost")]
        public float Cost { get; set; }

        public override string ToString()
        {
            return String.Format("Currency: [ name: {0}; Cost in rubles: {1} ]", Name, Cost);
        }
    }
}