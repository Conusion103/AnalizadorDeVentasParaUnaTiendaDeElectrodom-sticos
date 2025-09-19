
List<Seller> sellerList = new List<Seller>();

while (true)
{
    Console.WriteLine(@"Welcome to main of sales
    Want do you want?
    1. Resgiter a new seller
    2. Make a new purchase
    ");
    string? option = Console.ReadLine();
    switch (option)
    {
        case "1":
            Seller.FillSellerList(sellerList);
            break;
        case "2":


        
    }
}






