using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;
namespace Barajeo_Perfecto
{
    class Baraja
    {
        int[] barajaFinal;
        int[] baraja1;
        int[] baraja2;
        int tam;
        int tam1;
        int tam2;
        Boolean band;
        /*
         * Metodo para Darle tamaño a las Barajas(Vectores).
         * Asignarle el valor del tamaño de la barajaFinal
         */
        public void CrearBarajas(int tam)
        {
            this.tam=tam;

            if (tam % 2 != 0)
            {
                tam1 = (tam / 2) + 1;
                band = true;
            }

            else
            {
                tam1 = (tam / 2);
                band = false;
            }
                
            tam2 = tam / 2;


            barajaFinal = new int[tam];
            baraja1=new int[tam1];

            baraja2 = new int[tam2];
            
        }


        /*
         * Metodo Para Cargar las Barajas(Vectores).
         */
        public void CargarBarajas()
        {
            StreamReader file = new StreamReader("barajeo.in");
            String linea = "";
            int cont = 0;
            
            if (file != null)
            {
                linea = file.ReadLine();
                CrearBarajas(Convert.ToInt32(linea));
                while (true)
                {
                    linea = file.ReadLine();
                    if (linea != null)
                    {
                            if (tam1 > cont)
                                baraja1[cont] = Convert.ToInt32(linea);
                            else
                                baraja2[cont-tam1] = Convert.ToInt32(linea);

                            cont++;
 
                    }
                    else
                        break;
                }
            }
        }


        /*
         * Metodo para Barajear
         * Se en carga de hacer el barajeo y dar de una carta de cada baraja a la principal
         */
        public void Barajeo()
        {
            int k=0;
            for (int i = 0; i < tam2; i++)
            {
                barajaFinal[k] = baraja1[i];
                barajaFinal[k + 1] = baraja2[i];
                k = k + 2;
            }

            if (band)
                barajaFinal[k] = baraja1[tam2];
        }


        /*
         * Mostrar los Vectores
         */
        public void Mostrar()
        {
            for (int i = 0; i < tam; i++)
                Console.WriteLine(barajaFinal[i]);
        }

        public void MostrarV()
        {
            Console.WriteLine("VEC_1:\tVEC_2:");
            for (int i = 0; i < tam2; i++)
                Console.WriteLine(baraja1[i]+"\t"+baraja2[i]);
            if (tam % 2 != 0)
                Console.WriteLine(baraja1[tam1 - 1]);
        }
    }
}
