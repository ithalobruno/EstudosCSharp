﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio2
{
    class Aluno
    {
        public string Nome;
        public double Nota1, Nota2, Nota3;


        public double NotaFinal()
        {
            return (Nota1 + Nota2 + Nota3);
        }

        public bool VerificaAprovacao()
        {
            if (NotaFinal() > 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double NotaRestante()
        {
            return 60 - NotaFinal();
        }
    }
}
