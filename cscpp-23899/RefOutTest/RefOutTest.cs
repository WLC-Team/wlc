using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOutTest
{
    class RefOutTest
    {
 

        public RefOutTest()
        {
 
        }
        private void RefAdd(ref int a, ref int b)
        {
            a = a + 2;
            b = b + 3;
        }
        private void OutAdd( int a, int b, out int z)
        {
            z = a + b + 3;
        }
        public int RefOutTestExecute()
        {
            int x = 0;
            int y = 0;
            RefAdd(ref x, ref y);
            int z = 0;
            OutAdd(x, y , out z);
            if( z ==  8)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}
