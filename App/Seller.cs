using System;
using System.Collections.Generic;

class Seller
{
    // Public properties with private setters to ensure controlled modification
    public string Name { get; private set; }
    public string TypeOfDocument { get; private set; }
    public string Document { get; private set; }

    // Constructor to initialize the Seller object
    public Seller(string name, string typeOfDocument, string document)
    {
        Name = name;
        TypeOfDocument = typeOfDocument;
        Document = document;
    }

    // Prompts the user to enter the seller's name and validates the input
    private static string AskName()
    {
        while (true)
        {
            Console.WriteLine("Enter name of the new seller:");
            string? name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Name can't be empty.");
                continue;
            }
            return name;
        }
    }

    // Prompts the user to select a valid document type
    private static string AskTypeOfDocument()
    {
        while (true)
        {
            Console.WriteLine(@"Choose a valid option:
  1. C.C
  2. PEP
  3. DNI");
            string? input = Console.ReadLine();
            switch (input)
            {
                case "1": return "C.C";
                case "2": return "PEP";
                case "3": return "DNI";
                default:
                    Console.WriteLine("Choose a correct option.");
                    break;
            }
        }
    }

    // Prompts the user to enter the seller's document number and validates the input
    private static string AskDocument()
    {
        while (true)
        {
            Console.WriteLine("Enter your document number:");
            string? document = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(document))
            {
                Console.WriteLine("The document number can't be empty.");
                continue;
            }
            return document;
        }
    }

    // Collects seller data from the user and adds a new Seller to the provided list
    public static void FillSellerList(List<Seller> sellerList)
    {
        string name = AskName();
        string typeOfDocument = AskTypeOfDocument();
        string document = AskDocument();

        Seller seller = new Seller(name, typeOfDocument, document);
        sellerList.Add(seller);
        Console.WriteLine(Show(sellerList));
    }

    // Returns a formatted string with the seller's information
    private static string Show(List<Seller> sellerList)
    {
        Seller tempSeller = sellerList.Last();
        return $"Name: {tempSeller.Name}, Document Type: {tempSeller.TypeOfDocument}, Document: {tempSeller.Document}";
    }
}
