using System;

namespace Calculadora {
    class Program {
        static void Main(string[] args){
            int operacionSuma = 1;
            int operacionResta = 2;
            int operacionMultiplicar = 3;
            int operacionDividir = 4;
            int cero = 0;

            Console.WriteLine("Ingresa el numero de la operacion para seleccionarla:");
            Console.WriteLine("1- Suma");
            Console.WriteLine("2- Resta");
            Console.WriteLine("3- Multiplicacion");
            Console.WriteLine("4- Division");
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

            if (eleccionNum == operacionSuma){
                Console.WriteLine($"El resultado de {numUno} + {numDos}, es {numUno+numDos}.");
            }
            else if (eleccionNum == operacionResta){
                Console.WriteLine($"El resultado de {numUno} - {numDos}, es {numUno-numDos}.");

            }
            else if (eleccionNum == operacionMultiplicar){
                Console.WriteLine($"El resultado de {numUno} * {numDos}, es {numUno*numDos}.");

            }
            else if (eleccionNum == operacionDividir){
                if(numUno == cero || numDos == cero){
                    Console.Write($"Error: No es posible realizar divisiones por cero.");
                }
                else{
                    Console.WriteLine($"El resultado de {numUno} / {numDos}, es {numUno/numDos}.");
                }
            }
            // else if (eleccionNum is null){
            //     // manejar en caso de null????
            // }
            else {
                Console.WriteLine($"El valor ingresado no es valido: {eleccionNum}.");
            }

        }

    }
}
