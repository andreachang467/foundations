using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_v2
{
    public struct Inventory
    {
        public string ItemNo;
        public string Description;
        public string Price;
        public string Quantity;
        public string Cost;
        public string Value;
    }

    class Program
    {
        static void Main()
        {
            var numberOfItems = 0;
            var inventory = new Inventory[100];
            int x = 0;
            while (x!=5)
            {
                Console.WriteLine("1. Add an item"); //List out all the options available to the user to select
                Console.WriteLine("2. Change an item");
                Console.WriteLine("3. Delete an item");
                Console.WriteLine("4. List all items in the database");
                Console.WriteLine("5. Quit");
                Console.WriteLine("");
                Console.Write("Please choose an option from the list (1, 2, 3, 4, or 5):");
                var choice = Console.ReadLine();
                Console.WriteLine("");

                switch (choice)
                {

                    case "1":  //code for Adding an item
                        {
                            
                            Console.Write("Item No: ");
                            var _itemNo = Console.ReadLine(); //storing input from user
                            
                            Console.Write("Description:");
                            var description = Console.ReadLine(); // declaring a variable for the description and storing input from user

                            Console.Write("Price:");
                            var price = Console.ReadLine(); //storing input from user
                          
                            Console.Write("Quantity :");
                            var quantity = Console.ReadLine(); // declaring a variable for the quantity and storing input from user

                            Console.Write("Cost :");
                            var cost = Console.ReadLine(); // declaring a variable for the cost and storing input from user

                            Console.Write("Value :");
                            var value = Console.ReadLine(); // declaring a variable for the value and storing input from user

                            Console.WriteLine("");
                            Console.WriteLine("");

                            //inside the struct inventory, you are looking at the row "numberofItems" and finding the ItemNo for that row and assighning it to the variable itemNo  
                            inventory[numberOfItems].ItemNo = _itemNo;
                            inventory[numberOfItems].Description = description;
                            inventory[numberOfItems].Price = price;
                            inventory[numberOfItems].Quantity = quantity;
                            inventory[numberOfItems].Cost = cost;
                            inventory[numberOfItems].Value = value;

                            numberOfItems++;
                            break;
                        }


                    case "2": //code for Changing an item
                        {

                            if (numberOfItems == 0)
                            {
                                Console.WriteLine("There are no items");
                                break;
                            }

                            Console.WriteLine("Index   ItemID   Description            Price   QQH   Cost   Value");
                            Console.WriteLine("-----   ------   --------------------   -----   ---   ----   -----");

                            for (var index = 0; index < numberOfItems; index++) // starting at index 0, you add 1 to the index each time until you've listed all of your items
                            {
                                Console.WriteLine("{0, 5}   {1,6}   {2,-20}   {3,5}   {4,3}   {5,4}   {6,5}", index + 1, inventory[index].ItemNo, inventory[index].Description, inventory[index].Price, inventory[index].Quantity, inventory[index].Cost, inventory[index].Value);
                                Console.WriteLine();
                            }


                            Console.Write("Write the Index number for the item you wish to change (1-{0})", numberOfItems);


                            var itemNumberToChange = Console.ReadLine();
                            var indexToChange = int.Parse(itemNumberToChange);


                            // Input the new information
                            { 
                            Console.Write("Item No: ");
                            var _itemNo = Console.ReadLine(); //storing input from user

                            Console.Write("Description:");
                            var description = Console.ReadLine(); // declaring a variable for the description and storing input from user

                            Console.Write("Price:");
                            var price = Console.ReadLine(); //storing input from user

                            Console.Write("Quantity :");
                            var quantity = Console.ReadLine(); // declaring a variable for the quantity and storing input from user

                            Console.Write("Cost :");
                            var cost = Console.ReadLine(); // declaring a variable for the cost and storing input from user

                            Console.Write("Value :");
                            var value = Console.ReadLine(); // declaring a variable for the value and storing input from user

                            Console.WriteLine("");
                            Console.WriteLine("");

                            //inside the struct inventory, you are looking at the row "numberofItems" and finding the ItemNo for that row and assighning it to the variable itemNo  
                            inventory[indexToChange-1].ItemNo = _itemNo;
                            inventory[indexToChange-1].Description = description;
                            inventory[indexToChange-1].Price = price;
                            inventory[indexToChange-1].Quantity = quantity;
                            inventory[indexToChange-1].Cost = cost;
                            inventory[indexToChange-1].Value = value;

                                Console.WriteLine();

                          
                            break;
                        }
                           
                            


                        }


                    case "3": //code for Deleting an item
                        {
                            
                            if (numberOfItems == 0)
                            {
                                Console.WriteLine("There are no items");
                                break;
                            }

                            Console.WriteLine("Index   ItemID   Description            Price   QQH   Cost   Value");
                            Console.WriteLine("-----   ------   --------------------   -----   ---   ----   -----");

                            for (var index = 0; index < numberOfItems; index++) // starting at index 0, you add 1 to the index each time until you've listed all of your items
                            {
                                Console.WriteLine("{0, 5}   {1,6}   {2,-20}   {3,5}   {4,3}   {5,4}   {6,5}", index + 1, inventory[index].ItemNo, inventory[index].Description, inventory[index].Price, inventory[index].Quantity, inventory[index].Cost, inventory[index].Value);
                                Console.WriteLine();
                            }


                            Console.Write("Write the Index number for the item you wish to remove (1-{0})", numberOfItems);


                            var itemNumberToDelete = Console.ReadLine();
                            var indexToDelete = int.Parse(itemNumberToDelete);


                            // Squish the array from index to the end

                            for (var index = indexToDelete - 1; index < numberOfItems; index++)
                            {
                                // Just copy the index from the next index into the current index
                                inventory[index] = inventory[index + 1];
                            }

                            // We have one less item
                            if (indexToDelete <= numberOfItems)
                            numberOfItems--;

                            break;
                        }

                    case "4": //code for Listing out all items in database

                        {
                            
                            if (numberOfItems == 0)
                            {
                                Console.WriteLine("There are no items");
                                break;
                            }

                                Console.WriteLine("Index   ItemID   Description            Price   QQH   Cost   Value");
                                Console.WriteLine("-----   ------   --------------------   -----   ---   ----   -----");

                                for (var index = 0; index < numberOfItems; index++) // starting at index 0, you add 1 to the index each time until you've listed all of your items
                                {
                                    Console.WriteLine("{0, 5}   {1,6}   {2,-20}   {3,5}   {4,3}   {5,4}   {6,5}", index + 1, inventory[index].ItemNo, inventory[index].Description, inventory[index].Price, inventory[index].Quantity, inventory[index].Cost, inventory[index].Value);
                                    Console.WriteLine();
                                }

                                break;

                                
                            }

                    case "5": //List code to Quit
                        {
                            x = 5;
                            break;
                            }


                            default:
                        {
                            Console.WriteLine("Invalid option [{0}]", choice);
                            break;
                        }
                }
            }
        }
    }
}
 