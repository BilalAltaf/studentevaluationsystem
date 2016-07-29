using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;

public partial class teacher_quiz_marks_entrance : System.Web.UI.Page
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
            quiz_button();
        }
    }
    string total_quiz;
    public void quiz_button()
    {

        string t_id = Session["t_id"].ToString();
        string su_id = Session["teachersubject_id"].ToString();
        con.Open();
        MySqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select count(total_quiz) from subject_result where srs_id=(Select srs_id from student_registered_courses where su_id='" + su_id + "' limit 1)";
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
            cmd1.CommandText = "select total_quiz from subject_result where srs_id=(Select srs_id from student_registered_courses where su_id='" + su_id + "' limit 1)";
            MySqlDataReader ids = cmd1.ExecuteReader();
            while (ids.Read())
            {
                total_quiz = ids.GetString(0);
            }
            con.Close();
            if (total_quiz == "1")
            {
                btnquiz1.Visible = true;
            }
            else if (total_quiz == "2")
            {
                btnquiz1.Visible = true;
                btnquiz2.Visible = true;
            }
            else if (total_quiz == "3")
            {
                btnquiz1.Visible = true;
                btnquiz2.Visible = true;
                btnquiz3.Visible = true;

            }
            else if (total_quiz == "4")
            {
                btnquiz1.Visible = true;
                btnquiz2.Visible = true;
                btnquiz3.Visible = true;
                btnquiz4.Visible = true;


            }
            else if (total_quiz == "5")
            {
                btnquiz1.Visible = true;
                btnquiz2.Visible = true;
                btnquiz3.Visible = true;
                btnquiz4.Visible = true;
                btnquiz5.Visible = true;
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
        cmd1.CommandText = "select total_assignment_percentage,total_project_percentage from subject_result where srs_id=(Select srs_id from student_registered_courses where su_id='" + su_id + "' limit 1)";
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

        string total_quiz = DropDownList1.SelectedValue;
        string total_quiz_percentage = DropDownList2.SelectedValue;
        int quiz_percentage = Convert.ToInt32(DropDownList2.SelectedValue);
        if (quiz_percentage <= check_valid_percentage)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update subject_result set total_quiz='" + total_quiz + "',total_quiz_percentage='" + total_quiz_percentage + "' where srs_id in(Select srs_id from student_registered_courses where su_id='" + su_id + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            quiz_button();
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
    protected void btnedit_Click(object sender, EventArgs e)
    {
        Panel4.Visible = false;
        Panel3.Visible = true;
        Panel5.Visible = false;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("teacher_subjectresult.aspx");
    }
    protected void btnquiz_Click(object sender, EventArgs e)
    {
        quiz_button();
    }
    protected void btnquiz1_Click(object sender, EventArgs e)
    {
        Response.Redirect("teacher_quiz1_marks_entrance.aspx");
    }
    protected void btnquiz2_Click(object sender, EventArgs e)
    {
        Response.Redirect("teacher_quiz2_marks_entrance.aspx");
    }
    protected void btnquiz3_Click(object sender, EventArgs e)
    {
        Response.Redirect("teacher_quiz3_marks_entrance.aspx");
    }
    protected void btnquiz4_Click(object sender, EventArgs e)
    {
        Response.Redirect("teacher_quiz4_marks_entrance.aspx");
    }
    protected void btnquiz5_Click(object sender, EventArgs e)
    {
        Response.Redirect("teacher_quiz5_marks_entrance.aspx");
    }
}