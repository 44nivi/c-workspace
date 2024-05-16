using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Customer{
     public int custid { get; set; }
    public string Name { get; set; }
    public string city { get; set; }
    public int Balance { get; set; }
        }
    internal class Class_Datatype
    {
        public static void Main(String[] args)
        {
            List<Customer> list = new List<Customer>();
            Customer c1 = new Customer { custid=101,Name="NIVI",city="CBE",Balance=25000};
            Customer c2 = new Customer { custid = 101, Name = "VIVI", city = "CBE", Balance = 25000 };
            Customer C3 = new Customer { custid = 101, Name = "PONNU", city = "CBE", Balance = 25000 };

            list.Add(c1);
            list.Add(c2);
            list.Add(C3);

            foreach(Customer c in list)
            {
                Console.WriteLine("Customer name "+c.Name);
                Console.WriteLine("Customer Balance"+c.Balance);
            }

        }
    }

    
}

