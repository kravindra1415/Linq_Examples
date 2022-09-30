using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1;

public class SelectDemo
{
    public void Test()
    {
        List<Employee> employees = new List<Employee>()
{
        new Employee(){Id=1, Name="Tom",Email="tom@gmail.com"},
        new Employee(){Id=2, Name="sam",Email="sam@gmail.com"},
        new Employee(){Id=3, Name="david",Email="david@gmail.com"},
        new Employee(){Id=4, Name="ross",Email="ross@gmail.com"},
        new Employee(){Id=5, Name="kane",Email="kane@gmail.com"},
};

        //query syntax => getting all records
        //var getEmployee = (from e in employees
        //                   select e).ToList();

        //method syntax
        //var getEmployee = employees.Select(e => e);


        //get all using the Id, Name
        //var getEmployee = (from e in employees select e.Id).ToList();
        //here, if we Select(e=>e.name) then the employee object contains all the names property in the employees

        //var getEmployee = employees.Select(e => e.Name).ToList();


        //Q. get all the property but select only name and Id.

        //var getEmployee = (from emp in employees
        //                   select new Employee()
        //                   {
        //                       Id = emp.Id,
        //                       Name = emp.Name
        //                   }).ToList();


        //Q. get all the property but select only name and Id. and assign to the new class i.e; Student

        //var getEmployee = (from emp in employees
        //                   select new Student()
        //                   {
        //                       StudentId = emp.Id,
        //                       FullName = emp.Name
        //                   }).ToList();

        //var getEmployee = employees.Select(emp => new Student()

        //{
        //    StudentId = emp.Id,
        //    FullName = emp.Name
        //}).ToList();


        //Q. convert data to some anonymous type
        //here we not declare any specific type

        //var getEmployee = (from emp in employees
        //                   select new
        //                   {
        //                       newId = emp.Id,
        //                       newFullName = emp.Name
        //                   }).ToList();


        //var getEmployee = employees.Select(emp => new
        //{
        //    newId = emp.Id,
        //    newFullName = emp.Name
        //}).ToList();

        //Q. How to select data using index.

        //var getEmployee = employees.Select((emp, index) => new { Index = index, Name = emp.Name, Email = emp.Email }).ToList();

        var getEmployee = (from emp in employees
                           from index in emp.Id.ToString()
                           select new { Index = index, Name = emp.Name, Email = emp.Email }).ToList();


        foreach (var employee in getEmployee)
        {
            Console.WriteLine($"Id : {employee.Index} | Name : {employee.Name} | Email : {employee.Email}");
        }
    }
}
