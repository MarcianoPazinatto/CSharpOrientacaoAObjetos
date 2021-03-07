using System;

namespace _007_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            Cliente cliente = new Cliente();

            cliente.Nome = "Marcos";
            cliente.CPF = "06405866947";
            cliente.Profissao = "Arquiteto";

            conta.Titular = cliente;

            conta.Saldo = 10;
            Console.WriteLine(conta.Saldo);
            Console.WriteLine(conta.Titular.Nome);
        }
    }
}
