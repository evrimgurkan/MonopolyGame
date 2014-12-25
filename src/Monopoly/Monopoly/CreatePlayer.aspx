<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreatePlayer.aspx.cs" Inherits="Monopoly.CreatePlayer" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            font-family: "Comic Sans MS";
            color: #C60021;
        }
        .style2
        {
            font-size: small;
        }
    </style>
</head>
<body background="images/bg.jpg">
    <form id="form1" runat="server">
    <div style="text-align: center">
        <br />
        <br />
        <asp:Image ID="Image1" runat="server" ImageUrl="~/images/monop.gif" />
        <br />
    </div>
    <div style="text-align: center">
        <br />
        <br />
        <br />
        <br />
        <div class="style1">
            Player Name 1:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtName1" runat="server" Height="35px" 
                Width="178px" style="font-size: medium" ></asp:TextBox>
            <br />
            <br />
            Player Name 2:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtName2" runat="server" Height="35px" 
                Width="178px" style="font-size: medium" ></asp:TextBox>
            <br />
            <br />
            Player Name 3:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtName3" runat="server" Height="35px" 
                Width="178px" style="font-size: medium" ></asp:TextBox>
            <br />
            <br />
            Player Name 4:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtName4" runat="server" Height="35px" 
                Width="178px" style="font-size: medium" ></asp:TextBox>
            <br />
            <br />
        </div>
        <div>
        
            <br />
            <br />
        
            <asp:Label ID="lblWarning" runat="server" 
                style="color: #FF0000; font-size: large;" Text="Please enter Player names !!" 
                Visible="False"></asp:Label>
        
        </div>
    </div>
    <div style="text-align: center">
        <br />
        <br />
        <br />
        <asp:ImageButton ID="btnAddPlayers" runat="server" 
            ImageUrl="~/images/Buttons/AddPlayers.png" onclick="btnAddPlayers_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="btnStartGame" runat="server" 
            ImageUrl="~/images/Buttons/StartGameInactive.png" 
            onclick="btnStartGame_Click1" Enabled="False" EnableTheming="True" />
    </div>
    <div style="font-style: italic; text-align: center; font-family: Consolas; font-size: x-small">
        <br />
        <br />
        <br />
        <span class="style2">*
        If you leave text areas empty, users could not be added.
    </span>
    </div>
    </form>
</body>
</html>
