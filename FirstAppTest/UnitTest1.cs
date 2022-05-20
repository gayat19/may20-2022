using FirstAppWithAnaysis;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FirstAppTest
{
    [TestClass]
    public class UnitTest1
    {
        //Department department;
        //[TestInitialize]
        //public void Fix()
        //{
        //    department = new Department();
        //    department.Id = 101;
        //    department.Name = "Check";
        //}
        //[TestMethod]
        
        //[DataRow(234.2f)]
        //[DataRow(233.4f)]
        //public void CheckNumberTestFail(float value)
        //{
        //    //Arrange
        //    Employee employee = new Employee();
        //    employee.Salary = value;
        //    //Action
        //    bool result = employee.CheckNumber();
        //    //Assert
        //    Assert.IsFalse(result);
        //}
        //[TestMethod]
        //public void CheckNumberTestPass()
        //{
        //    //Arrange
        //    Employee employee = new Employee();
        //    employee.Salary = 1908.4f;
        //    //Action
        //    bool result = employee.CheckNumber();
        //    //Assert
        //    Assert.IsTrue(result);
        //}
        
        //[TestMethod]
        //public void CheckDepartmentTest()
        //{
        //    //Arrange
           
        //    Employee employee = new Employee();
        //    employee.Salary = 1908.4f;
        //    //Action
        //    var result = employee.DepartmentCheck(department.Id);
        //    //Assert
        //    Assert.AreEqual(department.Name,result);
        //}
        [TestMethod]
        public void ExceptionTest()
        {
            Employee employee = new Employee();
            var result = Assert.ThrowsException<Exception>(()=>employee.GetName("tthe"));
            Assert.AreSame("Test Exception", result.Message);
        }
    }
}