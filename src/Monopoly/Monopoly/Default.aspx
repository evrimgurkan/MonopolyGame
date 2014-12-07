<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Monopoly._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Monopoly Game</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table cellpadding="2" align="center" cellspacing="0" border="2" style=" width: 1250px;height:900px; font-size:15px;" class="monopolyTable">
                <caption style="font-size:15px;"><b>Standard (American Edition) Monopoly game board layout</b>
                </caption>
                <tbody>
                    <tr style="text-align: center;">
                        <td colspan="2" rowspan="2">
                            <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;" title="Free Parking">Free Parking</a>
                        </td>
                        <td>
                            <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;" title="Kentucky Avenue">Kentucky Avenue</a>
                            <br /><s($220)
                        </td>
                        <td rowspan="2">
                            <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;" title="Chance">Chance</a>
                        </td>
                        <td>
                            <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;" title="Indiana Avenue">Indiana Avenue</a><br>($220)
                        </td>
                        <td>
                            <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;" title="Illinois Avenue">Illinois Avenue</a><br>($240)
                        </td>
                        <td rowspan="2">
                            <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;" title="B. &amp; O. Railroad">B. &amp; O. Railroad</a><br>($200)
                        </td>
                        <td>
                            <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;" title="Atlantic Avenue">Atlantic Avenue</a> ($260)
                        </td>
                        <td>
                            <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;" title="Ventnor Avenue">Ventnor Avenue</a>($260)
                        </td>
                        <td rowspan="2">
                            <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;" title="Water Works">Water Works</a><br>($150)
                        </td>
                        <td>
                            <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;" title="Marvin Gardens">Marvin Gardens</a><br>($280)
                        </td>
                        <td colspan="2" rowspan="2">
                            Go To Jail
                        </td>
                    </tr>
                    <tr style="text-align: center;">
                        <td bgcolor="#ff0000">
                        </td>
                        <td bgcolor="#ff0000">
                        </td>
                        <td bgcolor="#ff0000">
                        </td>
                        <td bgcolor="#ffff00">
                        </td>
                        <td bgcolor="#ffff00">
                        </td>
                        <td bgcolor="#ffff00">
                        </td>
                    </tr>
                    <tr style="text-align: center;">
                        <td >
                            <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;" title="New York Avenue">New York Avenue</a>
                            <br>($200)
                        </td>
                        <td bgcolor="#ff8000" style="width:20px;">
                        </td>
                        <th colspan="9" rowspan="9" style="text-align: center; vertical-align: middle; font-size:50px;">
                            Monopoly
                        </th>
                        <td bgcolor="#338033" style="width:20px;">
                        </td>
                        <td >
                            <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;" title="Pacific Avenue">Pacific Avenue</a>
                            <br>($300)
                        </td>
                    </tr>
                    <tr style="text-align: center;">
                        <td>
                            <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;" title="Tennessee Avenue">Tennessee Avenue</a><br>($180)
                        </td>
                        <td bgcolor="#ff8000">
                        </td>
                        <td bgcolor="#338033">
                        </td>
                        <td>
                            <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;" title="North Carolina Avenue">North Carolina Avenue</a>
                            <br>($300)
                        </td>
                    </tr>
                    <tr style="text-align: center;">
                        <td colspan="2">
                            <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;" title="Community Chest">Community Chest</a>
                        </td>
                        <td colspan="2">
                            <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;" title="Community Chest">Community Chest</a>
                        </td>
                    </tr>
                    <tr style="text-align: center;">
                        <td>
                            <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;" title="St. James Place">St. James Place</a>
                            <br>($180)
                        </td>
                        <td bgcolor="#ff8000">
                        </td>
                        <td bgcolor="#338033">
                        </td>
                        <td>
                            <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;" title="Pennsylvania Avenue">Pennsylvania Avenue</a>
                            <br>($320)
                        </td>
                    </tr>
                    <tr style=" text-align: center;">
                        <td colspan="2">
                            <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;" title="Pennsylvania Railroad">Pennsylvania Railroad</a>
                            <br>($200)
                        </td>
                        <td colspan="2">
                            <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;" title="Short Line">Short Line</a>
                            <br>($200)
                        </td>
                    </tr>
                    <tr style=" text-align: center;">
                        <td>
                            <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;" title="Virginia Avenue">Virginia Avenue</a>
                            <br>($160)
                        </td>
                        <td bgcolor="#F660AB">
                        </td>
                        <td colspan="2">
                            <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;" title="Chance">Chance</a>
                        </td>
                    </tr>
                    <tr style="text-align: center;">
                        <td> 
                            <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;" title="States Avenue">States Avenue</a>
                            <br>($140)
                        </td>
                        <td bgcolor="#F660AB">
                        </td>
                        <td bgcolor="#803399">
                            &nbsp;;
                        </td>
                        <td>
                            <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;" title="Park Place">Park Place</a>
                            <br>($350)
                        </td>
                    </tr>
                    <tr style="text-align: center;">
                        <td colspan="2">
                            <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;" title="Electric Company">Electric Company</a>
                            <br>($150)
                        </td>
                        <td colspan="2">
                            <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;" title="Luxury Tax">Luxury Tax</a>
                            <br>(Pay $75)
                        </td>
                    </tr>
                    <tr style="text-align: center;">
                        <td>
                            <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;" title="St. Charles Place">St. Charles Place</a>
                            <br>($140)
                        </td>
                        <td bgcolor="#F660AB">
                        </td>
                        <td bgcolor="#803399">
                        </td>
                        <td>
                            <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;" title="Boardwalk">Boardwalk</a>
                            <br>($400)
                        </td>
                    </tr>
                    <tr style="text-align: center;">
                        <td colspan="2" rowspan="2"> Jail/Just Visiting
                        </td>
                        <td bgcolor="#80ccff">
                        </td>
                        <td bgcolor="#80ccff">
                        </td>
                        <td rowspan="2">
                            <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;" title="Chance">Chance</a>
                        </td>
                        <td bgcolor="#80ccff">
                        </td>
                        <td rowspan="2">
                            <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;" title="Reading Railroad">Reading Railroad</a>
                            <br>($200)
                        </td>
                        <td rowspan="2"> 
                            <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;" title="Income Tax">Income Tax</a>
                            <br>(Pay 10% or $200)
                        </td>
                        <td bgcolor="#6F4E37">
                        </td>
                        <td rowspan="2"> 
                            <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;" title="Community Chest">Community Chest</a>
                        </td>
                        <td bgcolor="#6F4E37">
                        </td>
                        <td colspan="2" rowspan="2"> 
                            ← GO
                            <br>Collect $200 salary<br>
                        </td>
                    </tr>
                    <tr style="text-align: center;">
                        <td> 
                            <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;" title="Connecticut Avenue">Connecticut Avenue</a>
                            <br>($120)
                        </td>
                        <td> 
                            <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;" title="Vermont Avenue">Vermont Avenue</a>
                            <br>($100)
                        </td>
                        <td> 
                            <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;" title="Oriental Avenue">Oriental Avenue</a>
                            <br>($100)
                        </td>
                        <td> 
                            <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;" title="Baltic Avenue">Baltic Avenue</a>
                            <br>($60)
                        </td>
                        <td> 
                            <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;" title="Mediterranean Avenue">Mediterranean Avenue</a>
                            <br>($60)
                        </td>
                    </tr>
                </tbody>
            </table>
        </div>
    </form>
</body>
</html>
