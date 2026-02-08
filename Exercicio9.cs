Console.WriteLine("---Testando do-while---");

var i = 1;

Console.WriteLine($"i = {i}");


do
{
    Console.WriteLine($"i = {i}");
    i++;
    if (i > 7)
        break;
}
while (i <= 10);

Console.WriteLine("The software will be shut down.");
Console.ReadKey();

