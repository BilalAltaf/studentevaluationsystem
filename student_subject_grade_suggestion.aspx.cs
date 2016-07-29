using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;

public partial class student_subject_grade_suggestion : System.Web.UI.Page
{
    MySqlConnection con = new MySqlConnection("server=localhost;uid=root;database=student_academic_management_system;password=0544612702");
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
            Button1.Text = name;
            show_Grade_Suggestion_result();
        }
    }
    void show_Grade_Suggestion_result()
    {
        string s_id = Session["s_id"].ToString();
        string su_id = Session["subject_id"].ToString();
        string calculate_result = "prediction";
        float quiz_marks = 0;
        float assignment_marks = 0;
        float project_marks = 0;
        float midterm_marks = 0;
        float finalterm_marks = 0;
        con.Open();
        MySqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select total_obtained_quiz_percentage,total_obtained_assignment_percentage,total_obtained_project_percentage,total_obtained_midterm_percentage,total_obtained_finalterm_percentage from subject_result where srs_id=(select srs_id from student_registered_courses where s_id='" + s_id + "' && su_id='" + su_id + "')";
        MySqlDataReader ids = cmd.ExecuteReader();
        while (ids.Read())
        {
            for (int i = 0; i < 5; i++)
            {
                if (ids[i] != DBNull.Value)
                {
                    if (i == 4)
                    {
                        finalterm_marks = ids.GetFloat(4);
                        calculate_result = "orginal";
                    }
                    else
                    {
                        if (i == 0)
                        {
                            quiz_marks = ids.GetFloat(0);
                        }
                        else if (i == 1)
                        {
                            assignment_marks = ids.GetFloat(1);
                        }
                        else if (i == 2)
                        {
                            project_marks = ids.GetFloat(2);
                        }
                        else if (i == 3)
                        {
                            midterm_marks = ids.GetFloat(3);
                        }
                    }
                }
                else
                {
                    if (i == 0 || i == 1 || i == 2 || i == 3)
                    {
                        calculate_result = "no prediction";
                    }
                }
            }
        }
        con.Close();
        if (calculate_result == "no prediction")
        {
            Label10.Text = "Internal Or Midterm Result is not uploaded";
        }
        else if (calculate_result == "prediction")
        {
            for (int j = 0; j < 1; j++)
            {
                TableRow tr = new TableRow();
                for (int i = 0; i < 2; i++)
                {
                    TableCell tc = new TableCell();
                    if (i == 0)
                    {
                        tc.Text = "grade";
                    }
                    else if (i == 1)
                    {
                        tc.Text = "Marks needed";
                    }
                    tr.Cells.Add(tc);
                    tc.BorderWidth = 1;
                    tc.BorderColor = System.Drawing.Color.Black;
                }
                Table2.BorderWidth = 1;
                Table2.BorderColor = System.Drawing.Color.Black;
                Table2.BorderWidth = 1;
                Table2.BorderColor = System.Drawing.Color.Black;
                Table2.Rows.Add(tr);
            }
            float total_marks = quiz_marks + assignment_marks + project_marks + midterm_marks;
            for (int j = 0; j < 7; j++)
            {
                TableRow tr = new TableRow();
                for (int i = 0; i < 2; i++)
                {
                    TableCell tc = new TableCell();
                    if (i == 0)
                    {
                        if (j == 0)
                        {
                            tc.Text = "A";
                        }
                        else if (j == 1)
                        {
                            tc.Text = "B+";
                        }
                        else if (j == 2)
                        {
                            tc.Text = "B";
                        }
                        else if (j == 3)
                        {
                            tc.Text = "C+";
                        }
                        else if (j == 4)
                        {
                            tc.Text = "C";
                        }
                        else if (j == 5)
                        {
                            tc.Text = "D";

                        }
                        else if (j == 6)
                        {
                            tc.Text = "F";
                        }
                    }
                    else if (i == 1)
                    {
                        if (j == 0)
                        {
                            float marks_needed = 87 - total_marks;
                            if (marks_needed <= 50)
                            {
                                tc.Text = marks_needed.ToString();
                            }
                            else
                            {
                                tc.Text = "sorry";
                            }
                        }
                        else if (j == 1)
                        {
                            float marks_needed = 80 - total_marks;
                            if (marks_needed <= 50)
                            {
                                tc.Text = marks_needed.ToString() ;
                            }
                            else
                            {
                                tc.Text = "sorry";
                            }
                        }
                        else if (j == 2)
                        {
                            float marks_needed = 72 - total_marks;
                            if (marks_needed <= 50)
                            {
                                tc.Text = marks_needed.ToString() ;
                            }
                            else
                            {
                                tc.Text = "sorry";
                            }
                        }
                        else if (j == 3)
                        {
                            float marks_needed = 66 - total_marks;
                            if (marks_needed <= 50)
                            {
                                tc.Text = marks_needed.ToString() ;
                            }
                            else
                            {
                                tc.Text = "sorry";
                            }
                        }
                        else if (j == 4)
                        {
                            float marks_needed = 60 - total_marks;
                            if (marks_needed <= 50)
                            {
                                tc.Text = marks_needed.ToString() ;
                            }
                            else
                            {
                                tc.Text = "sorry";
                            }
                        }
                        else if (j == 5)
                        {
                            float marks_needed = 50 - total_marks;
                            if (marks_needed <= 50)
                            {
                                tc.Text = marks_needed.ToString() ;
                            }
                            else
                            {
                                tc.Text = "sorry";
                            }
                        }
                        else if (j == 6)
                        {
                            float marks_needed = 50 - total_marks;
                            tc.Text = "less than"+ marks_needed.ToString();
                        }
                    }
                    tr.Cells.Add(tc);
                    tc.BorderWidth = 1;
                    tc.BorderColor = System.Drawing.Color.Black;
                }
                Table2.BorderWidth = 1;
                Table2.BorderColor = System.Drawing.Color.Black;
                Table2.BorderWidth = 1;
                Table2.BorderColor = System.Drawing.Color.Black;
                Table2.Rows.Add(tr);
            }
        }
        else if (calculate_result == "orginal")
        {
            float total_marks = quiz_marks + assignment_marks + project_marks + midterm_marks + finalterm_marks;
            for (int j = 0; j < 2; j++)
            {
                TableRow tr = new TableRow();
                for (int i = 0; i < 2; i++)
                {
                    TableCell tc = new TableCell();
                    if (i == 0)
                    {
                        if (j == 0)
                        {
                            tc.Text = "Total Mark";
                        }
                        else
                        {
                            tc.Text = total_marks.ToString();
                        }
                    }
                    else
                    {
                        if (j == 0)
                        {
                            tc.Text = "Total Grade";
                        }
                        else
                        {
                            if (total_marks <= 100 && total_marks >= 87)
                            {
                                tc.Text = "A";
                            }
                            else if (total_marks < 87 && total_marks >= 80)
                            {
                                tc.Text = "B+";
                            }
                            else if (total_marks < 80 && total_marks >= 72)
                            {
                                tc.Text = "B";
                            }
                            else if (total_marks < 72 && total_marks >= 66)
                            {
                                tc.Text = "c+";
                            }
                            else if (total_marks < 66 && total_marks >= 60)
                            {
                                tc.Text = "c";
                            }
                            else if (total_marks < 60 && total_marks >= 50)
                            {
                                tc.Text = "D";
                            }
                            else if (total_marks < 50)
                            {
                                tc.Text = "F";
                            }
                        }
                    }
                    tr.Cells.Add(tc);
                    tc.BorderWidth = 1;
                    tc.BorderColor = System.Drawing.Color.Black;
                }
                Table2.BorderWidth = 1;
                Table2.BorderColor = System.Drawing.Color.Black;
                Table2.BorderWidth = 1;
                Table2.BorderColor = System.Drawing.Color.Black;
                Table2.Rows.Add(tr);
            }
            Label10.Text = "original Result";
        }

    }
    protected void btnsubjectname_Click(object sender, EventArgs e)
    {
        Response.Redirect("student_subjectresult.aspx");
    }
    protected void btn_suggestion_Click(object sender, EventArgs e)
    {

    }

}