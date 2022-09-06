using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBancarioHeranca
{
    internal class ContaCorrente: Conta
    {
        private double limite;
        private double jurosChequeEspecial;

        public double getLimite()
        {
            return limite;
        }
        public void setLimite(double Limite)
        {
            this.limite = Limite;
        }
        public double getJurosChequeEspecial()
        {
            return jurosChequeEspecial;
        }
        public void setJurosChequeEspecial(double JurosChequeEspecial)
        {
            this.jurosChequeEspecial = JurosChequeEspecial;
        }

        public ContaCorrente():base()
        {
            limite = 0;
            jurosChequeEspecial = 0;
        }
        public ContaCorrente(double saldo, int numero, double Limite, double JurosChequeEspecial):base(saldo,numero)
        {
            this.limite= Limite;
            this.jurosChequeEspecial= JurosChequeEspecial;
        }

        public bool Sacar(double valor)
        {
            if (valor > 0 && valor <= getSaldo() + getLimite())
            {
                setSaldo(getSaldo() - valor);
                if (getSaldo() == 0)
                {
                    setLimite(getLimite() + getSaldo());
                }
                return true;
            }
            return false;
        }

        public void calcularJuros(double taxa)
        {
            if (taxa > 0)
            {
                setJurosChequeEspecial((getSaldo() * taxa) + getSaldo());
            }
        }

        public override string consultarSaldo()
        {
            return base.consultarSaldo() + "\nLimite: " + getLimite() + "\nJuros do cheque especial: " + getJurosChequeEspecial();
        }
    }
}
