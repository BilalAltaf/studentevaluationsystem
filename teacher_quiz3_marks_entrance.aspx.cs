using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;

public partial class teacher_quiz3_marks_entrance : System.Web.UI.Page
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
            quiz3_button();
        }
    }
    public int a = 0;
    public void quiz3_button()
    {
        for (int j = 0; j < 1; j++)
        {
            TableRow tr = new TableRow();
            for (int i = 0; i < 3; i++)
            {
                TableCell tc = new TableCell();
                if (i == 0)
                {
                    tc.Text = "Student Id";
                }
                else if (i == 1)
                {
                    tc.Text = "Student Name";
                }
                else if (i == 2)
                {
                    tc.Text = "Enter Quiz#3 Obtained Marks";
                }
                tr.Cells.Add(tc);
                tc.BorderWidth = 1;
                tc.BorderColor = System.Drawing.Color.Black;
            }
            Table1.BorderWidth = 1;
            Table1.BorderColor = System.Drawing.Color.Black;
            Table1.Rows.Add(tr);
        }
        string t_id = Session["t_id"].ToString();
        string su_id = Session["teachersubject_id"].ToString();
        con.Open();
        MySqlCommand cmd1 = con.CreateCommand();
        cmd1.CommandType = CommandType.Text;
        cmd1.CommandText = "select count(q3) from subject_result where srs_id=(select srs_id from student_registered_courses where su_id='" + su_id + "' limit 1)";
        int d = Convert.ToInt32(cmd1.ExecuteScalar());
        con.Close();
        if (d == 0)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select s_id,s_name from student_detail where s_id in(select s_id from student_registered_courses where su_id='" + su_id + "')";
            MySqlDataReader ids = cmd.ExecuteReader();
            while (ids.Read())
            {
                TableRow tr = new TableRow();
                for (int i = 0; i < 3; i++)
                {
                    TableCell tc = new TableCell();
                    if (i == 0)
                    {
                        tc.Text = ids.GetString(0);
                    }
                    else if (i == 1)
                    {
                        tc.Text = ids.GetString(1);
                    }
                    else if (i == 2)
                    {
                        TextBox tx = new TextBox();
                        tx.ID = "tx" + a.ToString();
                        RequiredFieldValidator rf = new RequiredFieldValidator();
                        rf.ControlToValidate = "tx" + a.ToString();
                        rf.ErrorMessage = "First Enter " + ids.GetString(1) + " Quiz marks whose id is " + ids.GetString(0) + "<br/>";
                        rf.CssClass = "fg-red";
                        Panel6.Controls.Add(rf);
                        tc.Controls.Add(tx);
                    }
                    tr.Cells.Add(tc);
                    tc.BorderWidth = 1;
                    tc.BorderColor = System.Drawing.Color.Black;
                }
                Table1.BorderWidth = 1;
                Table1.BorderColor = System.Drawing.Color.Black;
                Table1.Rows.Add(tr);
                a++;
            }
            con.Close();
        }
        else if (d == 1)
        {
            btn_quiz3_marks_save.Text = "Edit";
            con.Open();
            MySqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select sd.s_id,sd.s_name,sr.q3,sr.total_q3_marks from student_detail sd,student_registered_courses src,subject_result sr where src.s_id=sd.s_id && src.srs_id=sr.srs_id && src.su_id ='" + su_id + "'";
            MySqlDataReader ids = cmd2.ExecuteReader();
            while (ids.Read())
            {
                TableRow tr = new TableRow();
                for (int i = 0; i < 3; i++)
                {
                    TableCell tc = new TableCell();
                    if (i == 0)
                    {
                        tc.Text = ids.GetString(0);
                    }
                    else if (i == 1)
                    {
                        tc.Text = ids.GetString(1);
                    }
                    else if (i == 2)
                    {
                        TextBox tx = new TextBox();
                        tx.ID = "tx" + a.ToString();
                        tx.Text = ids.GetString(2);
                        RequiredFieldValidator rf = new RequiredFieldValidator();
                        rf.ControlToValidate = "tx" + a.ToString();
                        rf.ErrorMessage = "First Enter " + ids.GetString(1) + " Quiz marks whose id is " + ids.GetString(0) + "<br/>";
                        rf.CssClass = "fg-red";
                        Panel6.Controls.Add(rf);
                        tc.Controls.Add(tx);
                    }
                    tr.Cells.Add(tc);
                    tc.BorderWidth = 1;
                    tc.BorderColor = System.Drawing.Color.Black;
                }
                Table1.BorderWidth = 1;
                Table1.BorderColor = System.Drawing.Color.Black;
                Table1.Rows.Add(tr);
                a++;
                Total_q3_marks.Text = ids.GetString(3);
            }
            con.Close();
        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("teacher_subjectresult.aspx");
    }
    protected void btnquiz_Click(object sender, EventArgs e)
    {
        Response.Redirect("teacher_quiz_marks_entrance.aspx");
    }
    protected void btn_quiz3_marks_save_Click(object sender, EventArgs e)
    {
        int n = 0;
        string[] marks = new string[a];
        for (int s = 0; s < a; s++)
        {
            string t = n.ToString();
            TextBox tx1 = (TextBox)Table1.FindControl("tx" + s.ToString());
            if (tx1.Text == null)
            {
                marks[s] = "0";
            }
            else
            {
                marks[s] = tx1.Text;
            }
            string t_id = Session["t_id"].ToString();
            string su_id = Session["teachersubject_id"].ToString();
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update subject_result set q3='" + marks[s] + "',total_q3_marks='" + Total_q3_marks.Text + "' where srs_id =(Select srs_id from student_registered_courses where su_id='" + su_id + "' limit " + t + ",1)";
            cmd.ExecuteNonQuery();
            con.Close();
            n = n + 1;
        }
        btn_quiz3_marks_save.Text = "Edit";
    }
    protected void btnquiz3_Click(object sender, EventArgs e)
    {

    }
}