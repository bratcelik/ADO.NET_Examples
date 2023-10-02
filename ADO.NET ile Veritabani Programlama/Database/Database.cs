namespace ADO.NET_ile_Veritabani_Programlama.Database
{
    public class Database
    {
        public static string GetConnectionString
        {//"Server=localhost;Database=master;Trusted_Connection=True;"
            get { return "Server=localhost;Database=NORTHWND;Trusted_Connection=True;"; }

            //"Server=DESKTOP-RBB5KNH\\MSSQLSERVER01;Database=NORTHWND;User=DESKTOP-RBB5KNH\\BSercan"
        }
    }
}
