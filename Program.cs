using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital Root
{
    class Program
    {
        static void Main(string[] args)
        {// a function that sums the digits of a number, then sums the digits of the
         //result, and repeats until there is one digit left
         
            DigitalRoot("31337");

            Console.ReadKey();
        }
        
        static int   DigitalRoot(string rootThis)
         {
         //Declare list to store individual digits of current number
             List <int> digits = new List<int>();
        //Declare variable to store current number
             string currentNum = rootThis;

             while (currentNum.Length > 1)
             {
             //Start counter to store sum of digits
                 int counter = 0;

            //Loop through digits of current number
                 for (int i = 0; i < currentNum.Length; i++)
                 {
                 //Add each digit individually to digits list
                     digits.Add(int.Parse(currentNum[i].ToString()));
                 }
                 //Loop through each item in digits list
                 foreach (var item in digits) 
                 {
                 //Add value to digit to sum counter
                 counter += item;
                 }
             //Set new current number to previous sum
                 currentNum = counter.ToString();
                 //clear digits list
                 digits.Clear();
                }
             int digitalRoot = int.Parse(currentNum);

             Console.WriteLine("Input: " + rootThis);
             Console.WriteLine("Digital root: " + digitalRoot);

             return digitalRoot;

             
           }
         }
       }

