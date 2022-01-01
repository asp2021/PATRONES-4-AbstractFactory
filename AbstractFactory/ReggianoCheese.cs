using System;
using static System.Console;

namespace AbstractFactory
{
    internal class ReggianoCheese : ICheese
    {
        public ReggianoCheese()
        {
            Write("Agregando el queso parmesano" + Environment.NewLine);
        }
    }
}