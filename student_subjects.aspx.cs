using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

public partial class student_subjects : System.Web.UI.Page
{
    MySqlConnection con = new MySqlConnection("server=localhost;uid=root;database=student_academic_management_system;password=0544612702");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["s_id"] == null)
        {
            Response.Redirect("student_loginpage.aspx");
        }
        else if ((string)Session["s_registration"] == "not done")
        {
            Response.Redirect("student_subject_registration.aspx");
        }
        else
        {
            generate();
        }
    }
    public string[] subject_name;
    public string[] subject_id;
    public void generate()
    {
        string s = Session["s_id"].ToString();
        con.Open();
        MySqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select count(su_id) from student_registered_courses where s_id='" + s + "'";
        cmd.ExecuteNonQuery();
        int RecordCount;
        int a = 0;
        RecordCount = Convert.ToInt32(cmd.ExecuteScalar());
        subject_name = new string[RecordCount];
        subject_id = new string[RecordCount];
        cmd.CommandText = "select su_id,su_name from subject_detail where su_id in(select su_id from student_registered_courses where s_id='" + s + "')";
        cmd.ExecuteNonQuery();
        MySqlDataReader ids = cmd.ExecuteReader();
        while (ids.Read())
        {
            subject_name[a] = ids.GetString(1);
            subject_id[a] = ids.GetString(0);
            a++;

        }
        con.Close();
        for (int i = 0; i < a; i++)
        {
            //btnsubjects.BackColor = System.Drawing.Color.DarkRed;
            Button dynamicButton = new Button();
            dynamicButton.Text = subject_name[i];
            dynamicButton.ID = "DynamicButton" + i.ToString();
            dynamicButton.Width = 300;
            dynamicButton.CssClass = "button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange";
            if (i == 0)
            {
                dynamicButton.Click += new EventHandler(Subject0_Click);
            }
            else if (i == 1)
            {
                dynamicButton.Click += new EventHandler(Subject1_Click);
            }
            else if (i == 2)
            {
                dynamicButton.Click += new EventHandler(Subject2_Click);
            }
            else if (i == 3)
            {
                dynamicButton.Click += new EventHandler(Subject3_Click);
            }
            else if (i == 4)
            {
                dynamicButton.Click += new EventHandler(Subject4_Click);
            }
            else if (i == 5)
            {
                dynamicButton.Click += new EventHandler(Subject5_Click);
            }
            else if (i == 6)
            {
                dynamicButton.Click += new EventHandler(Subject6_Click);
            }
            else if (i == 7)
            {
                dynamicButton.Click += new EventHandler(Subject7_Click);
            }
            else if (i == 8)
            {
                dynamicButton.Click += new EventHandler(Subject8_Click);
            }
            else if (i == 9)
            {
                dynamicButton.Click += new EventHandler(Subject9_Click);
            }
            else if (i == 10)
            {
                dynamicButton.Click += new EventHandler(Subject10_Click);
            }
            Panel1.Controls.Add(dynamicButton);
            //TextBox1.Text = myString;
        }
    }
    private void Subject0_Click(object sender, EventArgs e)
    {
        Session["subject_id"] = subject_id[0];
        Session["subjectname"] = subject_name[0];
        Response.Redirect("student_subjectresult.aspx");
    }

    private void Subject1_Click(object sender, EventArgs e)
    {
        Session["subject_id"] = subject_id[1];
        Session["subjectname"] = subject_name[1];
        Response.Redirect("student_subjectresult.aspx");
    }
    private void Subject2_Click(object sender, EventArgs e)
    {
        Session["subject_id"] = subject_id[2];
        Session["subjectname"] = subject_name[2];
        Response.Redirect("student_subjectresult.aspx");
    }
    private void Subject3_Click(object sender, EventArgs e)
    {
        Session["subject_id"] = subject_id[3];
        Session["subjectname"] = subject_name[3];
        Response.Redirect("student_subjectresult.aspx");
    }
    private void Subject4_Click(object sender, EventArgs e)
    {
        Session["subject_id"] = subject_id[4];
        Session["subjectname"] = subject_name[4];
        Response.Redirect("student_subjectresult.aspx");
    }
    private void Subject5_Click(object sender, EventArgs e)
    {
        Session["subject_id"] = subject_id[5];
        Session["subjectname"] = subject_name[5];
        Response.Redirect("student_subjectresult.aspx");
    }
    private void Subject6_Click(object sender, EventArgs e)
    {
        Session["subject_id"] = subject_id[6];
        Session["subjectname"] = subject_name[6];
        Response.Redirect("student_subjectresult.aspx");
    }
    private void Subject7_Click(object sender, EventArgs e)
    {
        Session["subject_id"] = subject_id[7];
        Session["subjectname"] = subject_name[7];
        Response.Redirect("student_subjectresult.aspx");
    }
    private void Subject8_Click(object sender, EventArgs e)
    {
        Session["subject_id"] = subject_id[8];
        Session["subjectname"] = subject_name[8];
        Response.Redirect("student_subjectresult.aspx");
    }
    private void Subject9_Click(object sender, EventArgs e)
    {
        Session["subject_id"] = subject_id[9];
        Session["subjectname"] = subject_name[9];
        Response.Redirect("student_subjectresult.aspx");
    }
    private void Subject10_Click(object sender, EventArgs e)
    {
        Session["subject_id"] = subject_id[10];
        Session["subjectname"] = subject_name[10];
        Response.Redirect("student_subjectresult.aspx");
    }
}