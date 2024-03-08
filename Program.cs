// See https://aka.ms/new-console-template for more information
Console.WriteLine("Numeros");

int[] primeros = new int[3];
int[] segundos = new int[3];
int suma = 0;


for (int i = 0; i < primeros.Length; i++)
{

    Console.WriteLine("Introduzca los primeros 10 numeros: {0}"+(i+1));
    Console.WriteLine();
    primeros[i] = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Introduzca los siguientes 10 numeros: {0}"+(i+1));
    segundos[i] = Convert.ToInt32(Console.ReadLine());

    

    suma = primeros[i]+segundos[i];
}

for (int i = 0; i < primeros.Length; i++)
{


}




Console.WriteLine("La suma de los 20 numeros enteros son : "+ suma);