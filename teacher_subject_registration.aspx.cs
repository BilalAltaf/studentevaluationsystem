using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;

public partial class teacher_subject_registration : System.Web.UI.Page
{
    MySqlConnection con = new MySqlConnection("server=localhost;uid=root;database=student_academic_management_system;password=0544612702");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["t_id"] == null)
        {
            Response.Redirect("teacher_loginpage.aspx");
        }
        else if ((string)Session["t_registration"] == "done")
        {
            registrationdone();
        }
    }
    public void search_button()
    {
        label11.Visible = false;
        Label2.Visible = false;
        con.Open();
        MySqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select count(su_code),su_code,su_credit_hours from subject_detail where su_name='" + textbox1.Text + "' && sss_id='" + codetextbox.Text + "'";
        MySqlDataReader ids = cmd.ExecuteReader();
        while (ids.Read())
        {
            if(ids.GetString(0)=="1")
            {
                Label10.Visible = false;
                Table1.Visible = true;
                btnregisterit.Visible = true;
                TableRow tr = new TableRow();
                for (int j = 0; j < 3; j++)
                {
                    TableCell tc = new TableCell();
                    if (j == 0)
                    {
                        tc.Text = ids.GetString(1);
                    }
                    else if (j == 1)
                    {
                        tc.Text = textbox1.Text;
                    }
                    else if (j == 2)
                    {
                        tc.Text = ids.GetString(2);
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
            else if (ids.GetString(0) == "0")
        {
            Table1.Visible = false;
            btnregisterit.Visible = false;
            Label10.Visible=true;
        }
    }
    }
    protected void btnsearch_Click(object sender, EventArgs e)
    {
        search_button();
    }
    public void registrationdone()
    {
        Panel1.Visible = false;
        label11.Visible = false;
        Label2.Text = "Registered courses";
        Label2.Visible = true;
        Table1.Visible = true;
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
            Table1.BorderWidth = 1;
            Table1.BorderColor = System.Drawing.Color.Black;
            Table1.BorderWidth = 1;
            Table1.BorderColor = System.Drawing.Color.Black;
            Table1.Rows.Add(tr);
        }
        btnregistrationdone.Visible = false;
        string t_id = Session["t_id"].ToString();
        con.Open();
        MySqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select su_code,su_name,su_credit_hours from subject_detail where su_id in(select su_id from teacher_registered_courses where t_id='" + t_id + "')";
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
            Table1.BorderWidth = 1;
            Table1.BorderColor = System.Drawing.Color.Black;
            Table1.BorderWidth = 1;
            Table1.BorderColor = System.Drawing.Color.Black;
            Table1.Rows.Add(tr);
        }
        con.Close();
    }
    protected void btnregistrationdone_Click(object sender, EventArgs e)
    {
        Session["t_registration"] = "done";
        string t_id = Session["t_id"].ToString();
        con.Open();
        MySqlCommand cmd11 = con.CreateCommand();
        cmd11.CommandType = CommandType.Text;
        cmd11.CommandText = "UPDATE teacher_detail SET t_registration = 'done' where t_id='" + t_id + "'";
        cmd11.ExecuteNonQuery();
        con.Close();
        registrationdone();
    }
    public void registerit()
    {
        int f = 0;
        Label2.Text = textbox1.Text + "is registered successfully";
        Label2.Font.Bold = true;
        Table1.Visible = false;
        btnregistrationdone.Visible = true;
        btnregisterit.Visible = false;
        string t_id = Session["t_id"].ToString();
        con.Open();
        MySqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select count(su_id) from teacher_registered_courses where su_id=(select su_id from subject_detail where su_name='" + textbox1.Text + "' && sss_id='" + codetextbox.Text + "')";
        f = Convert.ToInt32(cmd.ExecuteScalar());
        con.Close();
        if (f == 0)
        {
            con.Open();
            MySqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "insert into teacher_registered_courses(su_id,t_id)(select su_id,'" + t_id + "' from subject_detail where su_name='" + textbox1.Text + "' && sss_id='" + codetextbox.Text + "')";
            cmd1.ExecuteNonQuery();
            con.Close();
            con.Open();
            MySqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "insert into subject_announcement(su_id)(select su_id from subject_detail where su_name='" + textbox1.Text + "' && sss_id='" + codetextbox.Text + "')";
            cmd2.ExecuteNonQuery();
            con.Close();

        }
        else
        {
            label11.Text = "Already Registered";
            label11.Visible = true;
        }
    }
    protected void btnregisterit_Click(object sender, EventArgs e)
    {
        registerit();
    }
}