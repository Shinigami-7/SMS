using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Businesslayer
{
    public class BLLUser
    {
        public int CreateUser(string Username, string Password, string Cpassword, string Email, string Gender)
        {
            SqlConnection con = new SqlConnection("Data Source = SHINIGAMI\\SQLEXPRESS; Integrated Security=True; Initial Catalog=TMSDB");
            string sql = "insert into tbuser(Username,Password,Cpassword,Email,Gender) values(@a,@b,@c,@d,@e)";
            SqlCommand cmd = new SqlCommand(sql,con);
            cmd.Parameters.AddWithValue("@a", Username);
            cmd.Parameters.AddWithValue("@b", Password);
            cmd.Parameters.AddWithValue("@c", Cpassword);
            cmd.Parameters.AddWithValue("@d", Email);
            cmd.Parameters.AddWithValue("@e", Gender);
            con.Open();
            int i= cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
    }
}
