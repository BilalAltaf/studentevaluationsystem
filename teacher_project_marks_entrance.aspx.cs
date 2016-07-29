using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;

public partial class teacher_project_marks_entrance : System.Web.UI.Page
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
            project_button();
        }
    }
    string total_project;
    string total_project_percentage;
    public void project_button()
    {

        string t_id = Session["t_id"].ToString();
        string su_id = Session["teachersubject_id"].ToString();
        con.Open();
        MySqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select count(total_project) from subject_result where srs_id=(Select srs_id from student_registered_courses where su_id='" + su_id + "' limit 1)";
        cmd.ExecuteNonQuery();
        int a = Convert.ToInt32(cmd.ExecuteScalar());
        con.Close();
        if (a == 0)
        {
            Panel3.Visible = true;
        }
        else
        {
            Panel4.Visible = true;
            Panel5.Visible = true;
            Panel3.Visible = false;
            con.Open();
            MySqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select total_project,total_project_percentage from subject_result where srs_id=(Select srs_id from student_registered_courses where su_id='" + su_id + "' limit 1)";
            MySqlDataReader ids = cmd1.ExecuteReader();
            while (ids.Read())
            {
                total_project = ids.GetString(0);
                total_project_percentage = ids.GetString(1);
            }
            con.Close();
            if (total_project == "1")
            {
                btnproject1.Visible = true;
            }
            else if (total_project == "2")
            {
                btnproject1.Visible = true;
                btnproject2.Visible = true;
            }
            else if (total_project == "3")
            {
                btnproject1.Visible = true;
                btnproject2.Visible = true;
                btnproject3.Visible = true;

            }
            else if (total_project == "4")
            {
                btnproject1.Visible = true;
                btnproject2.Visible = true;
                btnproject3.Visible = true;
                btnproject4.Visible = true;


            }
            else if (total_project == "5")
            {
                btnproject1.Visible = true;
                btnproject2.Visible = true;
                btnproject3.Visible = true;
                btnproject4.Visible = true;
                btnproject5.Visible = true;
            }
        }
    }
    public void submit_button()
    {
        string t_id = Session["t_id"].ToString();
        string su_id = Session["teachersubject_id"].ToString();
        int check_valid_percentage = 30;
        con.Open();
        MySqlCommand cmd1 = con.CreateCommand();
        cmd1.CommandType = CommandType.Text;
        cmd1.CommandText = "select total_quiz_percentage,total_assignment_percentage from subject_result where srs_id=(Select srs_id from student_registered_courses where su_id='" + su_id + "' limit 1)";
        MySqlDataReader ids = cmd1.ExecuteReader();
        while (ids.Read())
        {
            for (int i = 0; i < 2; i++)
            {
                if (ids[i] != DBNull.Value)
                {
                    check_valid_percentage = check_valid_percentage - ids.GetInt32(i);
                }
                else
                {
                    check_valid_percentage = check_valid_percentage - 0;
                }
            }
        }
        con.Close();
        string total_project = DropDownList1.SelectedValue;
        string total_project_percentage = DropDownList2.SelectedValue;
        int project_percentage = Convert.ToInt32(DropDownList2.SelectedValue);
        if (project_percentage <= check_valid_percentage)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update subject_result set total_project='" + total_project + "',total_project_percentage='" + total_project_percentage + "' where srs_id in(Select srs_id from student_registered_courses where su_id='" + su_id + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            project_button();
        }
        else
        {
            if (check_valid_percentage == 0)
            {
                label10.Text = "Your total internal 30 marks are already used";
            }
            else
            {
                label10.Text = "Total percentage must be equal or less than" + check_valid_percentage.ToString();
            }
        }
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        submit_button();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("teacher_subjectresult.aspx");
    }
    protected void btnedit_Click(object sender, EventArgs e)
    {
        Panel4.Visible = false;
        Panel3.Visible = true;
        Panel5.Visible = false;
    }
    protected void btnproject_Click(object sender, EventArgs e)
    {
        project_button();
    }
    protected void btnproject1_Click(object sender, EventArgs e)
    {
        Response.Redirect("teacher_project1_marks_entrance.aspx");
    }
    protected void btnproject2_Click(object sender, EventArgs e)
    {
        Response.Redirect("teacher_project2_marks_entrance.aspx");
    }
    protected void btnproject3_Click(object sender, EventArgs e)
    {
        Response.Redirect("teacher_project3_marks_entrance.aspx");
    }
    protected void btnproject4_Click(object sender, EventArgs e)
    {
        Response.Redirect("teacher_project4_marks_entrance.aspx");
    }
    protected void btnproject5_Click(object sender, EventArgs e)
    {
        Response.Redirect("teacher_project5_marks_entrance.aspx");
    }
}