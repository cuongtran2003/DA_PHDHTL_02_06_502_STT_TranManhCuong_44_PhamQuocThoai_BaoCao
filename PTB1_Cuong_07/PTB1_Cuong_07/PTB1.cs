using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTB1_Cuong_07
{
    public class PTB1
    {
        public static int Solve(int a, int b)
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    // Phương trình vô số nghiệm.
                    throw new ArgumentException("PTVSN");
                }
                else
                {
                    // Phương trình vô nghiệm.
                    throw new ArgumentException("PTVN");
                }
            }
            else
            {
                // Phương trình có một nghiệm duy nhất.
                return -b / a;
            }
        }
    }
}
