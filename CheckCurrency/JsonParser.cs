using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace CheckCurrency
{
    public class JsonParser<T>
    {
        public static string filename
        {
            set
            {
                if (!String.IsNullOrEmpty(value))
                    filename = value;
            }
            get => filename;
        }

        public void SerializeToFile(T value)
        {
            
            File.WriteAllText(filename, JsonConvert.SerializeObject(value));
        }

        public T DeserializeFromFile()
        {
            if (!File.Exists(filename))
                throw new IOException(String.Format("File with filename { {0} } didn't found", filename));
            
            return JsonConvert.DeserializeObject<T>(File.ReadAllText(filename));
        }
        
        public void SerializeToFile(T value, string filename)
        {
            if (String.IsNullOrEmpty(filename))
                throw new NullReferenceException("Given filename is null or empty");
            
            File.WriteAllText(filename, JsonConvert.SerializeObject(value));
        }

        public T DeserializeFromFile(string filename)
        {
            if (!File.Exists(filename))
                throw new IOException(String.Format("File with filename { {0} } didn't found", filename));
           
            return JsonConvert.DeserializeObject<T>(File.ReadAllText(filename));
        }

        public string Serialize(T value)
        {
            return JsonConvert.SerializeObject(value);
        }

        public T Deserialize(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}