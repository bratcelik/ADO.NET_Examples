namespace ADO.NET_ile_Veritabani_Programlama.Business
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public Byte[] Picture { get; set; }

        public Category(int categoryID, string categoryName, string description, Byte[] picture)
        {
            CategoryID = categoryID;
            CategoryName = categoryName;
            Description = description;
            Picture = picture;
        }
    }
}
