using System;

class Program {
  public static void Main (string[] args) {
    //Console.WriteLine ("Hello World");
    Employee employee1 = new Employee();
    employee1.Intro();
    Employee employee2 = new Employee("Alexandria", "Macko-Millard", "1234", 45);
    employee2.Intro();
  }
}