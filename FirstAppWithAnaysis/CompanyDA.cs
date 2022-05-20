using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppWithAnaysis
{
    public  class CompanyDA
    {
        public virtual List<Employee> Employees { get; set; }
        public int GetNumber()
        {
            return 100;
        }
        public string GetName()
        {
            return "No Name";
        }
    }
}
