using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;

public partial class student_subject_midterm_result : System.Web.UI.Page
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
            show_midterm_result();
        }
    }
    public void show_midterm_result()
    {
        string s_id = Session["s_id"].ToString();
        string su_id = Session["subject_id"].ToString();
        for (int i = 0; i < 1; i++)
        {
            TableRow tr = new TableRow();
            for (int j = 0; j < 2; j++)
            {
                TableCell tc = new TableCell();
                if (j == 0)
                {
                    tc.Text = "Midterm Total Marks";
                }
                else if (j == 1)
                {
                    tc.Text = "Midterm Total Obtained Marks";
                }
                tc.Font.Bold = true;
                tr.Cells.Add(tc);
                tc.BorderWidth = 1;
                tc.BorderColor = System.Drawing.Color.Black;
            }
            Table1.BorderWidth = 1;
            Table1.BorderColor = System.Drawing.Color.Black;
            Table1.Rows.Add(tr);
        }
        con.Open();
        MySqlCommand cmd1 = con.CreateCommand();
        cmd1.CommandType = CommandType.Text;
        cmd1.CommandText = "select midterm_marks,total_midterm_marks from subject_result where srs_id=(select srs_id from student_registered_courses where s_id='" + s_id + "' && su_id='" + su_id + "')";
        MySqlDataReader ids = cmd1.ExecuteReader();
        while (ids.Read())
        {
            TableRow tr = new TableRow();
            for (int i = 0; i < 2; i++)
            {
                TableCell tc = new TableCell();
                if (ids[i] != DBNull.Value)
                {
                    tc.Text = ids.GetString(i);
                }
                if (ids[i] == DBNull.Value)
                {
                    tc.Text = "Not uploaded";
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
    }
    protected void btnsubjectname_Click(object sender, EventArgs e)
    {
        Response.Redirect("student_subjectresult.aspx");
    }
}