<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Info.ascx.cs" Inherits="Monopoly.Info" %>
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
<asp:Panel ID="Panel1" runat="server" Height="117px" style="text-align: left" 
    Width="274px">
<span class="style1"><span class="style2">Cash :</span>&nbsp; </span>
<asp:Label ID="lblCash" runat="server" style="font-size: large" 
Text="Label">
</asp:Label>
<br />
<asp:ListBox ID="lbProps" runat="server" Height="138px" Width="299px">
</asp:ListBox>
</asp:Panel>