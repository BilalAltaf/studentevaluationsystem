<%@ Page Title="" Language="C#" MasterPageFile="~/teacher.master" AutoEventWireup="true" CodeFile="teacher_subjectresult.aspx.cs" Inherits="teacher_subjectresult" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<asp:Panel ID="Panel1" runat="server">
        <br />
        <asp:Button ID="Button1" 
            Class = "button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange" 
            runat="server" Text="Button" Width="300px" />
    </asp:Panel>
<asp:Panel ID="Panel2" runat="server">
    <asp:Button ID="btnquiz" 
        Class = "button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange" 
        runat="server" Text="Quiz" onclick="btnquiz_Click" Width="97px" />
    <asp:Button ID="btnassignment" 
        Class = "button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange" 
        runat="server" Text="Assignment" 
        onclick="btnassignment_Click" Width="116px" />
    <asp:Button ID="btnproject" 
        Class = "button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange" 
        runat="server" Text="Project" 
        onclick="btnproject_Click" Width="94px" />
    <asp:Button ID="btnmidterm" 
        Class = "button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange" 
        runat="server" Text="Midterm" 
        onclick="btnmidterm_Click" Width="105px" />
    <asp:Button ID="btnfinal" 
        Class = "button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange" 
        runat="server" Text="Final" 
        onclick="btnfinal_Click" Width="105px" />
        <asp:Button ID="Button2" 
        Class = "button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange" 
        runat="server" Text="Subject Announcement" 
        onclick="btnannouncement_Click" Width="192px" />
</asp:Panel>
</asp:Content>

