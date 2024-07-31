

using RecruitmentApp.Models;

namespace RecruitmentApp.DataAccess
{
    public class InMemoryCompanyRepository : ICompanyRepository
    {
        private List<Company> companyList;
        public InMemoryCompanyRepository()
        {
            companyList = new List<Company>()
            {
                new Company() { Id = 1, Name = "KMS", Address = "HCM", Email = "", TaxId = "" },
                new Company() { Id = 2, Name = "Viet Hoa", Address = "HCM", Email = "", TaxId = "" },
                new Company() { Id = 3, Name = "Hoa Sen", Address = "HCM", Email = "", TaxId = "" }
            };
        }

        public void CreateCompany(Company company)
        {
            var random = new Random();
            company.Id = random.Next(100 - companyList.Count);

            companyList.Add(company);
        }

        public bool DeleteCompany(int id)
        {
            var company = companyList.Where(x => x.Id == id).FirstOrDefault();

            if (company != null)
            {
                companyList.Remove(company);
                return true;
            }

            return false;
        }

        public Company? GetCompanyById(int id)
        {
            return companyList.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
