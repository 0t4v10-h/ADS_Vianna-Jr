using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AGREGCOMP.Models
{
    public class Transacao
    {
        public DateTime DataHora{get; set;}
        public double Valor{get; set;}
        public ETipo Tipo{get; set;}

        public enum ETipo
        {
            Credito = 0,
            Debito = 1
        }
    }
}