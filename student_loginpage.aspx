<%@ Page Language="C#" AutoEventWireup="true" CodeFile="student_loginpage.aspx.cs" Inherits="student_loginpage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<link href="css/metro-bootstrap.css" rel="stylesheet">
    <link href="css/metro-bootstrap-responsive.css" rel="stylesheet">
    <link href="css/iconFont.css" rel="stylesheet">
    <link href="css/docs.css" rel="stylesheet">
    <!-- Load JavaScript Libraries -->
    <script src="js/jquery/jquery.min.js" type="text/javascript"></script>
    <script src="js/jquery/jquery.widget.min.js" type="text/javascript"></script>
    <script src="js/jquery/jquery.mousewheel.js" type="text/javascript"></script>
    <script src="js/prettify/prettify.js" type="text/javascript"></script>
<!--
 Metro UI CSS JavaScript plugins 
-->
<script src="js/load-metro.js" type="text/javascript"></script>
<!--
 Local JavaScript 
-->
<script src="js/docs.js" type="text/javascript"></script>
<script src="js/github.info.js" type="text/javascript"></script>

    
    <style type="text/css">
        .style1
        {}
        .style13
        {
            width: 449px;
            height: 47px;
        }
        .style16
        {
            width: 278px;
            height: 47px;
        }
        .style17
        {
            width: 116px;
            height: 47px;
        }
        .style18
        {
        }
        .style19
        {
            width: 191px;
            height: 30px;
        }
        .style21
        {
            width: 191px;
            height: 402px;
        }
        .style25
        {
            width: 191px;
            height: 38px;
        }
        .style27
        {
            width: 191px;
            height: 360px;
        }
        .style29
        {
            width: 123px;
            height: 30px;
        }
        .style30
        {
            height: 38px;
            width: 210px;
        }
        .style31
        {
            height: 360px;
            width: 210px;
        }
        .style32
        {
            height: 402px;
            width: 210px;
        }
        .style33
        {
            height: 30px;
            width: 210px;
        }
        .style34
        {
            width: 880px;
            height: 47px;
        }
    </style>
    <title></title>
</head>
<body class="metro" style="height:780px; width:40%;" ;>
    <form id="form1" runat="server">
    <div>
        <table class="style1"; style="height:30%; width: 1365px;";>
        <tr  style="background-color:#323232" ;>
            <td class="style17" style="vertical-align: top">
                <asp:Image ID="Image1" src="images/logo.jpg" runat="server" Height="68px" 
                    Width="69px" />
            </td>
            <td class="style34" style="vertical-align: top">
                <h2 class="fg-white">
                    &nbsp; Bahria University Islamabad Campus-Student Profile</h2>
            </td>
            <td class="style13">
                &nbsp;</td>
            <td class="style16">
               
            </td>
        </tr>
    </table>
    <table class="style18" 
            
            
            style="background: url('images/background.jpg') no-repeat left top; height: 854px; width: 1362px;" >
        <tr>
            <td class="style25">
                <br />
            </td>
            <td class="style30" style="vertical-align: top">
       
                <h5 class="fg-white">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Login Page</h5>
       
            </td>
               
        <tr>
            <td class="style27">
                </td>
            <td class="style31">
       
                
       
                <br />
                <br />
                

                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
                <br />
                &nbsp;
                <h5 class="fg-white"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                    Student Id :
                    <asp:TextBox ID="student_id"  runat="server" Width="119px" PlaceHolder="Enter Id"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" class="fg-red" 
                        runat="server" ErrorMessage="Please enter your Id!" 
                        ControlToValidate="student_id"></asp:RequiredFieldValidator>
                </h5>
                <br />
                <h5 class="fg-white"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Password :&nbsp;&nbsp;
                    <asp:TextBox ID="student_password" type="password" runat="server" Width="125px" PlaceHolder="Enter Password!"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator3" class="fg-red" runat="server" ErrorMessage="Please enter your password!" ControlToValidate="student_password"></asp:RequiredFieldValidator>
                </h5>
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="btnlogin" 
                    class="place-center button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange" 
                    runat="server" Text="Log In" Width="99px" onclick="btnlogin_Click" />
                <br />
            </td>
               
        <tr>
            <td class="style21">
                &nbsp;</td>
            <td class="style32" style="vertical-align: top">
       
                
       
                &nbsp;</td>
               
         
        <tr style="background-color:#323232" style="height:30% ";>
            <td class="style19" >
            </td>
            <td class="style33">
                <h6 class="fg-white">
                    All Rights Reserved. Bahria University.</h6>
            </td>
            <td class="style29">
            </td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>

