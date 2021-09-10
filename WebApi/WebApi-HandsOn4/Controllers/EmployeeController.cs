using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_HandsOn3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employees = new List<Employee>()
        {
            new Employee(){Id = 1, Name = "John", Salary = 40000, DateOfBirth = Convert.ToDateTime("1999/2/21"), Permanent = false },
            new Employee(){Id = 2, Name = "John2", Salary = 40001, DateOfBirth = Convert.ToDateTime("1999/3/21"), Permanent = true },
            new Employee(){Id = 3, Name = "John3", Salary = 40002, DateOfBirth = Convert.ToDateTime("1999/4/21"), Permanent = false }
        };
        // GET: api/<EmployeeController>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpGet("empList")]
        public ActionResult<Employee> empList()
        {
            return Ok(employees);
        }

        // GET api/<EmployeeController>/5
        [HttpPut]
        public ActionResult empList(int id)
        {
            Employee emp = employees.SingleOrDefault(e => e.Id == id);
            if (emp != null)
                return Ok(emp);
            return NotFound($"Emp Id {id} was not found");
        }

        // POST api/<EmployeeController>
        [HttpPost("NewEmployee")]
        public void NewEmployee([FromBody] Employee emp)
        {
            employees.Add(emp);
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public ActionResult UpdateEmployee([FromBody] Employee emp)
        {
            Employee employee = employees.Find(e => e.Id == emp.Id);
            if (employee != null)
            {
                employee.Id = emp.Id;
                employee.Name = emp.Name;
                employee.Salary = emp.Salary;
                return Ok(employee);
            }
            else
            {
                return BadRequest("Invalid employee id");
            }
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            Employee emp = employees.SingleOrDefault(e => e.Id == id);
            employees.Remove(emp);
        }
    }
}
