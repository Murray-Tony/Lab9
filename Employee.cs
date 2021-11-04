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
      firstname = "Unknown";
      lastname = "Unknown";
      id = "Unknown";
      age=0;
      employmentstatus= "Active";
    }
    public Employee(string empfirstname, string emplastname, string empid, int empage)
    {
      firstname = empfirstname;
      lastname=emplastname;
      id=empid;
      age=empage;
      employmentstatus="Active";
    }
    public void Intro()
      {
        Console.WriteLine("My name is " + firstname+" "+lastname);
        Console.WriteLine("My id is "+id);
        Console.WriteLine("My age is "+age);
        Console.WriteLine("My employment status is "+employmentstatus);
      }
    
}