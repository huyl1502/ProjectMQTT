using System.Collections.Generic;

namespace Mqtt.Models
{
    public class ServerContext
    {
        public string Url { get; set; }
        public string ClientId { get; set; }
        public string Token { get; set; }
        public object Value { get; set; }

        public T ParseObject<T>()
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(Value.ToString());
            //return ((Newtonsoft.Json.Linq.JObject)Value).ToObject<T>();
        }
        public List<T> ParseArray<T>()
        {
            var lst = new List<T>();
            foreach (var e in ((Newtonsoft.Json.Linq.JArray)Value))
            {
                lst.Add(e.ToObject<T>());
            }
            return lst;
        }
    }
}
