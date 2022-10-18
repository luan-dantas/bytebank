using bytebank.Conta;
using bytebank.Titular;
using System.Net;

Cliente cliente = new Cliente();
cliente.nome = "luan dantas";
cliente.cpf = "12345678910";
cliente.profissao = "Programador";

ContaCorrente contaDoLuan = new ContaCorrente(18,"1010-x");
contaDoLuan.titular = cliente;
contaDoLuan.Saldo=-10;


Console.WriteLine(ContaCorrente.numeroDeContas);
Console.WriteLine(Cliente.numeroClientes);
