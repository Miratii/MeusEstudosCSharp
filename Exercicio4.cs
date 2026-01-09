Console.WriteLine("Insira o valor da compra\n");

var compra = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Insira o número de parcelas\n");

var parcelas = Convert.ToInt32(Console.ReadLine());

switch (parcelas)
{
case 1:
        Console.WriteLine($"O valor do produto em {parcelas}x será de R$ {compra / parcelas}");

        break;

case 2:
        Console.WriteLine($"O valor do produto em {parcelas}x será de R$ {compra / parcelas}");
        break;
case 3:
        Console.WriteLine($"O valor do produto em {parcelas}x será de R$ {compra / parcelas}");
        
        break;

default: Console.WriteLine("A compra só pode ser feita em até 3 vezes!");
        
break;

}
Console.ReadKey ();