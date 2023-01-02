using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseParcial
{
    partial class Rectangulo
    {
        private int lado1;
        private int lado2;

        public int Lado1
        {
            get
            {
                return lado1;
            }

            set
            {
                lado1 = value;
            }
        }

        public int Lado2
        {
            get
            {
                return lado2;
            }

            set
            {
                lado2 = value;
            }
        }
    }
}
