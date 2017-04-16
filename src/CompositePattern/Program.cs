using System;

namespace CompositePattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var ceo = new Employee("John", "CEO", 30000);

            var headSales = new Employee("Robert", "Head Sales", 20000);

            var headMarketing = new Employee("Michel", "Head Marketing", 20000);

            var clerk1 = new Employee("Laura", "Marketing", 10000);
            var clerk2 = new Employee("Bob", "Marketing", 10000);

            var salesExecutive1 = new Employee("Richard", "Sales", 10000);
            var salesExecutive2 = new Employee("Rob", "Sales", 10000);

            ceo.AddEmployee(headSales);
            ceo.AddEmployee(headMarketing);

            headSales.AddEmployee(salesExecutive1);
            headSales.AddEmployee(salesExecutive2);

            headMarketing.AddEmployee(clerk1);
            headMarketing.AddEmployee(clerk2);

            Console.WriteLine(ceo);
            foreach (var headEmployee in ceo.Subordinates)
            {
                Console.WriteLine(headEmployee);
                foreach (var employee in headEmployee.Subordinates)
                    Console.WriteLine(employee);
            }
        }
    }
}