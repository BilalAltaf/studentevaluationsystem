<%@ Page Language="C#" AutoEventWireup="true" CodeFile="teacher_loginpage.aspx.cs" Inherits="teacher_loginpage" %>

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
        .style21
        {
            width: 233px;
            height: 402px;
        }
        .style25
        {
            width: 233px;
            height: 38px;
        }
        .style27
        {
            width: 233px;
            height: 360px;
        }
        .style29
        {
            width: 123px;
            height: 30px;
        }
        .style34
        {
            width: 880px;
            height: 47px;
        }
        .style35
        {
            width: 233px;
            height: 30px;
        }
        .style36
        {
            width: 171px;
            height: 38px;
        }
        .style37
        {
            width: 171px;
            height: 360px;
        }
        .style38
        {
            width: 171px;
            height: 402px;
        }
        .style39
        {
            width: 171px;
            height: 30px;
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
                    &nbsp; Bahria University Islamabad Campus-Teacher Profile</h2>
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
            <td class="style36" style="vertical-align: top">
       
                <h5 class="fg-white">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Login Page</h5>
       
            </td>
               
        <tr>
            <td class="style27">
                </td>
            <td class="style37" style="vertical-align: top">
       
                
       
                <br />
                <br />
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
                <br />
                <h5 class="fg-white"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                    Teacher Id :
                    <asp:TextBox ID="teacher_id"  runat="server" Width="119px" placeholder="Enter Id"></asp:TextBox>&nbsp;<asp:RequiredFieldValidator
                        ID="RequiredFieldValidator1" runat="server" class="fg-red" ErrorMessage="Enter Your Id!" ControlToValidate="teacher_id"></asp:RequiredFieldValidator>
                </h5>
                <br />
                <h5 class="fg-white"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Password :&nbsp;
                    <asp:TextBox ID="teacher_password" type="password" runat="server" Width="125px" placeholder="Enter Password"></asp:TextBox></asp:TextBox>&nbsp;<asp:RequiredFieldValidator
                        ID="RequiredFieldValidator2" runat="server" class="fg-red" ErrorMessage="Enter Your Password!" ControlToValidate="teacher_password"></asp:RequiredFieldValidator>
                </h5>
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <h5>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="btnlogin" 
                    class="place-center button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange" 
                    runat="server" Text="Log In" Width="99px" onclick="btnlogin_Click" />
                <br />
            </td>
               
        <tr>
            <td class="style21">
                &nbsp;</td>
            <td class="style38" style="vertical-align: top">
       
                
       
                &nbsp;</td>
               
         
        <tr style="background-color:#323232" style="height:30% ";>
            <td class="style35" >
            </td>
            <td class="style39">
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
