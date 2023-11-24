using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opr3
{
    public class matrix3
    {
        public int opred3por(int[,] ar)
        {
            int res = ar[0, 0] * ar[1, 1] * ar[2, 2] + ar[0, 1] * ar[1, 2] * ar[2, 0] + ar[1, 0] * ar[2, 1] * ar[0, 2] - ar[0, 2] * ar[1, 1] * ar[2, 0] - ar[0, 1] * ar[1, 0] * ar[2, 2] - ar[0, 0] * ar[1, 2] * ar[2, 1];
            return res;
        }
    }
}
