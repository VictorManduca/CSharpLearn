using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatVariables {
    internal class Program {
        static void Main(string[] args) {
            int age = 22; // 32 bits
            double salary = 1200.66;
            double finalSalary = age * salary;
            Console.WriteLine("The final salary is: " + finalSalary);

            age = (int)salary;
            Console.WriteLine("Casted age is: " + age);

            long bigSalary = 10_000_000_000; // 64 bits
            Console.WriteLine("Big salary is: " + bigSalary);

            short qtyProducts = 150; // 16 bits
            Console.WriteLine("Quantity of product is: " + qtyProducts);

            float height = 1.70f;
            Console.WriteLine("My height is: " + height);

            /*
             * boolean = 1 byte
             * byte = 1 byte
             * short = 2 bytes
             * char = 2 bytes
             * int = 4 bytes
             * float = 4 bytes
             * long = 8 bytes
             * double = 8 bytes
            */

            Console.ReadLine();
        }
    }
}
