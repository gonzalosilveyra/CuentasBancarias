using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class RepositorioBanca
    {
        public Banca[] Bancas;
        private int cant;

        public RepositorioBanca()
        {
            this.Bancas = new Banca[100];
            this.cant = 0;
        }

        public void Agregar(Banca pBanca)
        {
            this.Bancas[cant] = pBanca;
            this.cant++;            
        }

        public Banca Obtener(int pNumero)
        {
            int lugar = -1;             
            for (int i = 0; i == this.cant-1; i++)
            {
                    if (this.Bancas[i].Numero == pNumero)
                    {
                        lugar = i;
                        break;
                    }                  
            }            
            if (lugar > -1)
            {
                return this.Bancas[lugar];
            }
            else
            {
                return null;               
            }            
        }            
    }
}