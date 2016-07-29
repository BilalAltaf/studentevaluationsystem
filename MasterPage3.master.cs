using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;

public partial class MasterPage3 : System.Web.UI.MasterPage
{
    MySqlConnection con = new MySqlConnection("server=localhost;uid=root;database=student_academic_management_system;password=0544612702");
    protected void Page_Load(object sender, EventArgs e)
    {
        username.Text = Session["s_name"].ToString();
    }
    protected void changepassword_Click(object sender, EventArgs e)
    {
        Response.Redirect("student_change_password.aspx");
    }
    protected void logout_Click(object sender, EventArgs e)
    {
        Session.RemoveAll();
        Response.Redirect("student_loginpage.aspx");
    }
    protected void btnhomepage_Click(object sender, EventArgs e)
    {
        Response.Redirect("student_homepage.aspx");
    }
    protected void btnpersonalinformation_Click(object sender, EventArgs e)
    {
        Response.Redirect("student_personal_information.aspx");
    }
    protected void btnregistration_Click(object sender, EventArgs e)
    {
        Response.Redirect("student_subject_registration.aspx");
    }
    protected void btnsubjects_Click(object sender, EventArgs e)
    {
        Session.Remove("subjectname");
        Response.Redirect("student_subjects.aspx");
    }
    protected void btngpaprediction_Click(object sender, EventArgs e)
    {
        Response.Redirect("student_subject_gpa_prediction.aspx");
    }
    protected void btncgpaprediction_Click(object sender, EventArgs e)
    {
        Response.Redirect("student_cgpa_prediction.aspx");
    }
    protected void btnsubjectsannouncement_Click(object sender, EventArgs e)
    {
        Response.Redirect("student_subject_announcement.aspx");
    }
    protected void btnfinalresult_Click(object sender, EventArgs e)
    {
        Response.Redirect("student_subject_final_result.aspx");
    }
    protected void btnsubjects_progress_Click(object sender, EventArgs e)
    {
        Response.Redirect("student_all_subject_progress.aspx");
    }
}
