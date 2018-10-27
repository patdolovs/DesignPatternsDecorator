using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exampleText
{
    class Slash : IText
    {

        IText _text;

        public Slash(IText text) {
            _text = text;
        }
        public string getText()
        {
            return "//" + _text.getText() + "//";
        }

        public string inputText()
        {
            throw new NotImplementedException();
        }
    }
}
