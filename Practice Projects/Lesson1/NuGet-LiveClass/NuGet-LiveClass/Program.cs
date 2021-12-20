using Newtonsoft.Json.Linq;
using System;

namespace NuGet_LiveClass
{
    class Program
    {
        static void Main(string[] args)
        {
            JArray array = new JArray();
            JValue text = new JValue("some text");
            JValue date = new JValue(new DateTime(2000, 5, 23));

            array.add(text);
            array.add(date);

            Console.WriteLine(array);
        }
    }
}
