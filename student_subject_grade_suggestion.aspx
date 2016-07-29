<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage3.master" AutoEventWireup="true" CodeFile="student_subject_grade_suggestion.aspx.cs" Inherits="student_subject_grade_suggestion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <asp:Panel ID="Panel2" runat="server">
    <asp:Button ID="Button1" 
         class="place-center button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange"  
         runat="server" Text="Button" 
        onclick="btnsubjectname_Click" Width="300px" />
     &nbsp;<asp:Button ID="btn_suggestion" runat="server" 
         class="place-center button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange" 
         onclick="btn_suggestion_Click" Text="Subject Grade Suggestion" Width="300px" />
    </asp:Panel>
    <asp:Panel ID="Panel1" runat="server">
                  
</asp:Panel>
    <asp:Panel ID="Panel3" runat="server">
    <asp:Label ID="Label10" class="fg-white" runat="server" Text="you can get following grades"></asp:Label>
        <asp:Table ID="Table2" class="table striped bordered hovered" runat="server" 
            Width="497px">
        </asp:Table>
    </asp:Panel>
</asp:Content>

