using System;

namespace Ejercicio_2
{
    class Program
    {
        /*
        Una empresa de viajes le solicita ingresar que continente le gustaría visitar y la
        cantidad de días , la oferta dice que por día se cobra $100 , que se puede pagar de todas las maneras:
            a. Crear un método que valide continentes: recibe un continente y retorna true
        si se trata de un continente válido (América, Asia, Europa, Africa, Oceanía).
        Crear un método que valide forma de pago: recibe la forma de pago y retorna
        true si se trata de una forma de pago válido (Débito, Crédito, Efectivo,
        Mercado Pago, Cheque, Leliq)
            b. Si es América tiene un 15% de descuento y si además paga por débito se le
        agrega un 10% más de descuento
            c. Si es África u Oceanía tiene un 30% de descuento y si además paga por
        mercadoPago o efectivo se le agrega un 15% más de descuento
            d. Si es Europa tiene un 20% de descuento y si además paga por débito se le
        agrega un 15% , por mercadoPago un 10% y cualquier otro medio 5%
            e. cualquier otro continente tiene un recargo del 20%
            f. en cualquier continente , si paga con cheque, se recarga un 15% de impuesto al cheque.
        */

        static void Main(string[] args)
        {
            Console.WriteLine("---------- Ejercicio 2 ----------{0}", Environment.NewLine);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("----- Agencia de Viajes FlyAirways -----");
            Console.WriteLine("----------------------------------------");
            bool flag = true;
            string continente;
            string pago;
            int dias;
            int preciofinal;
            do
            {
                Console.WriteLine("{0}Ingrese el nombre del continente al que desea viajar:", Environment.NewLine);
                continente = Console.ReadLine().ToLower();
                if (ValidarContinente(continente))
                {
                    flag = false;
                }
            } while(flag);
            flag = true;
            do
            {
                Console.WriteLine("{0}Ingrese el metodo de pago deseado:", Environment.NewLine);
                pago = Console.ReadLine().ToLower();
                if (ValidarPago(pago))
                {
                    flag = false;
                }
            } while (flag);
            do
            {
                Console.WriteLine("{0}Ingrese la cantidad de dias que desea que dure su viaje:", Environment.NewLine);
                dias = int.Parse(Console.ReadLine());
            } while (dias <= 0);
            switch(continente)
            {
                case "america":
                    switch(pago)
                    {
                        case "debito":
                            preciofinal = Descuento(dias, 15);
                            MostrarPrecioFinal(continente, dias, preciofinal, pago);
                            break;
                        case "credito":
                            preciofinal = Descuento(dias, 15);
                            MostrarPrecioFinal(continente, dias, preciofinal, pago);
                            break;
                        case "efectivo":
                            preciofinal = Descuento(dias, 15);
                            MostrarPrecioFinal(continente, dias, preciofinal, pago);
                            break;
                        case "mercado pago":
                            preciofinal = Descuento(dias, 15);
                            MostrarPrecioFinal(continente, dias, preciofinal, pago);
                            break;
                        case "cheque":
                            preciofinal = Recargo(dias, 20);
                            MostrarPrecioFinal(continente, dias, preciofinal, pago);
                            break;
                        case "leliq":
                            preciofinal = Descuento(dias, 20);
                            MostrarPrecioFinal(continente, dias, preciofinal, pago);
                            break;
                    }
                    break;
                case "asia":
                    switch (pago)
                    {
                        case "debito":
                            preciofinal = Recargo(dias, 20);
                            MostrarPrecioFinal(continente, dias, preciofinal, pago);
                            break;
                        case "credito":
                            preciofinal = Recargo(dias, 20);
                            MostrarPrecioFinal(continente, dias, preciofinal, pago);
                            break;
                        case "efectivo":
                            preciofinal = Recargo(dias, 20);
                            MostrarPrecioFinal(continente, dias, preciofinal, pago);
                            break;
                        case "mercado pago":
                            preciofinal = Recargo(dias, 20);
                            MostrarPrecioFinal(continente, dias, preciofinal, pago);
                            break;
                        case "cheque":
                            preciofinal = Recargo(dias, 15);
                            MostrarPrecioFinal(continente, dias, preciofinal, pago);
                            break;
                        case "leliq":
                            preciofinal = Recargo(dias, 20);
                            MostrarPrecioFinal(continente, dias, preciofinal, pago);
                            break;
                    }
                    break;
                case "europa":
                    switch (pago)
                    {
                        case "debito":
                            preciofinal = Descuento(dias, 35);
                            MostrarPrecioFinal(continente, dias, preciofinal, pago);
                            break;
                        case "credito":
                            preciofinal = Descuento(dias, 25);
                            MostrarPrecioFinal(continente, dias, preciofinal, pago);
                            break;
                        case "efectivo":
                            preciofinal = Descuento(dias, 25);
                            MostrarPrecioFinal(continente, dias, preciofinal, pago);
                            break;
                        case "mercado pago":
                            preciofinal = Descuento(dias, 30);
                            MostrarPrecioFinal(continente, dias, preciofinal, pago);
                            break;
                        case "cheque":
                            preciofinal = Recargo(dias, 15);
                            MostrarPrecioFinal(continente, dias, preciofinal, pago);
                            break;
                        case "leliq":
                            preciofinal = Descuento(dias, 25);
                            MostrarPrecioFinal(continente, dias, preciofinal, pago);
                            break;
                    }
                    break;
                case "africa":
                    switch (pago)
                    {
                        case "debito":
                            preciofinal = Descuento(dias, 30);
                            MostrarPrecioFinal(continente, dias, preciofinal, pago);
                            break;
                        case "credito":
                            preciofinal = Descuento(dias, 30);
                            MostrarPrecioFinal(continente, dias, preciofinal, pago);
                            break;
                        case "efectivo":
                            preciofinal = Descuento(dias, 45);
                            MostrarPrecioFinal(continente, dias, preciofinal, pago);
                            break;
                        case "mercado pago":
                            preciofinal = Descuento(dias, 45);
                            MostrarPrecioFinal(continente, dias, preciofinal, pago);
                            break;
                        case "cheque":
                            preciofinal = Recargo(dias, 15);
                            MostrarPrecioFinal(continente, dias, preciofinal, pago);
                            break;
                        case "leliq":
                            preciofinal = Descuento(dias, 30);
                            MostrarPrecioFinal(continente, dias, preciofinal, pago);
                            break;
                    }
                    break;
                case "oceania":
                    switch (pago)
                    {
                        case "debito":
                            preciofinal = Descuento(dias, 30);
                            MostrarPrecioFinal(continente, dias, preciofinal, pago);
                            break;
                        case "credito":
                            preciofinal = Descuento(dias, 30);
                            MostrarPrecioFinal(continente, dias, preciofinal, pago);
                            break;
                        case "efectivo":
                            preciofinal = Descuento(dias, 45);
                            MostrarPrecioFinal(continente, dias, preciofinal, pago);
                            break;
                        case "mercado pago":
                            preciofinal = Descuento(dias, 45);
                            MostrarPrecioFinal(continente, dias, preciofinal, pago);
                            break;
                        case "cheque":
                            preciofinal = Recargo(dias, 15);
                            MostrarPrecioFinal(continente, dias, preciofinal, pago);
                            break;
                        case "leliq":
                            preciofinal = Descuento(dias, 30);
                            MostrarPrecioFinal(continente, dias, preciofinal, pago);
                            break;
                    }
                    break;
            }     
        }

        static void MostrarPrecioFinal(string cont, int dias, int total, string pago)
        {
            Console.WriteLine("{0}--------------------------------------------------------------------------------", Environment.NewLine);
            Console.WriteLine("Usted viajara a {0} por {1} dias y decidio abonar el total de {2} mediante {3}.", cont, dias, total, pago);
            Console.WriteLine("--------------------------------------------------------------------------------");
        }
        static int Recargo(int dias, int recargo)
        {
            int rec = (dias * 100) * recargo / 100;
            return (dias * 100) + rec;
        }
        static int Descuento(int dias, int porcentajedesc)
        {
            int desc = (dias * 100) * porcentajedesc / 100;
            return (dias * 100) - desc;
        }
        static bool ValidarContinente(string continente)
        {
            if (continente == "america" || continente == "asia" || continente == "europa" || continente == "africa" || continente == "oceania")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool ValidarPago(string pago)
        {
            if (pago == "debito" || pago == "credito" || pago == "efectivo" || pago == "mercado pago" || pago == "cheque" || pago == "leliq")
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
