using System;
using static System.Console;

namespace AbstractFactory
{
    internal class MarinaraSauce : ISauce
    {
        public MarinaraSauce()
        {
            Write("Agregando la salsa marinara" + Environment.NewLine);
        }
    }
}