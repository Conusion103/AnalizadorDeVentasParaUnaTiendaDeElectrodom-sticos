class Sales
{
    public Guid Id { get; private set; }
    public DateTime SaleDate { get; private set; }
    public decimal ProductValue { get; private set; }
    public int ProductAmount { get; private set; }
    public Seller seller;
    public Buyer buyer;
    public TimeSpan WarrantyPeriod { get; private set; }

    public Sales()
    {
        

    }





}