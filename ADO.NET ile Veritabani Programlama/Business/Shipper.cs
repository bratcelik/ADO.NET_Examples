namespace ADO.NET_ile_Veritabani_Programlama.Business
{
    public class Shipper
    {
        public int ShipperID { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }

        public Shipper(int shipperID, string companyName, string phone)
        {
            ShipperID = shipperID;
            CompanyName = companyName;
            Phone = phone;
        }
    }
}
