using System;

namespace _002_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.agencia = 123;
            conta.saldo += 123.12;
            Console.WriteLine(conta.agencia);
            Console.WriteLine(conta.titular);
            Console.WriteLine(conta.saldo);
        }
    }
}
