<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="About.aspx.cs" Inherits="About" %>
<%@ MasterType  virtualPath="~/Site.master"%>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.</p>
    <p>&nbsp;</p>
    <p>
        <asp:CheckBox ID="testSubject" runat="server" OnCheckedChanged="testSubject_CheckedChanged" Text="General" />
    </p>
    <p>&nbsp;</p>
    <p>
        <asp:Button ID="normBtn" runat="server" OnClick="normBtn_Click" Text="Normal" />
    </p>
</asp:Content>
