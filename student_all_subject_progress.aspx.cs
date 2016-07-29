using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

public partial class student_subject_progress : System.Web.UI.Page
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
        else
        {
            generate();
        }
    }
    public string[] subject_name;
    public string[] subject_id;
    public float[] subject_progress;
    public float[] quiz_progress;
    public float[] assignment_progress;
    public float[] project_progress;
    public float[] midterm_progress;
    public float[] finalterm_progress;
    public int a;
    public int d;
    float total_value = 0;
    public void generate()
    {
        string s_id = Session["s_id"].ToString();
        con.Open();
        MySqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select count(su_id) from student_registered_courses where s_id='" + s_id + "'";
        cmd.ExecuteNonQuery();
        int RecordCount;
        int n = 0;
        RecordCount = Convert.ToInt32(cmd.ExecuteScalar());
        subject_name = new string[RecordCount];
        subject_id = new string[RecordCount];
        subject_progress = new float[RecordCount];
        quiz_progress = new float[RecordCount];
        assignment_progress = new float[RecordCount];
        project_progress = new float[RecordCount];
        midterm_progress = new float[RecordCount];
        finalterm_progress = new float[RecordCount];
        cmd.CommandText = "select su_id,su_name from subject_detail where su_id in(select su_id from student_registered_courses where s_id='" + s_id + "')";
        cmd.ExecuteNonQuery();
        MySqlDataReader ids = cmd.ExecuteReader();
        while (ids.Read())
        {
            subject_name[n] = ids.GetString(1);
            subject_id[n] = ids.GetString(0);
            n++;

        }
        con.Close();
        for (int j = 0; j < RecordCount; j++)
        {
            string su_id = subject_id[j];
            con.Open();
            MySqlCommand cmd10 = con.CreateCommand();
            cmd10.CommandType = CommandType.Text;
            cmd10.CommandText = "select count(total_quiz) from subject_result where srs_id=(select srs_id from student_registered_courses where s_id='" + s_id + "' && su_id='" + su_id + "')";
            int b = Convert.ToInt32(cmd10.ExecuteScalar());
            con.Close();
            if (b == 1)
            {
                con.Open();
                MySqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "select total_quiz from subject_result where srs_id=(select srs_id from student_registered_courses where s_id='" + s_id + "' && su_id='" + su_id + "')";
                d = Convert.ToInt32(cmd2.ExecuteScalar());
                con.Close();
                int a = d + d;
                total_value = 0;
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
                            if ((i == 0 || i == 2 || i == 4 || i == 4 || i == 6 || i == 8) && i != a)
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
                            if (k == 0)
                            {
                                quiz_progress[j] = 0;
                            }
                            else
                            {
                                total_value = total_value / k;
                                quiz_progress[j] = total_value;
                            }
                        }
                        else
                        {
                            total_value = total_value + 0;
                        }
                    }
                }
                con.Close();
            }
            else
            {
                total_value = total_value + 0;
            }
            //quiz progress value
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
                total_value = 0;
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
                    float percentage1 = id1.GetFloat(10);
                    for (int i = 0; i <= a; i++)
                    {
                        if (id1[i] != DBNull.Value && i != a)
                        {
                            if ((i == 0 || i == 2 || i == 4 || i == 4 || i == 6 || i == 8) && i != a)
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
                            if (k == 0)
                            {
                                assignment_progress[j] = 0;
                            }
                            else
                            {
                                total_value = total_value / k;
                                assignment_progress[j] = total_value;
                            }
                        }
                        else
                        {
                            total_value = total_value + 0;
                        }
                    }
                }
                con.Close();
            }
            else
            {
                total_value = total_value + 0;
                assignment_progress[j] = 0;
            }
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
                total_value = 0;
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
                            if ((i == 0 || i == 2 || i == 4 || i == 4 || i == 6 || i == 8) && i != a)
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
                            if (k == 0)
                            {
                                project_progress[j] = 0;
                            }
                            else
                            {
                                total_value = total_value / k;
                                project_progress[j] = total_value;
                            }
                        }
                        else
                        {
                            total_value = total_value + 0;
                        }
                    }
                }
                con.Close();
            }
            else
            {
                total_value = total_value + 0;
                project_progress[j] = 0;
            }
            //project progress value
            total_value = 0;
            float value11 = 0;
            float value22 = 0;
            con.Open();
            MySqlCommand cmd6 = con.CreateCommand();
            cmd6.CommandType = CommandType.Text;
            cmd6.CommandText = "select midterm_marks,total_midterm_marks from subject_result where srs_id=(select srs_id from student_registered_courses where s_id='" + s_id + "' && su_id='" + su_id + "')";
            MySqlDataReader ids1 = cmd6.ExecuteReader();
            while (ids1.Read())
            {
                for (int i = 0; i < 2; i++)
                {
                    if (ids1[i] != DBNull.Value)
                    {
                        if (i == 0)
                        {
                            value11 = ids1.GetFloat(i);
                        }
                        else if (i == 1)
                        {
                            if (value11 != 0)
                            {
                                value22 = ids1.GetFloat(i);
                                total_value = (value11 / value22) * 100;
                                midterm_progress[j] = total_value;
                            }
                            else
                            {
                                total_value = 0;
                                midterm_progress[j] = total_value;
                            }
                        }
                    }
                    if (ids1[i] == DBNull.Value)
                    {
                        total_value = 0;
                        midterm_progress[j] = total_value;
                    }
                }
            }
            con.Close();
            //midterm progress value
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
                                finalterm_progress[j] = total_value;
                            }
                            else
                            {
                                total_value = 0;
                                finalterm_progress[j] = total_value;
                            }
                        }
                    }
                    if (id[i] == DBNull.Value)
                    {
                        total_value = 0;
                        finalterm_progress[j] = total_value;
                    }
                }
            }
            con.Close();
            //finalterm progress value
            con.Open();
            MySqlCommand cmd8 = con.CreateCommand();
            cmd8.CommandType = CommandType.Text;
            cmd8.CommandText = "select q1,a1,p1,midterm_marks,finalterm_marks,total_quiz_percentage,total_assignment_percentage,total_project_percentage from subject_result where srs_id=(select srs_id from student_registered_courses where s_id='" + s_id + "' && su_id='" + su_id + "')";
            MySqlDataReader id2 = cmd8.ExecuteReader();
            while (id2.Read())
            {
                if ((id2[0] == DBNull.Value) && (id2[1] == DBNull.Value) && (id2[2] == DBNull.Value) && (id2[3] == DBNull.Value) && (id2[4] == DBNull.Value))
                {
                    subject_progress[j] = 0;
                }
                else if ((id2[0] != DBNull.Value) && (id2[1] == DBNull.Value) && (id2[2] == DBNull.Value) && (id2[4] == DBNull.Value))
                {
                    if (id2[3] == DBNull.Value)
                    {
                        subject_progress[j] = quiz_progress[j];
                    }
                    else if (id2[3] != DBNull.Value)
                    {
                        quiz_progress[j] = (quiz_progress[j] / 100) * id2.GetFloat(5);
                        midterm_progress[j] = (midterm_progress[j] / 100) * 20;
                        float percentage1 = id2.GetFloat(5) + 20;
                        subject_progress[j]=quiz_progress[j]+midterm_progress[j];
                        subject_progress[j] = (subject_progress[j] / percentage1) * 100;
                    }

                }
                else if ((id2[0] == DBNull.Value) && (id2[1] != DBNull.Value) && (id2[2] == DBNull.Value) && (id2[4] == DBNull.Value))
                {
                    if (id2[3] == DBNull.Value)
                    {
                        subject_progress[j] = assignment_progress[j] ;
                    }
                    else if (id2[3] != DBNull.Value)
                    {
                        assignment_progress[j] = (assignment_progress[j] / 100) * id2.GetFloat(6);
                        midterm_progress[j] = (midterm_progress[j] / 100) * 20;
                        float percentage1 = id2.GetFloat(6) + 20;
                        subject_progress[j] = assignment_progress[j] + midterm_progress[j];
                        subject_progress[j] = (subject_progress[j] / percentage1) * 100;
                    }
                }
                else if ((id2[0] == DBNull.Value) && (id2[1] == DBNull.Value) && (id2[2] != DBNull.Value) && (id2[4] == DBNull.Value))
                {
                    if (id2[3] == DBNull.Value)
                    {
                        subject_progress[j] = project_progress[j];
                    }
                    else if (id2[3] != DBNull.Value)
                    {
                        project_progress[j] = (project_progress[j] / 100) * id2.GetFloat(7);
                        midterm_progress[j] = (midterm_progress[j] / 100) * 20;
                        float percentage1 = id2.GetFloat(7) + 20;
                        subject_progress[j] = project_progress[j] + midterm_progress[j];
                        subject_progress[j] = (subject_progress[j] / percentage1) * 100;
                    }
                }
                else if ((id2[0] != DBNull.Value) && (id2[1] != DBNull.Value) && (id2[2] == DBNull.Value) && (id2[4] == DBNull.Value))
                {
                    if (id2[3] == DBNull.Value)
                    {
                        quiz_progress[j] = (quiz_progress[j] / 100) * id2.GetFloat(5);
                        assignment_progress[j] = (assignment_progress[j] / 100) * id2.GetFloat(6);
                        float percentage1 = id2.GetFloat(5) + id2.GetFloat(6);
                        subject_progress[j] = quiz_progress[j] + assignment_progress[j];
                        subject_progress[j] = (subject_progress[j] / percentage1) * 100;
                    }
                    else if (id2[3] != DBNull.Value)
                    {
                        quiz_progress[j] = (quiz_progress[j] / 100) * id2.GetFloat(5);
                        assignment_progress[j] = (assignment_progress[j] / 100) * id2.GetFloat(6);
                        midterm_progress[j]=(midterm_progress[j]/100)*20;
                        float percentage1 = id2.GetFloat(5) + id2.GetFloat(6)+20;
                        subject_progress[j] = quiz_progress[j] + assignment_progress[j]+midterm_progress[j];
                        subject_progress[j] = (subject_progress[j] / percentage1) * 100;
                    }
                }
                else if ((id2[0] != DBNull.Value) && (id2[1] == DBNull.Value) && (id2[2] != DBNull.Value) && (id2[4] == DBNull.Value))
                {
                    if (id2[3] == DBNull.Value)
                    {
                        quiz_progress[j] = (quiz_progress[j] / 100) * id2.GetFloat(5);
                        project_progress[j] = (project_progress[j] / 100) * id2.GetFloat(7);
                        float percentage1 = id2.GetFloat(5) + id2.GetFloat(7);
                        subject_progress[j] = quiz_progress[j] + project_progress[j];
                        subject_progress[j] = (subject_progress[j] / percentage1) * 100;
                    }
                    else if (id2[3] != DBNull.Value)
                    {
                        quiz_progress[j] = (quiz_progress[j] / 100) * id2.GetFloat(5);
                        project_progress[j] = (project_progress[j] / 100) * id2.GetFloat(7);
                        midterm_progress[j] = (midterm_progress[j] / 100) * 20;
                        float percentage1 = id2.GetFloat(5) + id2.GetFloat(7) + 20;
                        subject_progress[j] = quiz_progress[j] + project_progress[j] + midterm_progress[j];
                        subject_progress[j] = (subject_progress[j] / percentage1) * 100;
                    }
                }
                else if ((id2[0] == DBNull.Value) && (id2[1] != DBNull.Value) && (id2[2] != DBNull.Value) && (id2[4] == DBNull.Value))
                {
                    if (id2[3] == DBNull.Value)
                    {
                        assignment_progress[j] = (assignment_progress[j] / 100) * id2.GetFloat(6);
                        project_progress[j] = (project_progress[j] / 100) * id2.GetFloat(7);
                        float percentage1 = id2.GetFloat(6) + id2.GetFloat(7);
                        subject_progress[j] = assignment_progress[j] + project_progress[j];
                        subject_progress[j] = (subject_progress[j] / percentage1) * 100;
                    }
                    else if (id2[3] != DBNull.Value)
                    {
                        assignment_progress[j] = (assignment_progress[j] / 100) * id2.GetFloat(6);
                        project_progress[j] = (project_progress[j] / 100) * id2.GetFloat(7);
                        midterm_progress[j] = (midterm_progress[j] / 100) * 20;
                        float percentage1 = id2.GetFloat(7) + id2.GetFloat(6) + 20;
                        subject_progress[j] = assignment_progress[j] + project_progress[j] + midterm_progress[j];
                        subject_progress[j] = (subject_progress[j] / percentage1) * 100;
                    }
                }
                else if ((id2[0] != DBNull.Value) && (id2[1] != DBNull.Value) && (id2[2] != DBNull.Value) && (id2[4] == DBNull.Value))
                {
                    if (id2[3] == DBNull.Value)
                    {
                        quiz_progress[j] = (quiz_progress[j] / 100) * id2.GetFloat(5);
                        assignment_progress[j] = (assignment_progress[j] / 100) * id2.GetFloat(6);
                        project_progress[j] = (project_progress[j] / 100) * id2.GetFloat(7);
                        float percentage1 = id2.GetFloat(5) +id2.GetFloat(6)+ id2.GetFloat(7);
                        subject_progress[j] = assignment_progress[j] + project_progress[j] + quiz_progress[j];
                        subject_progress[j] = (subject_progress[j] / percentage1) * 100;
                    }
                    else if (id2[3] != DBNull.Value)
                    {
                        quiz_progress[j] = (quiz_progress[j] / 100) * id2.GetFloat(5);
                        assignment_progress[j] = (assignment_progress[j] / 100) * id2.GetFloat(6);
                        project_progress[j] = (project_progress[j] / 100) * id2.GetFloat(7);
                        midterm_progress[j] = (midterm_progress[j] / 100) * 20;
                        float percentage1 = id2.GetFloat(5) + id2.GetFloat(6) + id2.GetFloat(7) + 20;
                        subject_progress[j] = assignment_progress[j] + project_progress[j] + quiz_progress[j] + midterm_progress[j];
                        subject_progress[j] = (subject_progress[j] / percentage1) * 100;
                    }
                }
                else if ((id2[0] != DBNull.Value) && (id2[1] != DBNull.Value) && (id2[2] != DBNull.Value) && (id2[3] != DBNull.Value) && (id2[4] != DBNull.Value))
                {
                    quiz_progress[j] = (quiz_progress[j] / 100) * id2.GetFloat(5);
                    assignment_progress[j] = (assignment_progress[j] / 100) * id2.GetFloat(6);
                    project_progress[j] = (project_progress[j] / 100) * id2.GetFloat(7);
                    midterm_progress[j] = (midterm_progress[j] / 100) * 20;
                    finalterm_progress[j] = (finalterm_progress[j] / 100) * 50;
                    float percentage1 = id2.GetFloat(5) + id2.GetFloat(6) + id2.GetFloat(7) + 20+50;
                    subject_progress[j] = assignment_progress[j] + project_progress[j] + quiz_progress[j] + midterm_progress[j] + finalterm_progress[j];
                    subject_progress[j] = (subject_progress[j] / percentage1) * 100;
                }
            }
            con.Close();
            Chart1.Series["progress_status"].Points[j].AxisLabel = subject_name[j].ToString();
            Chart1.Series["progress_status"].Points[j].YValues[0] = subject_progress[j];
        }
        Chart1.ChartAreas[0].AxisY.Minimum = 0;
        Chart1.ChartAreas[0].AxisY.Maximum = 100;
        Chart1.ChartAreas[0].AxisY.Interval = 5;
    }
}
           /*
            total_value = 0;
            float value11 = 0;
            float value22 = 0;
            con.Open();
            MySqlCommand cmd6 = con.CreateCommand();
            cmd6.CommandType = CommandType.Text;
            cmd6.CommandText = "select midterm_marks,total_midterm_marks from subject_result where srs_id=(select srs_id from student_registered_courses where s_id='" + s_id + "' && su_id='" + su_id + "')";
            MySqlDataReader ids1 = cmd6.ExecuteReader();
            while (ids1.Read())
            {
                for (int i = 0; i < 2; i++)
                {
                    if (ids1[i] != DBNull.Value)
                    {
                        if (i == 0)
                        {
                            value11 = ids1.GetFloat(i);
                        }
                        else if (i == 1)
                        {
                            if (value11 != 0)
                            {
                                value22 = ids1.GetFloat(i);
                                total_value = (value11 / value22) * 20;
                            }
                            else
                            {
                                total_value = 0;
                            }
                        }
                    }
                    if (ids1[i] == DBNull.Value)
                    {
                        total_value = 0;
                    }
                }
            }
            con.Close();
            midterm_progress[j] = total_value;//midterm progress value
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
                                total_value = (value111 / value222) * 50;
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
            finalterm_progress[j] =total_value;//finalterm progress value
        }
        TextBox1.Text = quiz_progress[1].ToString();
        TextBox2.Text = assignment_progress.ToString();
        TextBox3.Text = project_progress.ToString();
        for(int j=0;j<RecordCount;j++)
        {
            string su_id = subject_id[j];
            con.Open();
            MySqlCommand cmd8 = con.CreateCommand();
            cmd8.CommandType = CommandType.Text;
            cmd8.CommandText = "select q1,a1,p1,midterm_marks,finalterm_marks,total_quiz_percentage,total_assignment_percentage,total_project_percentage from subject_result where srs_id=(select srs_id from student_registered_courses where s_id='" + s_id + "' && su_id='" + su_id + "')";
            MySqlDataReader id2 = cmd8.ExecuteReader();
            while (id2.Read())
            {
                if ((id2[0] == DBNull.Value) && (id2[1] == DBNull.Value) && (id2[2] == DBNull.Value) && (id2[3] == DBNull.Value) && (id2[4] == DBNull.Value))
                {
                    subject_progress[j] = 0;
                }
                else if ((id2[0] != DBNull.Value) && (id2[1] ==DBNull.Value)&& (id2[2]==DBNull.Value)&& (id2[4]==DBNull.Value))
                {
                    if (id2[3] == DBNull.Value)
                    {
                        subject_progress[j] = (quiz_progress[j])*100;
                        // subject_progress[j] = (subject_progress[j]) * 100;
                    }
                    else if (id2[3] != DBNull.Value)
                    {
                        float percentage1 = id2.GetFloat(5) + 20;
                        subject_progress[j] = (quiz_progress[j] / percentage1) * 100;
                    } 
                    
                }
                else if ((id2[0] == DBNull.Value) && (id2[1] != DBNull.Value) && (id2[2] == DBNull.Value) && (id2[4] == DBNull.Value))
                {
                    if (id2[3] == DBNull.Value)
                    {
                        subject_progress[j] = (assignment_progress[j] / id2.GetFloat(6)) * 100;
                    }
                    else if (id2[3] != DBNull.Value)
                    {
                        float percentage1 = id2.GetFloat(6) + 20;
                        subject_progress[j] = (quiz_progress[j] / percentage1) * 100;
                    }    
                }
                else if ((id2[0] == DBNull.Value) && (id2[1] == DBNull.Value) && (id2[2] != DBNull.Value) && (id2[4] == DBNull.Value))
                {
                    if (id2[3] == DBNull.Value)
                    {
                        subject_progress[j] = (project_progress[j] / id2.GetFloat(7)) * 100;
                    }
                    else if (id2[3] != DBNull.Value)
                    {
                        float percentage1 = id2.GetFloat(7) + 20;
                        subject_progress[j] = (quiz_progress[j] / percentage1) * 100;
                    } 
                    
                }
                else if ((id2[0] != DBNull.Value) && (id2[1] != DBNull.Value) && (id2[2] == DBNull.Value) && (id2[4] == DBNull.Value))
                {
                    if (id2[3] == DBNull.Value)
                    {
                        float percentage1 = id2.GetFloat(5) + id2.GetFloat(6);
                        subject_progress[j] = (quiz_progress[j] + assignment_progress[j]) / percentage1;
                        subject_progress[j] = subject_progress[j] * 100;
                    }
                    else if (id2[3] != DBNull.Value)
                    {
                        float percentage1 = id2.GetFloat(5) + id2.GetFloat(6)+20;
                        subject_progress[j] = (quiz_progress[j] + assignment_progress[j] + midterm_progress[j]) / percentage1;
                        subject_progress[j] = subject_progress[j] * 100;
                    }
                }
                else if ((id2[0] != DBNull.Value) && (id2[1] == DBNull.Value) && (id2[2] != DBNull.Value) && (id2[4] == DBNull.Value))
                {
                    if (id2[3] == DBNull.Value)
                    {
                        float percentage1 = id2.GetFloat(5) + id2.GetFloat(7);
                        subject_progress[j] = (quiz_progress[j] + project_progress[j]) / percentage1;
                        subject_progress[j] = subject_progress[j] * 100;
                    }
                    else if (id2[3] != DBNull.Value)
                    {
                        float percentage1 = id2.GetFloat(5) + id2.GetFloat(7)+20;
                        subject_progress[j] = (quiz_progress[j] + project_progress[j] + midterm_progress[j]) / percentage1;
                        subject_progress[j] = subject_progress[j] * 100;
                    } 
                }
                else if ((id2[0] == DBNull.Value) && (id2[1] != DBNull.Value) && (id2[2] != DBNull.Value) && (id2[4] == DBNull.Value))
                {
                    if (id2[3] == DBNull.Value)
                    {
                        float percentage1 = id2.GetFloat(6) + id2.GetFloat(7);
                        subject_progress[j] = (assignment_progress[j] + project_progress[j]) / percentage1;
                        subject_progress[j] = subject_progress[j] * 100;
                    }
                    else if (id2[3] != DBNull.Value)
                    {
                        float percentage1 = id2.GetFloat(6) + id2.GetFloat(7)+20;
                        subject_progress[j] = (assignment_progress[j] + project_progress[j] + midterm_progress[j]) / percentage1;
                        subject_progress[j] = subject_progress[j] * 100;
                    } 
                }
                else if ((id2[0] != DBNull.Value) && (id2[1] != DBNull.Value) && (id2[2] != DBNull.Value) && (id2[4] == DBNull.Value))
                {
                    if (id2[3] == DBNull.Value)
                    {
                        float percentage1 = id2.GetFloat(5) + id2.GetFloat(6) + id2.GetFloat(7);
                        subject_progress[j] = (assignment_progress[j] + project_progress[j]) / percentage1;
                        subject_progress[j] = subject_progress[j] * 100;
                    }
                    else if (id2[3] != DBNull.Value)
                    {
                        float percentage1 = id2.GetFloat(5) + id2.GetFloat(6) + id2.GetFloat(7)+20;
                        subject_progress[j] = (assignment_progress[j] + project_progress[j] + midterm_progress[j]) / percentage1;
                        subject_progress[j] = subject_progress[j] * 100;
                    }
                }
                else if ((id2[0] != DBNull.Value) && (id2[1] != DBNull.Value) && (id2[2] != DBNull.Value) && (id2[3] != DBNull.Value) && (id2[4] == DBNull.Value))
                {
                    float percentage1 = id2.GetFloat(5) + id2.GetFloat(6) + id2.GetFloat(7)+20;
                    subject_progress[j] = (quiz_progress[j] + assignment_progress[j] + project_progress[j] + midterm_progress[j]) / percentage1;
                    subject_progress[j] = subject_progress[j] * 100;
                }
                else if ((id2[0] != DBNull.Value) && (id2[1] != DBNull.Value) && (id2[2] != DBNull.Value) && (id2[3] != DBNull.Value) && (id2[4] != DBNull.Value))
                {
                    float percentage1 = id2.GetFloat(5) + id2.GetFloat(6) + id2.GetFloat(7) + 20+50;
                    subject_progress[j] = (quiz_progress[j] + assignment_progress[j] + project_progress[j] + midterm_progress[j] + finalterm_progress[j]) / percentage1;
                    subject_progress[j] = subject_progress[j] * 100;
                }
            }
            
            
            con.Close();
        }
        for (int j = 0; j <RecordCount; j++)
        {
           // Chart1.Series["progress_status"].Points[j].AxisLabel.
            Chart1.Series["progress_status"].Points[j].AxisLabel = subject_name[j].ToString();
            Chart1.Series["progress_status"].Points[j].YValues[0] = quiz_progress[j];
        }
        Chart1.ChartAreas[0].AxisY.Minimum = 0;
        Chart1.ChartAreas[0].AxisY.Maximum = 100;
        Chart1.ChartAreas[0].AxisY.Interval = 5;
    }*/
