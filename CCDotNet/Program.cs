using System;
using CCDotNet.Emulation.State;

namespace CCDotNet
{
    class Program
    {
        static IComputerState state;
        
        static void Main(string[] args)
        {
            state = new NLuaComputerState();
            Console.ReadKey();
        }
    }
}