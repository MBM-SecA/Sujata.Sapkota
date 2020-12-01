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

     
     }
     



