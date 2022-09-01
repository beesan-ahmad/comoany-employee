using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using task3.Repo;
using task3.Mdels;
namespace task3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        private readonly IEmployeeInterface _EmployeeRepo;
        public EmployeeController(IEmployeeInterface EmployeeRepo)
        {
            _EmployeeRepo = EmployeeRepo;
        }


        [HttpGet]
        public ActionResult<List<Employee>> GetAll()
        {
            return Ok(_EmployeeRepo.GetAll());
        }
        [HttpGet("{id}")]
        public ActionResult<Employee> Get(int id)
        {

            return Ok(_EmployeeRepo.Get(id));

        }
        [HttpDelete]

        public ActionResult<bool> Delete(int id)
        {
          
            return Ok(_EmployeeRepo.delete(id));
        }
        [HttpPost]
        public ActionResult<Employee> Creat(Employee employee)
        {
           
            return Ok(_EmployeeRepo.add(employee));
        }
        [HttpPut]
        public ActionResult<Employee> Update(Employee employee)
        {
           
            return Ok(_EmployeeRepo.update(employee));
        }
    }
    //

}
