<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Monopoly.aspx.cs" Inherits="Monopoly._Default" %>

<%@ Register Src="~/UserControls/Info.ascx" TagName="BankInfo" TagPrefix="uc" %>
<%@ Register Src="~/UserControls/Info.ascx" TagName="UserInfo" TagPrefix="uc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Monopoly Game</title>

    <script src="/js/utils.js"></script>

    <script src="/js/rotate-box.js"></script>

    <style media="screen">
        body
        {
            background-image: url("images/bg0.jpg");
            background-repeat: repeat;
        }
        figure
        {
            margin: 0;
        }
        .container
        {
            width: 100px;
            height: 100px;
            position: relative;
            float: left;
            margin: auto 40px;
            border: 1px solid #CCC;
            -webkit-perspective: 500px;
            -moz-perspective: 500px;
            -o-perspective: 500px;
            perspective: 500px;
        }
        table
        {
            width: 100%;
            height: 900px;
            font-size: 15px;
            z-index: ==-1;
        }
        td
        {
            border: 2px inset gray;
        }
        tr
        {
        }
        img:hover
        {
            -webkit-transform: scale(1.1);
            -moz-transform: scale(1.1);
            -o-transform: scale(1.1);
            -moz-box-shadow: 3px 5px 7px rgba(0,0,0,.7);
            -webkit-box-shadow: 3px 5px 7px rgba(0,0,0,.7);
            box-shadow: 3px 5px 7px rgba(0,0,0,.7);
            cursor: pointer;
            background-color: FCF;
        }
        img
        {
            position: absolute;
            z-index: 33;
        }
        img:hover
        {
            margin-top: -400px;
            transition: margin 5s;
        }
        .LogContainer
        {
            vertical-align: bottom;
            margin-top: -45px;
            margin-bottom: -55px;
        }
        .LogContainer #logTitle
        {
            font-size: large;
        }
        .LogContainer #lbLogs
        {
            height: 400px;
            width: 300px;
        }
        .PlayerContainer
        {
            width: 300px;
        }
        .OperationsContainer
        {
            width: 300px;
            vertical-align: top;
        }
        .BankContainer
        {
            width: 300px;
        }
        #cube
        {
            width: 100%;
            height: 100%;
            position: absolute;
            -webkit-transform-style: preserve-3d;
            -moz-transform-style: preserve-3d;
            -o-transform-style: preserve-3d;
            transform-style: preserve-3d;
            -webkit-transition: -webkit-transform 1s;
            -moz-transition: -moz-transform 1s;
            -o-transition: -o-transform 1s;
            transition: transform 1s;
        }
        #cube figure
        {
            display: block;
            position: absolute;
            width: 96px;
            height: 96px;
            border: 2px solid black;
            line-height: 96px;
            font-size: 100px;
            font-weight: bold;
            color: white;
            text-align: center;
        }
        #cube.panels-backface-invisible figure
        {
            -webkit-backface-visibility: hidden;
            -moz-backface-visibility: hidden;
            -o-backface-visibility: hidden;
            backface-visibility: hidden;
        }
        #cube .front
        {
            background: hsla(   0, 100%, 50%, 0.7 );
        }
        #cube .back
        {
            background: hsla(  60, 100%, 50%, 0.7 );
        }
        #cube .right
        {
            background: hsla( 120, 100%, 50%, 0.7 );
        }
        #cube .left
        {
            background: hsla( 180, 100%, 50%, 0.7 );
        }
        #cube .top
        {
            background: hsla( 240, 100%, 50%, 0.7 );
        }
        #cube .bottom
        {
            background: hsla( 300, 100%, 50%, 0.7 );
        }
        #cube .front
        {
            -webkit-transform: translateZ( 50px );
            -moz-transform: translateZ( 50px );
            -o-transform: translateZ( 50px );
            transform: translateZ( 50px );
        }
        #cube .back
        {
            -webkit-transform: rotateX( -180deg ) translateZ( 50px );
            -moz-transform: rotateX( -180deg ) translateZ( 50px );
            -o-transform: rotateX( -180deg ) translateZ( 50px );
            transform: rotateX( -180deg ) translateZ( 50px );
        }
        #cube .right
        {
            -webkit-transform: rotateY(   90deg ) translateZ( 50px );
            -moz-transform: rotateY(   90deg ) translateZ( 50px );
            -o-transform: rotateY(   90deg ) translateZ( 50px );
            transform: rotateY(   90deg ) translateZ( 50px );
        }
        #cube .left
        {
            -webkit-transform: rotateY(  -90deg ) translateZ( 50px );
            -moz-transform: rotateY(  -90deg ) translateZ( 50px );
            -o-transform: rotateY(  -90deg ) translateZ( 50px );
            transform: rotateY(  -90deg ) translateZ( 50px );
        }
        #cube .top
        {
            -webkit-transform: rotateX(   90deg ) translateZ( 50px );
            -moz-transform: rotateX(   90deg ) translateZ( 50px );
            -o-transform: rotateX(   90deg ) translateZ( 50px );
            transform: rotateX(   90deg ) translateZ( 50px );
        }
        #cube .bottom
        {
            -webkit-transform: rotateX(  -90deg ) translateZ( 50px );
            -moz-transform: rotateX(  -90deg ) translateZ( 50px );
            -o-transform: rotateX(  -90deg ) translateZ( 50px );
            transform: rotateX(  -90deg ) translateZ( 50px );
        }
        #cube.show-front
        {
            -webkit-transform: translateZ( -50px );
            -moz-transform: translateZ( -50px );
            -o-transform: translateZ( -50px );
            transform: translateZ( -50px );
        }
        #cube.show-back
        {
            -webkit-transform: translateZ( -50px ) rotateX( -180deg );
            -moz-transform: translateZ( -50px ) rotateX( -180deg );
            -o-transform: translateZ( -50px ) rotateX( -180deg );
            transform: translateZ( -50px ) rotateX( -180deg );
        }
        #cube.show-right
        {
            -webkit-transform: translateZ( -50px ) rotateY(  -90deg );
            -moz-transform: translateZ( -50px ) rotateY(  -90deg );
            -o-transform: translateZ( -50px ) rotateY(  -90deg );
            transform: translateZ( -50px ) rotateY(  -90deg );
        }
        #cube.show-left
        {
            -webkit-transform: translateZ( -50px ) rotateY(   90deg );
            -moz-transform: translateZ( -50px ) rotateY(   90deg );
            -o-transform: translateZ( -50px ) rotateY(   90deg );
            transform: translateZ( -50px ) rotateY(   90deg );
        }
        #cube.show-top
        {
            -webkit-transform: translateZ( -50px ) rotateX(  -90deg );
            -moz-transform: translateZ( -50px ) rotateX(  -90deg );
            -o-transform: translateZ( -50px ) rotateX(  -90deg );
            transform: translateZ( -50px ) rotateX(  -90deg );
        }
        #cube.show-bottom
        {
            -webkit-transform: translateZ( -50px ) rotateX(   90deg );
            -moz-transform: translateZ( -50px ) rotateX(   90deg );
            -o-transform: translateZ( -50px ) rotateX(   90deg );
            transform: translateZ( -50px ) rotateX(   90deg );
        }
        #cube2
        {
            width: 100%;
            height: 100%;
            position: absolute;
            -webkit-transform-style: preserve-3d;
            -moz-transform-style: preserve-3d;
            -o-transform-style: preserve-3d;
            transform-style: preserve-3d;
            -webkit-transition: -webkit-transform 1s;
            -moz-transition: -moz-transform 1s;
            -o-transition: -o-transform 1s;
            transition: transform 1s;
        }
        #cube2 figure
        {
            display: block;
            position: absolute;
            width: 96px;
            height: 96px;
            border: 2px solid black;
            line-height: 96px;
            font-size: 100px;
            font-weight: bold;
            color: white;
            text-align: center;
        }
        #cube2.panels-backface-invisible figure
        {
            -webkit-backface-visibility: hidden;
            -moz-backface-visibility: hidden;
            -o-backface-visibility: hidden;
            backface-visibility: hidden;
        }
        #cube2 .front
        {
            background: hsla(   0, 100%, 50%, 0.7 );
        }
        #cube2 .back
        {
            background: hsla(  60, 100%, 50%, 0.7 );
        }
        #cube2 .right
        {
            background: hsla( 120, 100%, 50%, 0.7 );
        }
        #cube2 .left
        {
            background: hsla( 180, 100%, 50%, 0.7 );
        }
        #cube2 .top
        {
            background: hsla( 240, 100%, 50%, 0.7 );
        }
        #cube2 .bottom
        {
            background: hsla( 300, 100%, 50%, 0.7 );
        }
        #cube2 .front
        {
            -webkit-transform: translateZ( 50px );
            -moz-transform: translateZ( 50px );
            -o-transform: translateZ( 50px );
            transform: translateZ( 50px );
        }
        #cube2 .back
        {
            -webkit-transform: rotateX( -180deg ) translateZ( 50px );
            -moz-transform: rotateX( -180deg ) translateZ( 50px );
            -o-transform: rotateX( -180deg ) translateZ( 50px );
            transform: rotateX( -180deg ) translateZ( 50px );
        }
        #cube2 .right
        {
            -webkit-transform: rotateY(   90deg ) translateZ( 50px );
            -moz-transform: rotateY(   90deg ) translateZ( 50px );
            -o-transform: rotateY(   90deg ) translateZ( 50px );
            transform: rotateY(   90deg ) translateZ( 50px );
        }
        #cube2 .left
        {
            -webkit-transform: rotateY(  -90deg ) translateZ( 50px );
            -moz-transform: rotateY(  -90deg ) translateZ( 50px );
            -o-transform: rotateY(  -90deg ) translateZ( 50px );
            transform: rotateY(  -90deg ) translateZ( 50px );
        }
        #cube2 .top
        {
            -webkit-transform: rotateX(   90deg ) translateZ( 50px );
            -moz-transform: rotateX(   90deg ) translateZ( 50px );
            -o-transform: rotateX(   90deg ) translateZ( 50px );
            transform: rotateX(   90deg ) translateZ( 50px );
        }
        #cube2 .bottom
        {
            -webkit-transform: rotateX(  -90deg ) translateZ( 50px );
            -moz-transform: rotateX(  -90deg ) translateZ( 50px );
            -o-transform: rotateX(  -90deg ) translateZ( 50px );
            transform: rotateX(  -90deg ) translateZ( 50px );
        }
        #cube2.show-front
        {
            -webkit-transform: translateZ( -50px );
            -moz-transform: translateZ( -50px );
            -o-transform: translateZ( -50px );
            transform: translateZ( -50px );
        }
        #cube2.show-back
        {
            -webkit-transform: translateZ( -50px ) rotateX( -180deg );
            -moz-transform: translateZ( -50px ) rotateX( -180deg );
            -o-transform: translateZ( -50px ) rotateX( -180deg );
            transform: translateZ( -50px ) rotateX( -180deg );
        }
        #cube2.show-right
        {
            -webkit-transform: translateZ( -50px ) rotateY(  -90deg );
            -moz-transform: translateZ( -50px ) rotateY(  -90deg );
            -o-transform: translateZ( -50px ) rotateY(  -90deg );
            transform: translateZ( -50px ) rotateY(  -90deg );
        }
        #cube2.show-left
        {
            -webkit-transform: translateZ( -50px ) rotateY(   90deg );
            -moz-transform: translateZ( -50px ) rotateY(   90deg );
            -o-transform: translateZ( -50px ) rotateY(   90deg );
            transform: translateZ( -50px ) rotateY(   90deg );
        }
        #cube2.show-top
        {
            -webkit-transform: translateZ( -50px ) rotateX(  -90deg );
            -moz-transform: translateZ( -50px ) rotateX(  -90deg );
            -o-transform: translateZ( -50px ) rotateX(  -90deg );
            transform: translateZ( -50px ) rotateX(  -90deg );
        }
        #cube2.show-bottom
        {
            -webkit-transform: translateZ( -50px ) rotateX(   90deg );
            -moz-transform: translateZ( -50px ) rotateX(   90deg );
            -o-transform: translateZ( -50px ) rotateX(   90deg );
            transform: translateZ( -50px ) rotateX(   90deg );
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table class="monopolyTable">
            <caption style="font-size: 15px;">
                <b>Monopoly game board layout</b>
            </caption>
            <tbody>
                <tr style="text-align: center; height: 75px;">
                    <td rowspan="13">
                        <div id="playerContainer" class="PlayerContainer">
                            PLAYERS INFO
                        </div>
                    </td>
                    <td colspan="2" rowspan="2" style="width: 100px;">
                        <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;"
                            title="Free Parking">Free Parking</a>
                    </td>
                    <td style="width: 100px;">
                        <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;"
                            title="Kentucky Avenue">Kentucky Avenue</a>
                        <br />
                        ($220)
                    </td>
                    <td rowspan="2" style="width: 100px;">
                        <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;"
                            title="Chance">Chance</a>
                    </td>
                    <td style="width: 100px;">
                        <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;"
                            title="Indiana Avenue">Indiana Avenue</a><br>
                        ($220)
                    </td>
                    <td style="width: 100px;">
                        <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;"
                            title="Illinois Avenue">Illinois Avenue</a><br>
                        ($240)
                    </td>
                    <td rowspan="2" style="width: 100px;">
                        <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;"
                            title="B. &amp; O. Railroad">B. &amp; O. Railroad</a><br>
                        ($200)
                    </td>
                    <td style="width: 100px;">
                        <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;"
                            title="Atlantic Avenue">Atlantic Avenue</a> ($260)
                    </td>
                    <td style="width: 100px;">
                        <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;"
                            title="Ventnor Avenue">Ventnor Avenue</a>($260)
                    </td>
                    <td rowspan="2" style="width: 100px;">
                        <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;"
                            title="Water Works">Water Works</a><br>
                        ($150)
                    </td>
                    <td style="width: 100px;">
                        <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;"
                            title="Marvin Gardens">Marvin Gardens</a><br>
                        ($280)
                    </td>
                    <td colspan="2" rowspan="2" style="width: 100px;">
                        Go To Jail
                    </td>
                    <td rowspan="3" style="vertical-align: top">
                        <div id="bankContainerID" class="BankContainer">
                            BANK INFO
                        </div>
                        <uc:BankInfo ID="bankInfo" runat="server" width="300px" />
                    </td>
                </tr>
                <tr style="text-align: center; height: 25px;">
                    <td bgcolor="#ff0000">
                        1 hotel
                    </td>
                    <td bgcolor="#ff0000">
                        4 house
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
                <tr style="text-align: center; height: 75px;">
                    <td>
                        <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;"
                            title="New York Avenue">New York Avenue</a>
                        <br>
                        ($200)
                    </td>
                    <td bgcolor="#ff8000" style="width: 20px;">
                    </td>
                    <th colspan="9" rowspan="8" style="text-align: center; vertical-align: middle; font-size: 50px;">
                        <img src="images/monop.gif" style="vertical-align: top;" />
                        <br />
                        <section class="container">
                            <div id="cube" class="show-front" runat="server">
                              <figure class="front">1</figure>
                              <figure class="back">2</figure>
                              <figure class="right">3</figure>
                              <figure class="left">4</figure>
                              <figure class="top">5</figure>
                              <figure class="bottom">6</figure>
                            </div>
                        </section>
                        <section class="container">
                            <div id="cube2" class="show-front" runat="server">
                              <figure class="front">1</figure>
                              <figure class="back">2</figure>
                              <figure class="right">3</figure>
                              <figure class="left">4</figure>
                              <figure class="top">5</figure>
                              <figure class="bottom">6</figure>
                            </div>
                        </section>
                    </th>
                    <td bgcolor="#338033" style="width: 20px;">
                    </td>
                    <td>
                        <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;"
                            title="Pacific Avenue">Pacific Avenue</a>
                        <br>
                        ($300)
                    </td>
                </tr>
                <tr style="text-align: center; height: 75px;">
                    <td>
                        <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;"
                            title="Tennessee Avenue">Tennessee Avenue</a><br>
                        ($180)
                    </td>
                    <td bgcolor="#ff8000">
                    </td>
                    <td bgcolor="#338033">
                    </td>
                    <td>
                        <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;"
                            title="North Carolina Avenue">North Carolina Avenue</a>
                        <br>
                        ($300)
                    </td>
                    <td rowspan="3">
                        <div id="operationsContainer" class="OperationsContainer">
                            OPERATIONS
                            <br />
                            <br />
                            <asp:Button ID="btnBuild" runat="server" Text="BUILD" BackColor="#9999FF" BorderColor="#CCFFFF"
                                Font-Bold="True" Font-Size="Medium" ForeColor="White" Height="60px" Width="150px" />
                            <asp:Button ID="btnSell" runat="server" Text="SELL" Width="150px" BackColor="#9999FF"
                                BorderColor="#CCCCFF" Font-Bold="True" Font-Size="Medium" ForeColor="White" Height="60px" />
                        </div>
                    </td>
                </tr>
                <tr style="text-align: center; height: 75px;">
                    <td colspan="2">
                        <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;"
                            title="Community Chest">Community Chest</a>
                    </td>
                    <td colspan="2">
                        <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;"
                            title="Community Chest">Community Chest</a>
                    </td>
                </tr>
                <tr style="text-align: center; height: 75px;">
                    <td>
                        <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;"
                            title="St. James Place">St. James Place</a>
                        <br>
                        ($180)
                    </td>
                    <td bgcolor="#ff8000">
                    </td>
                    <td bgcolor="#338033">
                    </td>
                    <td>
                        <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;"
                            title="Pennsylvania Avenue">Pennsylvania Avenue</a>
                        <br>
                        ($320)
                    </td>
                </tr>
                <tr style="text-align: center; height: 75px;">
                    <td colspan="2">
                        <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;"
                            title="Pennsylvania Railroad">Pennsylvania Railroad</a>
                        <br>
                        ($200)
                    </td>
                    <td colspan="2">
                        <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;"
                            title="Short Line">Short Line</a>
                        <br>
                        ($200)
                    </td>
                    <td rowspan="7">
                        <div id="logContainer" class="LogContainer">
                            <label id="logTitle" class="logTitle">
                                HISTORY</label>
                            <br />
                            <asp:ListBox ID="lbLogs" class="lbLogs" runat="server"></asp:ListBox>
                        </div>
                    </td>
                </tr>
                <tr style="text-align: center; height: 75px;">
                    <td>
                        <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;"
                            title="Virginia Avenue">Virginia Avenue</a>
                        <br>
                        ($160)
                    </td>
                    <td bgcolor="#F660AB">
                    </td>
                    <td colspan="2">
                        <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;"
                            title="Chance">Chance</a>
                    </td>
                </tr>
                <tr style="text-align: center; height: 75px;">
                    <td>
                        <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;"
                            title="States Avenue">States Avenue</a>
                        <br>
                        ($140)
                    </td>
                    <td bgcolor="#F660AB">
                    </td>
                    <td bgcolor="#803399">
                        &nbsp;;
                    </td>
                    <td>
                        <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;"
                            title="Park Place">Park Place</a>
                        <br>
                        ($350)
                    </td>
                </tr>
                <tr style="text-align: center; height: 75px;">
                    <td colspan="2">
                        <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;"
                            title="Electric Company">Electric Company</a>
                        <br>
                        ($150)
                    </td>
                    <td colspan="2">
                        <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;"
                            title="Luxury Tax">Luxury Tax</a>
                        <br>
                        (Pay $75)
                    </td>
                </tr>
                <tr style="text-align: center; height: 75px;">
                    <td>
                        <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;"
                            title="St. Charles Place">St. Charles Place</a>
                        <br>
                        ($140)
                    </td>
                    <td bgcolor="#F660AB">
                    </td>
                    <th colspan="9" rowspan="1" style="text-align: center; vertical-align: middle;">
                        <div id="rollDiceContainer">
                            <asp:Button ID="btnRollDice" runat="server" OnClick="btnRollDice_Click" Text="Roll Dice"
                                BackColor="#9999FF" BorderColor="#CCFFFF" Font-Bold="True" Font-Size="Medium"
                                ForeColor="White" Height="60px" Width="150px" />
                            <asp:Button ID="btnFinishTurn" runat="server" OnClick="btnFinishTurn_Click" Text="Finish Turn"
                                Visible="False" Width="150px" BackColor="#9999FF" BorderColor="#CCCCFF" Font-Bold="True"
                                Font-Size="Medium" ForeColor="White" Height="60px" />
                        </div>
                    </th>
                    <td bgcolor="#803399">
                    </td>
                    <td>
                        <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;"
                            title="Boardwalk">Boardwalk</a>
                        <br>
                        ($400)
                    </td>
                </tr>
                <tr style="text-align: center;">
                    <td colspan="2" rowspan="2">
                        Jail/Just Visiting
                    </td>
                    <td bgcolor="#80ccff">
                    </td>
                    <td bgcolor="#80ccff">
                    </td>
                    <td rowspan="2">
                        <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;"
                            title="Chance">Chance</a>
                    </td>
                    <td bgcolor="#80ccff">
                    </td>
                    <td rowspan="2">
                        <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;"
                            title="Reading Railroad">Reading Railroad</a>
                        <br>
                        ($200)
                    </td>
                    <td rowspan="2">
                        <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;"
                            title="Income Tax">Income Tax</a>
                        <br>
                        (Pay 10% or $200)
                    </td>
                    <td bgcolor="#6F4E37">
                    </td>
                    <td rowspan="2">
                        <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;"
                            title="Community Chest">Community Chest</a>
                    </td>
                    <td bgcolor="#6F4E37">
                    </td>
                    <td colspan="2" rowspan="2">
                        <img id="dad" src="icons/Indian.png" runat="server" />
                        GO
                        <br>
                        Collect $200 salary<br>
                    </td>
                </tr>
                <tr style="text-align: center; height: 75px;">
                    <td>
                        <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;"
                            title="Connecticut Avenue">Connecticut Avenue</a>
                        <br>
                        ($120)
                    </td>
                    <td>
                        <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;"
                            title="Vermont Avenue">Vermont Avenue</a>
                        <br>
                        ($100)
                    </td>
                    <td>
                        <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;"
                            title="Oriental Avenue">Oriental Avenue</a>
                        <br>
                        ($100)
                    </td>
                    <td>
                        <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;"
                            title="Baltic Avenue">Baltic Avenue</a>
                        <br>
                        ($60)
                    </td>
                    <td>
                        <a href="" onclick="window.open('items.aspx', 'ITEMS', 'width=340, height=300'); return false;"
                            title="Mediterranean Avenue">Mediterranean Avenue</a>
                        <br>
                        ($60)
                    </td>
                </tr>
            </tbody>
        </table>
    </div>
    </form>
</body>
</html>
