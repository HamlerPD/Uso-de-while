//Calcular promedio

int suma = 0;
int valor1 = 0;
int valor2 = 0;
int valor3 = 0;
decimal promedio = 0;
string linea = string.Empty;

Console.WriteLine(" Digite el primer numero");
linea = Console.ReadLine();
valor1 = int.Parse(linea);

Console.WriteLine(" Digite el primer numero");
linea = Console.ReadLine();
valor2 = int.Parse(linea);

Console.WriteLine(" Digite el primer numero");
linea = Console.ReadLine();
valor3 = int.Parse(linea);

while (valor1 >=0 && valor2 >= 0 && valor3 >= 0)
{
    suma = valor1 + valor2 + valor3;
    promedio = suma / 3;
    Console.WriteLine(" La suma de los 3 digitos es: " + suma + " y el promedio es igual" + promedio);
    break;
}
