using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class student_subjectresult : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["s_id"] == null)
        {
            Response.Redirect("student_loginpage.aspx");
        }
        else if (Session["subjectname"] != null)
        {
            string name;
            name = Session["subjectname"].ToString();
            btnsubjectname.Text = name;
        }
    }
    protected void btnsubjectname_Click(object sender, EventArgs e)
    {
        Response.Redirect("student_subjectresult.aspx");
    }
    protected void btnquiz_Click(object sender, EventArgs e)
    {
        Response.Redirect("student_subject_quiz_result.aspx");
    }
    protected void btnassignment_Click(object sender, EventArgs e)
    {
        Response.Redirect("student_subject_assignment_result.aspx");
    }
    protected void btnproject_Click(object sender, EventArgs e)
    {
        Response.Redirect("student_subject_project_result.aspx");
    }
    protected void btnmidterm_Click(object sender, EventArgs e)
    {
        Response.Redirect("student_subject_midterm_result.aspx");
    }
    protected void btnfinal_Click(object sender, EventArgs e)
    {
        Response.Redirect("student_subject_finalterm_result.aspx");
    }
    protected void btn_suggestion_Click(object sender, EventArgs e)
    {
        Response.Redirect("student_subject_grade_suggestion.aspx");
    }
    protected void btn_subject_progress_Click(object sender, EventArgs e)
    {
        Response.Redirect("student_subject_progress.aspx");
    }
    protected void btn_subject_announcement_Click(object sender, EventArgs e)
    {
        Response.Redirect("student_subject_announcement.aspx");
    }
}