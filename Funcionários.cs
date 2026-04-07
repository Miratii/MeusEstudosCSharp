using Pratica;

namespace Praticapolimorf{
    class program
    {
   static void Main(string[] args)
        {
            Funcionário1 n1 = new Funcionário1();
            n1.Nome = "José";

            Funcionário2 n2 = new Funcionário2();
            n2.Nome = "Paulo";

            Funcionário3 n3 = new Funcionário3();
            n3.Nome = "Maria";

            Console.WriteLine($"Nome: {n1.Nome}\n Participação: {n1.ParticipacaoLucro().ToString()}");
            Console.WriteLine($"Nome: {n2.Nome}\n Participação: {n2.ParticipacaoLucro().ToString()}");
            Console.WriteLine($"Nome: {n3.Nome}\n Participação: {n3.ParticipacaoLucro().ToString()}");

            Console.ReadKey();
        }
    } 

}



