using System;

namespace Calculadora {
    class Program {
        static void Main(string[] args){

            Console.WriteLine("Ingresa el numero de la operacion para seleccionarla:");
            Console.WriteLine("1- Suma");
            Console.WriteLine("2- Resta");
            Console.WriteLine("3- Multiplicacion");
            Console.WriteLine("4- Division");
            Console.WriteLine("5- Porcentaje");

            string entradaOperacion = Console.ReadLine();
            if (!int.TryParse(entradaOperacion, out int eleccionNum)){
                Console.WriteLine("Entrada no válida.");
                return;
            }

            Console.WriteLine("Ingresa el primer número de la operación.");
            string entradaNumUno = Console.ReadLine();
            if (!int.TryParse(entradaNumUno, out int numUno)){
                Console.WriteLine("Entrada no válida.");
                return;
            }

            Console.WriteLine("Ingresa el segundo número de la operación.");
            string entradaNumDos = Console.ReadLine();
            if (!int.TryParse(entradaNumDos, out int numDos)){
                Console.WriteLine("Entrada no válida.");
                return;
            }

            switch (eleccionNum){
                case 1: 
                    Console.WriteLine($"El resultado de {numUno} + {numDos}, es {suma(numUno,numDos)}.");
                    break;
                case 2:
                    Console.WriteLine($"El resultado de {numUno} - {numDos}, es {resta(numUno,numDos)}.");
                    break;
                case 3:
                    Console.WriteLine($"El resultado de {numUno} * {numDos}, es {multiplicacion(numUno,numDos)}.");
                    break;
                case 4:
                    int cero = 0;
                    if(numDos == cero){
                        Console.Write($"Error: No es posible realizar divisiones por cero.");
                    }
                    else{
                    Console.WriteLine($"El resultado de {numUno} / {numDos}, es {division(numUno,numDos)}.");
                    }
                    break;
                case 5:
                    Console.WriteLine("Ingresa el número base.");
                    string entradaNumBase = Console.ReadLine();
                    if (!int.TryParse(entradaNumBase, out int numBase)){
                        Console.WriteLine("Entrada no válida.");
                        return;
                    }
                    Console.WriteLine("Ingresa el porcentaje a calcular.");
                    string entradaPorcentaje = Console.ReadLine();
                    if (!int.TryParse(entradaPorcentaje, out int porcentaje)){
                        Console.WriteLine("Entrada no válida.");
                        return;
                    }
                    double resultadoPorcentaje = calcularPorcentaje(numBase,porcentaje);
                    Console.WriteLine($"El {porcentaje}% de {numBase}, es {resultadoPorcentaje}.");
                    break;
                default:
                    Console.WriteLine($"El valor especificado no es válido: {eleccionNum}");
                    break;
            }

            static int suma(int a, int b){
                return a + b;
            }
            static int resta(int a, int b){
                return a - b;
            }
            static int multiplicacion(int a, int b){
                return a * b;
            }
            static int division(int a, int b){
                return a / b;
            }
            static double calcularPorcentaje(int numBase, int porcentaje){
                double porcentajeDecimal = (double)porcentaje / 100;
                double resultado = numBase * porcentajeDecimal;
                return resultado;
            }
        }
    }
}