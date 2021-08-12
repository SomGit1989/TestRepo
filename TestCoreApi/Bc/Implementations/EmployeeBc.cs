using System;
using System.Collections.Generic;
using TestCoreApi.Bc.Interfaces;
using TestCoreApi.Models;

namespace TestCoreApi.Bc.Implementations
{
    public class EmployeeBc : IEmployeeBc
    {
        public List<Employee> GetEmployeeList()
        {
            return new List<Employee> {
                new Employee
                {
                    EmpId=1,
                    FirstName="Somnath",
                    LastName="Dey",
                    MobileNo="8564789325"
                }
            };
        }
    }
}
