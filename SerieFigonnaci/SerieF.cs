using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieFigonnaci
{
    public class SerieF
    {
        private int num1;
        
        public int Getnum1()
        {
            return num1;
        }

        public void Setnum1(int value)
        {
            num1 = value;
        }


        public int[] serieFigo()
        {
            if(num1 <= 1)
            {
                throw new ArgumentException("el numero debe de ser mayor a 1");
            }

            int[] seie = new int[num1];
            seie[0] = 0;
            seie[1] = 1;

            for (int i = 2; i< num1; i++) 
            {
                seie[i] = seie[i - 1] + seie[i - 2];
            }

            return seie;
        }

    }
}
