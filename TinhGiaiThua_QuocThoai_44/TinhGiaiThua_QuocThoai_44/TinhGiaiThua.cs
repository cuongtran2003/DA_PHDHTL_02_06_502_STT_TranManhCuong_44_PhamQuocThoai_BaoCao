using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhGiaiThua_QuocThoai_44
{
    public class TinhGiaiThua
    {
        public long Tinh_Giai_Thua(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Input must be non-negative", nameof(n));
            }

            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return n * Tinh_Giai_Thua(n - 1);
            }
        }
    }
}
