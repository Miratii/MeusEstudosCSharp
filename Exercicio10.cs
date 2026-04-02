Console.WriteLine("Coordenada com do-while");

var x = 0;

do
{
    int y = 0;
    do
    {
        Console.Write($"({x},{y}) " );
        y++;
    }
    while (y < 5);
    x++;
    Console.WriteLine();
}
while (x < 5);

Console.WriteLine("\n The software will be shut down");
Console.ReadKey();