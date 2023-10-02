using ADO.NET_ile_Veritabani_Programlama.Business;
using System.Data;
using System.Data.SqlClient;

namespace ADO.NET_ile_Veritabani_Programlama.Database
{
    public class ShipperDAL
    {
        string sql = string.Empty;
        SqlConnection conn = new SqlConnection(Database.GetConnectionString);
        SqlCommand cmd;
        bool result;
        string queryResult;

        public bool Add(string companyName, string phone)
        {
            sql = "INSERT INTO Shippers VALUES('" + companyName + "', '" + phone + "')";
            cmd = new SqlCommand(sql, conn);

            ExecuteCommand(cmd);

            return result;
        }

        public bool Update(int id, string companyName, string phone)
        {
            sql = "UPDATE Shippers SET CompanyName='" + companyName + "', Phone='" + phone + "' WHERE ShipperID =" + id;
            cmd = new SqlCommand(sql, conn);

            ExecuteCommand(cmd);

            return result;
        }

        public bool Delete(int id)
        {
            sql = "DELETE FROM Shippers WHERE ShipperID =" + id;
            cmd = new SqlCommand(sql, conn);

            ExecuteCommand(cmd);

            return result;
        }

        public string GetCompanyNameById(int id)
        {
            sql = "Select CompanyName FROM Shippers WHERE ShipperID =" + id;
            cmd = new SqlCommand(sql, conn);

            return ExecuteSingleQuery(cmd);
        }

        public List<Shipper> GetShippers()
        {
            sql = "Select * FROM Shippers";
            cmd = new SqlCommand(sql, conn);

            return ExecuteListQuery(cmd);
        }

        private List<Shipper> ExecuteListQuery(SqlCommand cmd)
        {
            List<Shipper> list = new List<Shipper>();
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                SqlDataReader reader = cmd.ExecuteReader();
                
                while(reader.Read())
                {
                    list.Add(new Shipper((int)reader[0], reader[1].ToString(), reader[2].ToString()));
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

        private string ExecuteSingleQuery(SqlCommand cmd)
        {
            string sonuc;
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                sonuc = cmd.ExecuteScalar().ToString();


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

            return sonuc;
        }

        private void ExecuteCommand(SqlCommand cmd)
        {
            try
            {
                if(conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                int sonuc = cmd.ExecuteNonQuery();

                if( sonuc > 0 )
                {
                    result = true;
                }
            }
            catch(Exception ex)
            {
                throw;
            }
            finally
            {
                if(conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }
    }
}
