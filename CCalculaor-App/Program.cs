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
    

       public static int CalCulate()
        {



            int action,calinpt, calinpt2;

            Console.WriteLine(" Enter 1  for  Adition ");
            Console.WriteLine(" Enter 2  for  Substraction ");
            Console.WriteLine(" Enter 3  for  Multiply ");
            Console.Write(" Enter 4  for  Division \n\n\n");
            Console.Write("Enter Action Input :-:-: ");
            action = Convert.ToInt32(Console.ReadLine()); 


           



            if (action <= 4)
            {
                Console.Write(" Enter Number 1 :-:-: ");
                calinpt = Convert.ToInt32(Console.ReadLine());

                Console.Write(" Enter Number 2 :-:-:-");
                calinpt2 = Convert.ToInt32(Console.ReadLine());

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

            }else
            {
                Console.WriteLine(" Please try Correct Action Input  :-: \n\n\n\n ");
            }


            return CalCulate() ;
        }




        public static void Addition(int inpt1,int inpt2)
        {

            Console.Write(" The addition is :-- \n" + inpt1 + inpt2);

        }

        public static void substration(int inpt1, int inpt2)
        {

            output = inpt1 - inpt2;
            Console.Write(" The Substration is :-- \n" + output);
        }


        public static void Multiply(int inpt1, int inpt2)
        {
            Console.Write(" The Multiplication is :-- " + inpt1* inpt2);

        }


       public static void Division(int inpt1, int inpt2)
        {
            Console.Write(" The Division is :-- " + inpt1 / inpt2);

        }
            }
        }




    
