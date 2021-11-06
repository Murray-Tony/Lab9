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
    public Employee(string empfirstname, string emplastname, string empid, int empage)
    {
      FirstName = empfirstname;
      LastName=emplastname;
      ID=empid;
      Age=empage;
      EmploymentStatus="Active";
    }
    public void Intro()
      {
        Console.WriteLine("My name is " + firstname+" "+lastname);
        Console.WriteLine("My id is "+id);
        Console.WriteLine("My age is "+age);
        Console.WriteLine("My employment status is "+employmentstatus);
      }
    
}