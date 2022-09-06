using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBancarioHeranca
{
    internal class ContaPoupanca: Conta
    {
        private double reajusteMensal;
        
        public double getReajusteMensal()
        {
            return reajusteMensal;
        }
        public void setReajusteMensal(double ReajusteMensal)
        {
            this.reajusteMensal = ReajusteMensal;
        }

        public ContaPoupanca():base()
        {
            reajusteMensal = 0;
        }
        public ContaPoupanca(double saldo, int numero, double ReajusteMensal):base(saldo,numero)
        {
            this.reajusteMensal = ReajusteMensal;
        }

        public void calcularRendimento(double taxa)
        {
            if (taxa > 0)
            {
                setReajusteMensal(getSaldo() * taxa);
                atualizarSaldo();
            }
        }

        private void atualizarSaldo()
        {
            setSaldo(getSaldo() + getReajusteMensal());
        }

        public override string consultarSaldo()
        {
            return base.consultarSaldo() + "\nReajuste mensal: " + reajusteMensal;
        }
    }
}
