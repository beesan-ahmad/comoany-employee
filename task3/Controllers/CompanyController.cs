using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using task3.Repo;
using task3.Mdels;
namespace task3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController: ControllerBase
    {
        public ICompanyInterface _CompanyRepo;
        public CompanyController( ICompanyInterface CompanyRepo )
        {
        _CompanyRepo=CompanyRepo;
        }
        [HttpGet]
        public ActionResult<List<Company>> GetAll()
        {
            return Ok(_CompanyRepo.GetAll());
        }
        [HttpGet("{id}")]
        public ActionResult<Company> Get(int id)
        {
            return Ok(_CompanyRepo.Get(id));

        }
        [HttpDelete]

        public ActionResult<bool> Delete(int id)
        {
           /* var company = CompanyRepo.Get(id);
            if (company == null)
                return NotFound();
            CompanyRepo.delete(id);*/
            return Ok(_CompanyRepo.delete(id));
        }
        [HttpPost]
        public ActionResult<Company> Creat(Company company)
        {
         
            return Ok(_CompanyRepo.add(company));
        }
        [HttpPut]
      public ActionResult<Company> Update(Company company)
        {
           /* var company = CompanyRepo.Get(company.companyId);
            if(company == null)
                return NotFound();
            CompanyRepo.update(company);*/
            return Ok(_CompanyRepo.update(company));
        }
    }
    //

}
