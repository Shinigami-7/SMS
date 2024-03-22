using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Numerics;
using System.Xml.Linq;
using System.Diagnostics;

namespace Businesslayer
{
    public class BLLStudent
    {
        public int CreateStudent(int Roll_No,string Student_name, string Guardian_Name, string Guardian_No, string Grade)
        {
            SqlConnection con = new SqlConnection("Data Source = SHINIGAMI\\SQLEXPRESS; Integrated Security=True; Initial Catalog=TMSDB");
            string sql = "insert into tbstudent(Student_name,Guardian_Name,Guardian_No,Grade,Roll_no) values (@a,@b,@c,@d,@e)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@a", Student_name);
            cmd.Parameters.AddWithValue("@b", Guardian_Name);
            cmd.Parameters.AddWithValue("@c", Guardian_No);
            cmd.Parameters.AddWithValue("@d", Grade);
            cmd.Parameters.AddWithValue("@e", Roll_No);
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
        public DataTable GetAllUserbyusername(string std_name, string grade)
        {
            SqlConnection con = new SqlConnection("Data Source = SHINIGAMI\\SQLEXPRESS; Integrated Security=True; Initial Catalog=TMSDB");
            string sql = "select * from tbstudent where Student_Name=@a and Grade=@b";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@a", std_name);
            cmd.Parameters.AddWithValue("@b", grade);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable GetAllUserinfo(string Roll_No, string Student_name, string Guardian_Name, string Guardian_No, string Grade)
        {
            SqlConnection con = new SqlConnection("Data Source = SHINIGAMI\\SQLEXPRESS; Integrated Security=True; Initial Catalog=TMSDB");
            string sql = "select * from tbstudent where Roll_no=@e and Student_Name=@a and Grade=@b and Guardian_Name=@c and Guardian_No=@d";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@a", Student_name);
            cmd.Parameters.AddWithValue("@c", Guardian_Name);
            cmd.Parameters.AddWithValue("@d", Guardian_No);
            cmd.Parameters.AddWithValue("@b", Grade);
            cmd.Parameters.AddWithValue("@e", Roll_No);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int EditStudent(int Roll_no, string Student_Name, string Guardian_Name, string Guardian_No, string Grade)
        {
            SqlConnection con = new SqlConnection("Data Source = SHINIGAMI\\SQLEXPRESS; Integrated Security=True; Initial Catalog=TMSDB");
            string sql = "UPDATE tbstudent SET Student_Name = @a, Grade = @b, Guardian_Name = @c, Guardian_No = @d WHERE Roll_no = @e";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@a", Student_Name);
            cmd.Parameters.AddWithValue("@c", Guardian_Name);
            cmd.Parameters.AddWithValue("@d", Guardian_No);
            cmd.Parameters.AddWithValue("@b", Grade);
            cmd.Parameters.AddWithValue("@e", Roll_no);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public int deleteuser(int roll_no)
        {
            SqlConnection con = new SqlConnection("Data Source = SHINIGAMI\\SQLEXPRESS; Integrated Security=True; Initial Catalog=TMSDB");
            string sql = "delete from tbstudent where Roll_no=@a";
            SqlCommand cmd = new SqlCommand(sql,con);
            cmd.Parameters.AddWithValue("@a",roll_no);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
    }
}
