using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

public partial class student_loginpage : System.Web.UI.Page
{
    MySqlConnection con = new MySqlConnection("server=localhost;uid=root;database=student_academic_management_system;password=0544612702");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["s_id"] != null)
        {
            Response.Redirect("student_homepage.aspx");
        }
    }
    protected void btnlogin_Click(object sender, EventArgs e)
    {
        con.Open();
        MySqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select count(s_id),s_profile from student_detail where S_id='" + student_id.Text + "' && S_password='" + student_password.Text + "'";
        MySqlDataReader id3 = cmd.ExecuteReader();
        int countvalue=0;
        string check_profile="";
        while (id3.Read())
        {
            countvalue = id3.GetInt32(0);
            check_profile = id3.GetString(1);
        }
        con.Close();
        if (countvalue == 1 && check_profile=="done")
        {
            con.Open();
            cmd.CommandText = "select s_id,s_firstname,s_semester,s_section,s_registration from student_detail where S_id='" + student_id.Text + "' && S_password='" + student_password.Text + "'";
            cmd.ExecuteNonQuery();
            MySqlDataReader ids = cmd.ExecuteReader();
            while (ids.Read())
            {
                if (ids[3] != DBNull.Value)
                {
                    Session["s_section"] = ids.GetString(3);
                    Session["s_id"] = ids.GetString(0);
                    Session["s_name"] = ids.GetString(1);
                    Session["s_semester"] = ids.GetString(2);
                    Session["s_registration"] = ids.GetString(4);
                }
                else
                {
                     Session["s_section"] = "nil";
                    Session["s_id"] = ids.GetString(0);
                    Session["s_name"] = ids.GetString(1);
                    Session["s_semester"] = ids.GetString(2);
                    Session["s_registration"] = ids.GetString(4);
                    
                }
                
            }
            con.Close();
            Response.Redirect("student_homepage.aspx");
        }
        else
        {
            Response.Redirect("student_loginpage.aspx");
        }
    }
}