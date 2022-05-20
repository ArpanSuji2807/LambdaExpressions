using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDataManagement
{
    public class PersonManagement
    {
        List<Person> personsList= new List<Person>();
        public void AddDefaultData()
        {
            personsList.Add(new Person { SSN = 100, Name = "Arpan", Address = "Darjeeling", Age = 23 });
            personsList.Add(new Person { SSN = 101, Name = "Ravi", Address = "Kalimpong", Age = 65 });
            personsList.Add(new Person { SSN = 102, Name = "Raj", Address = "Siliguri", Age = 75 });
            personsList.Add(new Person { SSN = 103, Name = "Ashok", Address = "Kurseong", Age = 35 });
        }
        public void Display(IEnumerable<Person> list)
        {
            foreach (Person person in list)
                Console.WriteLine(person.Name);
        }
    }
}
