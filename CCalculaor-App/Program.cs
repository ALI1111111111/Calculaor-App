using System;

namespace CCalculaor_App
{
    class Program
    {


        static int output;


        static void Main(string[] args)
        {

            Console.WriteLine(" Welcome to Console Calculator ");





            CalCulate();



        }
        /*
         This is the Main Function Of Calculator-app 
        This Include all variable 
        Action Input Or Calculations

         */

        public static int CalCulate()
        {



            int action, calinpt, calinpt2;

            Console.WriteLine(" Enter 1  for  Adition ");
            Console.WriteLine(" Enter 2  for  Substraction ");
            Console.WriteLine(" Enter 3  for  Multiply ");
            Console.Write(" Enter 4  for  Division \n\n\n");


            // Here We Get Action Input So we Do Above Writen calculations

            Console.Write("Enter Action Input :-:-: ");
            action = Convert.ToInt32(Console.ReadLine());

            //  This will check action input is less than or equal to 4 Becauses now we Are perrforming 4 basic Calculations

            if (action <= 4)
            {

                // this is input 1
                Console.Write(" Enter Number 1 :-:-: ");
                calinpt = Convert.ToInt32(Console.ReadLine());


                // Thi is input 2
                Console.Write(" Enter Number 2 :-:-:-");
                calinpt2 = Convert.ToInt32(Console.ReadLine());


                //  This Switch statement Do expresion calculation check stuff

                switch (action)
                {
                    case 1:

                        Addition(calinpt, calinpt2);


                        break;
                    case 2:
                        substration(calinpt, calinpt2);
                        break;
                    case 3:
                        Multiply(calinpt, calinpt2);
                        break;
                    case 4:
                        Division(calinpt, calinpt2);
                        break;
                    default:
                        Console.WriteLine(" Please Try Correct Action Input \n ");
                        break;
                }


                // Here We perform action if action >=5 
            }
            else
            {
                Console.WriteLine(" Please try Correct Action Input  :-: \n\n\n\n ");
            }


            //This is recursion So App Runing After Every Calculations

            return CalCulate();
        }




        /*
         
         this is Addition Function
        */


        public static void Addition(int inpt1, int inpt2)
        {

            Console.Write(" The addition is :-- \n" + inpt1 + inpt2);

        }
        /*
         
         this is substraction Function

        in this function we use Global static variable "output" which is define above         */

        public static void substration(int inpt1, int inpt2)
        {

            output = inpt1 - inpt2;
            Console.Write(" The Substration is :-- \n" + output);
        }/*
         
         this is Multiply Function
        */


        public static void Multiply(int inpt1, int inpt2)
        {
            Console.Write(" The Multiplication is :-- " + inpt1 * inpt2);

        }
        /*
         
         this is Division Function
        */


        public static void Division(int inpt1, int inpt2)
        {
            Console.Write(" The Division is :-- " + inpt1 / inpt2);

        }
    }
}





