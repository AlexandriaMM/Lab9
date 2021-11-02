using System;

class Program {
  public static void Main (string[] args) {
    Employee employee1 = new Employee();
    employee1.Intro();
    Employee employee2 = new Employee("John", "Smith", "1234", 45);
    employee2.Intro();
  }
}