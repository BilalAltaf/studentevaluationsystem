<%@ Page Title="" Language="C#" MasterPageFile="~/teacher.master" AutoEventWireup="true" CodeFile="teacher_quiz3_marks_entrance.aspx.cs" Inherits="teacher_quiz3_marks_entrance" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<asp:Panel ID="Panel1" runat="server">
        <br />
        <asp:Button ID="Button1" CausesValidation="false"
            Class="button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange" 
            runat="server" Text="Button" onclick="Button1_Click" Width="300px" />
        <asp:Button ID="btnquiz" runat="server" CausesValidation="false"
            Class="button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange" 
            onclick="btnquiz_Click" Text="Quiz" Width="100px" />
        <asp:Button ID="btnquiz3" runat="server" CausesValidation="false"
            Class="button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange" 
            onclick="btnquiz3_Click" Text="Quiz3" Width="100px" />
    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server">
    </asp:Panel>
    <asp:Panel ID="Panel3" runat="server">
    </asp:Panel>
    <asp:Table ID="Table1" class="table striped bordered hovered" runat="server" Width="49px">
    </asp:Table>
    <asp:Panel ID="Panel6" runat="server">
    </asp:Panel>
    <br />
    <asp:Label ID="Label1" Class = "fg-white" runat="server" Text="Total Quiz#3 marks :-"></asp:Label>
    <asp:TextBox ID="Total_q3_marks"  runat="server"></asp:TextBox><asp:RequiredFieldValidator
        ID="RequiredFieldValidator1" runat="server" Type="Integer" ErrorMessage="Enter Total Marks" ControlToValidate="Total_q3_marks" CssClass="fg-red"></asp:RequiredFieldValidator>
    <asp:Panel ID="Panel4" runat="server">
        <asp:Button ID="btn_quiz3_marks_save" 
            Class="button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange" 
            runat="server" Text="save" 
            onclick="btn_quiz3_marks_save_Click" Width="78px" />
    </asp:Panel>
</asp:Content>

