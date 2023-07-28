// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] numero = new int[3];
numero[0] = 10;
numero[1] = 11;
numero[2] = 12;

Console.WriteLine(numero[0]);
Console.WriteLine(numero[1]);
Console.WriteLine(numero[2]);


int[] pares = new int[3] {2, 4, 6};
Console.WriteLine(pares[0]);
Console.WriteLine(pares[1]);
Console.WriteLine(pares[2]);

int[] impares = new int[] {1, 3, 5, 7};
Console.WriteLine(impares[0]);
Console.WriteLine(impares[1]);
Console.WriteLine(impares[2]);
Console.WriteLine(impares[3]);

string[] nomes = new [] {"Edson", "Kadu", "Fernando"};
Console.WriteLine(nomes[0]);
Console.WriteLine(nomes[1]);
Console.WriteLine(nomes[2]);

string[] paises = {"Brasil", "EUA", "China"};
Console.WriteLine(paises[0]);
Console.WriteLine(paises[1]);
Console.WriteLine(paises[2]);

var cidades = new [] {"São Paulo", "Guarulhos"};
Console.WriteLine(cidades[0]);
Console.WriteLine(cidades[1]);