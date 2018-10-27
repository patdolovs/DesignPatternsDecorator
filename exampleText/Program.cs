using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exampleText
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text:");

            IText exampleText = new Text();
            exampleText.inputText();

            int number = 0;
            Console.WriteLine("You can wrap it with basic filter: ");
            Console.WriteLine("Press 1 for pointy brackets");
            Console.WriteLine("Press 2 for two slashes");
            Console.WriteLine("Press 3 for corner brackets");
            Console.WriteLine("Press 9 for exit");
            while (number != 9) {


                Console.WriteLine("Your word is: " + exampleText.getText());
                Console.WriteLine("Enter number: ");
                number = Convert.ToInt32(Console.ReadLine());

                switch (number) {
                    case 1: exampleText = new Pointy(exampleText); Console.WriteLine(exampleText.getText()); break;
                    case 2: exampleText = new Slash(exampleText); Console.WriteLine(exampleText.getText()); break;
                    case 3: exampleText = new Corner(exampleText); Console.WriteLine(exampleText.getText()); break;
                    case 9: break;
                    default: break;

                }

            }

          

            
        }
    }
}
