using System;

namespace Ejercicio_4
{
    class Program
    {
        /*
        Realizar el algoritmo que permita iterar el ingreso de dos datos de un vehiculo, un
        color (rojo verde o amarillo) y un valor entre 0 y 10000 hasta que el usuario quiera e
        informar al terminar el ingreso por consola:
            a. La cantidad de rojos
            b. La cantidad de rojos con precio mayor a 5000
            c. La cantidad de vehículos con precio inferior a 5000
            d. El promedio de todos los vehículos ingresados.
            e. El más caro y su color.
        */

        static void Main(string[] args)
        {
            Console.WriteLine("---------- Ejercicio 4 ----------");
            char continuar;
            bool flag = true;
            string color;
            int valor;
            int valortotal = 0;
            string colormascaro = "ninguno";
            int valormascaro = int.MinValue;
            int cantidad = 0;
            int cantidadrojos = 0;
            int cantidadrojos5000 = 0;
            int cantidadmenor5000 = 0;
            do
            {
                do
                {
                    Console.WriteLine("{0}Ingrese el color del vehiculo:", Environment.NewLine);
                    color = Console.ReadLine().ToLower();
                    if(ValidarColor(color))
                    {
                        flag = false;
                    }
                    if(color == "rojo")
                    {
                        cantidadrojos++;
                    }
                    
                } while (flag);
                flag = true;
                do
                {
                    Console.WriteLine("{0}Ingrese el valor del vehiculo:", Environment.NewLine);
                    valor = int.Parse(Console.ReadLine());
                    if (ValidarValor(valor))
                    {
                        flag = false;
                    }
                    if (valor < 5000)
                    {
                        cantidadmenor5000++;
                    }
                    valortotal = valortotal + valor;
                    if(valor > valormascaro)
                    {
                        valormascaro = valor;
                        colormascaro = color;
                    }
                    if (color == "rojo" && valor >= 5000)
                    {
                        cantidadrojos5000++;
                    }
                    cantidad++;
                } while (flag);
                Console.WriteLine("{0}--- Para detenerse presione 's', si desea continuar ingrese cualquier otra letra:", Environment.NewLine);
                continuar = char.Parse(Console.ReadLine().ToLower());
            } while (continuar != 's');
            int promedio = valortotal / cantidad;
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("Usted ingreso {0} vehiculos, de los cuales:{1}{1}{2} son de color rojo.{1}{3} rojos con un valor igual o superior a 5000.{1}{4} vehiculos con un valor inferior a 5000.{1}El promedio del valor de los {0} vehiculos ingresados es de {5}{1}El vehiculo mas caro es color '{6}' y tiene un valor de {7}..", cantidad, Environment.NewLine, cantidadrojos, cantidadrojos5000, cantidadmenor5000, promedio, colormascaro, valormascaro);
            Console.WriteLine("--------------------------------------------------------------------------------");
        }
        static bool ValidarColor(string color)
        {
            if(color == "rojo" || color == "verde" || color == "amarillo")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool ValidarValor(int valor)
        {
            if(valor > 0 && valor <= 10000)
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
