using System;
using System.Collections.Generic;
using System.Linq;

namespace Unit15._4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var departments = new List<Department>()
            {
                new Department() {Id = 1, Name = "Программирование"},
                new Department() {Id = 2, Name = "Продажи"}
            };

            var employees = new List<Employee>()
            {
                new Employee() { DepartmentId = 1, Name = "Инна", Id = 1},
                new Employee() { DepartmentId = 1, Name = "Андрей", Id = 2},
                new Employee() { DepartmentId = 2, Name = "Виктор", Id = 3},
                new Employee() { DepartmentId = 3, Name = "Альберт", Id = 4},
            };

            var result = from employee in employees
                join d in departments on employee.DepartmentId equals d.Id
                select new
                {
                    Name = employee.Name,
                    Department = d.Name,
                    DepartmentId = d.Id,
                };

            // выведем результаты
            foreach (var item in result)
                Console.WriteLine($"{item.Name} - {item.Department} ({item.DepartmentId})");
        }
    }
}
