using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;

public partial class teacher_subjectresult : System.Web.UI.Page
{
    MySqlConnection con = new MySqlConnection("server=localhost;uid=root;database=student_academic_management_system;password=0544612702");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["t_id"] == null)
        {
            Response.Redirect("teacher_loginpage.aspx");
        }
        if (Session["teachersubjectname"] != null)
        {
            string name;
            name = Session["teachersubjectname"].ToString();
            Button1.Text = name;
        }
    }
    protected void btnquiz_Click(object sender, EventArgs e)
    {
        Response.Redirect("teacher_quiz_marks_entrance.aspx");
    }

    protected void btnassignment_Click(object sender, EventArgs e)
    {
        Response.Redirect("teacher_assignment_marks_entrance.aspx");
    }
    protected void btnproject_Click(object sender, EventArgs e)
    {
        Response.Redirect("teacher_project_marks_entrance.aspx");
    }
    protected void btnmidterm_Click(object sender, EventArgs e)
    {
        Response.Redirect("teacher_midterm_marks_entrance.aspx");
    }
    protected void btnfinal_Click(object sender, EventArgs e)
    {
        Response.Redirect("teacher_final_marks_entrance.aspx");
    }
    protected void btnannouncement_Click(object sender, EventArgs e)
    {
        Response.Redirect("teacher_subject_announcement_entrance.aspx");
    }
}