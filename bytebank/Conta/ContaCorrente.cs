using System;
using System.Collections.Generic;
using System.Drawing;
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
                if (value > 0)
                {
                    this.numero_agencia = value;
                }
            }
        }
        public string Conta { get; set; }
        public double Saldo {get; set;}
        public static int numeroDeContas { get; set; }
        public Cliente titular { get; set; }
        public void Depositar(double valor)
        {
            this.Saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (this.Saldo >= valor)
            {
                this.Saldo -= valor;
                return true;
            }
            return false;
        }
        public bool Transferir(double valor, ContaCorrente destino)
        {
            bool sacou = Sacar(valor);
            if (sacou)
            {
                this.Saldo -= valor;
                destino.Saldo += valor;
            }
            return sacou;
        }
        public ContaCorrente(int numero_agencia, string numero_conta) { 
            this.numero_agencia = numero_agencia;
            this.Conta = numero_conta;
            numeroDeContas++;
        }
    }
}
