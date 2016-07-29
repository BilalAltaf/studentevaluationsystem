<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage3.master" AutoEventWireup="true" CodeFile="student_all_subject_progress.aspx.cs" Inherits="student_subject_progress" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<asp:Label ID="Label4" class="fg-white" runat="server" Text="All Subjects Progress " Font-Bold="True" Font-Size="Larger"></asp:Label>
 <br />
 <br />
    <asp:Panel ID="Panel1" runat="server">
     <asp:Label ID="Label1" runat="server" class="fg-white " Text="Progress Status"></asp:Label>
     </asp:Panel>
    <asp:Panel ID="Panel2" runat="server">
     <asp:Chart ID="Chart1" runat="server"  Height="486px" Width="900px">
        <Series>
            <asp:Series Name="progress_status" ChartType="Bar">
            <Points>
            <asp:DataPoint AxisLabel=" "  Color="#006666" />
            <asp:DataPoint AxisLabel=" " Color="#003300" />

				<asp:DataPoint AxisLabel=" "  Color="#660066" />
				<asp:DataPoint AxisLabel=" "  Color="#CC0066" />
                <asp:DataPoint AxisLabel=" "  Color="Maroon"  />
                <asp:DataPoint AxisLabel=" "  Color="Maroon"  />
                <asp:DataPoint AxisLabel=" "  Color="Maroon"  />
                <asp:DataPoint AxisLabel=" "  Color="Maroon"  />
                <asp:DataPoint AxisLabel=" "  Color="Maroon"  />
                
                
            </Points>
            </asp:Series>
        </Series>
        <ChartAreas>
            <asp:ChartArea Name="ChartArea1">
            </asp:ChartArea>
        </ChartAreas>
    </asp:Chart>
    </asp:Panel>
    
</asp:Content>

