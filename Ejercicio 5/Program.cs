using System;

namespace Ejercicio_5
{
    class Program
    {
        /*
        Realizar el algoritmo que permita ingresar el nombre de un estudiante, la edad
        (validar) , el sexo (validar) y la nota del final (validar) hasta que el usuario quiera e
        informar al terminar el ingreso por consola:
            a. La cantidad de varones aprobados
            b. El promedio de notas de los menores de edad
            c. El promedio de notas de los adolescentes.
            d. El promedio de notas de los mayores
            e. El promedio de notas por sexo.
        */
        static void Main(string[] args)
        {
            Console.WriteLine("---------- Ejercicio 5 ----------");
            char continuar;
            bool flag = true;
            int edad;
            float nota;
            char sexo;
            int cantidadmenores = 0;
            int cantidadadolescentes = 0;
            int cantidadmayores = 0;
            float totalnotamenores = 0;
            float totalnotaadolescentes = 0;
            float totalnotamayores = 0;
            int cantidadf = 0;
            int cantidadm = 0;
            int cantidadx = 0;
            float totalnotaf = 0;
            float totalnotam = 0;
            float totalnotax = 0;
            int cantidadmaprobados = 0;
            do
            {
                do
                {
                    Console.WriteLine("{0}Ingrese la edad del estudiante:", Environment.NewLine);
                    edad = int.Parse(Console.ReadLine());
                    if(ValidarEdad(edad))
                    {
                        flag = false;
                    }
                    if(edad < 13)
                    {
                        cantidadmenores++;
                        
                    }
                    else if(edad < 19 && edad >= 13)
                    {
                        cantidadadolescentes++;
                    }
                    else
                    {
                        cantidadmayores++;
                    }                    
                } while (flag);
                flag = true;
                do
                {
                    Console.WriteLine("{0}Ingrese el sexo del estudiante:", Environment.NewLine);
                    sexo = char.Parse(Console.ReadLine().ToLower());
                    if (ValidarSexo(sexo))
                    {
                        flag = false;
                    }                   
                } while (flag);
                flag = true;
                do
                {
                    Console.WriteLine("{0}Ingrese la nota del estudiante:", Environment.NewLine);
                    nota = int.Parse(Console.ReadLine());
                    if(ValidarNota(nota))
                    {
                        flag = false;
                    }
                    if (edad < 13)
                    {
                        totalnotamenores = totalnotamenores + nota;

                    }
                    else if (edad < 19 && edad >= 13)
                    {
                        totalnotaadolescentes = totalnotaadolescentes + nota;
                    }
                    else
                    {
                        totalnotamayores = totalnotamayores + nota;
                    }
                    if (sexo == 'f')
                    {
                        cantidadf++;
                        totalnotaf = totalnotaf + nota;
                    }
                    else if (sexo == 'm')
                    {
                        cantidadm++;
                        totalnotam = totalnotam + nota;
                        if(nota >= 6)
                        {
                            cantidadmaprobados++;
                        }
                    }
                    else
                    {
                        cantidadx++;
                        totalnotax = totalnotax + nota;
                    }
                } while (flag);
                Console.WriteLine("{0}--- Si desea continuar ingresando datos presione 's', sino ingrese cualquier otra letra:", Environment.NewLine);
                continuar = char.Parse(Console.ReadLine());
            } while (continuar != 's');
            double promediomenores = totalnotamenores / cantidadmenores;
            double promedioadolescentes = totalnotaadolescentes / cantidadadolescentes;
            double promediomayores = totalnotamayores / cantidadmayores;
            double promediof = totalnotaf / cantidadf;
            double promediom = totalnotam / cantidadm;
            double promediox = totalnotax / cantidadx;
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("De los datos ingresados:{0}{0}Se hallaron {1} alumnos de sexo 'm' aprobados.{0}El promedio de notas de los menores de edad es de {2}.{0}El promedio de notas de los adolescentes es de {3}.{0}El promedio de notas de los mayores de edad es de {4}.{0}El promedio de notas de los alumnos 'f' es de {5}.{0}El promedio de notas de los alumnos 'm' es de {6}.{0}El promedio de notas de los alumnos 'x' es de {7}.{0}", Environment.NewLine, cantidadmaprobados, promediomenores, promedioadolescentes, promediomayores, promediof, promediom, promediox);
            Console.WriteLine("--------------------------------------------------------------------------------");
        }
        static bool ValidarEdad(int edad)
        {
            if(edad > 0 && edad < 99)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool ValidarSexo(char sexo)
        {
            if(sexo == 'f' || sexo == 'm' || sexo == 'x')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool ValidarNota(float nota)
        {
            if(nota >= 0 && nota <= 10)
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
