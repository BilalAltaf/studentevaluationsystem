<%@ Page Title="" Language="C#" MasterPageFile="~/teacher.master" AutoEventWireup="true" CodeFile="teacher_subject_announcement_entrance.aspx.cs" Inherits="teacher_subject_announcement_entrance" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="Panel2" runat="server">
      <asp:Panel ID="Panel3" runat="server">
        <br />
        <asp:Button ID="Button1" runat="server" 
            Class="button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange" 
            onclick="Button1_Click" Text="Button" Width="300px" />
        <asp:Button ID="btnannouncement" runat="server" 
            Class="button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange" 
            onclick="btnAnnouncement_Click" Text="Subject Announcement" Width="203px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </asp:Panel>
    </asp:Panel>
    <asp:Panel ID="Panel1" runat="server" Width="1190px">
        <div class="balloon right">
            <div class="tab-control padding20" data-role="tab-control">
                <ul class="tabs">
                    <li class="active">
                        <asp:LinkButton ID="write" runat="server" href="#write" onclick="write_Click" 
                            Width="75px">write</asp:LinkButton>
                    </li>
                </ul>
                <div class="frames">
                
                    <div ID="write" class="frame" style="display: block;">
                        <div class="input-control textarea">
                            <asp:TextBox ID="TextBox1" runat="server" Height="54px" 
                                placeholder="leave a comment" TextMode="MultiLine" Width="846px"></asp:TextBox>
                        </div>
                        <asp:Button ID="Button2" 
                            Class="button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange" 
                            runat="server" Text="Button" onclick="Button2_Click" Width="124px" /> 
                        <asp:Label ID="Label1" class="fg-red" runat="server" Text=" Successfully posted !" Visible=false></asp:Label>
                        <asp:Panel ID="Panel4" runat="server" >
                        </asp:Panel>
                    </div>
                </div>
            </div>
            
        </div>
        </asp:Panel>
</asp:Content>

