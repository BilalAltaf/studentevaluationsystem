<%@ Page Title="" Language="C#" MasterPageFile="~/teacher.master" AutoEventWireup="true" CodeFile="teacher_project_marks_entrance.aspx.cs" Inherits="teacher_project_marks_entrance" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<asp:Panel ID="Panel1" runat="server">
        <br />
        <asp:Button ID="Button1" CausesValidation="false"
            Class="button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange"  
            runat="server" Text="Button" onclick="Button1_Click" Width="300px" />
        <asp:Button ID="btnproject" runat="server" CausesValidation="false"
            Class="button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange" 
            onclick="btnproject_Click" Text="Project" Width="100px" />
    </asp:Panel>
    <asp:Panel ID="Panel3" runat="server" Visible="False" Width="983px">
        <asp:Label ID="total" Class = "fg-white"  runat="server" Text="Total projects:-"></asp:Label>
        &nbsp;<asp:DropDownList ID="DropDownList1" runat="server" >
            <asp:ListItem Value="-1">choose one</asp:ListItem>
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
        </asp:DropDownList><asp:RequiredFieldValidator ID="RequiredFieldValidator1" class="fg-red" 
            runat="server" ErrorMessage="Choose total projects" InitialValue="-1" 
            ControlToValidate="DropDownList1"></asp:RequiredFieldValidator>
        <br/> <asp:Label ID="Total_Percentage" Class = "fg-white" runat="server" Text="Total Percentage:-"></asp:Label>
        <asp:DropDownList ID="DropDownList2" runat="server" >
            <asp:ListItem Value="-1">choose percentage</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
            <asp:ListItem>15</asp:ListItem>
            <asp:ListItem>20</asp:ListItem>
        </asp:DropDownList><asp:RequiredFieldValidator class="fg-red" ID="RequiredFieldValidator2" 
            runat="server" ErrorMessage="Choose projects percentage" InitialValue="-1" 
            ControlToValidate="DropDownList2"></asp:RequiredFieldValidator>
        <br/><asp:Button ID="btnsubmit" runat="server" 
            Class="button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange" 
            onclick="btnsubmit_Click" Text="Submit" Width="78px" />
        &nbsp;<asp:Label ID="label10" Class = "fg-white" runat="server"></asp:Label>
    </asp:Panel>
<asp:Panel ID="Panel4" runat="server" Height="24px" Width="985px">
    <asp:Button ID="btnproject1" 
        Class="button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange"  
        runat="server" Text="Project1" Visible="False" 
        onclick="btnproject1_Click" Width="100px"/>
    <asp:Button ID="btnproject2" 
        Class="button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange"  
        runat="server" Text="Project2" Visible="False" 
        onclick="btnproject2_Click" Width="100px"/>
    <asp:Button ID="btnproject3" 
        Class="button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange" 
        runat="server" Text="Project3" Visible="False" 
        onclick="btnproject3_Click" Width="100px"/>
    <asp:Button ID="btnproject4" 
        Class="button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange" 
        runat="server" Text="Project4" Visible="False" 
        onclick="btnproject4_Click" style="height: 26px" Width="100px"/>
    <asp:Button ID="btnproject5" 
        Class="button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange" 
        runat="server" Text="Project5" Visible="False" 
        onclick="btnproject5_Click" Width="100px"/>
</asp:Panel>
<asp:Panel ID="Panel5" runat="server">
    <asp:Button ID="btnedit" 
        Class="button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange"  runat="server" 
    onclick="btnedit_Click" Text="Edit_Project_info" Width="164px" />
    </asp:Panel>
</asp:Content>

