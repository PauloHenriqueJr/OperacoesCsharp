﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacoesCsharp.Basicas
{
    public class Divisao
    {
        public double Calcular(double dividendo, double divisor)
        {
            if(divisor == 0)
            {
                return 0;
            }
            return dividendo / divisor;
        }
    }
}
