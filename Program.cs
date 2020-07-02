using System;

namespace MonoDebuggerTest
{
    class Program
    {
        static void Main(string[] args)
        {
#if X86
            Console.WriteLine("X86");
#elif ANYCPU
            Console.WriteLine("AnyCPU");
#else
            Console.WriteLine("None");
#endif
            Console.ReadLine();
        }
    }
}
