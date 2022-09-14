using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmplProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
                Console.WriteLine(e.NetPaid());
            Employee e1=new Employee(1,0,0,0,0,0,0,"abc");
            Console.WriteLine(e1.NetPaid());
        } 
    }
}
