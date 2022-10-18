using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bytebank.Titular;

namespace bytebank.Conta
{
    internal class ContaCorrente
    {
        private int numero_agencia;
        public int Numero_Agencia
        {
            get { return this.numero_agencia; }
            set { 
                if(value > 0)
                {
                    this.numero_agencia = value;
                }
            }
        }
        public string Conta { get; set; }
        private double saldo = 100;

        public Cliente titular { get; set; }
        public void Depositar(double valor)
        {
            saldo += saldo;
        }

        public bool Sacar(double valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
                return true;
            }
            return false;
        }
        public bool Transferir(double valor, ContaCorrente destino)
        {
            bool sacou = Sacar(valor);
            if (sacou)
            {
                saldo -= valor;
                destino.saldo += valor;
            }
            return sacou;
        }
     
    }
}
