using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AGREGCOMP.Models
{
    public class Conta
    {
        private double saldo;
        public int Numero{get; set;}
        public double Saldo{get; set;}

        private IList<Transacao> transacoes = new List<Transacao>();


        public void Depositar(double quantia)
        {
            this.saldo += quantia;

            transacoes.Add(new Transacao
            {
                DataHora = DateTime.Now,
                Valor = quantia,
                Tipo = Transacao.ETipo.Debito
            });
        }

        public void Sacar(double quantia)
        {
            this.saldo -= quantia;

            transacoes.Add(new Transacao
            {
                DataHora = DateTime.Now,
                Valor = quantia,
                Tipo = Transacao.ETipo.Debito
            });
        }
    }    
}

