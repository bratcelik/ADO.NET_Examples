namespace ADO.NET_ile_Veritabani_Programlama.Business
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }

        public Product(int productID, string productName, decimal unitPrice, short unitsInStock)
        {
            ProductID = productID;
            ProductName = productName;
            UnitPrice = unitPrice;
            UnitsInStock = unitsInStock;
        }
    }
}
