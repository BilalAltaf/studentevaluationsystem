﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage3.master" AutoEventWireup="true" CodeFile="student_subject_quiz_result.aspx.cs" Inherits="student_subject_quiz_result" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="Panel2" runat="server">
    <asp:Button ID="Button1" CausesValidation="false" class="button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange" runat="server" Text="Button" 
        onclick="btnsubjectname_Click" Width="300px" />
        &nbsp;<asp:Button CausesValidation="false" ID="btnquiz" runat="server" 
            class="button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange" 
            onclick="btnquiz_Click" Text="quiz" Width="300px" />
    </asp:Panel>
    <asp:Panel ID="Panel1" runat="server">
</asp:Panel>
<asp:Label ID="Label7" class="fg-white" runat="server" Text="Uptil obtained quizes Marks " Visible="False"></asp:Label>
    <asp:Table ID="Table1" class="table striped bordered hovered" runat="server">

    </asp:Table>
    <asp:Panel ID="Panel3" runat="server" Visible="False">
        <asp:Label ID="Label1" class="fg-white" runat="server" Text="No Uploadin Is Done"></asp:Label>
        &nbsp;&nbsp;&nbsp;
    </asp:Panel>
    <asp:Label ID="Label2" class="fg-white" runat="server" Text="Uptil obtained quizes percentage "></asp:Label>
<asp:Table ID="Table2" class="table striped bordered hovered" runat="server">
</asp:Table>
 <asp:Panel ID="Panel4" runat="server" >
        <asp:Button ID="Maximum_Percentage" CausesValidation="false" class="button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange"  runat="server" Text="Maximum Percentage You Can Get In Quiz" onclick="Maximum_Percentage_Click" />
        <asp:Button ID="Average_Percentage" CausesValidation="false" class="button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange"  runat="server" Text="Average Percentage You Can Get In Quiz" 
            onclick="Average_Percentage_Click" />
        <asp:Button ID="Minimum_Percentage" CausesValidation="false" class="button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange"  runat="server" Text="Minimum Percentage You Can Get In Quiz" 
            onclick="Minimum_Percentage_Click" />
        <asp:Button ID="Self_Prediction" CausesValidation="false" class="button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange"  runat="server" Text="Self_Prediction" 
            onclick="Self_Prediction_Click" />
</asp:Panel>
<asp:Panel ID="Panel5" runat="server" >
    <asp:Label ID="Label3" class="fg-white" runat="server" 
        Text="Maximum quizes percentage that you can obtain " Visible="False"></asp:Label>
<asp:Table ID="Table3" class="table striped bordered hovered" runat="server">
</asp:Table>
</asp:Panel>
<asp:Panel ID="Panel10" runat="server">
        <asp:Button CausesValidation="false" ID="Press" class="button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange" runat="server" Text="Press if You want To Do Prediction" 
            Visible="False" onclick="Press_Click"/>
    </asp:Panel>
<asp:Panel ID="Panel8" runat="server" Visible="False">
    <asp:Label ID="Label6" class="fg-white" runat="server" 
        Text="self prediction for quizes percentage " Visible="False"></asp:Label>
<asp:Table ID="Table6" class="table striped bordered hovered" runat="server">
 
</asp:Table>
 <asp:Button ID="btnsubmit" CausesValidation="true"
        class="button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange"  
        runat="server" onclick="btnsubmit_Click" 
        Text="Submit"  />
        <asp:Panel ID="Panel6" runat="server">
        </asp:Panel>
    <br />
    &nbsp;<h1 class="fg-white">
        you can get:-
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </h1>
    

</asp:Panel>
</asp:Content>

