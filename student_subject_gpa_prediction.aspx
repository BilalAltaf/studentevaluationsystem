<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage3.master" AutoEventWireup="true" CodeFile="student_subject_gpa_prediction.aspx.cs" Inherits="student_subject_gpa_prediction" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<asp:Label ID="Label4" class="fg-white" runat="server" Text="Gpa Prediction " Font-Bold="True" Font-Size="Larger"></asp:Label>
 <br />
    <br />
    
<asp:Button ID="Maximum_gpa" class="button bg-darkOrange bg-hover-orange fg-white fg-hover-white bd-orange"  runat="server" Text="Maximum Gpa You Can Get" onclick="Maximum_Gpa_Click" />
<asp:Button ID="Average_gpa" class="button bg-darkOrange bg-hover-orange fg-white fg-hover-white bd-orange"  runat="server" Text="Average Gpa You Can Get" onclick="Average_Gpa_Click" />
<asp:Button ID="Minimum_gpa" class="button bg-darkOrange bg-hover-orange fg-white fg-hover-white bd-orange"  runat="server" Text="Minimum Gpa You Can Get" onclick="Minimum_Gpa_Click" />
<br />
<asp:Label ID="Label1" class="fg-white" runat="server" Text="Label" Visible="false"></asp:Label>
<asp:Table ID="Table1" class="table striped bordered hovered" runat="server" 
        Width="720px" Visible="false">
    </asp:Table>
</asp:Content>

