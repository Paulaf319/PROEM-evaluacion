using System;

namespace Ejercicio_3
{
    class Program
    {
        /*
        Realizar el algoritmo que permita el ingreso de 10 bolsas de alimento para mascotas,
        con los kilos (validar entre 0 y 500) , sabor validar (carne vegetales pollo) e informar por consola:
            a. El promedio de los kilos totales.
            b. La bolsa más liviana y su sabor
            c. La cantidad de bolsas sabor carne y el promedio de kilos de sabor carne
        */

        static void Main(string[] args)
        {
            Console.WriteLine("---------- Ejercicio 3 ----------{0}", Environment.NewLine);
            int peso, promedio, promediocarne;
            int totalpesobolsas = 0;
            int totalpesocarne = 0;
            int cantidadcarne = 0;
            int pesobolsaliviana = int.MaxValue;
            string sabor;
            string saborbolsaliviana = "ninguno";
            bool flag = true;
            for (int i = 0; i < 10; i++)
            {
                do
                {
                    Console.WriteLine("Ingrese el peso de la bolsa de alimento en kilos:");
                    peso = int.Parse(Console.ReadLine());
                    if (ValidarPeso(peso))
                    {
                        totalpesobolsas = totalpesobolsas + peso;
                        flag = false;
                    }
                } while (flag);
                flag = true;
                do
                {
                    Console.WriteLine("Ingrese el sabor de la bolsa de alimento:");
                    sabor = Console.ReadLine().ToLower();
                    if (ValidarSabor(sabor))
                    {
                        flag = false;
                    }
                    if(sabor == "carne")
                    {
                        cantidadcarne++;
                        totalpesocarne = totalpesocarne + peso;
                    }
                    if (peso < pesobolsaliviana)
                    {
                        pesobolsaliviana = peso;
                        saborbolsaliviana = sabor;
                    }
                } while (flag);
                Console.WriteLine("Datos ingresados correctamente.{0}", Environment.NewLine);
            }
            promedio = totalpesobolsas / 10;
            promediocarne = totalpesocarne / cantidadcarne;
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("Usted ingreso:{0}{0}10 bolsas de alimento para mascotas con un peso promedio de {1}.{0}La bolsa mas liviana que ingreso es sabor '{2}' y tiene un peso de {3} kilos.{0}{4} bolsas de alimento sabor 'carne' con un promedio de {5} kilos.", Environment.NewLine, promedio, saborbolsaliviana, pesobolsaliviana, cantidadcarne, promediocarne);
            Console.WriteLine("--------------------------------------------------------------------------------");
        }
        static bool ValidarPeso(int peso)
        {
            if(peso > 0 && peso <= 500)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool ValidarSabor(string sabor)
        {
            if (sabor == "carne" || sabor == "vegetales" || sabor == "pollo")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
