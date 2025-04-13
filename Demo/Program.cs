using Demo.Data;
using Demo.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Connection
            //CompanyDbContext dbContext = new CompanyDbContext();

            //try
            //{
            //    // Crud operations: Create, Read, Update, Delete 
            //    // Query object model
            //}
            //finally
            //{
            //    // Dispose unManagment Resourcess || Realse || Free || Deallocate

            //    dbContext.Dispose();

            //}

            // Syntax sugar => Try Finally

            //---------------------------------------

            //using (CompanyDbContext dbContext = new CompanyDbContext())
            //{

            //}

            //---------------------------------------

            //using CompanyDbContext db = new CompanyDbContext(); 
            #endregion
            #region Connection
            using CompanyDbContext db = new CompanyDbContext();
            #region CRUD Operation
            Employee emp01 = new Employee()
            {
                //Code = 1, // Invalid => Code is auto increment Identity
                Name = "Islam",
                Salary = 10000,
                Age = 25,
                

            };
            Employee emp02 = new Employee()
            {
                Name = "Ahmed",
                Salary = 20000,
                Age = 30,
            };

            #region Insert
            //Console.WriteLine(db.Entry(emp02).State); //Detached
            //Console.WriteLine(db.Entry(emp01).State); //Detached

            //db.employees.Add(emp01); // add emp01 to the context
            //db.employees.Add(emp02); // add emp02 to the context
            //#region Other Ways Of Adding
            ////db.Set<Employee>().Add(emp02); 
            ////db.Add(emp02); 
            ////db.Entry(emp02).State = EntityState.Added;
            //#endregion

            //Console.WriteLine(db.Entry(emp02).State); //Added
            //Console.WriteLine(db.Entry(emp01).State); //Added

            //// Add in database
            //db.SaveChanges(); // Save changes to the database

            //Console.WriteLine(db.Entry(emp02).State); //Unchanged
            //Console.WriteLine(db.Entry(emp01).State); //Unchanged

            //Console.WriteLine("---------------------------------------------------------------");
            //Console.WriteLine($"emp01 ={emp01.Code}");
            //Console.WriteLine($"emp01 ={emp02.Code}"); 
            #endregion

            #region Read \ Retrive
            //var employee = (from emp in db.employees
            //                 where emp.Code == 8
            //                 select emp).FirstOrDefault();
            //Console.WriteLine(employee?.Name??"Not Found");
            #endregion

            #region Update
            ////var emp = db.employees.FirstOrDefault(e => e.Code == 8);
            //var emp = (from e in db.employees
            //          where e.Code == 8
            //          select e).FirstOrDefault();
            //Console.WriteLine(db.Entry(emp).State);
            //emp.Name = "Ali"; // update the name localy
            //Console.WriteLine(db.Entry(emp).State);
            //db.SaveChanges(); // update the name in the database
            #endregion

            #region Delete
            var emp = (from e in db.employees
                       where e.Code == 8
                       select e).FirstOrDefault();
            Console.WriteLine(db.Entry(emp).State);
            db.employees.Remove(emp); // remove the employee from the context locally
            Console.WriteLine(db.Entry(emp).State);
            db.SaveChanges(); // remove the employee from the database
            #endregion



            #endregion
            #endregion
        }
    }
}
