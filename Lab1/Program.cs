
using System.Xml.Serialization;

namespace Lab1;

class Program
{
    static void Main(string[] args)
    {
        // Step1
        Console.WriteLine("Jacqueline Somos");
        Console.WriteLine("IT 1050 - Programming Logic");

        // Step2
        /* 
        Jacqueline Somos 
        IT-1050-Lab1 
        */
        // Step3
       
        int temp = 75;
        Console.WriteLine("The current temperature is " + temp + " degrees.");
       
        string fav_lang = "Python";
        Console.WriteLine("My favorite computer language is " + fav_lang + ".");
       
        double prog_count = 1.8e38;
        Console.WriteLine("The number of programs I've written is " + prog_count + ".");
       
        bool myanswer = true;
        Console.WriteLine("My answer is "+ myanswer + " to having programming experience");

         // Step5

         const string mschool = "Tri-C";
         Console.WriteLine("My school is "+ mschool);
    }
       
    
}   
