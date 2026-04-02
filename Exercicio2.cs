Console.WriteLine(" ---TABELA DE DESCONTO--- \n");

Console.Write("Digite o valor do produto: ");

if (!decimal.TryParse(Console.ReadLine(), out decimal valorOriginal))
{
    Console.WriteLine("Valor inválido! Digite apenas números.");
    return;
}

Console.WriteLine("Cliente é VIP? Digite S/N");

var cliente = Console.ReadLine()?.ToUpper() ?? "N";

if (cliente == "S")
{
    const decimal taxaDesconto = 0.10m;
    decimal valorComDesconto = valorOriginal * (1 - taxaDesconto);
    Console.WriteLine("Cliente é VIP, prossiga com o desconto de 10%.\n PRESS ENTER TO CONTINUE");
    
    Console.ReadLine();

    Console.WriteLine($"O valor do produto para clientes vip é de {valorComDesconto:C2}");
}

else if (cliente == "N")
        {
    Console.WriteLine("O valor do produto não será alterado, o valor final é de {produto}");
}


Console.ReadKey();