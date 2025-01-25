using Mission_3;
using System.Transactions;

List<FoodItem> listItems = new List<FoodItem>();
string name;
string category;
string expDate;
string cmd = "";
int quantity;
int id;

while (cmd != "exit")
{

    Console.WriteLine("\nAdd Food Items: add\n" +
                      "Delete Food Items: delete\n" +
                      "List Current Food Items: list\n" +
                      "Exit Program: exit\n\n" +
                      "Please type one of the commands above: ");

    cmd = Console.ReadLine();

    if (cmd.Equals("add")) 
    {
        listItems = FoodItem.AddItem(listItems);
    }
    else if (cmd.Equals("delete")) 
    {
        listItems = FoodItem.DeleteItem(listItems);
    }
    else if (cmd.Equals("list"))
    {
        FoodItem.List(listItems);
    }
    else if (cmd.Equals("exit")) 
    {
        return;
    }
    else
    {
        Console.WriteLine("\nInput Invalid");
    }

}


