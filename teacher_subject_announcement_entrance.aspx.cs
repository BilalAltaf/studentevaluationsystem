using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;

public partial class teacher_subject_announcement_entrance : System.Web.UI.Page
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
            generate();
        }
    }
    protected void write_Click(object sender, EventArgs e)
    {

    }
    protected void btnAnnouncement_Click(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("teacher_subjectresult.aspx");
    }
    int a;
    protected void Button2_Click(object sender, EventArgs e)
    {
        string su_id = Session["teachersubject_id"].ToString();
        con.Open();
        MySqlCommand cmd1 = con.CreateCommand();
        cmd1.CommandType = CommandType.Text;
        cmd1.CommandText = "select total_announcement from subject_announcement where su_id='" + su_id + "'";
        a = Convert.ToInt32(cmd1.ExecuteScalar());
        con.Close();
        con.Open();
        a = a + 1;
        MySqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "update subject_announcement set an_" + a + "='" + TextBox1.Text + "' where su_id='" + su_id + "'";
        cmd.ExecuteNonQuery();
        con.Close();
        TextBox1.Text = "";
        Label1.Visible = true;
    }
    public void generate()
    {
        string su_id = Session["teachersubject_id"].ToString();
        con.Open();
        MySqlCommand cmd1 = con.CreateCommand();
        cmd1.CommandType = CommandType.Text;
        cmd1.CommandText = "select total_announcement from subject_announcement where su_id='" + su_id + "'";
        a = Convert.ToInt32(cmd1.ExecuteScalar());
        con.Close();
        if (a != 0)
        {
            for (int j = a; j > 0; j--)
            {
                con.Open();
                MySqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "select an_" + j + " from subject_announcement where su_id='" + su_id + "'";
                MySqlDataReader id = cmd2.ExecuteReader();
                while (id.Read())
                {
                    Label lb = new Label();
                    lb.Text = "<br />" + "Post#" + j.ToString() + "<br />";
                    lb.Font.Bold = true;
                    lb.CssClass = "fg-black";
                    TextBox tx = new TextBox();
                    tx.Width = 846;
                    tx.ID = "<br />" + "tx" + j.ToString() + "<br />";
                    tx.ReadOnly = true;
                    tx.TextMode = TextBoxMode.MultiLine;
                    tx.Text = id.GetString(0);
                    Panel4.Controls.Add(lb);
                    Panel4.Controls.Add(tx);
                }
                con.Close();
            }
        }
        else
        {
            Label lb = new Label();
            lb.Text = "No Post!";
            lb.Font.Bold = true;
            lb.CssClass = "fg-black";
            Panel4.Controls.Add(lb);
        }
    }
}