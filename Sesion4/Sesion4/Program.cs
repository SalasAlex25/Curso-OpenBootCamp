Console.WriteLine("Ejercicio 1:");
Console.WriteLine("Ingrese un numero para mostrar su tabla del 10");
int num1;
int numero = 0;

num1 = Convert.ToInt32(Console.ReadLine());
while (numero < 11)
{
    Console.WriteLine(num1 + "*" + numero + "=" + num1 * numero);
    numero++;
}
Console.WriteLine("------------------------------------------------------------------------------------------------");
Console.WriteLine("Ejercicio 2: ");
int num2;
int contadorPositvo = 0;
int contadorNegativo = 0;
int salir;

do
{
    Console.WriteLine("Ingrese un numero para saber si es positivo o negativo");
    num2 = Convert.ToInt32(Console.ReadLine());
    if (num2 == 0)
    {
        Console.WriteLine("Tu numero es 0");

    }
    if (num2 < 0)
    {
        Console.WriteLine("Tu numero es negativo");
        contadorNegativo++;
    }
    if (num2 > 0)
    {
        Console.WriteLine("Tu numero es positivo");
        contadorPositvo++;
    }
    Console.WriteLine("Contador de positivos:  " + contadorPositvo);
    Console.WriteLine("Contador de negativos:  " + contadorNegativo);
    Console.WriteLine("Desea Continuar 1-Si 2-No ");
    salir = Convert.ToInt32(Console.ReadLine());
} while (salir == 1);
Console.WriteLine("------------------------------------------------------------------------------------------------");
Console.WriteLine("Ejercicio 3: ");
int ancho, alto, x, y;
Console.WriteLine("Ingrese el ancho del cuadrado");
ancho = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese el alto del cuadrado");
alto = Convert.ToInt32(Console.ReadLine());


for (x = 1; x <= alto; x++)
{
    for (y = 1; y <= ancho; y++)
    {
        Console.Write("* ", y);
    }
    Console.WriteLine(" ");
}