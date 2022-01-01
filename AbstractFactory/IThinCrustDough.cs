using System;
using static System.Console;

namespace AbstractFactory
{
    internal class IThinCrustDough : IDough
    {
        public IThinCrustDough()
        {
            Write("Agregando masa delgada" + Environment.NewLine);
        }
    }
}