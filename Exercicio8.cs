Console.WriteLine("---#Tabuada usando instruções lógicas!!---#");

int numero;
int contador = 1;

Console.WriteLine("Digite um número maior que zero");
numero = Convert.ToInt32(Console.ReadLine());

if (numero > 0)
{
    Console.WriteLine($"A tabuada de {numero} é:  ");
    while (contador < 11)
    {

        Console.WriteLine($"{numero} x {contador} = {numero * contador}");
        contador++;
    }

}

else
{

    Console.WriteLine("O número precisa ser maior que zero!!");


}
Console.WriteLine("O software será encerrado.");
Console.ReadKey();