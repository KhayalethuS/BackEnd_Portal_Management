using EmployeeAPI.Data;
using EmployeeAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAPI.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class EmployeesController : Controller
    {
        private readonly DBContext _dbContext;   

        public EmployeesController(DBContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetEmplyees()
        {
            var emplyees = await _dbContext.Employees.ToListAsync();

            return Ok(emplyees);    
        }

        [HttpPost]
        public async Task<IActionResult> CreateEmployee([FromBody] Employee requestBody)
        {
            requestBody.Id = Guid.NewGuid();

            await _dbContext.Employees.AddAsync(requestBody);
            await _dbContext.SaveChangesAsync();

            return Ok(requestBody);    
        }
    }
}
