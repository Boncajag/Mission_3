using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission_3
{
    internal class FoodItem
    {
        public string name;
        public string category;
        public int quantity;
        public string expDate;

        public FoodItem(string n, string c, int q, string e) {
            name = n;
            category = c;
            quantity = q;
            expDate = e;
        }

        public static List<FoodItem> AddItem(List<FoodItem> listItems)
        {
            string n;
            string c;
            int q;
            string e;

            Console.WriteLine("\nDonation Item Name: ");
            n = Console.ReadLine();

            Console.WriteLine("Donation Category: ");
            c = Console.ReadLine();

            Console.WriteLine("Quantity: ");
            q = int.Parse(Console.ReadLine());

            Console.WriteLine("Expiration Date: ");
            e = Console.ReadLine();

            FoodItem item = new FoodItem(n, c, q, e);

            listItems.Add(item);

            return listItems;
        }

        public static List<FoodItem> DeleteItem(List<FoodItem> listItems)
        {
            int id;

            Console.WriteLine("\nEnter an ID of the item to delete: ");
            id = int.Parse(Console.ReadLine());
            listItems.RemoveAt(id);

            return listItems;
        }

        public static void List(List<FoodItem> listItems)
        {
            for (int i = 0; i <= listItems.Count - 1; i++)
            {
                Console.WriteLine("\n" + i + " " + listItems[i].name + " " + listItems[i].category + " "
                    + listItems[i].quantity + " " + listItems[i].expDate);
            }
        }

    }

}
