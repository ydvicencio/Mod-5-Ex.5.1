using System;

class Program {
  static void Main() {
    //use arrays to store the data
    string[] names = {"Danielle", "Edward", "Francis"}; //name of sales person
    string[] initials = {"D", "E", "F"}; //initial of sales person
    double[] sales = new double[3]; //array to store sales

    double saleAmount;
    string input;


    while (true)
    {
      //get salesperson initial
      Console.Write("\nEnter salesperson initial (D, E, F) or 'Z' to quit: ");
      input = Console.ReadLine();

      //exit if input is 'Z'
      if (input.ToUpper() == "Z")
      {
        break;
      }

      //ensure input is valid initial
     int inx = Array.IndexOf(initials, input.ToUpper());
      if (inx == -1)
      {
        Console.WriteLine("Invalid initial. Please try again.");
        continue;
      }

      //get sale amount
      Console.WriteLine("Enter sale amount: ");
      if (!double.TryParse(Console.ReadLine(), out saleAmount) || saleAmount < 0)
      {
        Console.WriteLine("Invalid sale amount. Please try again.");
        continue;
      }

      //add sale amount to corresponding person
     sales[inx] += saleAmount;
    }

    //display sales for each person
    double grandTotal = 0;
    for (int i = 0; i < names.Length; i++)
    {
      grandTotal += sales[i];
    }

    //dispaly sales 
    Console.WriteLine("\nSales Summary:");
    for (int i = 0; i < names.Length; i++)
    {
      Console.WriteLine($"{names[i]}'s total sales: {sales[i]:C}");
    }
      
    Console.WriteLine( $"Grand total of all sales: {grandTotal:C}");

    //find and display highest sale
    int topSalespersonIndex = -1;
    double topSale = 0;

    for (int i = 0; i < sales.Length; i++)
    {
      if (sales[i] > topSale)
      {
        topSale = sales[i];
        topSalespersonIndex = i;
      }
    }
    
    if (topSalespersonIndex != -1)
    {
      Console.WriteLine($"Highest sale: {initials[topSalespersonIndex]}'s total sales: {topSale:C}");
    }
  }
} 
