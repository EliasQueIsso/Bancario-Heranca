using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBancarioHeranca
{
    internal class Conta
    {
        private double saldo;
        private int numero;

        public double getSaldo()
        {
            return saldo;
        }
        public void setSaldo(double saldo)
        {
            this.saldo = saldo; 
        }
        public int getNumero()
        {
            return numero;
        }
        public void setNumero(int numero)
        {
            this.numero = numero;
        }
        public Conta()
        {
            saldo = 0;
            numero = 0;
        }
        public Conta(double Saldo, int Numero)
        {
            this.saldo=Saldo;
            this.numero=Numero;

        }
        public Conta(int Numero)
        {
            saldo=0;
            Numero = this.numero;
        }
        public void depositar(double valor)
        {
            if (valor > 0)
            {
                saldo = saldo + valor;
            }
        }
        public bool sacar(double valor)
        {
            if (valor > 0 && valor <= saldo)
            {
                saldo = saldo - valor;
                return true;
            }
            return false;
        }
        public void transferir(double valor, Conta destino)
        {
            if (valor > 0 && sacar(valor))
            {
                destino.depositar(valor);
            }
        }
        public virtual string consultarSaldo()
        {
            return saldo.ToString();
        }
    }
}
