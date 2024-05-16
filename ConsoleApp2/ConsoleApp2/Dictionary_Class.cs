using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Dictionary_Class
    {
        public static void Main(string[] args)
        {
            Dictionary<string,object> dic = new Dictionary<string,object>();
            dic.Add("eid", 1010);
            dic.Add("name", "vini");
            dic.Add("salary", 25000);
            dic.Add("location", "cbe");
            foreach(string key in dic.Keys)
            {
                Console.WriteLine(key+"the values are \t" + dic[key]);
                Console.ReadLine();
            }
        }
    }
}
