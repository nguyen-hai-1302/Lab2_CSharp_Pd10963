using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    public class UserData
    {
        public string id;
        public string userName;
        public int level;
        public UserData(string id, string userName, int level)
        {
            this.id = id;
            this.userName = userName;
            this.level = level;
        }
        public void showData()
        {
            Console.WriteLine("ID: " + id + "|  UserName: " + userName + "|  level: " + level);
        }
    } 
}
