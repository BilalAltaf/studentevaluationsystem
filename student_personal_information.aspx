<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage3.master" AutoEventWireup="true" CodeFile="student_personal_information.aspx.cs" Inherits="student_personal_information" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style25
        {
            width: 65%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<asp:Label ID="Label4" class="fg-white" runat="server" Text="Personal Information " Font-Bold="True" Font-Size="Larger"></asp:Label>
 <br />
 <br />
    <table class="style25">
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" 
                    CssClass="fg-white bg-darkBlue bg-hover-blue" Text="Id :-" Width="130px"></asp:Label>
                <asp:Label ID="id" runat="server" Text="id"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label12" runat="server" 
                    CssClass="fg-white bg-darkBlue bg-hover-blue" Text="Program Name :-" 
                    Width="130px"></asp:Label>
                <asp:Label ID="program_name" runat="server" Text="Program Name "></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label6" runat="server" 
                    CssClass="fg-white bg-darkBlue bg-hover-blue" Text="Name :-" Width="130px"></asp:Label>
                <asp:Label ID="name" runat="server" Text="Name"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label11" runat="server" 
                    CssClass="fg-white bg-darkBlue bg-hover-blue" Text="Father Name :-" 
                    Width="130px"></asp:Label>
                <asp:Label ID="father_name" runat="server" Text="Father Name "></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label7" runat="server" 
                    CssClass="fg-white bg-darkBlue bg-hover-blue" Text="Class :-" Width="130px"></asp:Label>
                <asp:Label ID="class1" runat="server" Text="Class"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label10" runat="server" 
                    CssClass="fg-white bg-darkBlue bg-hover-blue" Text="Contact No :-" 
                    Width="130px"></asp:Label>
                <asp:Label ID="contact_no" runat="server" Text="Contact No"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label8" runat="server" 
                    CssClass="fg-white bg-darkBlue bg-hover-blue" Text="Email Address :-" 
                    Width="130px"></asp:Label>
                <asp:Label ID="email_address" runat="server" Text="Email Address"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label9" runat="server" 
                    CssClass="fg-white bg-darkBlue bg-hover-blue" Text="Address :-" Width="130px"></asp:Label>
                <asp:Label ID="address" runat="server" Text="Address"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>

