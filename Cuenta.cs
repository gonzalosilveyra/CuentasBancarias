using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Cuenta
    {
        private double iSaldo;
        private Moneda iMoneda;

        public Cuenta(Moneda pMoneda)
        {
            this.iSaldo = 0;
            this.iMoneda = pMoneda;
        }

        public Cuenta(double pSaldoInicial, Moneda pMoneda)
        {
            this.iSaldo = pSaldoInicial;
            this.iMoneda = pMoneda;
        }

        public Cuenta()
        {
            this.iSaldo = 0;
            this.iMoneda = null;
        }

        public double Saldo
        {
            get { return iSaldo; }
        }

        public void AcreditarSaldo(double pSaldo)
        {
            this.iSaldo += pSaldo;
        }

        public Boolean DebitarSaldo(double pSaldo)
        {
            if (this.iSaldo >= pSaldo)
            {
                this.iSaldo -= pSaldo;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
