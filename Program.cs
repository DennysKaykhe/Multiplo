double numero, multiplo;

Console.Clear();

Console.WriteLine("--- Múltiplo ---");

Console.Write("\nDigite um número...........: ");
numero = Convert.ToDouble(Console.ReadLine());

Console.Write("Avaliar se é múltiplo de...: ");
multiplo = Convert.ToDouble(Console.ReadLine());

if (numero % multiplo == 0)
{
    Console.Write($"\n{numero} é multiplo de {multiplo}");
}
else
{
    Console.Write($"\n{numero} não é multiplo de {multiplo}");
}