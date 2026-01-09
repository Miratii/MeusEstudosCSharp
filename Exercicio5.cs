Console.WriteLine("##---Verificação de impar ou par---##\t");

Console.WriteLine("\nDigite um número");

int num = Convert.ToInt32(Console.ReadLine());

switch (num % 2)
{

    case 0:
        Console.WriteLine($"O {num} é PAR");
        break;
    case 1:
        Console.WriteLine($"O {num} é IMPAR");
        break;

}


