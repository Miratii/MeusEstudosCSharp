using System;
using System.Collections.Generic;
using System.Text;

namespace Pratica
{
    class Funcionario
    {
        public string Nome { get; set; }
        public Char Sexo { get; set; }

        public virtual double ParticipacaoLucro()
        {

            return 120000;
        }
    }
    
}
