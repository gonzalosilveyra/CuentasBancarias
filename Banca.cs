using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Banca
    {
        private Cuenta iCuentaEnDolares, iCuentaEnPesos;
        private string iTitular;
        private int iNumero;

        public Banca(int pNumero, string pTitular)
        {
            iCuentaEnDolares = new Cuenta(new Moneda("USD","Dólar estadounidense","$"));
            iCuentaEnPesos = new Cuenta(new Moneda("ARS", "Peso argentino", "$"));
            this.iNumero = pNumero;
            this.iTitular = pTitular;
        }  
        
        public Banca()
        {
            this.iTitular = "";
            this.iNumero = 0;
        }

        public int Numero
        {
            get { return iNumero; }
        }

        public string Titular
        {
            get { return iTitular; }
        }

        public Cuenta CuentaEnPesos
        {
            get { return iCuentaEnPesos; }
            set { iCuentaEnPesos = value; }
        }
        public Cuenta CuentaEnDolares
        {
            get { return iCuentaEnDolares; }
            set { iCuentaEnDolares = value; }
        }
    }
}
