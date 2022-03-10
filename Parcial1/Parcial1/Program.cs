using System;
using System.Collections.Generic;
using System.Linq;

namespace Parcial1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arraAlcancia50 = new List<int>();
            List<int> arraAlcancia100 = new List<int>();
            List<int> arraAlcancia200 = new List<int>();
            List<int> arraAlcancia500 = new List<int>();
            List<int> arraAlcancia1000 = new List<int>(); 
            int moneda = 0;
            string tipoMoneda = "";
            int total = 0;
            string opcion = "";
            Console.WriteLine("Integrantes frayder simarra y Luis Padilla!");
            Console.WriteLine("Bienvenido a su alcancía!");
            do
            {
                Console.WriteLine("---------------------Opciones----------------!");
                Console.WriteLine("Ingresar Dinero                            [1]");
                Console.WriteLine("Ver total dinero guardado                  [2]");
                Console.WriteLine("Ver Cantidad Monedas guardadas             [3]");
                Console.WriteLine("Ver Cantidad Monedas especifica            [4]");
                Console.WriteLine("Ver Cantidad Dinero por Moneda especifica  [5]");
                Console.WriteLine("Salir                                      [6]");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingresar valor de la moneda");
                        tipoMoneda  = Console.ReadLine();
                        moneda = Int32.Parse(tipoMoneda); 
                        switch (tipoMoneda)
                        {
                            case "50": 
                                arraAlcancia50.Add(moneda);
                                break;
                            case "100": 
                                arraAlcancia100.Add(moneda); 
                                break;
                            case "200":  
                                arraAlcancia200.Add(moneda);
                                break;
                            case "500": 
                                arraAlcancia500.Add(moneda);
                                break;
                            case "1000": 
                                arraAlcancia1000.Add(moneda);
                                break;
                            default:
                                Console.WriteLine("Valor de moneda invalidado solo puede insertar de 50,100,200,500,100 ");
                                break;
                        }
                        break; 

                    case "2":
                        total = 0;
                        foreach (var item in arraAlcancia50)
                        {
                            total = total + item;
                        }
                        foreach (var item in arraAlcancia100)
                        {
                            total = total + item;
                        }
                        foreach (var item in arraAlcancia200)
                        {
                            total = total + item;
                        }
                        foreach (var item in arraAlcancia500)
                        {
                            total = total + item;
                        }
                        foreach (var item in arraAlcancia100)
                        {
                            total = total + item;
                        }
                        Console.WriteLine("Su total Ahorrado es de: " + total);
                        break;
                    case "3":

                        total = 0;
                        foreach (var item in arraAlcancia50)
                        {
                            total = total + 1;
                        }
                        foreach (var item in arraAlcancia100)
                        {
                            total = total + 1;
                        }
                        foreach (var item in arraAlcancia200)
                        {
                            total = total + 1;
                        }
                        foreach (var item in arraAlcancia500)
                        {
                            total = total + 1;
                        }
                        foreach (var item in arraAlcancia100)
                        {
                            total = total + 1;
                        }
                        Console.WriteLine("Cantidad de monedas guardadas en su alcancia: " + total);
                        break;
                    case "4":
                        
                        Console.WriteLine("especificar moneda");
                        Console.WriteLine("Opcione----------");
                        Console.WriteLine("50");
                        Console.WriteLine("100");
                        Console.WriteLine("200");
                        Console.WriteLine("300");
                        Console.WriteLine("400");
                        Console.WriteLine("500");
                        Console.WriteLine("1000");
                        tipoMoneda = Console.ReadLine();
                        switch (tipoMoneda)
                        {
                            case "50":
                                total = 0;
                                foreach (var item in arraAlcancia50)
                                {
                                    total = total + 1;
                                }
                                Console.WriteLine("La Cantidad de monedas de " + tipoMoneda + " es igual a: " + total);
                                break;
                            case "100":
                                total = 0;
                                foreach (var item in arraAlcancia100)
                                {
                                    total = total + 1;
                                }
                                Console.WriteLine("La Cantidad de monedas de " + tipoMoneda + " es igual a: " + total);
                                break;
                            case "200":
                                total = 0;
                                foreach (var item in arraAlcancia200)
                                {
                                    total = total + 1;
                                }
                                Console.WriteLine("La Cantidad de monedas de " + tipoMoneda + " es igual a: " + total);
                                break;
                            case "500":
                                total = 0;
                                foreach (var item in arraAlcancia500)
                                {
                                    total = total + 1;
                                }
                                Console.WriteLine("La Cantidad de monedas de " + tipoMoneda + " es igual a: " + total);
                                break;
                            case "1000":
                                total = 0;
                                foreach (var item in arraAlcancia1000)
                                {
                                    total = total + 1;
                                }
                                Console.WriteLine("La Cantidad de monedas de " + tipoMoneda + " es igual a: " + total);
                                break;
                        }
                        break;
                    case "5":
                        tipoMoneda = "";
                        Console.WriteLine("especificar moneda");
                        Console.WriteLine("Opcione----------");
                        Console.WriteLine("50");
                        Console.WriteLine("100");
                        Console.WriteLine("200");
                        Console.WriteLine("300");
                        Console.WriteLine("400");
                        Console.WriteLine("500");
                        Console.WriteLine("1000");
                        tipoMoneda = Console.ReadLine();
                        switch (tipoMoneda)
                        {
                            case "50":
                                total = 0;
                                foreach (var item in arraAlcancia100)
                                {
                                    total = total + item;
                                }
                                Console.WriteLine("La Cantidad de monedas de " + tipoMoneda + " es igual a: " + total);
                                break;
                            case "100":
                                total = 0;
                                foreach (var item in arraAlcancia100)
                                {
                                    total = total + item;
                                }
                                Console.WriteLine("La Cantidad de monedas de " + tipoMoneda + " es igual a: " + total);
                                break;
                            case "200":
                                total = 0;
                                foreach (var item in arraAlcancia200)
                                {
                                    total = total + item;
                                }
                                Console.WriteLine("La Cantidad de monedas de " + tipoMoneda + " es igual a: " + total);
                                break;
                            case "500":
                                total = 0;
                                foreach (var item in arraAlcancia500)
                                {
                                    total = total + item;
                                }
                                Console.WriteLine("La Cantidad de monedas de " + tipoMoneda + " es igual a: " + total);
                                break;
                            case "1000":
                                total = 0;
                                foreach (var item in arraAlcancia1000)
                                {
                                    total = total + item;
                                }
                                Console.WriteLine("La Cantidad de monedas de " + tipoMoneda + " es igual a: " + total);
                                break;
                        }
                        break;
                }

            } while (opcion != "6");
        }
    }
}
