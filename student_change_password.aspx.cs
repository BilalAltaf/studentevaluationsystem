using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;


public partial class student_change_password : System.Web.UI.Page
{
    MySqlConnection con = new MySqlConnection("server=localhost;uid=root;database=student_academic_management_system;password=0544612702");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["s_id"] == null)
        {
            Response.Redirect("student_loginpage.aspx");
        }
    }
    protected void submit_Click(object sender, EventArgs e)
    {
        string student_id = Session["s_id"].ToString();
        string password = "";
        con.Open();
        MySqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select s_password from student_detail where s_id='" + student_id + "' ";
        MySqlDataReader ids = cmd.ExecuteReader();
        while (ids.Read())
        {
            password = ids.GetString(0);
        }
        con.Close();
        if (password == Currentpassword.Text)
        {
            if (Newpassword.Text == Confirmpassword.Text)
            {
                con.Open();
                MySqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "update student_detail set s_password='" + Newpassword.Text + "' where s_id='" + student_id + "'";
                cmd1.ExecuteNonQuery();
                con.Close();
            }
            else
            {

            }
        }
        else
        {
        }
    }
}