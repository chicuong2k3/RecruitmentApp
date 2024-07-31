
using RecruitmentApp.Models;

namespace RecruitmentApp.DataAccess
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly AppDbContext dbContext;

        public CompanyRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void CreateCompany(Company company)
        {
            dbContext.Companies.Add(company);
            dbContext.SaveChanges();
        }

        public bool DeleteCompany(int id)
        {
            var company = dbContext.Companies.FirstOrDefault(x => x.Id == id);

            if (company != null)
            {
                dbContext.Companies.Remove(company);
                dbContext.SaveChanges();
                return true;
            }
            
            return false;
        }

        public Company? GetCompanyById(int id)
        {
            return dbContext.Companies.FirstOrDefault(x => x.Id == id);
        }
    }
}
