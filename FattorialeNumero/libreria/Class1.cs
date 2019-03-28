using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libreria
{
    public class Class1
    {

        public static string fattoriale(int n1)
        {
            int risultato2 = 1;

            if (n1 >= 0)
            {
                for (int i = 1; i <= n1; i++)
                {
                    risultato2 = risultato2 * i;
                }
                return Convert.ToString(risultato2);
            }
            else
            {
             return "non puo essere negativo";
            }
            

        }
    }
}