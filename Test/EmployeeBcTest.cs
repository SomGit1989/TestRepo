using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TestCoreApi.Bc.Implementations;
using TestCoreApi.Bc.Interfaces;
using TestCoreApi.Models;

namespace Test
{
    [TestClass]
    public class EmployeeBcTest
    {
        EmployeeBc _employeeBc;
        public EmployeeBcTest()
        {

        }
        //public EmployeeBcTest(IEmployeeBc employeeBc)
        //{
        //    _employeeBc = employeeBc;
        //}
        [TestMethod]
        public void TestGetEmployeeList()
        {
            _employeeBc = new EmployeeBc();
            var expectedData = new List<Employee>
            {
                new Employee
                {
                    EmpId=1,
                    FirstName="Somnath",
                    LastName="Dey",
                    MobileNo="8564789325"
                }
            };
            var actualData = _employeeBc.GetEmployeeList();
            for (int i = 0; i < expectedData.Count; i++)
            {
                Assert.AreEqual(expectedData[i].EmpId, actualData[i].EmpId);
                Assert.AreEqual(expectedData[i].FirstName, actualData[i].FirstName);
                Assert.AreEqual(expectedData[i].LastName, actualData[i].LastName);
                Assert.AreEqual(expectedData[i].MobileNo, actualData[i].MobileNo);
            }
        }
    }
}
