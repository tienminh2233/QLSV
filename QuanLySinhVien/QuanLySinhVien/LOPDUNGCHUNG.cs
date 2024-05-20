using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public class LOPDUNGCHUNG
    {
        private readonly string connectionString;

        public LOPDUNGCHUNG()
        {
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tranq\source\repos\QuanLySinhVien\QuanLySinhVien\QLSV.mdf;Integrated Security=True";
        }

        public int ThemXoaSua(string sql, List<SqlParameter> parameters = null)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand comm = new SqlCommand(sql, conn))
                    {
                        if (parameters != null)
                        {
                            comm.Parameters.AddRange(parameters.ToArray());
                        }
                        conn.Open();
                        return comm.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return -1;
            }
        }

        public DataTable LoadDL(string sql, List<SqlParameter> parameters = null)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                    {
                        if (parameters != null)
                        {
                            da.SelectCommand.Parameters.AddRange(parameters.ToArray());
                        }

                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
        }

        public object ExecuteScalar(string sql, List<SqlParameter> parameters = null)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand comm = new SqlCommand(sql, conn))
                    {
                        if (parameters != null)
                        {
                            comm.Parameters.AddRange(parameters.ToArray());
                        }

                        conn.Open();
                        return comm.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
        }

        public object GetData(string sql, List<SqlParameter> parameters = null)
        {
            return ExecuteScalar(sql, parameters);
        }

        public List<object> GetListData(string sql, List<SqlParameter> parameters = null)
        {
            List<object> list = new List<object>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand comm = new SqlCommand(sql, conn))
                    {
                        if (parameters != null)
                        {
                            comm.Parameters.AddRange(parameters.ToArray());
                        }

                        conn.Open();
                        using (SqlDataReader reader = comm.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                list.Add(reader[0]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return list;
        }
    }
}
