using task3.Mdels;
using task3.Repo;

namespace task3.Repo
{
    public interface ICompanyInterface
    {
        public List<Company> GetAll();
        public Company Get(int id);
        public  bool delete(int id);

        public Company add(Company company);
        public Company update(Company company);
    }



    public class CompanyRepo : ICompanyInterface
    {

        List<Company> companies { get; set; } = new List<Company>()
            {
                new Company() { companyId = 1, Name = "iConnect", Location ="Holanda-Street"},
                new Company() { companyId = 2, Name = "Exalt",Location ="Ramallah" },
                new Company() { companyId = 3, Name = "Soft Uni",Location ="Hebron" },
                new Company() { companyId = 4, Name = "Paltel",Location ="Bethlehem" }
        };
        //CompanyRepo()
        //{
        //    companies = new List<Company>()
        //    {
        //        new Company() { companyId = 1, Name = "iConnect", Location ="Holanda-Street"},
        //        new Company() { companyId = 2, Name = "Exalt",Location ="Ramallah" },
        //        new Company() { companyId = 3, Name = "Soft Uni",Location ="Hebron" },
        //        new Company() { companyId = 4, Name = "Paltel",Location ="Bethlehem" }
        //};
        //}
        public List<Company> GetAll()
        {
            return companies;
        }
        public Company Get(int id)
        {
            return companies.FirstOrDefault(company => company.companyId == id);
        }
        public bool delete(int id)
        {
            var company = Get(id);
            if (company != null)
                companies.Remove(company);
            return true;
        }

        public Company add(Company company)
        {
            companies.Add(company);
            return company;
        }

        public Company update(Company company)
        {
            var index = companies.FindIndex(e => e.companyId == company.companyId);
            if (index == -1)

                companies[index] = company;

            return company;

        }
    }





}
