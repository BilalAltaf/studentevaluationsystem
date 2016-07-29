<%@ Page Title="" Language="C#" MasterPageFile="~/teacher.master" AutoEventWireup="true" CodeFile="teacher_subject_registration.aspx.cs" Inherits="teacher_subject_registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<asp:Label ID="Label1" class="fg-white" runat="server" Text="Registration " Font-Bold="True" Font-Size="Larger"></asp:Label>
    <br />
    <br />
 <asp:Panel ID="Panel1" runat="server" Height="68px" Width="702px">
        <asp:Label ID="lblsubjectname" class="fg-white" runat="server" Text="Subject Name:-"></asp:Label>
        <asp:TextBox ID="textbox1" runat="server" Height="25px"></asp:TextBox><asp:RequiredFieldValidator
        ID="RequiredFieldValidator2" runat="server" Type="Integer" ErrorMessage="Enter subject Name" ControlToValidate="textbox1" CssClass="fg-red"></asp:RequiredFieldValidator>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br/>
        <asp:Label ID="Lblscode" class="fg-white" runat="server" Text="Enter code:-"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="codetextbox" runat="server"></asp:TextBox><asp:RequiredFieldValidator
        ID="RequiredFieldValidator1" runat="server" Type="Integer" ErrorMessage="Enter code for subject" ControlToValidate="codetextbox" CssClass="fg-red"></asp:RequiredFieldValidator>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br/><asp:Button ID="btnsearch" runat="server" 
            class="place-left button bg-darkViolet bg-hover-violet fg-white fg-hover-white bd-orange" 
            onclick="btnsearch_Click" Text="search" Width="109px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        &nbsp;&nbsp;
    </asp:Panel>
   <asp:Panel ID="Panel2" runat="server" Height="28px" style="margin-top: 25px">
      <asp:Label ID="Label10" class="fg-white" runat="server" Text="No Result" Visible="False"></asp:Label>
       &nbsp;
       <asp:Label ID="Label2" class="fg-white" runat="server" Text="Label" Visible="False"></asp:Label>
       <asp:Label ID="label11" class="fg-white" runat="server" Text="Label" Visible="False"></asp:Label>
       <asp:Table ID="Table1" class="table striped bordered hovered" runat="server" Width="851px" Height="35px" Visible="False">
           
       </asp:Table>
       <asp:Button ID="btnregisterit" 
           class="place-left button bg-darkViolet bg-hover-violet fg-white fg-hover-white bd-orange" 
           runat="server" Text="Register It" 
           onclick="btnregisterit_Click" Visible="False" Width="227px" />
       <asp:Button ID="btnregistrationdone" 
           class="place-left button bg-darkViolet bg-hover-violet fg-white fg-hover-white bd-orange" runat="server" 
           Text="All Subject Registration Done" onclick="btnregistrationdone_Click" 
           Visible="False" Width="365px" />
</asp:Panel>
</asp:Content>

