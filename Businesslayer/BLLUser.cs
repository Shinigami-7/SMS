using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Businesslayer
{
    public class BLLUser
    {
        public int CreateUser(string Fullname, string Username, string Password, string Cpassword, string Email, string Gender)
        {
            SqlConnection con = new SqlConnection("Data Source = SHINIGAMI\\SQLEXPRESS; Integrated Security=True; Initial Catalog=TMSDB");
            string sql = "insert into tbuser(Fullname,Username,Password,Cpassword,Email,Gender) values (@a,@b,@c,@d,@e,@g)";
            SqlCommand cmd = new SqlCommand(sql,con);
            cmd.Parameters.AddWithValue("@a", Fullname);
            cmd.Parameters.AddWithValue("@b", Username);
            cmd.Parameters.AddWithValue("@c", Password);
            cmd.Parameters.AddWithValue("@d", Cpassword);
            cmd.Parameters.AddWithValue("@e", Email);
            cmd.Parameters.AddWithValue("@g", Gender);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public DataTable GetAllUser()
        {
            SqlConnection con = new SqlConnection("Data Source = SHINIGAMI\\SQLEXPRESS; Integrated Security=True; Initial Catalog=TMSDB");
            string sql = "select * from tbuser"; 
            SqlCommand cmd = new SqlCommand(sql,con);
            SqlDataAdapter da=new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
