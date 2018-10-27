using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exampleText
{
    public interface IText
    {
        string getText();
        string inputText();

    }

    //text base
    public class Text : IText
    {
        public string text;


        public string inputText() {

            text = Console.ReadLine();
            return text;
        }
        public string getText()
        {
            return text;
        }
    }
}
