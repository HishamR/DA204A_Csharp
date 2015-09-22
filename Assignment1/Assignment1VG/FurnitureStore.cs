using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Author: Hisham Ramish
    This program displays information about a table.
    The information includes price, width, height and color.
    The user can choose to change this information or do nothing. 

    This class creates and object (instance) of the Table class which
    encapsulates all data and operations related to a product.
*/
namespace Assignment1VG
{
    class FurnitureStore
    {
        static void Main(string[] args)
        {

            Console.Title = "Apu's Supermarket";

            //Declare and create an instance of the Table class.
            Table table = new Table();

            //Call the table-objects Start method to perform all steps required.
            table.Start();

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
