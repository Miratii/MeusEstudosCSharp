using System;
using System.Collections.Generic;
using System.Text;

namespace Pratica
{
    class Funcionário3 : Funcionario
    {
        public int Idade { get; set; }

        public override double ParticipacaoLucro()
        {
            return base.ParticipacaoLucro() * 0.3;
        }
    }
}