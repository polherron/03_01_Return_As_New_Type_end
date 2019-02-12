using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;

namespace Model
{
    public class Model
    {

        public static SampleDataContext ReadData()
        {
            SampleDataContext dbContext = new SampleDataContext();
            return dbContext;
        }

        public static void UpdateData()
        {
            using (SampleDataContext dbContext = new SampleDataContext())
            {
                Employee employee = dbContext.Employees.SingleOrDefault(x => x.ID == 4);
                employee.Salary = 65000;
                dbContext.SubmitChanges();
            }
        }

        public static void CreateData()
        {
            using (SampleDataContext dbContext = new SampleDataContext())
            {
                Employee newEmployee = new Employee
                {
                    FirstName = "Tim",
                    LastName = "T",
                    Gender = "Male",
                    Salary = 55000,
                    DepartmentId = 1
                };

                dbContext.Employees.InsertOnSubmit(newEmployee);
                dbContext.SubmitChanges();
            }
        }

        public static void DeleteData(int id)
        {
            using (SampleDataContext dbContext = new SampleDataContext())
            {
                Employee employee = dbContext.Employees.SingleOrDefault(x => x.ID == id);
                dbContext.Employees.DeleteOnSubmit(employee);
                dbContext.SubmitChanges();
            }
        }
    }
}
