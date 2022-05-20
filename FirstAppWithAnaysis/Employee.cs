namespace FirstAppWithAnaysis
{
    public class Employee : Person
    {
        public Department department;
        
        public Employee(Department department)
        {
          this.department = department;
        }
        public string DepartmentCheck(int id)
        {
            return department.Name;
        }
        public float Salary { get; set; }
        public Employee()
        {
            Salary = 1234.4f;
        }
        public Employee(float salary)
        {
            Salary = salary;
        }
        public void CheckData()
        {

            if (Salary > 1000)
                Console.WriteLine("Good");
            else if (Salary < 500)
                Console.WriteLine("ok");
        }
        public bool CheckNumber()
        {
            if(Salary > 1000)
                return true;
            return false;
        }
       
        public string GetName(string name)
        {
            if (name.Length < 3)
                throw new Exception("Test Exception");
            return "Hello " + name;
        }
    }
}
