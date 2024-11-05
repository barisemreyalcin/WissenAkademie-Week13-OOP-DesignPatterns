using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.Sample1
{
    public class Employee : ICloneable
    {
        private List<string> employees;

        public Employee()
        {
            employees = new List<string>();
        }

        public Employee(List<string> _employees)
        {
            this.employees = _employees;
        }

        public void LoadData()
        {
            employees.Add("John");
            employees.Add("Jeyn");
            employees.Add("Tom");
            employees.Add("Poul");

        }

        public List<string> GetEmployees()
        {
            return employees;
        }
        public object Clone()
        {
            List<string> temp = new List<string>();
            foreach (string item in GetEmployees()) 
            {
                temp.Add(item);
            }
            return new Employee(temp);
        }
    }
}
