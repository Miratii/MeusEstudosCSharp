Console.WriteLine("Instrução for");
int num, resultado;

Console.WriteLine("\nDigite um número que deseja visualizar na tabuada");

num = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    resultado = num * i;
    Console.WriteLine($" {num} X {i} = {resultado}");
}

