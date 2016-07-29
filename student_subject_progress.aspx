<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage3.master" AutoEventWireup="true" CodeFile="student_subject_progress.aspx.cs" Inherits="student_subject_progress" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<asp:Panel ID="Panel2" runat="server">
    <asp:Button ID="Button1" 
        class="place-center button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange"  
        runat="server" Text="Button" 
        onclick="btnsubjectname_Click" Width="300px" />
    &nbsp;<asp:Button ID="btn_subject_progress" runat="server" 
        class="place-center button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange" 
        Text="Subject progress" Width="300px" />
    <br>
    <br></br>
    <asp:Label ID="Label1" runat="server" class="fg-white " Text="Progress Status"></asp:Label>
    </br>
    </asp:Panel>
    <asp:Chart ID="Chart1" runat="server" Height="322px" onload="Chart1_Load" 
        Width="878px">
        <Series>
            <asp:Series Name="progress_status" ChartType="Bar" >
            <Points>
				<asp:DataPoint AxisLabel="Quiz"  Color="#006666" />
				<asp:DataPoint AxisLabel="Assignment" Color="#003300" />

				<asp:DataPoint AxisLabel="Project"  Color="#660066" />
				<asp:DataPoint AxisLabel="Midterm"  Color="#CC0066" />
                <asp:DataPoint AxisLabel="Finalterm"  Color="Maroon" />
                
			</Points>
            </asp:Series>
        </Series>
        <ChartAreas>
            <asp:ChartArea Name="ChartArea1">
            
                <AxisX2 Maximum="100" Minimum="0">
                </AxisX2>
            
            </asp:ChartArea>
        </ChartAreas>
    </asp:Chart>
    <asp:Panel ID="Panel1" runat="server">
    </asp:Panel>

</asp:Content>

