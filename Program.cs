using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // case sensitive
            // variable and constants
            // dataTYpe <variable_name>
            
            // string Name;
            // auto detect dataType => var
            // var name = "dakasakti";
            string name = "Dakasakti";

            const float Pi = 3.14f;
           
            // fast make CW tab
            Console.WriteLine(name);
            Console.WriteLine(Pi);

            // identifier
            // not number in the first, not space, keyword use @int, meaningful names.
            // naming conventions => [camelCase => variable, PascalCase => constants].
            // dataType names is lowercase.

            // Primitive Types => integer
            // nonPrimitive Types => string, array, enum, class

            // overflow
            // checked
            // {
            //     byte num = 255;
            //     num += 1;
            // }

            // scope

            // check min and max value
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue); // 0 - 255

            // Type Conversion
            // Implicit
            byte num = 1;
            int newNum = num;
            
            // Explicit (casting)
            int number = 1;
            byte newNumber = (byte)number;

            // Non-Compatible
            string numberName = "1";
            // int i = (int)numberName;

            // Convert
            var res = Convert.ToByte(numberName);
            Console.WriteLine(res);
            // ToByte(), ToInt16(), ToInt32(), ToInt64(), ToBoolean()

            // exception
            try
            {
                string greaterNumber = "1000";
                byte convertByte = Convert.ToByte(greaterNumber);
                Console.WriteLine(convertByte);
            }
            catch (Exception)
            {
                Console.WriteLine("number cannot be converted");
            }

        }

        // Operators
        // Aritmethic
        // +, -, *, /, %
        // Increment, Decrement
        
        // Comparison
        // ==, !=, >=, <=, >, <
        
        // Assignment
        // =, +=, -=, *=, /=, 
        
        // Logical
        // &&, ||, !

        // Bitwise
        // &, |
    }
}