Console.WriteLine("#---Portal do Aluno---#\n");

Console.WriteLine("Escolha a opção desejada:\n 1. Verificar aprovação \n 2.Gerador de Tabuada de Estudos\n 3. Gerar mapa de Coordenadas\n 0. Sair\n");

int opcao = Convert.ToInt32(Console.ReadLine());
double nota;
while (opcao != 0)
{


switch (opcao)
    {
    case 1:
        Console.WriteLine("Bem vindo (a) ao portal de notas! Por favor digite sua nota:");
        
        nota = Convert.ToDouble(Console.ReadLine());

        if (nota >= 6)
            Console.WriteLine("Você foi aprovado! Parabéns! Pressione 0 para sair:");
        else
        {
            Console.WriteLine("Você foi está de recuperação. Converse com a coordenação para mais informações.\nPressione 0 para sair:");

            
        }
            if (opcao == 0)
            {
                break;
            }
            break;
    }
}






