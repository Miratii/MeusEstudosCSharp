Console.WriteLine("#---Loop with Label and Goto---#\n");

int i = 1;

repetir:

Console.WriteLine($" i={i}");

i++;

if (i <= 10) 

goto repetir;

Console.WriteLine("\nThe software will be shut down.");

Console.ReadKey();

