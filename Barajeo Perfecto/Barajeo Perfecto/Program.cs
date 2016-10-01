using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Barajeo_Perfecto
{
    class Program
    {
        static void Main(string[] args)
        {

            Baraja b = new Baraja();
            b.CargarBarajas();
            b.Barajeo();
            b.Mostrar();
            Console.Read();
        }
    }
}
