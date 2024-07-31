using Microsoft.AspNetCore.Mvc;
using RecruitmentApp.Api.Requests;
using RecruitmentApp.DataAccess;
using RecruitmentApp.Models;

namespace RecruitmentApp.Api.Controllers
{
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        private ICompanyRepository companyRepository;
        public CompaniesController(ICompanyRepository companyRepository)
        {
            this.companyRepository = companyRepository;
        }


        [HttpGet("/companies/{id}")]
        
        public IActionResult GetCompanyById(int id)
        {
            var company = companyRepository.GetCompanyById(id);

            if (company == null)
            {
                return NotFound();
            }

            return Ok(company);
        }

        [HttpPost("/companies")] // 201
        public IActionResult CreateCompany(CreateCompanyRequest request)
        {
            var company = new Company()
            {
                Email = request.Email,
                Name = request.Name,
                Address = request.Address,
                TaxId = request.TaxId,
            };

            companyRepository.CreateCompany(company);

            return Created("/companies/" + company.Id, company);
        }

        [HttpDelete("/companies")]
        public IActionResult DeleteCompany(int id)
        {
            var result = companyRepository.DeleteCompany(id);

            if (result == false)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
