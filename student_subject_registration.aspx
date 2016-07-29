<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage3.master" AutoEventWireup="true" CodeFile="student_subject_registration.aspx.cs" Inherits="student_subject_registration" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="Label2" class="fg-white" runat="server" Text="Registration " Font-Bold="True" Font-Size="Larger"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label1" class="fg-white" runat="server" Text="This Semester Regular Offered Courses "></asp:Label>
    <asp:Table ID="table" class="table striped bordered hovered" runat="server" Width="66%" Height="28px">

    </asp:Table>
    <asp:Panel ID="Panel1" runat="server">
    <asp:Button ID="btnregister" 
            class="place-left button bg-darkViolet bg-hover-violet fg-white fg-hover-white bd-orange" 
            runat="server" Text="register" 
            onclick="btnregister_Click" Width="133px" />
        
</asp:Panel>
<asp:Label ID="lblsuccess" class="fg-white" runat="server" 
            Text="Following Courses Are Registered Successfully!"></asp:Label>
</asp:Content>

