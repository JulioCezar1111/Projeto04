using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro_DivisorTensao
{
    class CalculosR
    {
        public double corrente(double Fonte, double R1, double R2)
        {
            double ValorCorrente = Fonte / (R1 + R2);
            return Math.Round(ValorCorrente, 3);
        }

        public double VR1(double Fonte, double R1, double R2)
        {
            double ValorVR1 = (R1 / (R1 + R2)) * Fonte;
            return Math.Round(ValorVR1, 3);
        }
        public double VR2(double Fonte, double R1, double R2)
        {
            double ValorVR2 = (R2 / (R1 + R2)) * Fonte;
            return Math.Round(ValorVR2, 3);
        }
    }
}
