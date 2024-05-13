using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserData userData = new UserData();
            Console.WriteLine("Nhap Id: ");

            String ID = Console.ReadLine();

            userData.Id = Convert.ToInt32(ID);

            Console.WriteLine("UserData.id: " + userData.Id);

            Console.WriteLine("Nhap danh sach Diem: ");
            Console.WriteLine("So Luong diem can nhap: ");
            int soLuongDiem = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < soLuongDiem; i++)
            {
                Console.WriteLine("Nhap diem: ");
                String diem = Console.ReadLine();
                userData.Scores.Add(Convert.ToInt32(diem));
            }
            foreach (double score in userData.Scores)
            {
                Console.WriteLine("Diem: " + score);
            }
            Console.ReadLine();
        }        
    }
}
