using System.Collections.Generic;

namespace CompositePattern
{
    public class Employee
    {
        public Employee(string name, string dept, int salary)
        {
            Name = name;
            Dept = dept;
            Salary = salary;
            Subordinates = new List<Employee>();
        }

        public string Name { get; }

        public string Dept { get; }

        public int Salary { get; }

        public List<Employee> Subordinates { get; }

        public void AddEmployee(Employee e)
        {
            Subordinates.Add(e);
        }

        public void RemoveEmployee(Employee e)
        {
            Subordinates.Remove(e);
        }
        
        public override string ToString()
        {
            return "Employee :[ Name : " + Name
                   + ", dept : " + Dept + ", salary :"
                   + Salary + " ]";
        }
    }
}