using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;

public partial class student_personal_information : System.Web.UI.Page
{
    MySqlConnection con = new MySqlConnection("server=localhost;uid=root;database=student_academic_management_system;password=0544612702");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["s_id"] == null)
        {
            Response.Redirect("student_loginpage.aspx");
        }
        else 
        {
            generate();
        }
    }
    public void generate()
    {
        string s_id = Session["s_id"].ToString();
        con.Open();
        MySqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select s_id,s_ProgramName,S_firstName,S_lastName,s_fathername,s_semester,s_section,s_contactno,s_emailaddress,s_address from student_detail where s_id='" + s_id + "'";
        MySqlDataReader id1 = cmd.ExecuteReader();
        while (id1.Read())
        {
            id.Text = id1.GetString(0);
            program_name.Text = id1.GetString(1);
            name.Text = id1.GetString(2)+id1.GetString(3);
            father_name.Text = id1.GetString(4);
            if (id1[6] != DBNull.Value)
            {
                class1.Text = id1.GetString(1) + "(" + id1.GetString(5) + id1.GetString(6) + ")";
            }
            if ( id1[6] == DBNull.Value)
            {
                class1.Text = id1.GetString(1) + "(" + id1.GetString(5)+")";
            }
            contact_no.Text = id1.GetString(7);
            email_address.Text = id1.GetString(8);
            address.Text = id1.GetString(9);
        }
    }
}