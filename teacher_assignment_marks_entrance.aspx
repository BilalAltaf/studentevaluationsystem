<%@ Page Title="" Language="C#" MasterPageFile="~/teacher.master" AutoEventWireup="true" CodeFile="teacher_assignment_marks_entrance.aspx.cs" Inherits="teacher_assignment_marks_entrance" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<asp:Panel ID="Panel1" runat="server">
        <br />
        <asp:Button ID="Button1" CausesValidation="false"
            Class="button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange" 
            runat="server" Text="Button" onclick="Button1_Click" Width="300px" />
        <asp:Button ID="btnassignment" runat="server" CausesValidation="false"
            Class="button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange" 
            onclick="btnassignment_Click" Text="assignment" Width="100px" />
    </asp:Panel>
    <asp:Panel ID="Panel3" runat="server" Visible="False" Width="1085px">
        <asp:Label ID="total" Class = "fg-white" runat="server" Text="Total Assignments:-"></asp:Label>
        &nbsp;<asp:DropDownList ID="DropDownList1" runat="server" >
            <asp:ListItem Value="-1">choose one</asp:ListItem>
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
        </asp:DropDownList><asp:RequiredFieldValidator class="fg-red" ID="RequiredFieldValidator1" 
            runat="server" ErrorMessage="Choose total assignments" InitialValue="-1" 
            ControlToValidate="DropDownList1"></asp:RequiredFieldValidator>
        &nbsp;&nbsp; <br/><asp:Label ID="Total_Percentage" Class = "fg-white" runat="server" Text="Total Percentage:-"></asp:Label>
        <asp:DropDownList ID="DropDownList2" runat="server" >
            <asp:ListItem Value="-1">choose percentage</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
            <asp:ListItem>15</asp:ListItem>
            <asp:ListItem>20</asp:ListItem>
        </asp:DropDownList><asp:RequiredFieldValidator class="fg-red" ID="RequiredFieldValidator2" 
            runat="server" ErrorMessage="Choose assignments percentage" InitialValue="-1" 
            ControlToValidate="DropDownList2"></asp:RequiredFieldValidator>
        <br/><asp:Button ID="btnsubmit" 
            Class="button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange" 
            runat="server" Text="Submit" 
            onclick="btnsubmit_Click" Width="100px"  />
            <asp:Label ID="label10" Class = "fg-white" runat="server"></asp:Label>
    </asp:Panel>
<asp:Panel ID="Panel4" runat="server" Height="24px" Width="985px">
    <asp:Button ID="btnassignment1" 
        Class="button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange" 
        runat="server" Text="Assignment1" Visible="False" 
        onclick="btnassignment1_Click" Width="130px"/>
    <asp:Button ID="btnassignment2" 
        Class="button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange" 
        runat="server" Text="Assignment2" Visible="False" 
        onclick="btnassignment2_Click" Width="130px"/>
    <asp:Button ID="btnassignment3" 
        Class="button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange" 
        runat="server" Text="Assignment3" Visible="False" 
        onclick="btnassignment3_Click" Width="130px"/>
    <asp:Button ID="btnassignment4" 
        Class="button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange" 
        runat="server" Text="Assignment4" Visible="False" 
        onclick="btnassignment4_Click" Width="130px"/>
    <asp:Button ID="btnassignment5" 
        Class="button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange" 
        runat="server" Text="Assignment5" Visible="False" 
        onclick="btnassignment5_Click" Width="130px"/>
</asp:Panel>
<asp:Panel ID="Panel5" runat="server">
    <asp:Button ID="btnedit" 
        Class="button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange" runat="server" 
    onclick="btnedit_Click" Text="Edit_Assignment_info" Width="181px" />
    </asp:Panel>
</asp:Content>

