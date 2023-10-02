using ADO.NET_ile_Veritabani_Programlama.Business;
using System.Data;
using System.Data.SqlClient;

namespace ADO.NET_ile_Veritabani_Programlama.Database
{
    public class CategoryDAL
    {
        string sql = string.Empty;
        SqlConnection conn = new SqlConnection(Database.GetConnectionString);
        SqlCommand cmd;

        public List<Category> GetCategories()
        {
            sql = "Select * FROM Categories";
            cmd = new SqlCommand(sql, conn);

            return ExecuteListQuery(cmd);

        }

        private List<Category> ExecuteListQuery(SqlCommand cmd)
        {
            List<Category> list = new List<Category>();
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Category((int)reader[0], reader[1].ToString(), reader[2].ToString(), (Byte[])reader[3]));
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
