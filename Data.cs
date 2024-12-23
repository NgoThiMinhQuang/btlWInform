using System.Data.SqlClient;

namespace Phone_Store
{
    internal class Data
    {
        static string conn = "Data Source=MSI\\MSI;Initial Catalog=Phonestore;Integrated Security=True";
        public bool checkuser(string user)
        {
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            string query = "select * from taikhoan where tendangnhap = '" + user + "'";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                connection.Close();
                return true;
            }
            connection.Close();
            return false;
        }
        public bool checklogin(string user, string pass,string role)
        {
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            string query = "select * from taikhoan where tendangnhap = '" + user + "' and matkhau = '" + pass + "'" + "and quyenhan = '" + role + "'";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                connection.Close();
                return true;
            }
            connection.Close();
            return false;
        }
        public void adduser(string user, string pass, string role)
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {
                string query = "INSERT INTO taikhoan (tendangnhap, matkhau, quyenhan) VALUES (@user, @pass, @role)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.Parameters.AddWithValue("@role", role);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }




    }
}
