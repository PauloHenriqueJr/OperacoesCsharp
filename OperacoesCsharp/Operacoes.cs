﻿using OperacoesCsharp.Basicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacoesCsharp
{
    public class Operacoes
    {
        public Soma Soma { get; private set; }
        public Subtracao Subtracao { get; private set; }
        public Multiplicacao Multiplicacao { get; private set; }
        public Divisao Divisao { get; private set; }
        public Operacoes()
        {
            this.Soma = new Soma();
            this.Subtracao = new Subtracao();
            this.Multiplicacao = new Multiplicacao();
            this.Divisao = new Divisao();

        }

    }
}
