using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Challege1_Calculator
{
    class Screen
    {
        int a, b;
        string option;
        public void showScreen()
        {
            Console.WriteLine("\nPress Any Key to Perform Arithmetic Operation");
            Console.WriteLine("1. Addition \n" +
                "2. Subtraction\n" +
                "3. Multiplication\n" +
                "4. Division\n"+ 
                "5. Exit\n");
            Console.WriteLine("Choose your Option");
            option = Console.ReadLine();
            makeSelection(option);
            string opt;
            do
            {
                Console.WriteLine("Would you like to Perform Calculations Again: yes/no");
                opt = Console.ReadLine();
                if (opt == "no")
                {
                    break;
                }
                showScreen();
            }
            while (opt == "yes");
            
            Console.WriteLine("Thank you for using Calcaultor");
        }


        public void makeSelection(string choice)
        {
            
            int result = 0;
            switch (choice)
            {
                case "1":
                    //get input of 2 msg
                    Console.WriteLine("Please enter 1st No to calculate:");
                    a=Convert.ToInt32(Console.ReadLine());
                 
                    Console.WriteLine("Please enter 2nd value to calculate:");
                    b=Convert.ToInt32(Console.ReadLine());

                    result = a+b;
                    Console.WriteLine("Addition of no " +a+" and " +b+ " is:" +result);
                    //calculate
                    break;

                case "2":
                    //get input of 2 msg                
                    //calculate

                    break;

                case "3":
                    //get input of 2 msg                
                    //calculate

                    break;

                case "4":
                    //get input of 2 msg                
                    //calculate
                    break;

                case "5":
                    Environment.Exit(-1);
                    break;

            }
        }
    }
}
