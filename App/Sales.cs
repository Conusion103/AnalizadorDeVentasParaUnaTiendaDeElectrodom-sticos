class Sales
{
    public Guid Id { get; set; }
    public DateTime SaleDate { get; set; }
    public decimal ProductValue { get; set; }
    public int ProductAmount { get; set; }
    public Seller seller;
    public Buyer buyer;
    public TimeSpan WarrantyPeriod { get; set; }

    public Sales()
    {
        

    }



    static void Main()
    {
        Sales sale1 = new Sales();


    }


}