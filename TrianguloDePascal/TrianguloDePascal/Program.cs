using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrianguloDePascal
{
    class Program
    {
        static void Main(string[] args)
        {
            String linea = "";
            TriDePascal tri;
            Console.WriteLine("Ingrese El Numero de Filas a Generar: ");
            linea=Console.ReadLine();
            tri = new TriDePascal(Convert.ToInt32(linea));
            tri.GenerarTri();
            tri.ImprimirTri();

            Console.Read();
        }
    }
}
