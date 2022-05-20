using System;
using PersonDataManagement;
class program
{
    public static void Main(string[] args)
    {
        PersonManagement personManagement = new PersonManagement();
        bool end = true;
        Console.WriteLine("1.Add Person Data\n2.Get Top two records\n3.Get all record between age 13 to 18\n4.Average Age");
        while(end)
        {
            Console.WriteLine("Take an option to execute");
            int option= Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    personManagement.AddDefaultData();
                    break;
                case 2:
                    personManagement.GetTopRecords();
                    break;
                case 3:
                    personManagement.GetAllRecords();
                    break;
                case 4:
                    personManagement.AverageAge();
                    break;
            }
        }
    }
}
