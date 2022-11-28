using System;
using System.Collections.Generic;
using System.Linq;

namespace Unit15._4._2
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
                new Employee() { DepartmentId = 2, Name = "Виктор ", Id = 3},
                new Employee() { DepartmentId = 3, Name = "Альберт ", Id = 4},
            };

            var result = departments.GroupJoin(
                employees,
                d => d.Id,
                employee => employee.DepartmentId,
                (d, empl) => new
                {
                    DepartmentName = d.Name,
                    Employees = empl.Select(e => e.Name)
                });

            foreach (var group in result)
            {
                Console.WriteLine("Отдел: " + group.DepartmentName);
                foreach (var employee in group.Employees)
                {
                    Console.WriteLine(employee);
                }
                Console.WriteLine();
            }
        }
    }
}
