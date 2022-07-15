string nombre;
string apellido;
int edad;
string Ciudad;
Console.WriteLine("Ingrese su nombre");
nombre = Console.ReadLine();
Console.WriteLine("Ingrese su apellido");
apellido = Console.ReadLine();
Console.WriteLine("Ingrese su edad");
edad=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("¿Sabes Programar? 1-Si 2-No");
int sabeprogramar= Convert.ToInt32(Console.ReadLine());
string respuesta;
if (sabeprogramar == 1)
{
    respuesta = "Sabes Programar";
}
else
{
    respuesta= "No sabes porgramar";
}
Console.WriteLine("Ingrese su cuidad");
Ciudad = Console.ReadLine();
Console.WriteLine("Hola " + nombre + " " +apellido+ " Tu edad es " + edad + " Eres de la cuidad de " + Ciudad + " Y " + respuesta);

Console.WriteLine("--------------------------------------------------");
Console.WriteLine("Ejercicio 2");
//Coche
int puertas;
int ruedas;
string marca;
bool itvVigente;
//Mesa 
double peso;
float alto;
string material;
string color;
Console.WriteLine("--------------------------------------------------");
Console.WriteLine("Ejercicio 3");
int a = 10;
string A = "a";
Console.WriteLine("10 es mayor o iugal 18 "+ (a >= 18));
Console.WriteLine("Un char es 'a' " + (A == "a"));
Console.WriteLine("10 es mayor o iugal 18 y Un char es 'a' " + (18 > a && A == "a"));
Console.WriteLine("10 es mayor o iugal 18 o Un char es 'a' " + (18 > a || A == "a"));




