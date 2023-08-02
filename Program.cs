using System;
using System.Collections.Generic;

namespace Calculadora
{
    class Program
    {
        static List<String> operadores = new List<string>();
        static List<Double> valores = new List<double>();

        static void Inicio()
        {
            Console.WriteLine("Escribe un valor y apreta enter");
            valores.Add(Int32.Parse(Console.ReadLine()));
            Console.WriteLine("Escribe un operador y apreta enter");
            String operador = Console.ReadLine();
            switch (operador)
            {
                case "+":
                    Operacion(operador);
                    break;
                case "-":
                    Operacion(operador);
                    break;
                case "*":
                    Operacion(operador);
                    break;
                case "/":
                    Operacion(operador);
                    break;
                case "=":
                    Resultado();
                    break;
                default:
                    break;
            }

        }

        static void Operacion(String value)
        {
            operadores.Add(value);
            Inicio();
        }

        static void Resultado()
        {
            Double resultado = valores[0];

            for (int i = 0; i < valores.Count() - 1; i++)
            {
                Double numero = valores[i + 1];
                switch (operadores[i])
                {
                    case "+":
                        resultado += numero;
                        break;
                    case "-":
                        resultado -= numero;
                        break;
                    case "*":
                        resultado *= numero;
                        break;
                    case "/":
                        resultado /= numero;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine("El resultado es: " + resultado);
        }

        static void Main(string[] args)
        {
            Inicio();
            Console.ReadKey();
        }
    }
}