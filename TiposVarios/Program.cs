using System;



namespace TiposVarios
{

    class Program
    {
        static void Main(string[] args)
        {

            int num1 = 8;
            uint num2 = 4U;
            long num3 = 7L;
            ulong num4 = 2UL;

            char musicNote = '\u266b';
            char clover = '\u2663';
            char sun = '\u263c';

            Console.WriteLine(num1+" "+num2+" "+num3+" "+num4);
            Console.WriteLine(musicNote+" "+clover+" "+sun);
        }
    }
}
