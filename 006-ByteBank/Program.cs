using System;

namespace _006_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            conta.numero = 86712540;
            conta.agencia = 876;
            conta.SetSaldo(11);
            Console.WriteLine(conta.GetSaldo());
        }
    }
}
