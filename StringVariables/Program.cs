using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringVariables {
    internal class Program {
        static void Main(string[] args) {
            char firstLetter = 'A';
            Console.WriteLine(firstLetter);

            firstLetter = (char)(firstLetter + 1);
            Console.WriteLine(firstLetter);

            string name = "Victor";
            Console.WriteLine(name);

            string fullName = "Victor " +
                "Hugo " +
                "Manduca " +
                "Rizo";
            Console.WriteLine(fullName);

            string langs = @"
                - .net
                 - java
                - python";
            Console.WriteLine(langs);

            Console.ReadLine();
        }
    }
}
