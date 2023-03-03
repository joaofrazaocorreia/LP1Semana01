using System;

namespace ArgLongStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=0; i< args.Length ; i++)
            {
                if (args[i].Length>4)
                {
                    string uppercase = args[i].ToUpper();
                    Console.WriteLine(uppercase);
                }
            }
        }
    }
}
