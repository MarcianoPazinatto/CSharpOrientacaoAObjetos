using _005_ByteBank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente gabriela = new Cliente();
            gabriela.nome = "Gabriela";

            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = gabriela;
            contaDaGabriela.titular.cpf = "123456789-65";
            contaDaGabriela.titular.profissao = "Desenvolvedora";

            Console.WriteLine(contaDaGabriela.titular.nome);
            Console.WriteLine(contaDaGabriela.titular.cpf);
            Console.WriteLine(contaDaGabriela.titular.profissao);


        }
    }
}