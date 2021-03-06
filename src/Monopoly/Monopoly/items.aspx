﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="items.aspx.cs" Inherits="Monopoly.items" %>

<%@ Register src="UserControls/BuyButtons.ascx" tagname="BuyButton" tagprefix="uc" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

            .style1
            {
                height: 46px;
            }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <table class="toccolours" style="border: 1px solid black; font-variant: small-caps;
            float: right; clear: right; margin: 0 0 0.5em 1em; width: 20em; height:80px; ">
                <tr>
                    <th 
                        style="text-align: center; font-size: 17px;" 
                        class="style1">
                        <font color="white">
                            <asp:Panel ID="pnlTitle" runat="server" Height="42px">
                                <font color="white">
                                    <asp:Label ID="lblTitle" runat="server" Text="Label" style="font-size: large"></asp:Label>
                                </font>
                        </asp:Panel>
                        </font>
                    </th>
                </tr>
                <tr>
                    <td style="text-align: center;">
                        Rent $<asp:Label ID="lblRent" runat="server" Text="Label"></asp:Label>
                        .
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;With 1 House
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;With 2 Houses
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;With 3 Houses
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;With 4 Houses
                    </td>
                </tr>
                <tr>
                    <td style="text-align: center;">
                        With HOTEL $<asp:Label ID="lblHotelRent" runat="server" Text="Label"></asp:Label>
                        <br>
                        <br>
                        Mortgage Value $<asp:Label ID="lblMortgagedValue" runat="server" Text="Label"></asp:Label>
                        <br>
                        Houses cost $<asp:Label ID="lblHousePrice" runat="server" Text="Label"></asp:Label>
                        . each
                        <br>
                        Hotels, $<asp:Label ID="lblHotelPrice" runat="server" Text="Label"></asp:Label>
                        . plus 4 houses
                        <br>
                        <span style="font-size: 10px;">
                            <p>
                                If a player owns ALL the lots of any Color-Group, the rent is Doubled on Unimproved
                                Lots in that group.
                            </p>
                            <uc:BuyButton ID=BuyButtons runat="server"></uc:BuyButton>
                            </p>
                        </span>
                    </td>
                </tr>
        </table>
    </div>
    </form>
</body>
</html>
