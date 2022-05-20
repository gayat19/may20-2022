using System;

namespace FirstAppWithAnaysis // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        void Something()
        {
            Console.WriteLine("Hello from something");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Employee person = new Employee();
            Console.WriteLine(person.Salary);
        }
    }
}