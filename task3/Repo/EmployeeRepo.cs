using task3.Mdels;
using task3.Repo;

namespace task3.Repo
{
    public interface IEmployeeInterface
    {
        List<Employee> GetAll();
        Employee Get(int id);
        public bool delete(int id);

        Employee add(Employee empoloyee);
        Employee update(Employee empoloyee);
    }



    public class EmployeeRepo : IEmployeeInterface
    {

        List<Employee> employees { get; set; } = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Beesan",Age = 25, companyId = 1},
                new Employee() { Id = 2, Name = "Emran",Age = 21, companyId = 2 },
                new Employee() { Id = 3, Name = "sara",Age = 30, companyId = 1},
                new Employee() { Id = 4, Name = "Ali",Age = 35, companyId = 3},
                new Employee() { Id = 5, Name = "Deema",Age = 35, companyId = 4}
    };
        //EmployeeRepo()
        //{
        //}
        public List<Employee> GetAll()
        {
            return employees;
        }
        public Employee Get(int id)
        {
            return employees.FirstOrDefault(employee => employee.Id == id);
        }
        public bool delete(int id)
        {
            var employee = Get(id);
            if (employee != null)
                employees.Remove(employee);
                    return true;
        }

        public Employee add(Employee employee)
        {
            employees.Add(employee);
            return employee;
        }

        public Employee update(Employee employee)
        {
            var index = employees.FindIndex(e => e.Id == employee.Id);
            if (index == -1)

                employees[index] = employee;

            return employee;

        }
    }





}
