using FirstAppWithAnaysis;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppTest
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void TestDepartmentEmployee()
        {
            //Arrange
            Department department1 = new Department() { Id = 1, Name = "Ops" };
            Department department2 = new Department() { Id = 2, Name = "Admin" };
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){Id = 1,Name="Ramu",department = department1 },
                new Employee(){Id = 2,Name="Somu",department=department1 },
                 new Employee(){Id = 3,Name="Kimu",department=department2 }
            };
            Mock<CompanyDA> mock = new Mock<CompanyDA>(); 
            mock.Setup(x => x.Employees).Returns(employees);
            EmployeeDepartment empdpt = new EmployeeDepartment(mock.Object);
            //Action
            var result = empdpt.GetEmployeeByDepartment(1);
            //Assert
            Assert.AreEqual(2,result.Count());
        }
    }
}
