using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace ClassLibrary1

{
    public class HelloWorld
    {
        public static void Main(string[] argv)
        {
            argvTest(argv);
        }

        private static void argvTest(string[] argv)
        {
            
            Console.WriteLine("HelloWorld");
            if (argv.Length > 1)
            {
                var var1 = long.TryParse(argv[0], out long min);
                var var2 = long.TryParse(argv[1], out long max);
                if (var1 && var2)
                {
                    long value = (max - (min - 1)) * (max + min) / 2;
                    Console.WriteLine(value);
                    long value2 = 0;
                    for (long i = min; i <= max; i++)
                    {
                        value2 += i;
                        
                    }

                    List<string> a = new List<string>();
                    a.Add("a");
                    
                      
                    Console.WriteLine(a[0]);
                    
                    Console.WriteLine(value2);
                }
                else
                {
                    Console.WriteLine("Data type Error");
                }
            }
            else
            {
                Console.WriteLine("Parameter not enough");
            }
        }
        
    }
}