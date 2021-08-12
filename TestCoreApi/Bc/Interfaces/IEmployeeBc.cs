using System;
using System.Collections.Generic;
using TestCoreApi.Models;

namespace TestCoreApi.Bc.Interfaces
{
    public interface IEmployeeBc
    {
        List<Employee> GetEmployeeList();
    }
}
