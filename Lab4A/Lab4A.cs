using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
/*
Class: CSE 1321L
Section: W1 C#
Term: Fall 2022	
Instructor: Jaskirat Singh Sohal
Name: Heather Papp
Lab#: Lab4A 
*/
namespace Lab4A
{
    internal class Lab4A
    {
        static void Main(string[] args)
        {                               
            float points;            
            

            Console.Write("Enter the score of your exam: ");
            points = float.Parse(Console.ReadLine());
            

            {   string grade;
                grade = "";
                                
                if ((points >=98.0) && (points <= 100.0))
                    grade = "A+";
                
                else if ((points >= 95.0) && (points <= 97.9))
                    grade = "A";
                
                else if ((points >= 92.0) && (points <= 94.9))
                    grade = "A-";
               
                else if ((points >= 89.0) && (points <= 91.9))
                    grade = "B+";
               
                else if ((points >= 86.0) && (points <= 88.9))
                    grade = "B";
                
                else if ((points >= 83.0) && (points <= 85.9))
                    grade = "B-";
                
                else if ((points >= 80.0) && (points <= 82.9))
                    grade = "C+";
                
                else if ((points >= 77.0) && (points <= 79.9))
                    grade = "C";
                
                else if ((points >= 74.0) && (points <= 76.9))
                    grade = "C-";
                
                else if ((points >= 71.0) && (points <= 73.9))
                    grade = "D";
                
                else if ((points >= 65.0) && (points <= 67.9))
                    grade = "D-";
                
                else if ((points >= 0.0) && (points <= 64.9))
                    grade = "F";
                                              
                Console.WriteLine("Letter grade is: " +grade+ "");

                
            }        
        
        }
        
    }
}