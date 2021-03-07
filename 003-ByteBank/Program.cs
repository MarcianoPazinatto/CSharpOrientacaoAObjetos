using System;

namespace _003_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;
            contaDaGabriela.saldo = 100;

            ContaCorrente contaDaAna = new ContaCorrente();
            contaDaAna.titular = "Gabriela";
            contaDaAna.agencia = 863;
            contaDaAna.numero = 863452;
            contaDaAna.saldo = 100;

            if(contaDaGabriela.saldo == contaDaAna.saldo)
            {
                Console.WriteLine("Valores são iguais.");
            }
        }
    }
}
