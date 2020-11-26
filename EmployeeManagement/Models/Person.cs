using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

public class Person
{
   public int Id {get; set;}
   [Required(ErrorMessage="We need FirstName.")]
   [Display(Name = "First Name")]
    public string FirstName {get;set;}
    [Required(ErrorMessage="We need LastName.")]
    [Display(Name = "Last Name")]

    public string SurName{get;set;}

    public string Address{get;set;}
    public char? Gender{get;set;}='F';
    public double? Salary {get;set;}

     public static List<Person>GetEmployees()
     {
         //object initializer syntax
    Person emp1 = new Person() {  FirstName = "Sujata", SurName= "sapkota", Address="Naikap", Salary= 4000.0 };
    Person emp2 = new Person() {FirstName = "Suza", SurName= "sapkotaa", Address="KTM", Salary= 3000.0 };
    Person emp3 = new Person() {FirstName = "Luffy", SurName= "sapkota", Address="Japan", Salary= 4000.0 };
    Person emp4 = new Person() { FirstName = "Zoro", SurName= "sapkota", Address="Naikap", Salary= 8000.0 };
    Person emp5 = new Person() {FirstName = "Brook", SurName= "sapkotaa", Address="Korea", Salary= 9000.0 };
    Person emp6 = new Person() {FirstName = "Chopper", SurName= "sapkota", Address="Naikap", Salary= 4000.0 };

    List<Person> employees= new List<Person>(){emp1,emp2,emp3,emp4,emp5,emp6};
      return employees;
     }
     


}
