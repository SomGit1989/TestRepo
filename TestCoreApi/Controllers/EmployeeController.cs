using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TestCoreApi.Bc.Interfaces;
using TestCoreApi.Models;

namespace TestCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        IEmployeeBc _employeeBc;
        public EmployeeController(IEmployeeBc employeeBc)
        {
            _employeeBc = employeeBc;
        }
        [HttpGet]
        [Route("getAllEmployee")]
        public List<Employee> GetAllEmployees()
        {
            var empList = _employeeBc.GetEmployeeList();
            return empList;
        }
    }
}
