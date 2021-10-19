using System;

namespace SOLID.OCP.NewSolution
{

    public static class BankTerminalFactory
    {
        public static T Create<T>() where T : IBankTerminal, new()
        {
            return new T();
        }
    }
}