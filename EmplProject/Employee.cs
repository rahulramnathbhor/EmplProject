using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace EmplProject
{
    internal class Employee
    {
        int id, bs, allow, total, pf, pt, np;
        string name;
        public Employee()
        {
            id = 1;
            bs = 0;
            allow = 0;
            total = 0;
            pf = 0;
            pt = 0;
            np = 0;
            name = "abc"; 

        }
        public Employee(int id, int bs, int allow, int total, int pf, int pt, int np, string name)
        {
            this.id = id;
            this.bs = bs;
            this.allow = allow;
            this.total = total;
            this.pf = pf;
            this.pt = pt;
            this.np = np;
            this.name = name;
        }
        public int TotalSalary()
        { return total=bs+allow;
        }  
          public int NetPaid()
          {
          return np = total - pf - pt;

          }
    }
}



   


