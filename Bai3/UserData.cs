using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    public class UserData
    {
        public int Id;
        public string userName;
        public List<float> Scores;
        public UserData()
        {
            Id = 0;
            userName = "null";
            Scores = new List<float>();
        }
    }  
    
}
