using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Titular
{
    internal class Cliente
    {
        public string nome { get; set; }
        public string cpf { get; set; }
        public string profissao { get; set; }
        public static int numeroClientes { get; set; }
        public Cliente()
        {
            numeroClientes++;
        }
    }
}
