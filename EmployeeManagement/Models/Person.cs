using System.Collections.Generic;
using System;
public class Person
{
   public Guid Id {get; set;}
    public string FirstName {get;set;}
    public string SurName{get;set;}
    public string Address{get;set;}
    public char Gender{get;set;}='F';
    public double Salary {get;set;}

     public static List<Person>GetEmployees()
     {
         //object initializer syntax
    Person emp1 = new Person() { Id= Guid.NewGuid() , FirstName = "Sujata", SurName= "sapkota", Address="Naikap", Salary= 4000.0 };
    Person emp2 = new Person() {Id= Guid.NewGuid() ,FirstName = "Suza", SurName= "sapkotaa", Address="KTM", Salary= 3000.0 };
    Person emp3 = new Person() {Id= Guid.NewGuid() ,FirstName = "Luffy", SurName= "sapkota", Address="Japan", Salary= 4000.0 };
    Person emp4 = new Person() {Id= Guid.NewGuid() ,FirstName = "Zoro", SurName= "sapkota", Address="Naikap", Salary= 8000.0 };
    Person emp5 = new Person() {Id= Guid.NewGuid() ,FirstName = "Brook", SurName= "sapkotaa", Address="Korea", Salary= 9000.0 };
    Person emp6 = new Person() {Id= Guid.NewGuid() ,FirstName = "Chopper", SurName= "sapkota", Address="Naikap", Salary= 4000.0 };

    List<Person> employees= new List<Person>(){emp1,emp2,emp3,emp4,emp5,emp6};
      return employees;
     }


}
