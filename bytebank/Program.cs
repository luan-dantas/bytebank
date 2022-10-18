using bytebank.Conta;
using bytebank.Titular;
using System.Net;

Cliente cliente = new Cliente();
cliente.nome = "luan dantas";
cliente.cpf = "12345678910";
cliente.profissao = "Programador";

ContaCorrente contaDoLuan = new ContaCorrente();
contaDoLuan.titular = cliente;
contaDoLuan.numero_agencia = 15;
contaDoLuan.conta = "1010-X";
contaDoLuan.saldo = 100;
Console.WriteLine("Saldo da conta do Luan =" + contaDoLuan.saldo);
Console.WriteLine(contaDoLuan.titular.nome);

ContaCorrente conta2 = new ContaCorrente();
conta2.titular = new Cliente();
conta2.titular.nome = "Luan dantas";
conta2.titular.profissao = "tester";
conta2.titular.cpf = "74846512398";
conta2.numero_agencia = 18;
conta2.saldo = 500;

Console.WriteLine(conta2.titular.nome);
 
//ContaCorrente contaDoLuan2 = new ContaCorrente();
//contaDoLuan2.titular = "André Silva";
//contaDoLuan2.numero_agencia = 15;
//contaDoLuan2.conta = "1010-X";
//contaDoLuan2.saldo = 100;
//Console.WriteLine("Saldo da conta do André =" + contaDoLuan2.saldo);

//contaDoLuan = contaDoLuan2;

//Console.WriteLine(contaDoLuan == contaDoLuan2);

////ContaCorrente contaDaMaria = new ContaCorrente();
////contaDaMaria.titular = "Maria Souza";
////contaDaMaria.numero_agencia = 17;
////contaDaMaria.conta = "1010-5";
////contaDaMaria.saldo = 350;

//Console.WriteLine("Saldo da conta da Maria =" + contaDaMaria.saldo);

//contaDoLuan.Transferir(50, contaDaMaria);
//Console.WriteLine("Saldo do André = " + contaDoLuan.saldo);
//Console.WriteLine("Saldo da Maria = " + contaDaMaria.saldo);
//ContaCorrente contaDoPedro = new ContaCorrente();
//contaDoPedro.titular = "Pedro Silva";
//Console.WriteLine(contaDoPedro.titular);
//Console.WriteLine(contaDoPedro.saldo);
//Console.WriteLine(contaDoPedro.numero_agencia);
//Console.WriteLine(contaDoPedro.conta);