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
        public int numero_agencia;
        public string conta;
        public double saldo = 100;

        public Cliente titular;
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
