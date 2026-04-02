bool continuar = true;

while (continuar)
    { 
Console.Clear();
Console.WriteLine("#---Verificação de Login---#!\t");

Console.WriteLine("Você é Gerente (1), Programador (2) ou Deseja Sair (0)?");

var cargo = Convert.ToInt32(Console.ReadLine());

switch (cargo)
{
  case 0:
            Console.WriteLine("O software será encerrado"); 
            continuar = false;
            break;
  case 1:
        Console.WriteLine("Você foi identificado como Gerente!"); 
            continuar = false;
            break;
        case 2: Console.WriteLine("Você foi identificado como programador\t");


            Console.WriteLine("\nQual a sua senioridade? (1) Junior (2) Pleno (3) Senior");
var função = Convert.ToInt32(Console.ReadLine());   

switch (função)
        {
            case 1: Console.WriteLine("Você foi identificado como Junior!"); break;
            case 2: Console.WriteLine("Você foi identificado como Pleno!");  break;
            case 3: Console.WriteLine("Você foi identificado como Sênior!"); break;
            default:Console.WriteLine("Senioridade inválida!"); break;
            }
            continuar = false;
            break;
        
        default:
            Console.WriteLine("Opção inválida! Pressione qualquer tecla para tentar novamente."); 
            Console.ReadKey();
            break;
    }

}