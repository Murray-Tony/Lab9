using System;


class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World. Here is Lab 9:");
    Employee unknown = new Employee();
    unknown.Intro();
    Employee John = new Employee("John", "Smith", "1234", 45);
    John.Intro();


  }
}