using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;

public partial class student_subject_progress : System.Web.UI.Page
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
            subject_progress();
        }

    }
    protected void btnsubjectname_Click(object sender, EventArgs e)
    {
        Response.Redirect("student_subjectresult.aspx");
    }
    protected void Chart1_Load(object sender, EventArgs e)
    {

    }
    public int a;
    public int d;
    float total_value = 0;
    public void subject_progress()
    {
        string s_id = Session["s_id"].ToString();
        string su_id = Session["subject_id"].ToString();
        con.Open();
        MySqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select count(total_quiz) from subject_result where srs_id=(select srs_id from student_registered_courses where s_id='" + s_id + "' && su_id='" + su_id + "')";
        int b = Convert.ToInt32(cmd.ExecuteScalar());
        con.Close();
        if (b == 1)
        {
            con.Open();
            MySqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select total_quiz from subject_result where srs_id=(select srs_id from student_registered_courses where s_id='" + s_id + "' && su_id='" + su_id + "')";
            d = Convert.ToInt32(cmd2.ExecuteScalar());
            con.Close();
            a = d + d;
            float value1 = 0;
            float value2 = 0;
            float value = 0;
            int k = 0;
            con.Open();
            MySqlCommand cmd3 = con.CreateCommand();
            cmd3.CommandType = CommandType.Text;
            cmd3.CommandText = "select q1,total_q1_marks,q2,total_q2_marks,q3,total_q3_marks,q4,total_q4_marks,q5,total_q5_marks,total_quiz_percentage from subject_result where srs_id=(select srs_id from student_registered_courses where s_id='" + s_id + "' && su_id='" + su_id + "')";
            MySqlDataReader id1 = cmd3.ExecuteReader();
            while (id1.Read())
            {
                float percentage = id1.GetFloat(10);
                for (int i = 0; i <= a; i++)
                {
                    if (id1[i] != DBNull.Value && i != a)
                    {
                        if ((i == 0 || i == 2 || i == 4 || i == 6 || i == 8) && i != a)
                        {
                            value1 = id1.GetFloat(i);
                        }
                        else if ((i == 1 || i == 3 || i == 5 || i == 7 || i == 9) && i != a)
                        {
                            k++;
                            if (value1 != 0)
                            {
                                value2 = id1.GetFloat(i);
                                value = (value1 / value2) * 100;
                                total_value = total_value + value;
                            }
                            else
                            {
                                total_value = total_value + 0;
                            }
                        }
                    }
                    else if (i == a)
                    {
                        total_value = total_value / k;
                    }
                    else
                    {
                        total_value = total_value + 0;
                    }
                }
            }
            con.Close();
        }
        else if(b==0)
        {
            total_value = total_value + 0;
        }
        float quiz_progress = total_value;//quiz progress value
        total_value = 0;
        b = 0;
        con.Open();
        MySqlCommand cmd1 = con.CreateCommand();
        cmd1.CommandType = CommandType.Text;
        cmd1.CommandText = "select count(total_assignment) from subject_result where srs_id=(select srs_id from student_registered_courses where s_id='" + s_id + "' && su_id='" + su_id + "')";
        b = Convert.ToInt32(cmd1.ExecuteScalar());
        con.Close();
        if (b == 1)
        {
            con.Open();
            MySqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select total_assignment from subject_result where srs_id=(select srs_id from student_registered_courses where s_id='" + s_id + "' && su_id='" + su_id + "')";
            d = Convert.ToInt32(cmd2.ExecuteScalar());
            con.Close();
            a = d + d;
            float value1 = 0;
            float value2 = 0;
            float value = 0;
            int k = 0;
            con.Open();
            MySqlCommand cmd3 = con.CreateCommand();
            cmd3.CommandType = CommandType.Text;
            cmd3.CommandText = "select a1,total_a1_marks,a2,total_a2_marks,a3,total_a3_marks,a4,total_a4_marks,a5,total_a5_marks,total_assignment_percentage from subject_result where srs_id=(select srs_id from student_registered_courses where s_id='" + s_id + "' && su_id='" + su_id + "')";
            MySqlDataReader id1 = cmd3.ExecuteReader();
            while (id1.Read())
            {
                float percentage = id1.GetFloat(10);
                for (int i = 0; i <= a; i++)
                {
                    if (id1[i] != DBNull.Value && i != a)
                    {
                        if ((i == 0 || i == 2 || i == 4 || i == 6 || i == 8) && i != a)
                        {
                            value1 = id1.GetFloat(i);
                        }
                        else if ((i == 1 || i == 3 || i == 5 || i == 7 || i == 9) && i != a)
                        {
                            k++;
                            if (value1 != 0)
                            {
                                value2 = id1.GetFloat(i);
                                value = (value1 / value2) * 100;
                                total_value = total_value + value;
                            }
                            else
                            {
                                total_value = total_value + 0;
                            }
                        }
                    }
                    else if (i == a)
                    {
                        total_value = total_value / k;
                    }
                    else
                    {
                        total_value = total_value + 0;
                    }
                }
            }
            con.Close();
        }
        else if(b==0)
        {
            total_value = total_value + 0;
        }
        float assignment_progress = total_value;//assignment progress value
        total_value = 0;
        b = 0;
        con.Open();
        MySqlCommand cmd4 = con.CreateCommand();
        cmd4.CommandType = CommandType.Text;
        cmd4.CommandText = "select count(total_project) from subject_result where srs_id=(select srs_id from student_registered_courses where s_id='" + s_id + "' && su_id='" + su_id + "')";
        b = Convert.ToInt32(cmd4.ExecuteScalar());
        con.Close();
        if (b == 1)
        {
            con.Open();
            MySqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select total_project from subject_result where srs_id=(select srs_id from student_registered_courses where s_id='" + s_id + "' && su_id='" + su_id + "')";
            d = Convert.ToInt32(cmd2.ExecuteScalar());
            con.Close();
            a = d + d;
            float value1 = 0;
            float value2 = 0;
            float value = 0;
            int k = 0;
            con.Open();
            MySqlCommand cmd3 = con.CreateCommand();
            cmd3.CommandType = CommandType.Text;
            cmd3.CommandText = "select p1,total_p1_marks,p2,total_p2_marks,p3,total_p3_marks,p4,total_p4_marks,p5,total_p5_marks,total_project_percentage from subject_result where srs_id=(select srs_id from student_registered_courses where s_id='" + s_id + "' && su_id='" + su_id + "')";
            MySqlDataReader id1 = cmd3.ExecuteReader();
            while (id1.Read())
            {
                float percentage = id1.GetFloat(10);
                for (int i = 0; i <= a; i++)
                {
                    if (id1[i] != DBNull.Value && i != a)
                    {
                        if ((i == 0 || i == 2 || i == 4 ||i == 6 || i == 8) && i != a)
                        {
                            value1 = id1.GetFloat(i);
                        }
                        else if ((i == 1 || i == 3 || i == 5 || i == 7 || i == 9) && i != a)
                        {
                            k++;
                            if (value1 != 0)
                            {
                                value2 = id1.GetFloat(i);
                                value = (value1 / value2) * 100;
                                total_value = total_value + value;
                            }
                            else
                            {
                                total_value = total_value + 0;
                            }
                        }
                    }
                    else if (i == a)
                    {
                        total_value = total_value / k;
                    }
                    else
                    {
                        total_value = total_value + 0;
                    }
                }
            }
            con.Close();
        }
        else if(b==0)
        {
            total_value = total_value + 0;
        }
        float project_progress = total_value;//project progress value
        total_value = 0;
        float value11 = 0;
        float value22 = 0;
        con.Open();
        MySqlCommand cmd6 = con.CreateCommand();
        cmd6.CommandType = CommandType.Text;
        cmd6.CommandText = "select midterm_marks,total_midterm_marks from subject_result where srs_id=(select srs_id from student_registered_courses where s_id='" + s_id + "' && su_id='" + su_id + "')";
        MySqlDataReader ids = cmd6.ExecuteReader();
        while (ids.Read())
        {
            for (int i = 0; i < 2; i++)
            {
                if (ids[i] != DBNull.Value)
                {
                    if (i == 0)
                    {
                        value11 = ids.GetFloat(i);
                    }
                    else if (i == 1)
                    {
                        if (value11 != 0)
                        {
                            value22=ids.GetFloat(i);
                            total_value = (value11 / value22) * 100;
                        }
                        else
                        {
                            total_value = 0;
                        }
                    }
                }
                if (ids[i] == DBNull.Value)
                {
                    total_value = 0;
                }
            }
        }
        con.Close();
        float midterm_progress = total_value;//midterm progress value
        total_value = 0;
        float value111 = 0;
        float value222 = 0;
        con.Open();
        MySqlCommand cmd7 = con.CreateCommand();
        cmd7.CommandType = CommandType.Text;
        cmd7.CommandText = "select finalterm_marks,total_finalterm_marks from subject_result where srs_id=(select srs_id from student_registered_courses where s_id='" + s_id + "' && su_id='" + su_id + "')";
        MySqlDataReader id = cmd7.ExecuteReader();
        while (id.Read())
        {
            for (int i = 0; i < 2; i++)
            {
                if (id[i] != DBNull.Value)
                {
                    if (i == 0)
                    {
                        value111 = id.GetFloat(i);
                    }
                    else if (i == 1)
                    {
                        if (value111 != 0)
                        {
                            value222 = id.GetFloat(i);
                            total_value = (value111 / value222) * 100;
                        }
                        else
                        {
                            total_value = 0;
                        }
                    }
                }
                if (id[i] == DBNull.Value)
                {
                    total_value = 0;
                }
            }
        }
        con.Close();
        float finalterm_progress = Convert.ToInt32(total_value);//finalterm progress value
        Chart1.Series["progress_status"].Points[0].YValues[0] = quiz_progress;
        Chart1.Series["progress_status"].Points[1].YValues[0] = assignment_progress;
        Chart1.Series["progress_status"].Points[2].YValues[0] = project_progress;
        Chart1.Series["progress_status"].Points[3].YValues[0] = midterm_progress;
        Chart1.Series["progress_status"].Points[4].YValues[0] = finalterm_progress;
        Chart1.ChartAreas[0].AxisY.Minimum = 0;
        Chart1.ChartAreas[0].AxisY.Maximum = 100;
        Chart1.ChartAreas[0].AxisY.Interval = 5;
        //Chart1.Series["progress_status"].Points[0].IsValueShownAsLabel = true;
       // Chart1.Series["progress_status"].Points[1].Color = Color.RoyalBlue;
       /* Chart1.Series["progress_status"].Points[1].IsValueShownAsLabel = true;
        Chart1.Series["progress_status"].Points[2].Color = Color.Yellow;
        Chart1.Series["progress_status"].Points[2].IsValueShownAsLabel = true;
        Chart1.Series["progress_status"].Points[3].Color = Color.RosyBrown;
        Chart1.Series["progress_status"].Points[3].IsValueShownAsLabel = true;
        Chart1.Series["progress_status"].Points[4].Color = Color.Green;
        Chart1.Series["progress_status"].Points[4].IsValueShownAsLabel = true; */  
    }
}