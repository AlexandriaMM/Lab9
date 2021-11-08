using System;

class Program {
  public static void Main (string[] args) {
    //employee using constructor with no parameters
    Employee employee1 = new Employee();
    employee1.Intro();
    
    //employee using constructer with parameters
    //testing Increase Salary Method
    Employee employee2 = new Employee("Robert", "Downey", "1", 18);
    employee2.Intro();

    //employee using constructer with parameters
    //testing RemoveEmployee method
    Employee employee3 = new Employee("John", "Smith", "S0089", 38);
    employee3.Yearlysalary = 50000;
    employee3.Intro();
    employee3.IncreaseSalary(-2);
    employee3.RemoveEmployee();

    //employee using constructor with parameters
    //testing Increase Salary
    Employee employee4 = new Employee ("Maria", "Lambert", "S0010", 26);
    employee4.IncreaseSalary(7);
    employee4.RemoveEmployee();
    employee4.RemoveEmployee();
  }
}