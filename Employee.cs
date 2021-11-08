using System;
class Employee {
  //fields
  private string firstname;
  private string lastname;
  private string id;
  private int age;
  private string address;
  private string phonenumber;
  private string title;
  private double yearlysalary;
  private string employmentstatus;

  //properties are where you add validation via getters and setters
  //properties are public and names are uppercase
  public string Firstname {get; set;}
  public string Lastname {get; set;}
  public int Age {
    get{ return age; } 
    set{
        if(value > 18){
          age = value; 
        }
        else {
          age = 18;
          //Console.WriteLine("Age is set to 18");
        }
      }
    }
  public double Yearlysalary { 
      get{ return yearlysalary; }
      set{
        if(value >= 1000){
          yearlysalary = value;
        }
        else {
          yearlysalary = 1000;
          //Console.WriteLine("Yearly salary is set to 1000"); 
        }
      }
    }
    public string Id {get; set;}
    public string Employmentstatus {get; set;}

  //constructor with no parameters
  public Employee()
  {
    Firstname = "unknown";
    Lastname = "unknown";
    age = 0;
    Id = "unknown";
    Employmentstatus = "active";
    //Console.WriteLine("A new employee has been created");
  }

//constructor with parameters
  public Employee(string first, string last, string empid, int empage)
  {
    Firstname = first;
    Lastname = last;
    Id = empid;
    Age = empage;
    Yearlysalary = 1000;
    Employmentstatus = "active";
    //Console.WriteLine("A new employee has been created");
  }

  
  public void Intro()
  {
    if(Firstname == "unknown")
    {
      Console.WriteLine("First name: " + Firstname + "\nLast name: " + Lastname + "\nAge: " + Age + "\nId: " + Id);
    }
    else
    {
      Console.WriteLine("First name: " + Firstname + "\nLast name: " + Lastname + "\nAge: " + Age + "\nId: " + Id + "\nYearly Salary: " + Yearlysalary);
    }
  }

  public void IncreaseSalary(double percent)
  {
    if(percent > 0)
    {
      Yearlysalary = ((percent*.01)*Yearlysalary)+Yearlysalary;
      Console.WriteLine("Yearly salary is now " + Yearlysalary);
    }
    else
    {
      Console.WriteLine("Invalid input. Yearly Salary not updated");
    }
  }

  public void RemoveEmployee()
  {
    if(Employmentstatus == "active")
    {
      Employmentstatus = "inactive";
      Console.WriteLine("Employee removed successfully!");
    }
    else
    {
      Console.WriteLine("Employee already inactive");
    }
  }
}