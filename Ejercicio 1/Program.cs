using System;

namespace Ejercicio_1
{
    class Program
    {
        /*
         Pedir dos números por consola y mostrar el resultado:
            a. Si son iguales muestro el cuadrado del número.
            b. Si el primero es divisible por el segundo, los resto, de lo contrario muestro solo el resto.
            c. si el resto es mayor a 3(tres) informar por consola.
        */

        static void Main(string[] args)
        {
            int num1 = int.MaxValue;
            int num2 = int.MaxValue;
            int resultado = 0;
            Console.WriteLine("---------- Ejercicio 1 ----------");
            do
            {
                Console.WriteLine("Ingrese un numero:");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese otro numero:");
                num2 = int.Parse(Console.ReadLine());
            } while (num1 == int.MaxValue && num2 == int.MaxValue);

            if(num1 == num2)
            {
                resultado = num1 * num2;
                Console.WriteLine("------------------------------");
                Console.WriteLine("El cuadrado de {0} es {1}.", num1, resultado);
                Console.WriteLine("------------------------------{0}", Environment.NewLine);
            }

            if(num1 % num2 == 0)
            {
                resultado = num1 - num2;
                Console.WriteLine("------------------------------");
                Console.WriteLine("La resta entre {0} y {1} da como resultado {2}.", num1, num2, resultado);
                Console.WriteLine("------------------------------{0}", Environment.NewLine);
            }
            else
            {
                resultado = num1 % num2;
                Console.WriteLine("------------------------------");
                Console.WriteLine("El resto de la division de {0} por {1} da como resultado {2}.", num1, num2, resultado);
                Console.WriteLine("------------------------------{0}", Environment.NewLine);
                if(resultado > 3)
                {
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("El resto es mayor a 3.");
                    Console.WriteLine("------------------------------{0}", Environment.NewLine);
                }
            }
        }
    }
}
