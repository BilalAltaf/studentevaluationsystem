using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;

public partial class student_subject_registration : System.Web.UI.Page
{
    int a = 0;
    MySqlConnection con = new MySqlConnection("server=localhost;uid=root;database=student_academic_management_system;password=0544612702");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["s_id"] == null)
        {
            Response.Redirect("student_loginpage.aspx");
        }
        else if ((string)Session["s_registration"] == "done")
        {
            registration_done();
        }
        else
        {

            generate();
        }
    }
    public string[] subjectcheckbox = new string[10];
    public void generate()
    {
        lblsuccess.Visible = false;
        for (int i = 0; i < 1; i++)
        {
            TableRow tr = new TableRow();
            for (int j = 0; j < 4; j++)
            {
                TableCell tc = new TableCell();
                if (j == 0)
                {

                    tc.Text = "Check Box";
                    tc.Font.Bold = true;
                }
                else if (j == 1)
                {

                    tc.Text = "Course Code";
                    tc.Font.Bold = true;
                }
                else if (j == 2)
                {
                    tc.Text = "Course Name";
                    tc.Font.Bold = true;
                }
                else if (j == 3)
                {
                    tc.Text = "Course cerdit";
                    tc.Font.Bold = true;
                }

                tr.Cells.Add(tc);
                tc.BorderWidth = 1;
                tc.BorderColor = System.Drawing.Color.Black;

            }
            table.BorderWidth = 1;
            table.BorderColor = System.Drawing.Color.Black;
            table.BorderWidth = 1;
            table.BorderColor = System.Drawing.Color.Black;
            table.Rows.Add(tr);
        }
        string semester = Session["s_semester"].ToString();
        string section = Session["s_section"].ToString();
        con.Open();
        MySqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select su_code,su_name,su_credit_hours from subject_detail where sss_id=(select sss_id from subject_semester_section_status where ss_semester='" + semester + "'&& ss_section='" + section + "')";
        cmd.ExecuteNonQuery();
        MySqlDataReader ids = cmd.ExecuteReader();
        while (ids.Read())
        {
            TableRow tr = new TableRow();
            for (int j = 0; j < 4; j++)
            {
                TableCell tc = new TableCell();
                if (j == 0)
                {
                    CheckBox checkbox1 = new CheckBox();
                    checkbox1.ID = "checkbox" + a.ToString();
                    if (a == 0)
                    {
                        checkbox1.CheckedChanged += new EventHandler(checkbox0_CheckedChanged);
                    }
                    else if (a == 1)
                    {
                        checkbox1.CheckedChanged += new EventHandler(checkbox1_CheckedChanged);
                    }
                    else if (a == 2)
                    {
                        checkbox1.CheckedChanged += new EventHandler(checkbox2_CheckedChanged);
                    }
                    else if (a == 3)
                    {
                        checkbox1.CheckedChanged += new EventHandler(checkbox3_CheckedChanged);
                    }
                    else if (a == 4)
                    {
                        checkbox1.CheckedChanged += new EventHandler(checkbox4_CheckedChanged);
                    }
                    else if (a == 5)
                    {
                        checkbox1.CheckedChanged += new EventHandler(checkbox5_CheckedChanged);
                    }
                    else if (a == 6)
                    {
                        checkbox1.CheckedChanged += new EventHandler(checkbox6_CheckedChanged);
                    }
                    else if (a == 7)
                    {
                        checkbox1.CheckedChanged += new EventHandler(checkbox7_CheckedChanged);
                    }
                    else if (a == 8)
                    {
                        checkbox1.CheckedChanged += new EventHandler(checkbox8_CheckedChanged);
                    }
                    else if (a == 9)
                    {
                        checkbox1.CheckedChanged += new EventHandler(checkbox9_CheckedChanged);
                    }
                    else if (a == 10)
                    {
                        checkbox1.CheckedChanged += new EventHandler(checkbox10_CheckedChanged);
                    }
                    tc.Controls.Add(checkbox1);
                }
                else if (j == 1)
                {
                    tc.Text = ids.GetString(0);
                }
                else if (j == 2)
                {
                    tc.Text = ids.GetString(1);
                }
                else if (j == 3)
                {
                    tc.Text = ids.GetString(2);
                }
                tr.Cells.Add(tc);
                tc.BorderWidth = 1;
                tc.BorderColor = System.Drawing.Color.Black;
            }
            table.BorderWidth = 1;
            table.BorderColor = System.Drawing.Color.Black;
            table.BorderWidth = 1;
            table.BorderColor = System.Drawing.Color.Black;
            table.Rows.Add(tr);
            a++;
        }
        con.Close();
    }
    string[] su_id;
    protected void btnregister_Click(object sender, EventArgs e)
    {
        string semester = Session["s_semester"].ToString();
        string section = Session["s_section"].ToString();
        su_id = new string[a];
        string s_id = Session["s_id"].ToString();
        con.Open();
        MySqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select su_id from subject_detail where sss_id=(select sss_id from subject_semester_section_status where ss_semester='" + semester + "'&& ss_section='" + section + "')";
        cmd.ExecuteNonQuery();
        MySqlDataReader ids = cmd.ExecuteReader();
        int b = 0;
        while (ids.Read())
        {

            su_id[b] = ids.GetString(0);
            b++;
        }
        con.Close();
        for (int j = 0; j < a; j++)
        {
            if (subjectcheckbox[j] == "1")
            {
                con.Open();
                MySqlCommand cmd10 = con.CreateCommand();
                cmd10.CommandType = CommandType.Text;
                cmd10.CommandText = "insert into student_registered_courses(su_id,s_id)value('" + su_id[j] + "','" + s_id + "') ";
                cmd10.ExecuteNonQuery();
                con.Close();
            }
        }
        Session["s_registration"] = "done";
        string registration = Session["s_registration"].ToString();
        con.Open();
        MySqlCommand cmd11 = con.CreateCommand();
        cmd11.CommandType = CommandType.Text;
        cmd11.CommandText = "UPDATE student_detail SET s_registration = '" + registration + "' where s_id='" + s_id + "'";
        cmd11.ExecuteNonQuery();
        con.Close();
        //insertion in subject_result table 
        con.Open();
        MySqlCommand cmd1 = con.CreateCommand();
        cmd1.CommandType = CommandType.Text;
        cmd1.CommandText = "insert into subject_result(srs_id) select srs_id from student_registered_courses where s_id='" + s_id + "'";
        cmd1.ExecuteNonQuery();
        con.Close();
        Response.Redirect("student_subject_registration.aspx");
    }
    public void registration_done()
    {
        lblsuccess.Visible = true;
        lblsuccess.Font.Bold = true;
        for (int i = 0; i < 1; i++)
        {
            TableRow tr = new TableRow();
            for (int j = 0; j < 3; j++)
            {
                TableCell tc = new TableCell();
                if (j == 0)
                {

                    tc.Text = "Course Code";
                    tc.Font.Bold = true;
                }
                else if (j == 1)
                {
                    tc.Text = "Course Name";
                    tc.Font.Bold = true;
                }
                else if (j == 2)
                {
                    tc.Text = "Course cerdit";
                    tc.Font.Bold = true;
                }

                tr.Cells.Add(tc);
                tc.BorderWidth = 1;
                tc.BorderColor = System.Drawing.Color.Black;

            }
            table.BorderWidth = 1;
            table.BorderColor = System.Drawing.Color.Black;
            table.BorderWidth = 1;
            table.BorderColor = System.Drawing.Color.Black;
            table.Rows.Add(tr);
        }
        string s_id = Session["s_id"].ToString();
        btnregister.Visible = false;
        con.Open();
        MySqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select su_code,su_name,su_credit_hours from subject_detail where su_id in(select su_id from student_registered_courses where s_id='" + s_id + "')";
        cmd.ExecuteNonQuery();
        MySqlDataReader ids = cmd.ExecuteReader();
        while (ids.Read())
        {
            TableRow tr = new TableRow();
            for (int j = 0; j < 3; j++)
            {
                TableCell tc = new TableCell();
                if (j == 0)
                {
                    tc.Text = ids.GetString(0);
                }
                else if (j == 1)
                {
                    tc.Text = ids.GetString(1);
                }
                else if (j == 2)
                {
                    tc.Text = ids.GetString(2);
                }
                tr.Cells.Add(tc);
                tc.BorderWidth = 1;
                tc.BorderColor = System.Drawing.Color.Black;
            }
            table.BorderWidth = 1;
            table.BorderColor = System.Drawing.Color.Black;
            table.BorderWidth = 1;
            table.BorderColor = System.Drawing.Color.Black;
            table.Rows.Add(tr);
        }
        con.Close();

    }
    private void checkbox0_CheckedChanged(object sender, EventArgs e)
    {
        subjectcheckbox[0] = "1";
    }
    private void checkbox1_CheckedChanged(object sender, EventArgs e)
    {
        subjectcheckbox[1] = "1";
    }
    private void checkbox2_CheckedChanged(object sender, EventArgs e)
    {
        subjectcheckbox[2] = "1";
    }
    private void checkbox3_CheckedChanged(object sender, EventArgs e)
    {
        subjectcheckbox[3] = "1";
    }
    private void checkbox4_CheckedChanged(object sender, EventArgs e)
    {
        subjectcheckbox[4] = "1";
    }
    private void checkbox5_CheckedChanged(object sender, EventArgs e)
    {
        subjectcheckbox[5] = "1";
    }
    private void checkbox6_CheckedChanged(object sender, EventArgs e)
    {
        subjectcheckbox[6] = "1";
    }
    private void checkbox7_CheckedChanged(object sender, EventArgs e)
    {
        subjectcheckbox[7] = "1";
    }
    private void checkbox8_CheckedChanged(object sender, EventArgs e)
    {
        subjectcheckbox[8] = "1";
    }
    private void checkbox9_CheckedChanged(object sender, EventArgs e)
    {
        subjectcheckbox[9] = "1";
    }
    private void checkbox10_CheckedChanged(object sender, EventArgs e)
    {
        subjectcheckbox[10] = "1";
    }
}