using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Moneda
    {
        string iCodigoISO, iNombre, iSimbolo;

        public Moneda(string pCodigoISO, string pNombre, string pSimbolo)
        {
            this.iCodigoISO = pCodigoISO;
            this.iNombre = pNombre;
            this.iSimbolo = pSimbolo;
        }

        public Moneda()
        {
            this.iCodigoISO = null;
            this.iSimbolo = null;
            this.iNombre = null;

        }
        public string CodigoISO
        {
            get { return iCodigoISO; }
        }
        public string Nombre
        {
            get { return iNombre; }
        }
        public string Simbolo
        {
            get { return iSimbolo; }
        }

    }
}
