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


            string def= "D E" + " F ";
            string abc= "A B C " + def;

            string animal1= "cat";
            string animal2= "dog";

            string dollar1 = $"If you mix a {animal1} with a {animal2}, ...";
            string dollar2 = $"...you get a {animal1 + animal2}!";

            string notInterpol= $"I like {animal1 + "s"}! \n\n ^ Paragraphs!";
            string interpol= $@"I like {animal1 + "s"}! \n\n ^ Paragraphs!";

            string format=String.Format("{0} & {1} are cute", animal1, animal2);

            string animal3= $"The Legendary {animal1 + animal2}";

            string last=String.Format("Beware of {0}!", animal3);


            Console.WriteLine(paragraph);

            Console.WriteLine(favAnimal);

            Console.WriteLine(verbatimA);

            Console.WriteLine(verbParagraph);


            Console.WriteLine("\n\n\n");

            Console.WriteLine(abc);
            Console.WriteLine(abc + "G and I forgot the rest");

            Console.WriteLine(dollar1);
            Console.WriteLine(dollar2);

            Console.WriteLine(notInterpol);
            Console.WriteLine(interpol);

            Console.WriteLine(format);

            Console.WriteLine(last);
        }
    }
}
