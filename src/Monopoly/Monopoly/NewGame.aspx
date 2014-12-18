<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewGame.aspx.cs" Inherits="Monopoly.NewGame" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
                            </div>
                            
    <br />
    <th colspan="9" rowspan="9" style="text-align: center; vertical-align: middle; font-size:50px;">
                            Monopoly </th>
    <br />
    <br />
    <asp:Button ID="btnNewGame" runat="server" Height="92px" Text="New Game" 
        Width="130px" onclick="btnNewGame_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnOptions" runat="server" Height="92px" Text="Options" 
        Width="130px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnRules" runat="server" Height="92px" Text="Rules" 
        Width="130px" />
    </form>
</body>
</html>
