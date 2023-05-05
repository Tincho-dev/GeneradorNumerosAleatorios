// See https://aka.ms/new-console-template for more information
using NumerosAleatoriosIO.Services;

Console.WriteLine("Hello, World!");

Console.WriteLine("/n Usamos el nuevo generador /n");
GeneradorService GeneradorService = new();

var num2 = GeneradorService.ParteCentralDelCuadrado(3,123,4);
foreach (var item in num2)
{
    Console.WriteLine(item);
}