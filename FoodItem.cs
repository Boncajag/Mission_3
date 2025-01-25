using System;
using System.Collections.Generic;

namespace Mission_3
{
    internal class FoodItem
    {
        // Fields for the food item details
        public string name;
        public string category;
        public int quantity;
        public string expDate;

        // Constructor to initialize a FoodItem object
        public FoodItem(string n, string c, int q, string e)
        {
            name = n;
            category = c;
            quantity = q;
            expDate = e;
        }

        // Static method to add a new FoodItem to the list
        public static List<FoodItem> AddItem(List<FoodItem> listItems)
        {
            string n, c, e;
            int q;

            Console.WriteLine("\nDonation Item Name: ");
            n = Console.ReadLine();

            Console.WriteLine("Donation Category: ");
            c = Console.ReadLine();

            Console.WriteLine("Quantity: ");
            if (!int.TryParse(Console.ReadLine(), out q) || q <= 0)
            {
                Console.WriteLine("Invalid quantity. Please enter a positive integer.");
                return listItems; // Return unchanged list if input is invalid
            }

            Console.WriteLine("Expiration Date: ");
            e = Console.ReadLine();

            // Create a new FoodItem and add it to the list
            FoodItem item = new FoodItem(n, c, q, e);
            listItems.Add(item);
            Console.WriteLine("Item added successfully!");

            return listItems; // Return the updated list
        }

        // Static method to delete a FoodItem from the list by index
        public static List<FoodItem> DeleteItem(List<FoodItem> listItems)
        {
            Console.WriteLine("\nEnter an ID of the item to delete: ");
            if (!int.TryParse(Console.ReadLine(), out int id) || id < 0 || id >= listItems.Count)
            {
                Console.WriteLine("Invalid ID. Please enter a valid number corresponding to an item.");
                return listItems; // Return unchanged list if input is invalid
            }

            // Remove the item at the specified index
            listItems.RemoveAt(id);
            Console.WriteLine("Item deleted successfully!");

            return listItems; // Return the updated list
        }

        // Static method to list all FoodItems in the list
        public static void List(List<FoodItem> listItems)
        {
            if (listItems.Count == 0)
            {
                Console.WriteLine("\nNo items to display. The list is empty.");
                return;
            }

            Console.WriteLine("\nCurrent Food Items:");
            for (int i = 0; i < listItems.Count; i++)
            {
                Console.WriteLine($"{i}: Name: {listItems[i].name}, " +
                                  $"Category: {listItems[i].category}, " +
                                  $"Quantity: {listItems[i].quantity}, " +
                                  $"Expiration Date: {listItems[i].expDate}");
            }
        }
    }
}
