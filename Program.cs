using Mission_3;

List<FoodItem> listItems = new List<FoodItem>(); // List to store FoodItem objects
string cmd = ""; // Command input from the user

while (cmd != "exit")
{
    // Display menu options to the user
    Console.WriteLine("\nAdd Food Items: add\n" +
                      "Delete Food Items: delete\n" +
                      "List Current Food Items: list\n" +
                      "Exit Program: exit\n\n" +
                      "Please type one of the commands above: ");

    cmd = Console.ReadLine()?.ToLower(); // Read user input and normalize to lowercase

    if (cmd.Equals("add"))
    {
        // Add a new food item to the list
        listItems = FoodItem.AddItem(listItems);
    }
    else if (cmd.Equals("delete"))
    {
        // Delete a food item from the list by ID
        listItems = FoodItem.DeleteItem(listItems);
    }
    else if (cmd.Equals("list"))
    {
        // Display all current food items in the list
        FoodItem.List(listItems);
    }
    else if (cmd.Equals("exit"))
    {
        // Exit the program
        Console.WriteLine("Exiting program. Goodbye!");
        break;
    }
    else
    {
        // Invalid input handling
        Console.WriteLine("\nInvalid input. Please try again.");
    }
}
