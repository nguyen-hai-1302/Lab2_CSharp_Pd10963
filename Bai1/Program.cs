using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{   
    class Program
    {
        
        static void Main()
        {
            Bai1 bai1 = new Bai1();
            Console.WriteLine("Bai 1a: ");
            bai1.Bai1a();
            //----
            Console.WriteLine("Bai 1b: ");
            bai1.Bai1b();
            //----
            Console.WriteLine("Bai 1c: ");
            UserData data = new UserData("1302", "CBS x Xuat Huyet", 324);
            data.showData();
            //----
            Console.ReadLine();
        }
    }
}
