int sumar = 1;
int restar = 2;
int multiplicar = 3;
int dividir = 4;
int cero = 0;

Console.WriteLine("Ingresa el numero de la operacion para seleccionarla: 1- Suma. 2- Resta. 3- Multiplicacion. 4- Division.");
int eleccionNum = int.Parse(Console.ReadLine());
Console.WriteLine("Ingresa el primer numero de la operacion.");
int numUno = int.Parse(Console.ReadLine());
Console.WriteLine("Ingresa el segundo numero de la operacion.");
int numDos = int.Parse(Console.ReadLine());

if (eleccionNum == sumar){
    Console.WriteLine($"El resultado de {numUno} + {numDos}, es {numUno+numDos}.");
}
else if (eleccionNum == restar){
    Console.WriteLine($"El resultado de {numUno} - {numDos}, es {numUno-numDos}.");

}
else if (eleccionNum == multiplicar){
    Console.WriteLine($"El resultado de {numUno} * {numDos}, es {numUno*numDos}.");

}
else if (eleccionNum == dividir){
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

