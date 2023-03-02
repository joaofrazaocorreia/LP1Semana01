using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string favAnimal= "My favorite animal are... \n ...sheep! \u263c";

            string verbatimA= @"My favorite animal are... \n ... sheep! \u263c";

            string paragraph= "\n ------------------------------- \t:D\n";

            string verbParagraph= @"\n ------------------------------- \t:D\n";


            Console.WriteLine(paragraph);
            Console.WriteLine(favAnimal);
            Console.WriteLine(verbatimA);
            Console.WriteLine(verbParagraph);
        }
    }
}
