int Numero;

Console.WriteLine("Digite um numero...: ");
Numero = Convert.ToInt32(Console.ReadLine());

if (Numero < 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Esse Numero é Negativo");
    Console.ResetColor();
}
else
{
    if (Numero > 0)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Esse numero é Positivo");
        Console.ResetColor();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("Esse é Numero Zero");
        Console.ResetColor();

    }
}