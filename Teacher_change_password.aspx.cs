using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;


public partial class Teacher_change_password : System.Web.UI.Page
{
    MySqlConnection con = new MySqlConnection("server=localhost;uid=root;database=student_academic_management_system;password=0544612702");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["t_id"] == null)
        {
            Response.Redirect("teacher_loginpage.aspx");
        }
    }
    protected void submit_Click(object sender, EventArgs e)
    {
        string teacher_id = Session["t_id"].ToString();
        string password="";
        con.Open();
        MySqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select t_password from teacher_detail where t_id='" + teacher_id+"' ";
        MySqlDataReader ids = cmd.ExecuteReader();
        while (ids.Read())
        {
            password = ids.GetString(0);
        }
        con.Close();
        if (password == Currentpassword.Text)
        {
            if(Newpassword.Text==Confirmpassword.Text)
            {
                con.Open();
                MySqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText="update teacher_detail set t_password='"+Newpassword.Text+"' where t_id='"+teacher_id+"'";
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