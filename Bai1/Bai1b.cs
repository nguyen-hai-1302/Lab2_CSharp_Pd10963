using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    public partial class Bai1
    {
        public void Bai1b()
        {
            getDetail(10);
            getDetail("games");
            getDetail(true);
            getDetail(9.5);
        }
        public void getDetail(dynamic value)
        {
           Console.WriteLine("value: " + value);
        }
    }
}
