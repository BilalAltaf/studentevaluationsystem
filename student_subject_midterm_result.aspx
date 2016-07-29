<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage3.master" AutoEventWireup="true" CodeFile="student_subject_midterm_result.aspx.cs" Inherits="student_subject_midterm_result" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<asp:Panel ID="Panel2" runat="server">
    <asp:Button ID="Button1" 
        class="button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange" 
        runat="server" Text="Button" 
        onclick="btnsubjectname_Click" Width="300px" />
    &nbsp;<asp:Button ID="btnmidterm" runat="server" 
        class="button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange" 
        Text="Midterm" Width="300px" />
    </asp:Panel>
    <asp:Panel ID="Panel1" runat="server">
</asp:Panel>
<asp:Label ID="Label7" class="fg-white" runat="server" 
        Text="Uptil obtained Midterm Marks "></asp:Label>
    <asp:Table ID="Table1" class="table striped bordered hovered" runat="server" 
        Width="450px">

    </asp:Table>
    <asp:Panel ID="Panel3" runat="server" Visible="False">
        <asp:Label ID="Label1" class="fg-white" runat="server" Text="No Uploadin Is Done"></asp:Label>
    </asp:Panel>
</asp:Content>

