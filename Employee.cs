using System;
class Employee {
  public string firstname{get; set;}
  public string lastname{get; set;}
  public string id{get; set;}
  public int age{get; set;}
  private string address;
  private string phonenumber;
  private string title;
  private double yearlysalary;
  private string employmentstatus;

  //constructor with no parameters
  public Employee()
  {
    firstname = "Unknown";
    lastname = "Unknown";
    id = "Unknown";
    age = 0;
    employmentstatus = "active";
    Console.WriteLine("A new employee object has been created");
  }

//constructor with parameters
  public Employee(string first, string last, string empid, int empage)
  {
    firstname = first;
    lastname = last;
    id = empid;
    age = empage;
    employmentstatus = "active";
    Console.WriteLine("A new employee object has been created");
  }

  public void Intro()
  {
    Console.WriteLine("First name: " + firstname + "\nLast name: " + lastname + "\nEmployement status: " + employmentstatus);
  }

}