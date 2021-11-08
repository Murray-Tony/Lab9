using System;
class Employee {
    private string firstname;
    private string lastname;
    private string id;
    private int age;
    private string address;
    private string phonenumber;
    private string title;
    private double salary;
    private string employmentstatus;
    public string FirstName {get;set;}
    public string LastName {get;set;}
    public string ID {get;set;}
    public string EmploymentStatus {get;set;}
    public int Age {
      get{ return age;}
      set{
        if (value<18)
          age = 18;
        else
          age = value;
      }
    }
    public double YearlySalary {
      get {return salary;}
      set{
        if (value<1000)
          salary = 1000;
        else
        {
          salary = value;
        }
      }
    }
    public Employee()
    {
      FirstName = "Unknown";
      LastName = "Unknown";
      ID = "Unknown";
      Age=0;
      EmploymentStatus= "Active";
    }
    public Employee(string empfirstname, string emplastname, string empid, int empage, int yearlysalary)
    {
      FirstName = empfirstname;
      LastName=emplastname;
      ID=empid;
      Age=empage;
      EmploymentStatus="Active";
      YearlySalary=yearlysalary;
    }
    public void Intro()
      {
        Console.WriteLine("First name: " + FirstName);
        Console.WriteLine("Last name: " + LastName);
        Console.WriteLine("Age: "+Age);
        Console.WriteLine("ID: "+ID);
        Console.WriteLine("Yearly Salary: "+YearlySalary);
        
      }
    public void IncreaseSalary(double percent)
    {
      if (percent>=0){
      YearlySalary = YearlySalary+(YearlySalary*percent);
      Console.WriteLine("Yearly salary updated to "+ YearlySalary);
      }
      else
      {
        Console.WriteLine("Invalid input. Yearly Salary not updated.");
      }
    }
    public void RemoveEmployee()
    {
      if (EmploymentStatus == "Inactive")
      {
        Console.WriteLine("Employee is already inactive.");
      }
      else
      {
        EmploymentStatus = "Inactive";
        Console.WriteLine("Employee removed successfully!");
      }
    }
    
}