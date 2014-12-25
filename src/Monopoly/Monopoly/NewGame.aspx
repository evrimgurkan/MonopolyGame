<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewGame.aspx.cs" Inherits="Monopoly.NewGame" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1
        {
            text-align: center;
        }
        .style1
        {
            font-size: small;
            font-style: italic;
            font-family: "Courier New", Courier, monospace;
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
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    </div>
    <div>
        <asp:ImageButton ID="btnNewGame" runat="server" 
            ImageUrl="~/images/Buttons/NewGame.png" onclick="btnNewGame_Click1" />
    </div>
    <div>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:ImageButton ID="btnHelp" runat="server" 
            ImageUrl="~/images/Buttons/Help.png" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="btnOptions" runat="server" 
            ImageUrl="~/images/Buttons/Options.png" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="btnExit" runat="server" 
            ImageUrl="~/images/Buttons/Exit.png" />
        
    </div>
    <div>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <span class="style1">Created by Evrim Gürkan & Ahmet Ceylan</span></div>
    </form>
    </body>
</html>
