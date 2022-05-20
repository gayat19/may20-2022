using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppWithAnaysis
{
    public class EmployeeDepartment
    {
      
        private CompanyDA _da;

        public EmployeeDepartment(CompanyDA da)
        {
            _da = da;
        }
        public List<Employee> GetEmployeeByDepartment(int id)
        {
            List<Employee> _employees = _da.Employees;
            List<Employee> employees = new List<Employee>();
            foreach (Employee employee in _employees)
            {
                if(employee.department.Id==id)
                    employees.Add(employee);
            }
            return employees;
        }
    }
}
