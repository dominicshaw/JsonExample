using System;
using System.IO;
using Newtonsoft.Json;

namespace ConsoleApp2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var json = File.ReadAllText("data.json");

            var o = JsonConvert.DeserializeObject<Rootobject>(json);
        
            Console.WriteLine(o);
            Console.Read();
        }
    }
}
