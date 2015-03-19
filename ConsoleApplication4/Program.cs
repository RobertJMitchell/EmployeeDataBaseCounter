using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the employee database! To add an employee, type add. To view employee database, type view. To see how many employees you have, type total. To close program, type exit.");
            string openingScreen = Console.ReadLine();
            switch (openingScreen)
            {
                case "add":
                    //Console.Clear();
                    Console.WriteLine("Press 1 to add a manager, press 2 to add a developer, or press 3 to add an intern.");
                    string EmployeeSwitch = Console.ReadLine();
                    switch (EmployeeSwitch)
                    {
                        case "1":
                            //Console.Clear();
                            Console.WriteLine("Enter Employee's Name: ");
                            string nameManager = Console.ReadLine();
                            Console.WriteLine("Enter Employee's Position to Confirm: ");
                            string positionManager = Console.ReadLine();
                            Console.WriteLine("Enter Employee's Salary: ");
                            int salaryManager = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Employee's Responsibilties");
                            string responsibilityManager = Console.ReadLine();
                            Console.WriteLine("Enter Employee's Location");
                            string locationManager = Console.ReadLine();
                            Management x = new Management(nameManager, positionManager, salaryManager, responsibilityManager, locationManager);
                            Employee.Employees.Add(x);
                            Console.WriteLine(" ");
                            Console.WriteLine("Press enter to return to main menu");
                            Console.ReadLine();
                            Main();
                            break;
                        case "2":
                            Console.Clear();
                            Console.WriteLine("Enter Employee's Name: ");
                            string nameDeveloper = Console.ReadLine();
                            Console.WriteLine("Enter Employee's Position to Confirm: ");
                            string positionDeveloper = Console.ReadLine();
                            Console.WriteLine("Enter Employee's Salary: ");
                            string input = Console.ReadLine();
                            int salaryDeveloper = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Employee's Responsibilties");
                            string responsibilityDeveloper = Console.ReadLine();
                            Console.WriteLine("Enter Employee's Location");
                            string locationDeveloper = Console.ReadLine();
                            Developer y = new Developer(nameDeveloper, positionDeveloper, salaryDeveloper, responsibilityDeveloper, locationDeveloper); 
                            Employee.Employees.Add(y);
                            Console.WriteLine(" ");
                            Console.WriteLine("Press enter to return to main menu");
                            Console.ReadLine();
                            Main();
                            break;
                        case "3":
                            Console.Clear();
                            Console.WriteLine("Enter Employee's Name: ");
                            string nameIntern = Console.ReadLine();
                            Console.WriteLine("Enter Employee's Position to Confirm: ");
                            string positionIntern = Console.ReadLine();
                            Console.WriteLine("Enter Employee's Salary: ");
                            int salaryIntern = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Employee's Responsibilties");
                            string responsibilityIntern = Console.ReadLine();
                            Console.WriteLine("Enter Employee's Location");
                            string locationIntern = Console.ReadLine();
                            Intern z = new Intern(nameIntern, positionIntern, salaryIntern, responsibilityIntern, locationIntern);
                            Employee.Employees.Add(z);
                            Console.WriteLine(" ");
                            Console.WriteLine("Press enter to return to main menu");
                            Console.ReadLine();
                            Main();
                            break;
                    }
                    break;
                case "view":
                    Console.Clear();
                    Console.WriteLine(" ");
                    foreach (var item in Employee.Employees)
                    {
                        Console.WriteLine("Name: " + item.name + ", Position: " + item.position + ", Salary: " + item.salary);
                        //Console.WriteLine("Responsibilities: " + item.Responsibilities);
                        Console.WriteLine(" ");
                    }

                    Console.ReadLine();
                    Main();
                    break;
                case "exit":
                    Console.Clear();
                    Console.ReadLine();
                    break;
                case "total":
                    Console.Clear();
                    Console.WriteLine(" ");
                    //Console.WriteLine("Total Employees: " + Employee.count);
                    Console.WriteLine(" ");
                    break;
            }

        }
    }
}
public abstract class Employee
{
    public static List<Employee> Employees = new List<Employee>();

    //public static int numberofEmployeescreated = 0;
    public string name { get; set; }
    public string position { get; set; }
    public int salary { get; set; }
    public string responsibilities { get; set; }
    public string territory { get; set; }

}
public class Management : Employee  //  ( string name, string position, int salary, string responsibilities)
{
    //public string territory;
    public Management(string name, string position, int salary, string responsibilities, string territory)
    {
        this.name = name;
        this.position = position;
        this.salary = salary;
        this.responsibilities = responsibilities;
        this.territory = territory;

    }
}
public class Developer : Employee  //  ( string name, string position, int salary, string responsibilities)
{
    //public string language;
    public Developer(string name, string positon, int salary, string responsibilities, string territory)
    {
        this.name = name;
        this.position = position;
        this.salary = salary;
        this.responsibilities = responsibilities;
        this.territory = territory;
    }
}
public class Intern : Employee  //  ( string name, string position, int salary, string responsibilities)
{
    //public string service;
    public Intern(string name, string position, int salary, string responsibilities, string territory)
    {
        this.name = name;
        this.position = position;
        this.salary = salary;
        this.responsibilities = responsibilities;
        this.territory = territory;

    }
}