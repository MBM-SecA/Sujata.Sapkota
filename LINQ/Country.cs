using System;
using System.Collections.Generic;
public class Country
{
    public string Name { get; set;}
    public string Continent { get; set;}
    public double Area { get; set;}
    public long Population { get; set;}
    public DateTime IndependenceDay { get; set;}

    

    public Country(string n, string c, double a,long p, DateTime i = default)
    {
        Name=  n;
        Continent = c;
        Area = a;
        Population = p;
        IndependenceDay = i;
     }

    public static List<Country> GetCountries()
    {
            Country c1 = new Country( "Nepal", "Asia", 124245.55, 3346474);
            Country c2 = new Country( "India", "Asia", 425436445, 6474884);
            Country c3 = new Country( "Germany", "Europe", 35637444, 5373333);
            Country c4 = new Country( "USA", "North America", 124245.55, 3346474);
            Country c5 = new Country( "Russia", "Europe", 124245.55, 3346474);
            Country c6= new Country( "Austria", "Europe", 124245.55, 3346474);
            Country c7= new Country( "Korea", "Asia", 124245.55, 3346474);
            Country c8= new Country( "Croatia", "Europe", 124245.55, 3346474);
            Country c9 = new Country( "Norway", "Europe", 124245.55, 33474);
            Country c10= new Country( "Germany", "Europe", 124245.55, 3346474);
            Country c11= new Country( "Finland", "Europe", 124245.55, 3346474);
            Country c12= new Country( "Poland", "Europe", 2121212.121, 134);
            Country c13= new Country( "Italy", "Europe", 124245.55, 3346474);
            Country c14= new Country( "Uk", "Europe", 124245.55, 3346474);
            Country c15 = new Country( "Sweden", "Europe", 124245.55, 33474);
            Country c16= new Country( "Ukraine", "Europe", 124245.55, 6475664);
            Country c17 = new Country( "France", "Europe", 124245.55, 7874);
            Country c18 = new Country( "Spain", "Europe", 10000, 33475858);
            Country c19= new Country( "Romania", "Europe", 124245.55, 3346474);
            Country c20= new Country( "Greece", "Europe", 124245.55, 474);
           


            var countries = new List<Country> {c1, c2, c3, c4, c5, c6, c7, c8, c9, c10,c11,c12,c13,c14,c15,c16,c17,c18,c19,c20};

            return countries; 
    }

}