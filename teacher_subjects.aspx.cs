using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;

public partial class teacher_subjects : System.Web.UI.Page
{
    MySqlConnection con = new MySqlConnection("server=localhost;uid=root;database=student_academic_management_system;password=0544612702");

    protected void Page_Load(object sender, EventArgs e)
    {
        generate();
    }
    public string[] subject_name;
    public string[] subject_id;
    public void generate()
    {
        string t_id = Session["t_id"].ToString();
        con.Open();
        MySqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select count(su_id) from teacher_registered_courses where t_id='" + t_id + "'";
        cmd.ExecuteNonQuery();
        int RecordCount;
        int a = 0;
        RecordCount = Convert.ToInt32(cmd.ExecuteScalar());
        subject_name = new string[RecordCount];
        subject_id = new string[RecordCount];
        cmd.CommandText = "select su_name,su_id from subject_detail where su_id in(select su_id from teacher_registered_courses where t_id='" + t_id + "')";
        MySqlDataReader ids = cmd.ExecuteReader();
        while (ids.Read())
        {
            subject_name[a] = ids.GetString(0);
            subject_id[a] = ids.GetString(1);
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
            dynamicButton.CssClass = "place-center button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange";

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
            Panel1.Controls.Add(dynamicButton);
        }
    }
    private void Subject0_Click(object sender, EventArgs e)
    {
        Session["teachersubjectname"] = subject_name[0];
        Session["teachersubject_id"] = subject_id[0];
        Response.Redirect("teacher_subjectresult.aspx");
    }

    private void Subject1_Click(object sender, EventArgs e)
    {
        Session["teachersubjectname"] = subject_name[1];
        Session["teachersubject_id"] = subject_id[1];
        Response.Redirect("teacher_subjectresult.aspx");
    }
    private void Subject2_Click(object sender, EventArgs e)
    {
        Session["teachersubjectname"] = subject_name[2];
        Session["teachersubject_id"] = subject_id[2];
        Response.Redirect("teacher_subjectresult.aspx");
    }
    private void Subject3_Click(object sender, EventArgs e)
    {
        Session["teachersubjectname"] = subject_name[3];
        Session["teachersubject_id"] = subject_id[3];
        Response.Redirect("teacher_subjectresults.aspx");
    }
    private void Subject4_Click(object sender, EventArgs e)
    {
        Session["teachersubjectname"] = subject_name[4];
        Session["teachersubject_id"] = subject_id[4];
        Response.Redirect("teacher_subjectresults.aspx");
    }
    private void Subject5_Click(object sender, EventArgs e)
    {
        Session["teachersubjectname"] = subject_name[6];
        Session["teachersubject_id"] = subject_id[6];
        Response.Redirect("teacher_subjectresult.aspx");
    }

}