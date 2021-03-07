using System;

namespace _004_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaBruno = new ContaCorrente();

            contaBruno.titular = "Bruno";
            Console.WriteLine(contaBruno.saldo);
            bool resultadodoSaque = contaBruno.Sacar(50);
            Console.WriteLine(contaBruno.saldo);
            Console.WriteLine(resultadodoSaque);
            contaBruno.Depositar(500);
            Console.WriteLine(contaBruno.saldo);


            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";

            Console.WriteLine("Saldo do Bruno: " + contaBruno.saldo);
            Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela.saldo);

            bool resultadoTransferencia = contaBruno.Transferir(200, contaDaGabriela);

            Console.WriteLine("Saldo do Bruno: " + contaBruno.saldo);
            Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela.saldo);
            Console.WriteLine("Resultado Transferencia " + resultadoTransferencia);

            contaDaGabriela.Transferir(100, contaBruno);
            Console.WriteLine("Saldo do Bruno: " + contaBruno.saldo);
            Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela.saldo);

        }
    }
}
