using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Businesslayer
{
    public class BLLStudent
    {
        public int CreateStudent(string std_name, string gurdi_name, string gurdi_no, string grade)
        {
            SqlConnection con = new SqlConnection("Data Source = SHINIGAMI\\SQLEXPRESS; Integrated Security=True; Initial Catalog=TMSDB");
            string sql = "insert into tbstudent(std_name,gurdi_name,gurdi_no,grade) values (@a,@b,@c,@d)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@a", std_name);
            cmd.Parameters.AddWithValue("@b", gurdi_name);
            cmd.Parameters.AddWithValue("@c", gurdi_no);
            cmd.Parameters.AddWithValue("@d", grade);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public DataTable GetAllUser()
        {
            SqlConnection con = new SqlConnection("Data Source = SHINIGAMI\\SQLEXPRESS; Integrated Security=True; Initial Catalog=TMSDB");
            string sql = "select * from tbstudent";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
