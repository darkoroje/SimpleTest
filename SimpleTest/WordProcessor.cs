using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//simple test

//Test 


namespace SimpleTest
{
    // Main class for the library. In this case it just calls TextBeautifuer, but a more complex case may 
    // use multiple internal classes

    public class WordProcessor : IWordProcessor
    {
        private static ILogger logger = new ConsoleLogger();

        public string BeautifyText(string text)
        {
            var processor = new TextBeautifier(logger);
            return processor.BeautifyText(text);
        }

    }
}
