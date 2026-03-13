int menu = -1;
while (menu != 0)
{
    Console.WriteLine("#---Portal do Aluno---#\n");

    Console.WriteLine("Escolha a opção desejada:\n 1. Ver/Calcular minha média de notas \n 2. Matricular em uma disciplina\n 3. Visualizar meu horário de aulas\n 0. Sair\n");

    menu = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    double nota;



    switch (opcao)
    {
        case 1:
            Console.WriteLine("Bem vindo (a) ao portal de notas! Por favor digite sua nota:");

            nota = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            if (nota >= 6)
                Console.WriteLine("Você foi aprovado! Parabéns!\n");
            else
            {
                Console.WriteLine("Você foi reprovado.\nPressione 0 para sair:");


            }

            break;
    }
    if (menu != 0)
    {
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
        
    }
}





