using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Author: Hisham Ramish
    This program computes total VAT and the total amount for a product, 
    given the net price, type of product and the corresponding tax rate.
    The program then displays the results in form of a reciept. 

    This class creates and object (instance) of the Product class which
    encapsulates all data and operations related to a product.
*/

namespace Assignment1
{
    class GroceryStore
    {
        static void Main(string[] args)
        {

            Console.Title = "Apu's Supermarket";

            //Declare and create an instance of the Product class.
            Product product = new Product();

            //Call the product-objects Start method to perform all steps required.
            product.Start();

            /*
                The command prompt window will close quickly after the program
                has executed the instructions under the Start method. To cause
                the window to stay, put the application in a reading mode, using
                the ReadLine method.
            */
            Console.WriteLine("Press Enter to exit!");
            Console.ReadLine();

        }
    }
}
