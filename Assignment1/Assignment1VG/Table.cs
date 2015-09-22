using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
        Author: Hisham Ramish
        This class contains the object Table and its attributes.
*/

namespace Assignment1VG
{
    class Table
    {
        private int height = 60, width = 120;
        private string color = "Black";
        private double price = 199.99;
        private bool run = true;
        
        //Start method 
        public void Start()
        {
            while (run)
            {
                //Calculate totalNetPrice, total price
                PrintInfo();

                //Read input
                ReadInput();

            }

        }

        //Prints information about the table
        private void PrintInfo()
        {
            Console.WriteLine("TABLE INFO");
            Console.WriteLine();
            Console.WriteLine("Color: \t\t\t" + color);
            Console.WriteLine("Height: \t\t" + height);
            Console.WriteLine("Width: \t\t\t" + width);
            Console.WriteLine("Price: \t\t\t" + price);
            Console.WriteLine();
        }

        //Outputs choices and determines user action
        private void ReadInput()
        {

            Console.WriteLine("1. Change color");
            Console.WriteLine("2. Change height");
            Console.WriteLine("3. Change width");
            Console.WriteLine("4. Change price");
            Console.WriteLine("0. Exit");


            Console.WriteLine();
            Console.Write("Enter your choice:  ");

            Action(int.Parse(Console.ReadLine()));

        }

        //User determines choice of method used
        private void Action(int choice)
        {
            switch (choice)
            {
                case 0:
                    run = false;
                    break;
                case 1:
                    //1. Read name of the product
                    ChangeColor();
                    break;

                case 2:
                    //2. Read price without VAT
                    ChangeHeight();
                    break;

                case 3:
                    //3. Ask the user if the item is a food item
                    ChangeWidth();
                    break;

                case 4:
                    ChangePrice();
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    ReadInput();
                    break;

            }
        }

        //Changes price of table
        private void ChangePrice()
        {
            Console.WriteLine();
            Console.Write("Enter new price: ");

            price = double.Parse(Console.ReadLine());

            Console.WriteLine("Price changed!");
            Console.WriteLine();
        }

        //Changes width of table
        private void ChangeWidth()
        {
            Console.WriteLine();
            Console.Write("Enter new width: ");

            width = int.Parse(Console.ReadLine());

            Console.WriteLine("Width changed!");
            Console.WriteLine();
        }

        //Changes height of table
        private void ChangeHeight()
        {
            Console.WriteLine();
            Console.Write("Enter new height: ");

            height = int.Parse(Console.ReadLine());

            Console.WriteLine("Height changed!");
            Console.WriteLine();
        }

        //Changes color of table
        private void ChangeColor()
        {
            Console.WriteLine();
            Console.Write("Enter new color: ");

            color = Console.ReadLine();

            Console.WriteLine("Color changed!");
            Console.WriteLine();
        }
    
    }


}
