using ADO.NET_ile_Veritabani_Programlama.Business;
using System.Data.SqlClient;
using System.Data;

namespace ADO.NET_ile_Veritabani_Programlama.Database
{
    public class ProductDAL
    {
        string sql = string.Empty;
        SqlConnection conn = new SqlConnection(Database.GetConnectionString);
        SqlCommand cmd;
        public List<Product> GetProductsByCategoryID(int categoryID)
        {
            sql = "Select ProductID, ProductName FROM Products WHERE CategoryID=" + categoryID;
            cmd = new SqlCommand(sql, conn);

            return ExecuteListQuery(cmd);

        }

        private List<Product> ExecuteListQuery(SqlCommand cmd)
        {
            List<Product> list = new List<Product>();
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Product((int)reader[0], reader[1].ToString()));
                }

            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }

            return list;
        }
    }
}
