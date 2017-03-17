using BIIS.Model;
using System.Data;
using System.Data.SqlClient;

namespace BIIS.BusinessLogics
{
    public class ProductDal : BaseDAL
    {
        public static DataTable GetAll()
        {
            string sql = "Select * FROM Product";
            var da = new SqlDataAdapter(sql, connectionString);
            var dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable GetAllRecent()
        {
            string sql = "Select * FROM RecentTransaction";
            var da = new SqlDataAdapter(sql, connectionString);
            var dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        public static void UpdateTable(DataTable dt)
        {
            using (var con = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    cmd.CommandText = @"UPDATE Product SET 
                                                     Name=@name, 
                                                     Quantity=@quantity,
                                                     CostPerUnit=@cpu
                                                     WHERE Id=@id";
                    cmd.Parameters.Add("@name", SqlDbType.VarChar, 50, "Name");
                    cmd.Parameters.Add("@quantity", SqlDbType.Int, 0, "Quantity");
                    cmd.Parameters.Add("@cpu", SqlDbType.Int, 0, "CostPerUnit");
                    var param = cmd.Parameters.Add("@id", SqlDbType.Int, 5, "Id");
                    param.SourceVersion = DataRowVersion.Original;
                    cmd.Connection = con;
                    using (var da = new SqlDataAdapter())
                    {
                        da.UpdateCommand = cmd;
                        da.Update(dt);
                    }
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void SaveNewProduct(Product product)
        {
            //test
            //MessageBox.Show($"{product.Name} {product.CostPerUnit} {product.Quantity} {product.Type}");
            using (var con = new SqlConnection(connectionString))
            {
                var query = @"INSERT INTO Product (Name,Quantity,CostPerUnit,Type)
                            VALUES (@name,@quantity,@cpu,@type)";

                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("name", product.Name);
                    cmd.Parameters.AddWithValue("quantity", product.Quantity);
                    cmd.Parameters.AddWithValue("cpu", product.CostPerUnit);
                    cmd.Parameters.AddWithValue("type", product.Type);

                    con.Open();
                    cmd.ExecuteReader();
                }
            }
        }

        public static void UpdateExportRecord(int Id, int Quantity)
        {
            using (var con = new SqlConnection(connectionString))
            {
                var query = @"UPDATE Product
                              SET Quantity=@quantity
                              WHERE Id=@id";

                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("quantity", Quantity);
                    cmd.Parameters.AddWithValue("id", Id);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateRecentTransaction(string type, Product product)
        {
            using (var con = new SqlConnection(connectionString))
            {
                var query = @"INSERT INTO RecentTransaction (Name,Quantity,CostPerUnit,Type)
                            VALUES (@name,@quantity,@cpu,@type)";

                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("name", product.Name);
                    cmd.Parameters.AddWithValue("quantity", product.Quantity);
                    cmd.Parameters.AddWithValue("cpu", product.CostPerUnit);
                    cmd.Parameters.AddWithValue("type", type);

                    con.Open();
                    cmd.ExecuteReader();
                }
            }
        }

        public static int DbQuantity(int Id)
        {
            using (var con = new SqlConnection(connectionString))
            {
                var query = "SELECT Quantity FROM PRODUCT WHERE Id=@id";

                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("id", Id);

                    try
                    {
                        con.Open();
                        var retval = cmd.ExecuteScalar();

                        return (int)retval;
                    }
                    catch
                    {
                        return 0;
                    }
                }
            }
        }

        public static Product GetProduct(int Id)
        {
            var product = new Product();
            using (var con = new SqlConnection(connectionString))
            {
                var query = "SELECT * FROM Product WHERE Id=@id";

                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("id", Id);
                    con.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            product.Id = (int)reader["Id"];
                            product.Name = reader["Name"].ToString();
                            product.Quantity = (int)reader["Quantity"];
                            product.CostPerUnit = (int)reader["CostPerUnit"];
                            product.Type = reader["Type"].ToString();
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                }
                con.Close();
            }
            return product;
        }

        //public static void GetQuantity(int Id)
        //{
        //    using (var con = new SqlConnection(connectionString))
        //    {
        //        var query = "SELECT * FROM Product WHERE Id=@id";

        //        using (var cmd = new SqlCommand(query, con))
        //        {
        //            cmd.Parameters.AddWithValue("id", Id);
        //            con.Open();

        //        }
        //            cmd.Dispose();
        //        }
        //        con.Close();
        //    }

        //}

        public static void ReOrderTransaction(int Id, int Quantity)
        {
            using (var con = new SqlConnection(connectionString))
            {
                var query = @"UPDATE Product
                              SET Quantity=@quantity
                              WHERE Id=@id";

                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("quantity", Quantity);
                    cmd.Parameters.AddWithValue("id", Id);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
