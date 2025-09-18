class Seller
{
    private string Name { get; set; }
    private string TypeOfDocument { get; set; }
    private string Document { get; set; }

    public Seller(string name, string typeOfDocument, string document)
    {
        Name = name;
        TypeOfDocument = typeOfDocument;
        Document = document;
    }

    private static string AskName()
    {
        while (true)
        {
            Console.WriteLine("Enter name of the new seller");
            string? Name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(Name)) { Console.WriteLine("Name cant' be empty"); continue; }
            return Name;
        }

    }

    private static string AskTypeOfDocument()
    {
        while (true)
        {
            Console.WriteLine(@"Choose a valid option
                              1. C.C
                              2. PEP
                              3. DNI");
            string? typeOfDocument = Console.ReadLine();
            switch (typeOfDocument)
            {
                case "1":
                    return "C.C";
                case "2":
                    return "PEP";
                case "3":
                    return "DNI";
                default:
                    Console.WriteLine("Choose a correct option");
                    continue;
            }

        }

    }

    private static string AskDocument()
    {
        while (true)
        {

            Console.WriteLine("Enter your number of document");
            string document = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(document)) { Console.WriteLine("The number of document can't be empty"); continue; }
            return document;

        }

    }


    public static void FillSellerList(List<Seller> sellerList)
    {
        string Name = AskName();
        string TypeOfDocument = AskTypeOfDocument();
        string Document = AskDocument();
        Seller seller = new Seller(Name, TypeOfDocument, Document);
        sellerList.Add(seller);

    }

    public static string ShowNewSeller()
    {
        // return "New Seller: " + @"
        //         Name"+;
        return "";
    }


    static void Main()
    {
        List<Seller> sellerList = new List<Seller>();
        FillSellerList(sellerList);




    }
}