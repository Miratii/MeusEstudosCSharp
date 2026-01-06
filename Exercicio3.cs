using System.ComponentModel.Design;

Console.WriteLine("---Verificação de Aprovação Estudantil---\t");

Console.WriteLine("\nInsira a nota do(a) aluno(a):");

var aluno = Convert.ToDouble(Console.ReadLine());

if (aluno < 5 )
{
    Console.WriteLine("Aluno reprovado!");
}

else if (aluno >= 5 && aluno > 6.9)
{
    Console.WriteLine("Aluno em recuperação!");
}
else
{
    Console.WriteLine("Aluno aprovado");    
}
