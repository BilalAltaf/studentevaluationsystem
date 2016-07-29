<%@ Page Title="" Language="C#" MasterPageFile="~/teacher.master" AutoEventWireup="true" CodeFile="Teacher_change_password.aspx.cs" Inherits="Teacher_change_password" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <h3 class="fg-white">
    Change Password:
    </h3>
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label1" class="fg-white" runat="server" Text="Current Password:"></asp:Label>
    <asp:TextBox ID="Currentpassword" type="password" runat="server" PlaceHolder="Enter Current Password"></asp:TextBox>
    <br />
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label2" class="fg-white" runat="server" Text="New Password:"></asp:Label>
    <asp:TextBox ID="Newpassword" type="password" runat="server" PlaceHolder="Enter New Password"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label3" class="fg-white" runat="server" Text="Confirm New Password:"></asp:Label>
    <asp:TextBox ID="Confirmpassword" type="password" runat="server" PlaceHolder="Confirm New Password"></asp:TextBox>
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="submit" class="button inverse bg-hover-black" runat="server" 
        Text="submit" onclick="submit_Click" />

    <br />

</asp:Content>

