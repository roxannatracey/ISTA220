
using System;

namespace Parameters
{
    class Pass // creates a class named Pass 
    {
        private static object console;

        public static void Value(int i) // takes one parameter which is the int type
                                        // static method is a method that doesnt change and doesnt return anything
                                        // a static method is a class method and you can access(call it) it by calling the name of the class dot name of the method 
                                        // how do you call an instance method? you have to instatiate an instance first then you call it instance.method name 

        {
            i = 42;
            Console.WriteLine($" i is now {i} in value() method)"); // asigns 42 to the parameter 
        }
        public static void Reference(WrappedInt param)
        {
            param.Number = 42;
        }
        public static void Value(ref int param) // 
        {
            param = 42;
        }
    }
}
