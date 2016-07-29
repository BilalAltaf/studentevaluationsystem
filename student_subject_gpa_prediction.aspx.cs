using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

public partial class student_subject_gpa_prediction : System.Web.UI.Page
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
    }
    public string result = "";
    public void generate()
    {
        Label1.Visible = true;
        Table1.Visible = true;
        string s_id = Session["s_id"].ToString();
        con.Open();
        MySqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select count(su_id) from student_registered_courses where s_id='" + s_id + "'";
        int c = Convert.ToInt32(cmd.ExecuteScalar());
        con.Close();
        float[] quiz_marks = new float[c];
        float[] assignment_marks = new float[c];
        float[] project_marks = new float[c];
        float[] midterm_marks = new float[c];
        float[] finalterm_marks = new float[c];
        string[] status = new string[c];
        string[] subject_name = new string[c];
        float[] subject_credit_hours = new float[c];
        float[] subject_cgpa = new float[c];
        if (c == 0)
        {
            Response.Redirect("registration.aspx");
        }
        else
        {
            int s = 0;
            con.Open();
            MySqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select sd.su_name,sr.total_obtained_quiz_percentage,sr.total_obtained_assignment_percentage,sr.total_obtained_project_percentage,sr.midterm_marks,sr.total_midterm_marks,sr.finalterm_marks,sr.total_finalterm_marks,sd.su_credit_hours from subject_detail sd,subject_result sr,student_registered_courses src where src.su_id=sd.su_id && src.srs_id=sr.srs_id && src.s_id='" + s_id + "'";
            //cmd.CommandText = "select sd.su_name,sr.result_id from student_registered_courses src where src.s_id='" + s_id + "' inner join subject_detail sd on src.su_id=sd.su_id inner join subject_result sr on src.srs_id=sr.srs_id )";
            MySqlDataReader ids = cmd1.ExecuteReader();
            while (ids.Read())
            {
                status[s] = "prediction";
                TableRow tr = new TableRow();
                for (int i = 0; i < 9; i++)
                {
                    TableCell tc = new TableCell();
                    if (ids[i] != DBNull.Value)
                    {
                        if (i == 0)
                        {
                            subject_name[s] = ids.GetString(0);
                        }
                        else if (i == 1)
                        {
                            quiz_marks[s] = ids.GetFloat(1);
                        }
                        else if (i == 2)
                        {
                            assignment_marks[s] = ids.GetFloat(2);
                        }
                        else if (i == 3)
                        {
                            project_marks[s] = ids.GetFloat(3);
                        }
                        else if (i == 4)
                        {
                            midterm_marks[s] = (ids.GetFloat(4) / ids.GetFloat(5)) * 20;
                        }
                        else if (i == 6)
                        {
                            finalterm_marks[s] = (ids.GetFloat(6) / ids.GetFloat(7)) * 50;
                            status[s] = "orginal";
                        }
                        else if (i == 8)
                        {
                            subject_credit_hours[s] = ids.GetFloat(8);
                        }
                    }
                    else
                    {
                        if (i == 1 || i == 2 || i == 3 || i == 4 || i == 5)
                        {
                            status[s] = "no prediction";
                        }
                    }
                }
                s++;
            }
            con.Close();
            float total_credit_hour = 0;
            for (int j = 0; j < c; j++)
            {
                TableRow tr = new TableRow();
                for (int i = 0; i < 5; i++)
                {
                    TableCell tc = new TableCell();
                    if (status[j] == "no prediction")
                    {
                        if (i == 0)
                        {
                            tc.Text = subject_name[j];
                        }
                        else if (i == 1)
                        {
                            tc.Text = "Internals or midterm result is not uploaded";
                        }
                        else if (i == 2)
                        {
                            tc.Text = subject_credit_hours[j].ToString();
                        }
                        else if (i == 3)
                        {
                            subject_cgpa[j] = 0;
                            tc.Text = subject_cgpa[j].ToString();
                        }
                        else if (i == 4)
                        {
                            tc.Text = "No Prediction";
                        }

                    }
                    else if (status[j] == "prediction")
                    {
                        if (i == 0)
                        {
                            tc.Text = subject_name[j];
                        }
                        else if (i == 1)
                        {
                            total_credit_hour = total_credit_hour + subject_credit_hours[j];
                            float total_marks;
                            total_marks = quiz_marks[j] + assignment_marks[j] + project_marks[j] + midterm_marks[j];
                            if(result=="maximum")
                            {
                                total_marks = total_marks + 50;
                            }
                            else if(result=="average")
                            {
                                total_marks = total_marks + 35;
                            }
                            else if (result == "minimum")
                            {
                                total_marks = total_marks + 25;
                            }
                            if (total_marks <= 100 && total_marks >= 87)
                            {
                                subject_cgpa[j] = 4;
                                tc.Text = "A";
                            }
                            else if (total_marks < 87 && total_marks >= 80)
                            {
                                subject_cgpa[j] = (float)3.5;
                                tc.Text = "B+";
                            }
                            else if (total_marks < 80 && total_marks >= 72)
                            {
                                subject_cgpa[j] = 3;
                                tc.Text = "B";
                            }
                            else if (total_marks < 72 && total_marks >= 66)
                            {
                                subject_cgpa[j] = (float)2.5;
                                tc.Text = "C+";
                            }
                            else if (total_marks < 66 && total_marks >= 60)
                            {
                                subject_cgpa[j] = 2;
                                tc.Text = "C";
                            }
                            else if (total_marks < 60 && total_marks >= 50)
                            {
                                subject_cgpa[j] = (float)1.5;
                                tc.Text = "D";
                            }
                            else if (total_marks < 50)
                            {
                                subject_cgpa[j] = 0;
                                tc.Text = "F";
                            }
                        }
                        else if (i == 2)
                        {
                            tc.Text = subject_credit_hours[j].ToString();
                        }
                        else if (i == 3)
                        {
                            tc.Text = subject_cgpa[j].ToString();
                        }
                        else if (i == 4)
                        {
                            tc.Text = "Prediction";
                        }
                    }
                    else if (status[j] == "orginal")
                    {
                        if (i == 0)
                        {
                            tc.Text = subject_name[j];
                        }
                        else if (i == 1)
                        {
                            total_credit_hour = total_credit_hour + subject_credit_hours[j];
                            float total_marks;
                            total_marks = quiz_marks[j] + assignment_marks[j] + project_marks[j] + midterm_marks[j] + finalterm_marks[j];
                            if (total_marks <= 100 && total_marks >= 87)
                            {
                                subject_cgpa[j] = 4;
                                tc.Text = "A";
                            }
                            else if (total_marks < 87 && total_marks >= 80)
                            {
                                subject_cgpa[j] = (float)3.5;
                                tc.Text = "B+";
                            }
                            else if (total_marks < 80 && total_marks >= 72)
                            {
                                subject_cgpa[j] = 3;
                                tc.Text = "B";
                            }
                            else if (total_marks < 72 && total_marks >= 66)
                            {
                                subject_cgpa[j] = (float)2.5;
                                tc.Text = "C+";
                            }
                            else if (total_marks < 66 && total_marks >= 60)
                            {
                                subject_cgpa[j] = 2;
                                tc.Text = "C";
                            }
                            else if (total_marks < 60 && total_marks >= 50)
                            {
                                subject_cgpa[j] = (float)1.5;
                                tc.Text = "D";
                            }
                            else if (total_marks < 50)
                            {
                                subject_cgpa[j] = 0;
                                tc.Text = "F";
                            }
                        }
                        else if (i == 2)
                        {
                            tc.Text = subject_credit_hours[j].ToString();
                        }
                        else if (i == 3)
                        {
                            tc.Text = subject_cgpa[j].ToString();
                        }
                        else if (i == 4)
                        {
                            tc.Text = "Original";
                        }
                    }
                    tr.Cells.Add(tc);
                    tc.BorderWidth = 1;
                    tc.BorderColor = System.Drawing.Color.Black;
                }
                Table1.BorderWidth = 1;
                Table1.BorderColor = System.Drawing.Color.Black;
                Table1.BorderWidth = 1;
                Table1.BorderColor = System.Drawing.Color.Black;
                Table1.Rows.Add(tr);
            }
            float total_cgpa = 0;
            if (total_credit_hour == 0)
            {
                total_cgpa = 0;
            }
            else
            {
                for (int n = 0; n < c; n++)
                {
                    total_cgpa = total_cgpa + (subject_cgpa[n] * subject_credit_hours[n]);
                }
                total_cgpa = total_cgpa / total_credit_hour;
            }
            for (int j = 0; j < 1; j++)
            {
                TableRow ts = new TableRow();
                for (int i = 0; i < 2; i++)
                {
                    TableCell tc = new TableCell();
                    if (i == 0)
                    {
                        tc.Text = "total cgpa";
                    }
                    else if (i == 1)
                    {
                        tc.Text = total_cgpa.ToString();
                    }
                    ts.Cells.Add(tc);
                    tc.BorderWidth = 1;
                    tc.BorderColor = System.Drawing.Color.Black;
                }
                Table1.BorderWidth = 1;
                Table1.BorderColor = System.Drawing.Color.Black;
                Table1.BorderWidth = 1;
                Table1.BorderColor = System.Drawing.Color.Black;
                Table1.Rows.Add(ts);
            }
        }
    }
    protected void Maximum_Gpa_Click(object sender, EventArgs e)
    {
        Label1.Text="Maximum Gpa you can get";
        result = "maximum";
        generate();
    }
    protected void Average_Gpa_Click(object sender, EventArgs e)
    {
        Label1.Text = "Average Gpa you can get";
        result = "average";
        generate();
    }
    protected void Minimum_Gpa_Click(object sender, EventArgs e)
    {
        Label1.Text = "Minimum Gpa you can get";
        result = "minimum";
        generate();
    }
}