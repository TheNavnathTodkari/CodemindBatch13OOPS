using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodemindBatch13OOPS
{
    public class Person
    {
        // Public fields 
        public string EmployeeName { get; set; }
        public string Address { get; set; }

        
        public Person(string employeeName, string address)
        {
            EmployeeName = employeeName;
            Address = address;
        }
    }
    public class Employee : Person
    {
        // Protected field
        protected int employeeID;

        
        public Employee(string employeeName, string address, int id)
            : base(employeeName, address)
        {
            employeeID = id;
        }

        
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"Employee Name: {EmployeeName}, Address: {Address}, Employee ID: {employeeID}");
        }
    }

    class AccessModifiersDemo
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Navnath Todkari", "Rajapur Sangola ", 101);
            emp.DisplayEmployeeDetails();
      
        }
    }
}
