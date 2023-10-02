namespace ADO.NET_ile_Veritabani_Programlama.Business
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }

        public Product(int productID, string productName)
        {
            ProductID = productID;
            ProductName = productName;
        }
    }
}
