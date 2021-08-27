using Newtonsoft.Json;
using System;

namespace Messanger1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Message msg = new Message("Rusal", "Privet", DateTime.UtcNow);
            string output = JsonConvert.SerializeObject(msg);
            Message desmsg = JsonConvert.DeserializeObject<Message>(output);
            Console.WriteLine(output);
            //Console.WriteLine(msg.ToString());
        }
    }
}
