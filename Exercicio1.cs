

Console.WriteLine("--- Sistema de Notas Interativo --- \n");

Console.Write("Digite a nota 1 (Peso 1): ");
double nota1 = double.Parse(Console.ReadLine());


Console.Write("Digite a nota 2 (Peso 2): ");
double nota2 = double.Parse(Console.ReadLine());


Console.Write("Digite a nota 3 (Peso 3): ");
double nota3 = double.Parse(Console.ReadLine());


int p1 = 1, p2 = 2, p3 = 3;


double media = (nota1 * p1 + nota2 * p2 + nota3 * p3) / (p1 + p2 + p3);


Console.WriteLine($"\nA média ponderada calculada é: {media:F2}");


if (media >= 7.0)
{
    Console.WriteLine("Resultado: Aprovado!");
}
else
{
    Console.WriteLine("Resultado: Reprovado.");
}