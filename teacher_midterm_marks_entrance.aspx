<%@ Page Title="" Language="C#" MasterPageFile="~/teacher.master" AutoEventWireup="true" CodeFile="teacher_midterm_marks_entrance.aspx.cs" Inherits="teacher_midterm_marks_entrance" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <asp:Panel ID="Panel1" runat="server">
       <br />
      <asp:Button ID="Button1" CausesValidation="false"
           Class="button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange"  
           runat="server" Text="Button" onclick="Button1_Click" Width="300px" />
       <asp:Button ID="btnmidterm" runat="server" CausesValidation="false"
           Class="button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange" 
           onclick="btnmidterm_Click" Text="Midterm" Width="100px" />
    </asp:Panel>
    <asp:Table ID="Table1" class="table striped bordered hovered" runat="server" Width="49px">
    </asp:Table>
    <asp:Panel ID="Panel6" runat="server">
    </asp:Panel>
    <br />
    <asp:Label ID="Label1" Class = "fg-white" runat="server" Text="Total Midterm marks :-"></asp:Label>
    <asp:TextBox ID="Total_midterm_marks" runat="server"></asp:TextBox><asp:RequiredFieldValidator
        ID="RequiredFieldValidator1" runat="server" Type="Integer" ErrorMessage="Enter Total Marks" ControlToValidate="Total_midterm_marks" CssClass="fg-red"></asp:RequiredFieldValidator>
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label2" Class = "fg-white" runat="server" Text="Total Midterm Percentage:-"></asp:Label>
    <asp:TextBox ID="total_midterm_percentage" runat="server" ReadOnly="True" 
        Width="24px">20</asp:TextBox>
&nbsp;<asp:Panel ID="Panel4" runat="server">
        <asp:Button ID="btn_midterm_marks_save" 
            Class="button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange"  
            runat="server" Text="save" 
            onclick="btn_midterm_marks_save_Click" Width="87px" />
    </asp:Panel>
</asp:Content>

