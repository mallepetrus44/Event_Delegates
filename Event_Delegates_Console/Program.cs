using System;

delegate void MeDelegate();

namespace Event_Delegates_Console
{
    class Program
    {
        static void Main()
        {
            InvokeTheDelegate(Foo);
            InvokeTheDelegate(new MeDelegate(Goo));
        }

        static void InvokeTheDelegate(MeDelegate deler)
        {
            deler();
        }

        static void Foo()
        {
            Console.WriteLine("Foo()");
        }

        static void Goo()
        {
            Console.WriteLine("Goo()");
        }
    }
}
