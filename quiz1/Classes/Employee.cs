using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz1
{
    class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public int salary { get; set; }

        //Constructor
        public Employee() { };
        public Employee(int id, string name, int salary) {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }

        //Use a generic collection to put 5 employees in that
        public List<Employee> GetEmployees()
        {
            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(new Employee(1, "Daniek", 50000));
            employeeList.Add(new Employee(2, "John", 75000));
            employeeList.Add(new Employee(3, "Bob", 55300));
            employeeList.Add(new Employee(4, "Mark", 61555));
            employeeList.Add(new Employee(4, "Jim", 31852));

            return employeeList;
        }

        //Iterate through the collection and Write the name of the employee in the console.
        public void printAllNames() {
            foreach (Employee employee in this.GetEmployees())
            {
                Console.WriteLine(employee.name);
            }
        }

        //Use delegate to find the lowest and highest salary among the employee
        //

        //4- Use Dictionary to keep the values of Information of 5 employees in question 2.
        //a.Use employeeId as the key and the office address as the value.
        //Will use name not address
        public Dictionary<int, string> GetEmployeeDictionary() {

            Dictionary<int, string> employees = new Dictionary<int, string>();

            foreach (Employee employee in this.GetEmployees()) {
                employees.Add(employee.id, employee.name);
            }

           return employees;
        }
        
    }
}
