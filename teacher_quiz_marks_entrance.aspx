<%@ Page Title="" Language="C#" MasterPageFile="~/teacher.master" AutoEventWireup="true" CodeFile="teacher_quiz_marks_entrance.aspx.cs" Inherits="teacher_quiz_marks_entrance" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <asp:Panel ID="Panel1" runat="server">
        <br />
        <asp:Button ID="Button1" runat="server" CausesValidation="false"
            Class="button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange" 
            onclick="Button1_Click" Text="Button" Width="300px" />
        <asp:Button ID="btnquiz" runat="server" CausesValidation="false"
            Class="button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange" 
            onclick="btnquiz_Click" Text="Quiz" Width="137px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </asp:Panel>
    <asp:Panel ID="Panel3" runat="server" Visible="False" Width="983px">
        <asp:Label ID="total" Class = "fg-white" runat="server" Text="Total Quiz:-"></asp:Label>
        &nbsp;<asp:DropDownList ID="DropDownList1" runat="server" >
            <asp:ListItem Value="-1">choose one</asp:ListItem>
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
        </asp:DropDownList><asp:RequiredFieldValidator ID="RequiredFieldValidator1" class="fg-red" 
            runat="server" ErrorMessage="Choose total Quizes" InitialValue="-1" 
            ControlToValidate="DropDownList1"></asp:RequiredFieldValidator>
        &nbsp;&nbsp;&nbsp;
        <br /><asp:Label ID="Total_Percentage" Class = "fg-white" runat="server" Text="Total Percentage:-"></asp:Label>
        <asp:DropDownList ID="DropDownList2" runat="server">
            <asp:ListItem Value="-1">choose percentage</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
            <asp:ListItem>15</asp:ListItem>
            <asp:ListItem>20</asp:ListItem>
        </asp:DropDownList><asp:RequiredFieldValidator ID="RequiredFieldValidator2" class="fg-red" 
            runat="server" ErrorMessage="Choose  quizes percentage" InitialValue="-1" 
            ControlToValidate="DropDownList2"></asp:RequiredFieldValidator>
        &nbsp;
        <br/><asp:Button ID="btnsubmit" runat="server" 
            Class="button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange" 
            onclick="btnsubmit_Click" Text="Submit" Width="121px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="label10" Class = "fg-white" runat="server"></asp:Label>
    </asp:Panel>
<asp:Panel ID="Panel4" runat="server" Height="35px" Width="985px">
    <asp:Button ID="btnquiz1" 
        Class = "button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange" 
        runat="server" Text="Quiz1" Visible="False" 
        onclick="btnquiz1_Click" Width="75px"/>
    <asp:Button ID="btnquiz2" 
        Class = "button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange" 
        runat="server" Text="Quiz2" Visible="False" 
        onclick="btnquiz2_Click" Width="75px"/>
    <asp:Button ID="btnquiz3" 
        Class = "button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange" 
        runat="server" Text="Quiz3" Visible="False" 
        onclick="btnquiz3_Click" Width="75px"/>
    <asp:Button ID="btnquiz4" 
        Class = "button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange" 
        runat="server" Text="Quiz4" Visible="False" 
        onclick="btnquiz4_Click" Width="75px"/>
    <asp:Button ID="btnquiz5" 
        Class = "button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange" 
        runat="server" Text="Quiz5" Visible="False" 
        onclick="btnquiz5_Click" Width="75px"/>
</asp:Panel>
<asp:Panel ID="Panel5" runat="server">
    <asp:Button ID="btnedit" 
        Class = "button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange" runat="server" 
    onclick="btnedit_Click" Text="Edit_quiz_info" Width="170px" />
    </asp:Panel>
</asp:Content>

