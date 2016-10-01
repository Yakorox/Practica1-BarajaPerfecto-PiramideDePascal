using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrianguloDePascal
{
    class TriDePascal
    {
        int filaGenerar;
        int[][] triPas;
        public TriDePascal(int fila)
        {
            filaGenerar = fila;

           triPas=new int[filaGenerar][];
           for (int i = 0; i < filaGenerar; i++)
               triPas[i] = new int[filaGenerar];

           for (int i = 0; i < filaGenerar; i++)
               for (int j = 0; j < filaGenerar; j++)
                   triPas[i][j] = 0;
        }

        public void GenerarTri()
        {
            int k = 0;
            triPas[0][0]=1;
            for (int i = 1; i < filaGenerar; i++)
            {
                triPas[i][0] = triPas[i][i] = triPas[0][0];
                for(int j=1;j<i;j++)
                {
                    triPas[i][j]=triPas[i-1][j-1]+triPas[i-1][j];
                }

            }
        }

        public void ImprimirTri()
        {
            int k= filaGenerar;
            for (int i = 0; i < filaGenerar; i++)
                imprimir(k--, i+1);
        }

        public void imprimir(int nivel,int j)
        {
            for (int i = 1; i < nivel; i++)
                Console.Write(" ");
         
            for (int i = 0; i < j; i++)
                Console.Write(triPas[j-1][i]+" ");
   
            Console.WriteLine();
        }

            
        
    }
}
