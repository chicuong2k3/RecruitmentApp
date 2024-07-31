using RecruitmentApp.Models;

namespace RecruitmentApp.DataAccess
{
    // Dependency Injection
    public interface ICompanyRepository
    {
        Company? GetCompanyById(int id);
        void CreateCompany(Company company);
        bool DeleteCompany(int id);
    }
}
