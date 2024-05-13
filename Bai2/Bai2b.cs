using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public partial class Bai2
    {
        public void Bai2b()
        {
            int y = 10;
            Action<int> AnonymousMethod = delegate (int x)
            {
                int sum = x + y;
                int sub = x - y;
                Console.WriteLine("Sum: " + sum);
                Console.WriteLine("Sub: " + sub);
            };
            AnonymousMethod(5);
        }
    }
}
