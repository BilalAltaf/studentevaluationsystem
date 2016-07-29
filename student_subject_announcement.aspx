<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage3.master" AutoEventWireup="true" CodeFile="student_subject_announcement.aspx.cs" Inherits="student_subject_announcement" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<asp:Panel ID="Panel2" runat="server">
    <asp:Button ID="Button1" 
        class="button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange" 
        runat="server" Text="Button" 
        onclick="btnsubjectname_Click" Width="300px" />
    &nbsp;<asp:Button ID="btnannouncement" runat="server" 
        class="button bg-darkRed bg-hover-red fg-white fg-hover-white bd-orange" 
        onclick="btnannouncement_Click" Text="Subject announcement" Width="300px" />
    </asp:Panel>
     <asp:Panel ID="Panel1" runat="server" Width="1190px">
        <div class="balloon right">
            <div class="tab-control padding20" data-role="tab-control">
                <ul class="tabs">
                    <li class="active">
                        <asp:LinkButton ID="announcements" runat="server" href="#announcements" 
                            Width="131px">Announcements</asp:LinkButton>
                    </li>
                </ul>
                <div class="frames">
                
                    <div ID="announcements" class="frame" style="display: block;">
                        <div class="input-control textarea">
                           
                        </div>
                          <asp:Panel ID="Panel4" runat="server" >
                        </asp:Panel>
                       
                    </div>
                </div>
            </div>
            
        </div>
        </asp:Panel>
</asp:Content>

