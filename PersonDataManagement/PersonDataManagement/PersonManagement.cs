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
            personsList.Add(new Person { SSN = 100, Name = "Raju", Address = "Kolkata", Age = 33 });
            personsList.Add(new Person { SSN = 101, Name = "Stephen", Address = "Durgapur", Age = 85 });
            personsList.Add(new Person { SSN = 102, Name = "Amrit", Address = "Jalpaiguri", Age = 55 });
            personsList.Add(new Person { SSN = 103, Name = "Vivek", Address = "Jaigaon", Age = 45 });
            Display(personsList);
        }
        public void GetTopRecords()
        {
            var result = this.personsList.Where(x => x.Age < 60).Take(2);
            Display(result);
        }
        public void Display(IEnumerable<Person> list)
        {
            foreach (var person in list)
            {
                Console.WriteLine(person.SSN + " " + person.Name + " " + person.Address + " " + person.Age);
            }
        }
        public void GetAllRecords()
        {
            var result = this.personsList.Where(x => x.Age > 13 && x.Age < 18);
            Display(result);
        }
        public void AverageAge()
        {
            var average = this.personsList.Average(x => x.Age);
            Console.WriteLine(average);
        }
        public void CheckForSpecificName()
        {
            var name = this.personsList.Where(x => x.Name == "Vivek");
            if(name!=null)
            {
                Console.WriteLine("Name is present in the list");
            }
            else
            {
                Console.WriteLine("Name is not present in the list");
            }
            Display(name);
        }
        public void SkipRecordForAge()
        {
            var age=this.personsList.Skip(this.personsList.Where(x => x.Age < 60).Count());
            Display(age);
        }
        public void RemoveSpecificName()
        {
            Person specificName = this.personsList.Find(x => x.Name == "Raj");
            this.personsList.Remove(specificName);
            Display(this.personsList);
        }
    }
}
