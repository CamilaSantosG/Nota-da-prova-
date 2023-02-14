// See https://aka.ms/new-console-template for more information
decimal prova1;
decimal prova2;
decimal media;


Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine("Digite as notas");
Console.ResetColor();

Console.Write("Nota da prova 1:");
prova1 = Convert.ToDecimal(Console.ReadLine());

Console.Write("Nota da prova 2:");
prova2 = Convert.ToDecimal(Console.ReadLine());

media = (prova1 + prova2) / 2;
Console.WriteLine($"Média: {media}");

if (media >= 5)
{
    Console.WriteLine("Aprovado");
}
else
{
Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Reprovado");
    Console.ResetColor();
}
