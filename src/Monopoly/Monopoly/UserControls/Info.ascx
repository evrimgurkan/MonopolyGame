<%@ control AutoEventWireup="true" CodeBehind="Info.ascx.cs" Inherits="Monopoly.Info" Language="C#" %>
<style type="text/css">


    .style1
    {
        color: #000066;
        font-weight: bold;
    }
    .style2
    {
        font-size: large;
    }
</style>
<asp:Panel ID="Panel1" runat="server" style="text-align: left" 
    Width="300px">
    <asp:Label ID="lblName" runat="server" Text="Label"></asp:Label>
    <span class="style1"><span class="style2">
    <br />
    Cash :</span>&nbsp; </span>
    <asp:Label ID="lblCash" runat="server" style="font-size: large" Text="Label">
</asp:Label>
    <br />
    <asp:ListBox ID="lbProps" runat="server" Height="120px" Width="299px">
    </asp:ListBox>
</asp:Panel>
