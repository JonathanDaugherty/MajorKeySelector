using System;

namespace MajorKeySelector
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] keys = { "A", "B", "C", "D", "E", "F", "G", "Bb", "Db", "Eb", "Gb", "Ab" };

            Random r = new Random();

            int index = r.Next(keys.Length);

            Console.WriteLine($"Your scale today is in the key of: {keys[index]}");
        }
    }
}
