using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

public partial class teacher_loginpage : System.Web.UI.Page
{
    MySqlConnection con = new MySqlConnection("server=localhost;uid=root;database=student_academic_management_system;password=0544612702");
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnlogin_Click(object sender, EventArgs e)
    {
        con.Open();
        MySqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select count(t_id) from teacher_detail where t_id='" + teacher_id.Text + "' && t_password='" + teacher_password.Text + "'";
        cmd.ExecuteNonQuery();
        int countvalue;
        countvalue = Convert.ToInt32(cmd.ExecuteScalar());
        if (countvalue == 1)
        {
            cmd.CommandText = "select t_id,t_registration,t_name from teacher_detail where t_id='" + teacher_id.Text + "' && t_password='" + teacher_password.Text + "'";
            cmd.ExecuteNonQuery();
            MySqlDataReader ids = cmd.ExecuteReader();
            while (ids.Read())
            {
                Session["t_id"] = ids.GetString(0);
                Session["t_registration"] = ids.GetString(1);
                Session["t_name"] = ids.GetString(2);
            }
            con.Close();
            Response.Redirect("teacher_homepage.aspx");
        }
        else
        {
            Response.Redirect("teacher_loginpage.aspx");
        }
    }
}