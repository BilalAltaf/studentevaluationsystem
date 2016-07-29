using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;

public partial class student_subject_assignment_result : System.Web.UI.Page
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
            show_assignment_result();
        }
        if ((string)ViewState["selfprediction"] == "1")
        {
            self_prediction();
        }
    }
    public string result="";
    public int a;
    public int d;
    public void show_assignment_result()
    {
        string s_id = Session["s_id"].ToString();
        string su_id = Session["subject_id"].ToString();
        con.Open();
        MySqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select count(total_assignment) from subject_result where srs_id=(select srs_id from student_registered_courses where s_id='" + s_id + "' && su_id='" + su_id + "')";
        int b = Convert.ToInt32(cmd.ExecuteScalar());
        con.Close();
        if (b == 1)
        {
            Label7.Visible = true;
            con.Open();
            MySqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select total_assignment from subject_result where srs_id=(select srs_id from student_registered_courses where s_id='" + s_id + "' && su_id='" + su_id + "')";
            d = Convert.ToInt32(cmd2.ExecuteScalar());
            con.Close();
            a = d + d;
            for (int i = 0; i < 1; i++)
            {
                TableRow tr = new TableRow();
                for (int j = 0; j < a; j++)
                {
                    TableCell tc = new TableCell();
                    if (j == 0)
                    {
                        tc.Text = "Assignment#1 Total Obtained Marks";
                    }
                    else if (j == 1)
                    {
                        tc.Text = "Assignment#1 Total Marks";
                    }
                    else if (j == 2)
                    {
                        tc.Text = "Assignment#2 Total Obtained Marks";
                    }
                    else if (j == 3)
                    {
                        tc.Text = "Assignment#2 Total Marks";
                    }
                    else if (j == 4)
                    {
                        tc.Text = "Assignment#3 Total Obtained Marks";
                    }
                    else if (j == 5)
                    {
                        tc.Text = "Assignment#3 Total Marks";
                    }
                    else if (j == 6)
                    {
                        tc.Text = "Assignment#4 Total Obtained Marks";
                    }
                    else if (j == 7)
                    {
                        tc.Text = "Assignment#4 Total Marks";
                    }
                    else if (j == 8)
                    {
                        tc.Text = "Assignment#5 Total Obtained Marks";
                    }
                    else if (j == 9)
                    {
                        tc.Text = "Assignment#5 Total Marks";
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
            cmd1.CommandText = "select a1,total_a1_marks,a2,total_a2_marks,a3,total_a3_marks,a4,total_a4_marks,a5,total_a5_marks from subject_result where srs_id=(select srs_id from student_registered_courses where s_id='" + s_id + "' && su_id='" + su_id + "')";
            MySqlDataReader ids = cmd1.ExecuteReader();
            while (ids.Read())
            {
                TableRow tr = new TableRow();
                for (int i = 0; i < a; i++)
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
            con.Close();
            /*-----------------------------------------------------------------------------------------------------------------------------------------

        * FOR Uploading All Assignments Percentages    

      -------------------------------------------------------------------------------------------------------------------------------------------*/
            for (int i = 0; i < 1; i++)
            {
                TableRow tr = new TableRow();
                for (int j = 0; j <= d; j++)
                {
                    TableCell tc = new TableCell();
                    if (j == 0 && j != d)
                    {
                        tc.Text = "Assignment#1 Total percentage";
                    }
                    else if (j == 1 && j != d)
                    {
                        tc.Text = "Assignment#2 Total percentage";
                    }
                    else if (j == 2 && j != d)
                    {
                        tc.Text = "Assignment#3 Total percentage";
                    }
                    else if (j == 3 && j != d)
                    {
                        tc.Text = "Assignment#4 Total percentage";
                    }
                    else if (j == 4 && j != d)
                    {
                        tc.Text = "Assignment#5 Total percentage";
                    }
                    else if (j == d)
                    {
                        tc.Text = "Total Obtained percentage";
                    }
                    tc.Font.Bold = true;
                    tr.Cells.Add(tc);
                    tc.BorderWidth = 1;
                    tc.BorderColor = System.Drawing.Color.Black;
                }
                Table2.BorderWidth = 1;
                Table2.BorderColor = System.Drawing.Color.Black;
                Table2.Rows.Add(tr);
            }
            float value1 = 0;
            float value2 = 0;
            float value = 0;
            float total_value = 0;
            int k = 0;
            con.Open();
            MySqlCommand cmd3 = con.CreateCommand();
            cmd3.CommandType = CommandType.Text;
            cmd3.CommandText = "select a1,total_a1_marks,a2,total_a2_marks,a3,total_a3_marks,a4,total_a4_marks,a5,total_a5_marks,total_assignment_percentage from subject_result where srs_id=(select srs_id from student_registered_courses where s_id='" + s_id + "' && su_id='" + su_id + "')";
            MySqlDataReader id1 = cmd3.ExecuteReader();
            while (id1.Read())
            {
                float percentage = id1.GetFloat(10);
                TableRow tr = new TableRow();
                for (int i = 0; i <= a; i++)
                {
                    TableCell tc = new TableCell();
                    if (id1[i] != DBNull.Value && i != a)
                    {
                        if ((i == 0 || i == 2 || i == 4 || i == 4 || i == 6 || i == 8) && i != a)
                        {

                            tc.Visible = false;
                            value1 = id1.GetFloat(i);
                        }
                        else if ((i == 1 || i == 3 || i == 5 || i == 7 || i == 9) && i != a)
                        {

                            k++;
                            if (value1 != 0)
                            {
                                value2 = id1.GetFloat(i);
                                value = (value1 / value2) * percentage;
                                total_value = total_value + value;
                                tc.Text = value.ToString();
                            }
                            else
                            {
                                tc.Text = "0";
                            }
                        }
                    }
                    else if (i == a)
                    {
                        total_value = total_value / k;
                        tc.Text = total_value.ToString();
                    }
                    else
                    {

                        if (i == 0 || i == 2 || i == 4 || i == 4 || i == 6 || i == 8)
                        {
                            tc.Text = "Not Uploaded";
                        }
                        else
                        {
                            tc.Visible = false;
                        }
                    }
                    tr.Cells.Add(tc);
                    tc.BorderWidth = 1;
                    tc.BorderColor = System.Drawing.Color.Black;
                }
                Table2.BorderWidth = 1;
                Table2.BorderColor = System.Drawing.Color.Black;
                Table2.Rows.Add(tr);
            }
            con.Close();
        }
        else
        {
            Table1.Visible = false;
            Panel3.Visible = true;
            Panel9.Visible = false;
            Label2.Visible = false;
        }
        con.Close();



    }
    protected void btnsubjectname_Click(object sender, EventArgs e)
    {
        Response.Redirect("student_subjectresult.aspx");
    }
    protected void Maximum_Percentage_Click(object sender, EventArgs e)
    {
        Panel8.Visible = false;
        Panel10.Visible = false;
        Panel10.Visible = false;
       Label3.Visible = true;
        Label3.Text = "Maximum assignments percentage that you can obtain";
        result = "maximum";
        generate1();
        
    }
    protected void Average_Percentage_Click(object sender, EventArgs e)
    {
        Panel8.Visible = false;
        Panel10.Visible = false;
        Panel10.Visible = false;
        Label3.Visible = true;
        Label3.Text = "Average assignments percentage that you can obtain";
        result = "average";
        generate1();
    }
    protected void Minimum_Percentage_Click(object sender, EventArgs e)
    {
        Panel8.Visible = false;
        Panel10.Visible = false;
        Panel10.Visible = false;
        Label3.Visible = true;
        Label3.Text = "Minimum assignments percentage that you can obtain";
        result = "minimum";
        generate1();
    }
    public void generate1()
    {
        for (int i = 0; i < 1; i++)
        {
            TableRow tr = new TableRow();
            for (int j = 0; j <= d; j++)
            {
                TableCell tc = new TableCell();
                if (j == 0 && j != d)
                {
                    tc.Text = "Assignment#1 Total percentage";
                }
                else if (j == 1 && j != d)
                {
                    tc.Text = "Assignment#2 Total percentage";
                }
                else if (j == 2 && j != d)
                {
                    tc.Text = "Assignment#3 Total percentage";
                }
                else if (j == 3 && j != d)
                {
                    tc.Text = "Assignment#4 Total percentage";
                }
                else if (j == 4 && j != d)
                {
                    tc.Text = "Assignment#5 Total percentage";
                }
                else if (j == d)
                {
                    tc.Text = "Total Obtained percentage";
                }
                tc.Font.Bold = true;
                tr.Cells.Add(tc);
                tc.BorderWidth = 1;
                tc.BorderColor = System.Drawing.Color.Black;
            }
            Table3.BorderWidth = 1;
            Table3.BorderColor = System.Drawing.Color.Black;
            Table3.Rows.Add(tr);
        }
        string s_id = Session["s_id"].ToString();
        string su_id = Session["subject_id"].ToString();
        float value1 = 0;
        float value2 = 0;
        float value = 0;
        float total_value = 0;
        int k = 0;
        con.Open();
        MySqlCommand cmd1 = con.CreateCommand();
        cmd1.CommandType = CommandType.Text;
        cmd1.CommandText = "select a1,total_a1_marks,a2,total_a2_marks,a3,total_a3_marks,a4,total_a4_marks,a5,total_a5_marks,total_assignment_percentage from subject_result where srs_id=(select srs_id from student_registered_courses where s_id='" + s_id + "' && su_id='" + su_id + "')";
        MySqlDataReader ids = cmd1.ExecuteReader();
        while (ids.Read())
        {
            float percentage = ids.GetFloat(10);
            TableRow tr = new TableRow();
            for (int i = 0; i <= a; i++)
            {
                TableCell tc = new TableCell();
                if (ids[i] != DBNull.Value && i != a)
                {
                    if ((i == 0 || i == 2 || i == 4 || i == 4 || i == 6 || i == 8) && i != a)
                    {

                        tc.Visible = false;
                        value1 = ids.GetFloat(i);
                    }
                    else if ((i == 1 || i == 3 || i == 5 || i == 7 || i == 9) && i != a)
                    {

                        k++;
                        if (value1 != 0)
                        {
                            value2 = ids.GetFloat(i);
                            value = (value1 / value2) * percentage;
                            total_value = total_value + value;
                            tc.Text = value.ToString();
                        }
                        else
                        {
                            tc.Text = "0";
                        }
                    }
                }
                else if (i == a)
                {
                    total_value = total_value / k;
                    tc.Text = total_value.ToString();
                }
                else
                {

                    if (i == 0 || i == 2 || i == 4 || i == 4 || i == 6 || i == 8)
                    {
                        k++;
                        if (result == "maximum")
                        {
                            tc.Text = percentage.ToString();
                            //tc.BackColor=re
                            total_value = total_value + percentage;
                        }
                        else if (result == "average")
                        {
                            float minimum_percentage = percentage / 2;
                            tc.Text = minimum_percentage.ToString();
                            total_value = total_value + minimum_percentage;
                        }
                        else if (result == "minimum")
                        {
                            tc.Text = "0";
                            total_value = total_value + 0;
                        }
                    }
                    else
                    {
                        tc.Visible = false;
                    }
                }
                tc.Font.Bold = true;
                tr.Cells.Add(tc);
                tc.BorderWidth = 1;
                tc.BorderColor = System.Drawing.Color.Black;

            }
            Table3.BorderWidth = 1;
            Table3.BorderColor = System.Drawing.Color.Black;
            Table3.Rows.Add(tr);
        }
    }
    int textbox_count = 0;
    int t = 0;
    decimal total_prediction_value = 0;
    public void self_prediction()
    {
        Panel10.Visible = true;
        for (int i = 0; i < 1; i++)
        {
            TableRow tr = new TableRow();
            for (int j = 0; j < d; j++)
            {
                TableCell tc = new TableCell();
                if (j == 0)
                {
                    tc.Text = "Assignment#1 Total percentage";
                }
                else if (j == 1)
                {
                    tc.Text = "Assignment#2 Total percentage";
                }
                else if (j == 2 && j != d)
                {
                    tc.Text = "Assignment#3 Total percentage";
                }
                else if (j == 3)
                {
                    tc.Text = "Assignment#4 Total percentage";
                }
                else if (j == 4)
                {
                    tc.Text = "Assignment#5 Total percentage";
                }
                tc.Font.Bold = true;
                tr.Cells.Add(tc);
                tc.BorderWidth = 1;
                tc.BorderColor = System.Drawing.Color.Black;
            }
            Table6.BorderWidth = 1;
            Table6.BorderColor = System.Drawing.Color.Black;
            Table6.Rows.Add(tr);
        }
        string s_id = Session["s_id"].ToString();
        string su_id = Session["subject_id"].ToString();
        decimal value1 = 0;
        decimal value2 = 0;
        decimal value = 0;
        con.Open();
        MySqlCommand cmd1 = con.CreateCommand();
        cmd1.CommandType = CommandType.Text;
        cmd1.CommandText = "select a1,total_a1_marks,a2,total_a2_marks,a3,total_a3_marks,a4,total_a4_marks,a5,total_a5_marks,total_assignment_percentage from subject_result where srs_id=(select srs_id from student_registered_courses where s_id='" + s_id + "' && su_id='" + su_id + "')";
        MySqlDataReader ids = cmd1.ExecuteReader();
        while (ids.Read())
        {
            decimal percentage = ids.GetDecimal(10);
            TableRow tr = new TableRow();
            for (int i = 0; i < a; i++)
            {
                TableCell tc = new TableCell();
                if (ids[i] != DBNull.Value && i != a)
                {
                    if ((i == 0 || i == 2 || i == 4 || i == 4 || i == 6 || i == 8) && i != a)
                    {

                        tc.Visible = false;
                        value1 = ids.GetDecimal(i);
                    }
                    else if ((i == 1 || i == 3 || i == 5 || i == 7 || i == 9) && i != a)
                    {

                        t++;
                        if (value1 != 0)
                        {
                            value2 = ids.GetDecimal(i);
                            value = (value1 / value2) * percentage;
                            total_prediction_value = total_prediction_value + value;
                            tc.Text = value.ToString();
                        }
                        else
                        {
                            tc.Text = "0";
                        }
                    }
                }
                else
                {

                    if (i == 0 || i == 2 || i == 4 || i == 6 || i == 8)
                    {
                        t++;
                        TextBox tx = new TextBox();
                        tx.ID = "tx" + textbox_count.ToString();
                        tx.Text = "";
                        RequiredFieldValidator rf = new RequiredFieldValidator();
                        rf.ControlToValidate = "tx" + textbox_count.ToString();
                        if (i == 0)
                        {
                            rf.ErrorMessage = "Enter Assignment#1 textbox values! <br/>";
                        }
                        if (i == 2)
                        {
                            rf.ErrorMessage = "Enter Assignment#2 textbox values! <br/>";
                        } 
                        if (i == 4)
                        {
                            rf.ErrorMessage = "Enter Assignment#3 textbox values! <br/>";
                        } 
                        if (i == 6)
                        {
                            rf.ErrorMessage = "Enter Assignment#4 textbox values !<br/>";
                        }
                        if (i == 8)
                        {
                            rf.ErrorMessage = "Enter Assignment#5 textbox values! <br/>";
                        }
                        rf.CssClass = "fg-red";
                        Panel6.Controls.Add(rf);
                        tc.Controls.Add(tx);
                        textbox_count++;
                    }
                    else
                    {
                        tc.Visible = false;
                    }
                }
                tc.Font.Bold = true;
                tr.Cells.Add(tc);
                tc.BorderWidth = 1;
                tc.BorderColor = System.Drawing.Color.Black;

            }
            Table6.BorderWidth = 1;
            Table6.BorderColor = System.Drawing.Color.Black;
            Table6.Rows.Add(tr);
        }
        con.Close();

    }
    protected void Self_Prediction_Click(object sender, EventArgs e)
    {
        ViewState["selfprediction"] = "1";
        Press.Visible = true;
        Label3.Visible = false;
    }
    protected void btnassignment_Click(object sender, EventArgs e)
    {
        Response.Redirect("student_subject_assignment_result.aspx");
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < textbox_count; i++)
        {
            TextBox tx1 = (TextBox)Table6.FindControl("tx" + i.ToString());
            decimal s = decimal.Parse(tx1.Text);
            total_prediction_value = total_prediction_value + s;
        }
        total_prediction_value = total_prediction_value / t;
        TextBox1.Text = total_prediction_value.ToString();
    }
    protected void Press_Click(object sender, EventArgs e)
    {
        Panel8.Visible = true;

        Label6.Visible = true;
    }
}