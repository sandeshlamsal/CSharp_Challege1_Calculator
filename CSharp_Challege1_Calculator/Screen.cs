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
            Environment.Exit(-1);

        }


        public void makeSelection(string choice)
        {
            
            int result = 0;
            switch (choice)
            {
                case "1":
                    //get input of 2 msg
                    Console.WriteLine("Please enter 1st No to Add:");
                    a=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter 2nd value to Add:");
                    b=Convert.ToInt32(Console.ReadLine());

                    result = a+b;
                    Console.WriteLine("Addition of no " +a+" and " +b+ " is:" +result);
                    //calculate
                    break;

                case "2":
                    //get input of 2 msg
                    Console.WriteLine("Please enter 1st No to Subtract:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter 2nd value to Subtract:");
                    b = Convert.ToInt32(Console.ReadLine());

                    result = a - b;
                    Console.WriteLine("Subtraction of no " + a + " and " + b + " is:" + result);

                    break;

                case "3":
                    //get input of 2 msg                
                    //get input of 2 msg
                    Console.WriteLine("Please enter 1st No to Multiply:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter 2nd value to Multiply:");
                    b = Convert.ToInt32(Console.ReadLine());

                    result = a * b;
                    Console.WriteLine("Multiplication of no " + a + " and " + b + " is:" + result);

                    break;

                case "4":
                    //get input of 2 msg                
                    //calculate
                    Console.WriteLine("Please enter 1st No to Divide:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter 2nd value to Divide:");
                    b = Convert.ToInt32(Console.ReadLine());

                    result = a / b;
                    Console.WriteLine("Divison of no " + a + " and " + b + " is:" + result);

                    break;

                case "5":
                    Environment.Exit(-1);
                    break;

            }
        }
    }
}
