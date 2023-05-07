using NumerosAleatoriosIO.Services;

GeneradorService GeneradorService = new();

var cuadrados = GeneradorService.ParteCentralDelCuadrado(
    digitosDeseados: 3,
    semilla: 12467,
    totalDeNumerosaGenerar: 8);

var lehmer = GeneradorService.Lehmer(
    semilla: 35451,
    constanteMultiplicativa: 73,
    totalDeNumerosaGenerar: 8);

var multiplicativo = GeneradorService.CongruencialMultiplicativo(
    constanteMultiplicativa :5631, 
    semilla: 1317,
    modulo: 547, 
    totalDeNumerosaGenerar: 8,
    digitos: 3);

var aditivo = GeneradorService.CongruencialAditivo(
    listaSemilla: new List<int>
    {
        1942,
        2372,
        5131,
        3317
    },
    modulo: 5147,
    totalDeNumerosaGenerar:8,
    digitos: 3);

var mixto = GeneradorService.CongruencialMixto(
    semilla: 1237,
    constanteMultiplicativa: 4309,
    constanteAditiva: 2311,
    modulo: 6031,
    digitos: 3,
    totalDeNumerosaGenerar: 8) ;



Console.WriteLine();
Console.WriteLine("Cuadrados");
Console.WriteLine();
foreach (var item in cuadrados)
{
    Console.WriteLine(item);
}

Console.WriteLine();
Console.WriteLine("Lehmer");
Console.WriteLine();
foreach (var item in lehmer)
{
    Console.WriteLine(item);
}

Console.WriteLine();
Console.WriteLine("Multiplicativo");
Console.WriteLine();
foreach (var item in multiplicativo)
{
    Console.WriteLine(item);
}


Console.WriteLine("Aditivo");
foreach (var item in aditivo)
{
    Console.WriteLine(item);
}

Console.WriteLine("Mixto");
Console.WriteLine();
foreach (var item in mixto)
{
    Console.WriteLine(item);
}

