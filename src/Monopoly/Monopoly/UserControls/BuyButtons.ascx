<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BuyButtons.ascx.cs" Inherits="Monopoly.UserControls.BuyButtons" %>
<span style="font-size: 10px;">
<p>
    <asp:Button ID="btnBuy" runat="server" Height="53px" Text="Buy" 
        Width="101px" onclick="btnBuy_Click" />
&nbsp;
    <asp:Button ID="btnCancel" runat="server" Height="53px" Text="Cancel" 
        Width="101px" onclick="btnCancel_Click" />
</p>
</span>