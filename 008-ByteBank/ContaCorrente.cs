using System;
using _008_ByteBank;

namespace _008_ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular{get; set;}

        public static int TotalDeContasCriadas { get; private set; }

        
        private int _agencia;
        public int Agencia{
            get
            {
                return _agencia;
            }
            set 
            {
                if (value <= 0)
                {
                    return;
                }
                _agencia = value;
            }   

        }
        public int Numero{get; set;}




        
        private double _saldo;


        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;

            }
        }
        
        public ContaCorrente (int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

            ContaCorrente.TotalDeContasCriadas++;
        }

        public bool Sacar(double valor)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            else
            {
                this._saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            this._saldo += valor;
        }
        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            else
            {
                this._saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }
    }
}
