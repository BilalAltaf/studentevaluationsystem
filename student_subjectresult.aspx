<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage3.master" AutoEventWireup="true" CodeFile="student_subjectresult.aspx.cs" Inherits="student_subjectresult" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="Panel1" runat="server" Height="28px" Width="300px">
        <asp:Button ID="btnsubjectname" 
            class="button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange" 
            runat="server" Text="Button" Width="300px" />
    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server">
                  <asp:Button ID="btnquiz" 
                      class="button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange" 
                      runat="server" Text="quiz" onclick="btnquiz_Click" Width="99px" />
                  <asp:Button ID="btnassignment" 
                      class="button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange" 
                      runat="server" Text="assignment" 
                      onclick="btnassignment_Click" Width="114px" />
                  <asp:Button ID="btnproject" 
                      class="button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange" 
                      runat="server" Text="project" 
                      onclick="btnproject_Click" Width="79px" />

                  <asp:Button ID="btnmidterm" 
                      class="button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange" 
                      runat="server" onclick="btnmidterm_Click" 
                      Text="Midterm" Width="84px" />
                  <asp:Button ID="btnfinal" 
                      class="button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange" 
                      runat="server" onclick="btnfinal_Click" 
                      Text="Final" Width="71px" />
                      <asp:Button ID="btn_suggestion" 
                      class="button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange" 
                      runat="server" Text="Subject Grade Suggestion" 
                      onclick="btn_suggestion_Click" Width="212px" />
                      <asp:Button ID="btn_subject_progress" 
                      class="button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange" 
                      runat="server" Text="Subject progress" 
                      onclick="btn_subject_progress_Click" Width="212px" />
                      <asp:Button ID="Button1" 
                      class="button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange" 
                      runat="server" Text="Subject Announcement" 
                      onclick="btn_subject_announcement_Click" Width="212px" />
    </asp:Panel>

</asp:Content>


