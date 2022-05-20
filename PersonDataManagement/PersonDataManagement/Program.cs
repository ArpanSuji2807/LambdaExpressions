using System;
using PersonDataManagement;
class program
{
    public static void Main(string[] args)
    {
        PersonManagement personManagement = new PersonManagement();
        bool end = true;
        Console.WriteLine("1.Add Person Data\n2.Get Top two records\n3.Get all record between age 13 to 18\n4.Average Age\n5.Check for a specific name\n6.Skip record for age below 60\n7.Remove record for a specific name");
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
                case 5:
                    personManagement.CheckForSpecificName();
                    break;
                case 6:
                    personManagement.SkipRecordForAge();
                    break;
                case 7:
                    personManagement.RemoveSpecificName();
                    break;
                case 8:
                    Console.WriteLine("Enter a valid choice");
                    break;
                    default:break;
            }
        }
    }
}
