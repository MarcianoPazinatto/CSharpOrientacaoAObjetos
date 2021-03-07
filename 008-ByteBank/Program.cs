using System;

namespace _008_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(423, 123);

            Cliente cliente = new Cliente();

            cliente.Nome = "Marcos";
            cliente.CPF = "06405866947";
            cliente.Profissao = "Arquiteto";

            conta.Titular = cliente;
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
            conta.Saldo = 10;
            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);
            Console.WriteLine(conta.Titular.Nome);

            ContaCorrente contaDaGabriela = new ContaCorrente(867, 86745820);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
        }
    }
}
