<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Monopoly.aspx.cs" Inherits="Monopoly._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Monopoly Game</title>
    
  <script src="/js/utils.js"></script>
  <script src="/js/rotate-box.js"></script>
  <style media="screen">
	figure {
	  margin: 0;
	}
    .container {
      width: 200px;
      height: 200px;
      position: relative;
      float:left;
      margin: auto 40px;
      border: 1px solid #CCC;
      -webkit-perspective: 1000px;
         -moz-perspective: 1000px;
           -o-perspective: 1000px;
              perspective: 1000px;
    }

    #cube {
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

    #cube figure {
      display: block;
      position: absolute;
      width: 196px;
      height: 196px;
      border: 2px solid black;
      line-height: 196px;
      font-size: 120px;
      font-weight: bold;
      color: white;
      text-align: center;
    }

    #cube.panels-backface-invisible figure {
      -webkit-backface-visibility: hidden;
         -moz-backface-visibility: hidden;
           -o-backface-visibility: hidden;
              backface-visibility: hidden;
    }

    #cube .front  { background: hsla(   0, 100%, 50%, 0.7 ); }
    #cube .back   { background: hsla(  60, 100%, 50%, 0.7 ); }
    #cube .right  { background: hsla( 120, 100%, 50%, 0.7 ); }
    #cube .left   { background: hsla( 180, 100%, 50%, 0.7 ); }
    #cube .top    { background: hsla( 240, 100%, 50%, 0.7 ); }
    #cube .bottom { background: hsla( 300, 100%, 50%, 0.7 ); }

    #cube .front  {
      -webkit-transform: translateZ( 100px );
         -moz-transform: translateZ( 100px );
           -o-transform: translateZ( 100px );
              transform: translateZ( 100px );
    }
    #cube .back   {
      -webkit-transform: rotateX( -180deg ) translateZ( 100px );
         -moz-transform: rotateX( -180deg ) translateZ( 100px );
           -o-transform: rotateX( -180deg ) translateZ( 100px );
              transform: rotateX( -180deg ) translateZ( 100px );
    }
    #cube .right {
      -webkit-transform: rotateY(   90deg ) translateZ( 100px );
         -moz-transform: rotateY(   90deg ) translateZ( 100px );
           -o-transform: rotateY(   90deg ) translateZ( 100px );
              transform: rotateY(   90deg ) translateZ( 100px );
    }
    #cube .left {
      -webkit-transform: rotateY(  -90deg ) translateZ( 100px );
         -moz-transform: rotateY(  -90deg ) translateZ( 100px );
           -o-transform: rotateY(  -90deg ) translateZ( 100px );
              transform: rotateY(  -90deg ) translateZ( 100px );
    }
    #cube .top {
      -webkit-transform: rotateX(   90deg ) translateZ( 100px );
         -moz-transform: rotateX(   90deg ) translateZ( 100px );
           -o-transform: rotateX(   90deg ) translateZ( 100px );
              transform: rotateX(   90deg ) translateZ( 100px );
    }
    #cube .bottom {
      -webkit-transform: rotateX(  -90deg ) translateZ( 100px );
         -moz-transform: rotateX(  -90deg ) translateZ( 100px );
           -o-transform: rotateX(  -90deg ) translateZ( 100px );
              transform: rotateX(  -90deg ) translateZ( 100px );
    }

    #cube.show-front {
      -webkit-transform: translateZ( -100px );
         -moz-transform: translateZ( -100px );
           -o-transform: translateZ( -100px );
              transform: translateZ( -100px );
    }
    #cube.show-back {
      -webkit-transform: translateZ( -100px ) rotateX( -180deg );
         -moz-transform: translateZ( -100px ) rotateX( -180deg );
           -o-transform: translateZ( -100px ) rotateX( -180deg );
              transform: translateZ( -100px ) rotateX( -180deg );
    }
    #cube.show-right {
      -webkit-transform: translateZ( -100px ) rotateY(  -90deg );
         -moz-transform: translateZ( -100px ) rotateY(  -90deg );
           -o-transform: translateZ( -100px ) rotateY(  -90deg );
              transform: translateZ( -100px ) rotateY(  -90deg );
    }
    #cube.show-left {
      -webkit-transform: translateZ( -100px ) rotateY(   90deg );
         -moz-transform: translateZ( -100px ) rotateY(   90deg );
           -o-transform: translateZ( -100px ) rotateY(   90deg );
              transform: translateZ( -100px ) rotateY(   90deg );
    }
    #cube.show-top {
      -webkit-transform: translateZ( -100px ) rotateX(  -90deg );
         -moz-transform: translateZ( -100px ) rotateX(  -90deg );
           -o-transform: translateZ( -100px ) rotateX(  -90deg );
              transform: translateZ( -100px ) rotateX(  -90deg );
    }
    #cube.show-bottom {
      -webkit-transform: translateZ( -100px ) rotateX(   90deg );
         -moz-transform: translateZ( -100px ) rotateX(   90deg );
           -o-transform: translateZ( -100px ) rotateX(   90deg );
              transform: translateZ( -100px ) rotateX(   90deg );
    }

	
	<!-- CUBE 2-->
	.container2 {
      width: 200px;
      height: 200px;
      position: relative;
      margin: 0 auto 40px;
      border: 1px solid #CCC;
      -webkit-perspective: 1000px;
         -moz-perspective: 1000px;
           -o-perspective: 1000px;
              perspective: 1000px;
    }
	
	#cube2 {
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

    #cube2 figure {
      display: block;
      position: absolute;
      width: 196px;
      height: 196px;
      border: 2px solid black;
      line-height: 196px;
      font-size: 120px;
      font-weight: bold;
      color: white;
      text-align: center;
    }

    #cube2.panels-backface-invisible figure {
      -webkit-backface-visibility: hidden;
         -moz-backface-visibility: hidden;
           -o-backface-visibility: hidden;
              backface-visibility: hidden;
    }

    #cube2 .front  { background: hsla(   0, 100%, 50%, 0.7 ); }
    #cube2 .back   { background: hsla(  60, 100%, 50%, 0.7 ); }
    #cube2 .right  { background: hsla( 120, 100%, 50%, 0.7 ); }
    #cube2 .left   { background: hsla( 180, 100%, 50%, 0.7 ); }
    #cube2 .top    { background: hsla( 240, 100%, 50%, 0.7 ); }
    #cube2 .bottom { background: hsla( 300, 100%, 50%, 0.7 ); }

    #cube2 .front  {
      -webkit-transform: translateZ( 100px );
         -moz-transform: translateZ( 100px );
           -o-transform: translateZ( 100px );
              transform: translateZ( 100px );
    }
    #cube2 .back   {
      -webkit-transform: rotateX( -180deg ) translateZ( 100px );
         -moz-transform: rotateX( -180deg ) translateZ( 100px );
           -o-transform: rotateX( -180deg ) translateZ( 100px );
              transform: rotateX( -180deg ) translateZ( 100px );
    }
    #cube2 .right {
      -webkit-transform: rotateY(   90deg ) translateZ( 100px );
         -moz-transform: rotateY(   90deg ) translateZ( 100px );
           -o-transform: rotateY(   90deg ) translateZ( 100px );
              transform: rotateY(   90deg ) translateZ( 100px );
    }
    #cube2 .left {
      -webkit-transform: rotateY(  -90deg ) translateZ( 100px );
         -moz-transform: rotateY(  -90deg ) translateZ( 100px );
           -o-transform: rotateY(  -90deg ) translateZ( 100px );
              transform: rotateY(  -90deg ) translateZ( 100px );
    }
    #cube2 .top {
      -webkit-transform: rotateX(   90deg ) translateZ( 100px );
         -moz-transform: rotateX(   90deg ) translateZ( 100px );
           -o-transform: rotateX(   90deg ) translateZ( 100px );
              transform: rotateX(   90deg ) translateZ( 100px );
    }
    #cube2 .bottom {
      -webkit-transform: rotateX(  -90deg ) translateZ( 100px );
         -moz-transform: rotateX(  -90deg ) translateZ( 100px );
           -o-transform: rotateX(  -90deg ) translateZ( 100px );
              transform: rotateX(  -90deg ) translateZ( 100px );
    }

    #cube2.show-front {
      -webkit-transform: translateZ( -100px );
         -moz-transform: translateZ( -100px );
           -o-transform: translateZ( -100px );
              transform: translateZ( -100px );
    }
    #cube2.show-back {
      -webkit-transform: translateZ( -100px ) rotateX( -180deg );
         -moz-transform: translateZ( -100px ) rotateX( -180deg );
           -o-transform: translateZ( -100px ) rotateX( -180deg );
              transform: translateZ( -100px ) rotateX( -180deg );
    }
    #cube2.show-right {
      -webkit-transform: translateZ( -100px ) rotateY(  -90deg );
         -moz-transform: translateZ( -100px ) rotateY(  -90deg );
           -o-transform: translateZ( -100px ) rotateY(  -90deg );
              transform: translateZ( -100px ) rotateY(  -90deg );
    }
    #cube2.show-left {
      -webkit-transform: translateZ( -100px ) rotateY(   90deg );
         -moz-transform: translateZ( -100px ) rotateY(   90deg );
           -o-transform: translateZ( -100px ) rotateY(   90deg );
              transform: translateZ( -100px ) rotateY(   90deg );
    }
    #cube2.show-top {
      -webkit-transform: translateZ( -100px ) rotateX(  -90deg );
         -moz-transform: translateZ( -100px ) rotateX(  -90deg );
           -o-transform: translateZ( -100px ) rotateX(  -90deg );
              transform: translateZ( -100px ) rotateX(  -90deg );
    }
    #cube2.show-bottom {
      -webkit-transform: translateZ( -100px ) rotateX(   90deg );
         -moz-transform: translateZ( -100px ) rotateX(   90deg );
           -o-transform: translateZ( -100px ) rotateX(   90deg );
              transform: translateZ( -100px ) rotateX(   90deg );
    }
  </style>
</head>
<body>
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
  <section class="container">
    <div id="cube" class="show-front">
      <figure class="front">1</figure>
      <figure class="back">2</figure>
      <figure class="right">3</figure>
      <figure class="left">4</figure>
      <figure class="top">5</figure>
      <figure class="bottom">6</figure>
    </div>
  </section>
  
    <section class="container">
    <div id="cube2" class="show-front">
      <figure class="front">1</figure>
      <figure class="back">2</figure>
      <figure class="right">3</figure>
      <figure class="left">4</figure>
      <figure class="top">5</figure>
      <figure class="bottom">6</figure>
    </div>
  </section>
    <section id="options">

    <p id="show-buttons">
      <button class="show-front">Show 1</button>
      <button class="show-back">Show 2</button>
      <button class="show-right">Show 3</button>
      <button class="show-left">Show 4</button>
      <button class="show-top">Show 5</button>
      <button class="show-bottom">Show 6</button>
    </p>

  </section>
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
</body>
</html>
