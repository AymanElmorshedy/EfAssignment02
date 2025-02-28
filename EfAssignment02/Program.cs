using EfAssignment02.DbContexts;
using EfAssignment02.DbContexts.Models;

namespace EfAssignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region CRUD Operations
            #region Add to table Department
            using ITTDbContext dbContext = new ITTDbContext();
            //Department department01 = new Department()
            //{
            //    Name="Web Applications",
            //    HiringDate=DateOnly.FromDateTime(DateTime.Now),
            //    ManegerId=1,
            //};
            //dbContext.Add(department01);
            //dbContext.SaveChanges();

            #endregion

            #region Add To Tabel Students
            //Student student = new Student()
            //{
            //    FirstName="Ali",
            //    LastName="Mohamed",
            //    Address="New Cairo",
            //    Age=22,
            //    DepartmentId=10,

            //};
            //dbContext.Students.Add(student);
            //dbContext.SaveChanges();
            #endregion
            #endregion

        }
    }
}
