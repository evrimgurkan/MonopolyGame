<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BuyCard.ascx.cs" Inherits="Monopoly.UserControls.BuyCard" %>
<%@ Register Src="~/UserControls/BuyButtons.ascx" TagName="BuyButton" TagPrefix="uc" %>

        <style type="text/css">
            .style1
            {
                height: 46px;
            }
        </style>

        <table class="toccolours" style="border: 1px solid black; font-variant: small-caps;
            float: right; clear: right; margin: 0 0 0.5em 1em; width: 20em; height:80px; ">
            <tbody>
                <tr>
                    <th colspan="2" 
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
                    <td colspan="2" style="text-align: center;">
                        Rent $<asp:Label ID="lblRent" runat="server" Text="Label"></asp:Label>
                        .
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;With 1 House
                    </td>
                    <td>
                        &nbsp;$<asp:Label ID="lblOneHouseRent" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;With 2 Houses
                    </td>
                    <td>
                        &nbsp;$<asp:Label ID="lblTwoHousesRent" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;With 3 Houses
                    </td>
                    <td>
                        &nbsp;$<asp:Label ID="lblThreeHousesRent" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;With 4 Houses
                    </td>
                    <td>
                        &nbsp;$<asp:Label ID="lblFourHousesRent" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" style="text-align: center;">
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
            </tbody>
        </table>
    