using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
        This class contains the object Product and its attributes.
*/
namespace Assignment1
{
    class Product
    {

        private string name;
        private int count;
        private double unitPrice;
        private bool foodItem;

        private double totalVAT, totalNetValue;

        private const double foodVATrate = 0.12, otherVATRate = 0.25;

        //Start-method 
        public void Start()
        {
            //Read input
            ReadInput();

            //Calculate total tax
            CalculateValues();

            //Calculate totalNetPrice, total price
            PrintReceipt();

        }

        //Method that reads the users input of Productinformation
        private void ReadInput()
        {
            //1. Read name of the product
            ReadName();

            //2. Read price without VAT
            ReadNetUnitPrice();

            //3. Ask the user if the item is a food item
            ReadIfFoodItem();

            //4. Read number of items (quantity)
            ReadCount();

        }

        //Reads the name of the product
        private void ReadName()
        {
            Console.WriteLine();
            Console.Write("Enter the product name:  ");

            name = (Console.ReadLine());
        }

        //Reads the unitprice of the product
        private void ReadNetUnitPrice()
        {
            Console.Write("Net unit price:  ");

            unitPrice = double.Parse(Console.ReadLine());
        }

        //Reads if the product is a fooditem
        private void ReadIfFoodItem()
        {
            Console.Write("Food item (y/n): ");

            char response = char.Parse(Console.ReadLine());

            if ((response == 'y') || (response == 'Y'))
                foodItem = true;
            else
                foodItem = false;
        }

        //Reads the amount of product to calculate
        private void ReadCount()
        {
            Console.Write("Count:  ");

            count = int.Parse(Console.ReadLine());
        }


        //Calculate totalNetValue TotalVat
        private void CalculateValues()
        {
            if (foodItem)
            {
                totalVAT = (unitPrice * foodVATrate) * count;
                totalNetValue = (unitPrice * (1+foodVATrate)) * count;
            }
            else
            {
                totalVAT = (unitPrice * otherVATRate) * count;
                totalNetValue = (unitPrice * (1 + otherVATRate)) * count;
            }
            

        }

        //Print results
        private void PrintReceipt()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("****************" + "\t" +
                              "WELCOME TO APU's SUPERMARKET \t" +
                              "**************** ");

            Console.WriteLine("*** ");

            Console.WriteLine("*** " + 
                              "Name of the product: \t\t\t" +
                               name);

            Console.WriteLine("*** " + 
                              "Quantity: \t\t\t\t\t" +
                              count);

            Console.WriteLine("*** " +
                              "Unit price: \t\t\t\t" +
                               unitPrice);


            Console.WriteLine("*** " + 
                              "Food item: \t\t\t\t\t" +
                              foodItem);

            Console.WriteLine("*** ");

            Console.WriteLine("*** " + 
                              "Total amount to pay: \t\t\t" + 
                               totalNetValue);

            if (foodItem)
            {
                Console.WriteLine("*** " + 
                                  "Including VAT at 12%: \t\t\t" + 
                                   totalVAT);
            }

            else
            {
                Console.WriteLine("*** " +
                                  "Including VAT at 25%: \t\t\t" +
                                   totalVAT);
            }

            Console.WriteLine("*** ");

            Console.WriteLine("*** " +
                              "This program has been developed by: Hisham Ramish");

            Console.WriteLine("**************** \t" +
                              "PLEASE COME AGAIN \t\t" +
                              "**************** ");

            Console.WriteLine();
            Console.WriteLine();

        }
    }
}
