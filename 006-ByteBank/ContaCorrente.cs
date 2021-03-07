using System;
using _006_ByteBank;

namespace _006_ByteBank
{
    public class ContaCorrente
    {
        public Cliente titular;
        public int agencia;
        public int numero;
        private double saldo;

        public double GetSaldo()
        {
            return this.saldo;
        }

        public void SetSaldo( double saldo)
        {
            if (saldo < 0)
            {
                return;
            }
            this.saldo = saldo;
            
        }

        public bool Sacar(double valor)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }
        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }
    }
}
