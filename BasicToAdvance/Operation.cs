using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicToAdvance
{
    class Operation
    {
        public void Oopeation()
        {
            string someText = "Here is Some Text";
            string someOtherText = "Here is some Text";
            bool isEqual = someText.Equals(someOtherText, StringComparison.OrdinalIgnoreCase);
            string formattedString = string.Format("{0}{1}Here is more text", someText, someOtherText);
            Console.WriteLine(formattedString);
            Console.WriteLine(someText.Length);
            Console.WriteLine(someText[8]);
            Console.WriteLine(someText.Substring(8, 4));
            Console.WriteLine(someText.ToLower());
            Console.WriteLine(someText.ToUpper());
            string anotherText = string.Empty;
            string replacedText = someText.Replace("text", "string");
        }
    }
}
