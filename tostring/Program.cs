// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var nome = "Edson";
var sobrenome = "Santos";

var nomeCompleto = nome + " " + sobrenome;
var nomeCompleto2 = $"{nome} {sobrenome}";

Console.WriteLine(nomeCompleto2);

Console.WriteLine(nomeCompleto2.ToUpper());
Console.WriteLine(nomeCompleto2.ToLower());

Console.WriteLine(nomeCompleto2.Substring(5, 3));

Console.WriteLine(nomeCompleto2.Contains('o'));
Console.WriteLine(nomeCompleto2.Contains('z'));

Console.WriteLine(nomeCompleto2.StartsWith('E'));
Console.WriteLine(nomeCompleto2.EndsWith('s'));

Console.WriteLine(nomeCompleto2.IndexOf('s'));
Console.WriteLine(nomeCompleto2.LastIndexOf('s'));