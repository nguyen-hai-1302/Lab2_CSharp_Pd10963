using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public partial class Bai2
    {
        public void Bai2a()
        {
            var userInfp = new
            {
                id = "2024",
                name = "faker",
                isplaying = false,
                bag = new
                {
                    skins = 0,
                    cups = 20,
                }

            };
            Console.WriteLine("ID: " + userInfp.id);
            Console.WriteLine("Name: " + userInfp.name);
            Console.WriteLine("IsPlaying: " + userInfp.isplaying);
            Console.WriteLine("Bag Skins: " + userInfp.bag.skins);
            Console.WriteLine("Bag Cups: " + userInfp.bag.cups);
        }
    }
}
