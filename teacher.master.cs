using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class teacher : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        username.Text = Session["t_name"].ToString();
    }
    protected void changepassword_Click(object sender, EventArgs e)
    {
        Response.Redirect("teacher_change_password.aspx");
    }
    protected void logout_Click(object sender, EventArgs e)
    {
        Session.RemoveAll();
        Response.Redirect("teacher_loginpage.aspx");
    }
    protected void btnhomepage_Click(object sender, EventArgs e)
    {
        Response.Redirect("teacher_homepage.aspx");
    }
    protected void btnpersonalinformation_Click(object sender, EventArgs e)
    {
        Response.Redirect("teacher_personal_information.aspx");
    }
    protected void btnregistration_Click(object sender, EventArgs e)
    {
        Response.Redirect("teacher_subject_registration.aspx");
    }
    protected void btnsubjects_Click(object sender, EventArgs e)
    {
        Session.Remove("subjectname");
        Response.Redirect("teacher_subjects.aspx");
    }
}
