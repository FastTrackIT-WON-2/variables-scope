using System;

namespace VariableScope
{
    class Program
    {
        static void Main(string[] args)
        {
            // BlockScope();

            //int y = 10;
            //FunctionScope(y);
            //Console.WriteLine(y);

            ClassScope();
        }

        private static void BlockScope()
        {
            {
                // here is a block scope (parent)
                int i = 10;
                i = i + 30;
                Console.WriteLine(i);

                {
                    // here is a child block scope

                    // Not Allowed: we cannot define another variable with the same 
                    // name as a variable defined in the parent scope!
                    // int i = 5;

                    // we can re-use variables defined in the parent block scope
                    i = i * 5;
                    Console.WriteLine(i);
                }
            }

            // there are specific c# keywords that open block scopes
            // e.g.: if, for, etc
            if (true)
            {
                // here is another block scope
            }

            Console.WriteLine("----------------");

            for (int k = 0; k < 3; k++)
            {
                Console.WriteLine(k);
            }

            // for variable exists only in block scope!
            // Console.WriteLine(k);
        }

        private static void FunctionScope(int y)
        {
            // this is a function scope variable
            int x = 20;
            Console.WriteLine("x=" + x);
            Console.WriteLine("y=" + y);

            // ....
            if (true)
            {
                // 'z' is block scoped
                int z = 30;
                Console.WriteLine("z=" + z);

                if (true)
                {
                    Console.WriteLine("x=" + x);
                    Console.WriteLine("y=" + y);
                }
            }

            Console.WriteLine("x=" + x);
            Console.WriteLine("y=" + y);
        }

        private static void ClassScope()
        {
            Person p = new Person();
            p.SayHello();
        }
    }
}
