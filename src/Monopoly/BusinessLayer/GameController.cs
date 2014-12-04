using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    class GameController
    {

        #region Constants

        #region Brown
        private const string brown1_name = "Mediterranean Avenue";
        private const int brown1_rentPrice = 2;
        private const int brown1_1housePrice = 10;
        private const int brown1_2housePrice = 30;
        private const int brown1_3housePrice = 90;
        private const int brown1_4housePrice = 160;
        private const int brown1_hotelPrice = 250;
        private const int brown1_mortgagePrice = 30;
        private const int brown1_perHouseCost = 50;
        private const int brown1_perHotelCost = 200;

        private const string brown2_name = "Baltic Avenue";
        private const int brown2_rentPrice = 4;
        private const int brown2_1housePrice = 20;
        private const int brown2_2housePrice = 60;
        private const int brown2_3housePrice = 180;
        private const int brown2_4housePrice = 320;
        private const int brown2_hotelPrice = 450;
        private const int brown2_mortgagePrice = 30;
        private const int brown2_perHouseCost = 50;
        private const int brown2_perHotelCost = 200;
        #endregion

        #region Blue

        private const string blue1_name = "Oriental Avenue";
        private const int blue1_rentPrice = 6;
        private const int blue1_1housePrice = 30;
        private const int blue1_2housePrice = 90;
        private const int blue1_3housePrice = 270;
        private const int blue1_4housePrice = 400;
        private const int blue1_hotelPrice = 550;
        private const int blue1_mortgagePrice = 50;
        private const int blue1_perHouseCost = 50;
        private const int blue1_perHotelCost = 200;

        private const string blue2_name = "Vermont Avenue";
        private const int blue2_rentPrice = 6;
        private const int blue2_1housePrice = 30;
        private const int blue2_2housePrice = 90;
        private const int blue2_3housePrice = 270;
        private const int blue2_4housePrice = 400;
        private const int blue2_hotelPrice = 550;
        private const int blue2_mortgagePrice = 50;
        private const int blue2_perHouseCost = 50;
        private const int blue2_perHotelCost = 200;

        private const string blue3_name = "Connecticut Avenue";
        private const int blue3_rentPrice = 8;
        private const int blue3_1housePrice = 40;
        private const int blue3_2housePrice = 100;
        private const int blue3_3housePrice = 300;
        private const int blue3_4housePrice = 450;
        private const int blue3_hotelPrice = 600;
        private const int blue3_mortgagePrice = 60;
        private const int blue3_perHouseCost = 50;
        private const int blue3_perHotelCost = 200;
        #endregion

        #region Pink

        private const string pink1_name = "St. Charles Place";
        private const int pink1_rentPrice = 10;
        private const int pink1_1housePrice = 50;
        private const int pink1_2housePrice = 150;
        private const int pink1_3housePrice = 450;
        private const int pink1_4housePrice = 625;
        private const int pink1_hotelPrice = 750;
        private const int pink1_mortgagePrice = 70;
        private const int pink1_perHouseCost = 100;
        private const int pink1_perHotelCost = 400;

        private const string pink2_name = "States Avenue";
        private const int pink2_rentPrice = 10;
        private const int pink2_1housePrice = 50;
        private const int pink2_2housePrice = 150;
        private const int pink2_3housePrice = 450;
        private const int pink2_4housePrice = 625;
        private const int pink2_hotelPrice = 750;
        private const int pink2_mortgagePrice = 70;
        private const int pink2_perHouseCost = 100;
        private const int pink2_perHotelCost = 400;

        private const string pink3_name = "Virginia Avenue";
        private const int pink3_rentPrice = 12;
        private const int pink3_1housePrice = 60;
        private const int pink3_2housePrice = 180;
        private const int pink3_3housePrice = 500;
        private const int pink3_4housePrice = 700;
        private const int pink3_hotelPrice = 900;
        private const int pink3_mortgagePrice = 80;
        private const int pink3_perHouseCost = 100;
        private const int pink3_perHotelCost = 400;
        #endregion

        #region Orange

        private const string orange1_name = "St. James Place";
        private const int orange1_rentPrice = 14;
        private const int orange1_1housePrice = 70;
        private const int orange1_2housePrice = 200;
        private const int orange1_3housePrice = 550;
        private const int orange1_4housePrice = 750;
        private const int orange1_hotelPrice = 950;
        private const int orange1_mortgagePrice = 90;
        private const int orange1_perHouseCost = 100;
        private const int orange1_perHotelCost = 400;

        private const string orange2_name = "Tennessee Avenue";
        private const int orange2_rentPrice = 14;
        private const int orange2_1housePrice = 70;
        private const int orange2_2housePrice = 200;
        private const int orange2_3housePrice = 550;
        private const int orange2_4housePrice = 750;
        private const int orange2_hotelPrice = 950;
        private const int orange2_mortgagePrice = 90;
        private const int orange2_perHouseCost = 100;
        private const int orange2_perHotelCost = 400;

        private const string orange3_name = "New York Avenue";
        private const int orange3_rentPrice = 16;
        private const int orange3_1housePrice = 80;
        private const int orange3_2housePrice = 220;
        private const int orange3_3housePrice = 600;
        private const int orange3_4housePrice = 800;
        private const int orange3_hotelPrice = 1000;
        private const int orange3_mortgagePrice = 100;
        private const int orange3_perHouseCost = 100;
        private const int orange3_perHotelCost = 400;
        #endregion

        #region Red

        private const string red1_name = "Kentucky Avenue";
        private const int red1_rentPrice = 18;
        private const int red1_1housePrice = 90;
        private const int red1_2housePrice = 250;
        private const int red1_3housePrice = 700;
        private const int red1_4housePrice = 875;
        private const int red1_hotelPrice = 1050;
        private const int red1_mortgagePrice = 110;
        private const int red1_perHouseCost = 150;
        private const int red1_perHotelCost = 600;

        private const string red2_name = "Indiana Avenue";
        private const int red2_rentPrice = 18;
        private const int red2_1housePrice = 90;
        private const int red2_2housePrice = 250;
        private const int red2_3housePrice = 700;
        private const int red2_4housePrice = 875;
        private const int red2_hotelPrice = 1050;
        private const int red2_mortgagePrice = 110;
        private const int red2_perHouseCost = 150;
        private const int red2_perHotelCost = 600;

        private const string red3_name = "Illinois Avenue";
        private const int red3_rentPrice = 20;
        private const int red3_1housePrice = 100;
        private const int red3_2housePrice = 300;
        private const int red3_3housePrice = 750;
        private const int red3_4housePrice = 925;
        private const int red3_hotelPrice = 1100;
        private const int red3_mortgagePrice = 120;
        private const int red3_perHouseCost = 150;
        private const int red3_perHotelCost = 600;
        #endregion

        #region Yellow

        private const string yellow1_name = "Atlantic Avenue";
        private const int yellow1_rentPrice = 22;
        private const int yellow1_1housePrice = 110;
        private const int yellow1_2housePrice = 330;
        private const int yellow1_3housePrice = 800;
        private const int yellow1_4housePrice = 975;
        private const int yellow1_hotelPrice = 1150;
        private const int yellow1_mortgagePrice = 130;
        private const int yellow1_perHouseCost = 150;
        private const int yellow1_perHotelCost = 600;

        private const string yellow2_name = "Ventnor Avenue";
        private const int yellow2_rentPrice = 22;
        private const int yellow2_1housePrice = 110;
        private const int yellow2_2housePrice = 330;
        private const int yellow2_3housePrice = 800;
        private const int yellow2_4housePrice = 975;
        private const int yellow2_hotelPrice = 1150;
        private const int yellow2_mortgagePrice = 130;
        private const int yellow2_perHouseCost = 150;
        private const int yellow2_perHotelCost = 600;

        private const string yellow3_name = "Marvin Gardens";
        private const int yellow3_rentPrice = 24;
        private const int yellow3_1housePrice = 120;
        private const int yellow3_2housePrice = 360;
        private const int yellow3_3housePrice = 850;
        private const int yellow3_4housePrice = 1025;
        private const int yellow3_hotelPrice = 1200;
        private const int yellow3_mortgagePrice = 140;
        private const int yellow3_perHouseCost = 150;
        private const int yellow3_perHotelCost = 600;
        #endregion

        #region Green

        private const string green1_name = "Pacific Avenue";
        private const int green1_rentPrice = 26;
        private const int green1_1housePrice = 130;
        private const int green1_2housePrice = 390;
        private const int green1_3housePrice = 900;
        private const int green1_4housePrice = 1100;
        private const int green1_hotelPrice = 1275;
        private const int green1_mortgagePrice = 150;
        private const int green1_perHouseCost = 200;
        private const int green1_perHotelCost = 800;

        private const string green2_name = "North Carolina Avenue";
        private const int green2_rentPrice = 26;
        private const int green2_1housePrice = 130;
        private const int green2_2housePrice = 390;
        private const int green2_3housePrice = 900;
        private const int green2_4housePrice = 1100;
        private const int green2_hotelPrice = 1275;
        private const int green2_mortgagePrice = 150;
        private const int green2_perHouseCost = 200;
        private const int green2_perHotelCost = 800;

        private const string green3_name = "Pennsylvania Avenue";
        private const int green3_rentPrice = 28;
        private const int green3_1housePrice = 150;
        private const int green3_2housePrice = 450;
        private const int green3_3housePrice = 1000;
        private const int green3_4housePrice = 1200;
        private const int green3_hotelPrice = 1400;
        private const int green3_mortgagePrice = 160;
        private const int green3_perHouseCost = 200;
        private const int green3_perHotelCost = 800;
        #endregion

        #region Purple

        private const string purple1_name = "Park Place";
        private const int purple1_rentPrice = 35;
        private const int purple1_1housePrice = 175;
        private const int purple1_2housePrice = 500;
        private const int purple1_3housePrice = 1100;
        private const int purple1_4housePrice = 1300;
        private const int purple1_hotelPrice = 1500;
        private const int purple1_mortgagePrice = 175;
        private const int purple1_perHouseCost = 200;
        private const int purple1_perHotelCost = 800;

        private const string purple2_name = "Boardwalk";
        private const int purple2_rentPrice = 50;
        private const int purple2_1housePrice = 200;
        private const int purple2_2housePrice = 600;
        private const int purple2_3housePrice = 1400;
        private const int purple2_4housePrice = 1700;
        private const int purple2_hotelPrice = 2000;
        private const int purple2_mortgagePrice = 200;
        private const int purple2_perHouseCost = 200;
        private const int purple2_perHotelCost = 800;
        #endregion

        #region Stations

        private const string railroad1_name = "Reading Railroad";
        private const string railroad2_name = "Pennsylvania Railroad";
        private const string railroad3_name = "B. & O. Railroad";
        private const string railroad4_name = "Short Line";
        private const int railroad_cost = 200;
        private const int railroad_rentPrice = 25;
        private const int railroad_mortgagePrice = 100;

        #endregion

        #region Utilities

        private const string utilities1_name = "Electric Company";
        private const string utilities1_name = "Water Works";
        private const int utilities_rentMultiplierWithDice = 2;
        private const int utilities_rentMultiplierAllWithDice = 10; // Owned all utilities
        private const int utilities_cost = 150;
        private const int utilities_mortgagePrice = 75;

        #endregion

        #region Communitiy Chest Cards
        private const string cchest1_cardLabel = "Advance to Go (Collect $200) ";
        private const string cchest2_cardLabel = "Bank error in your favor – collect $75 ";
        private const string cchest3_cardLabel = "Doctor's fees – Pay $50 ";
        private const string cchest4_cardLabel = "Get out of jail free – this card may be kept until needed, or sold ";
        private const string cchest5_cardLabel = "Go to jail – go directly to jail – Do not pass Go, do not collect $200 ";
        private const string cchest6_cardLabel = "It is your birthday Collect $10 from each player ";
        private const string cchest7_cardLabel = "Grand Opera Night – collect $50 from every player for opening night seats ";
        private const string cchest8_cardLabel = "Income Tax refund – collect $20 ";
        private const string cchest9_cardLabel = "Life Insurance Matures – collect $100 ";
        private const string cchest10_cardLabel = "Pay Hospital Fees of $100 ";
        private const string cchest11_cardLabel = "Pay School Fees of $50 ";
        private const string cchest12_cardLabel = "Receive $25 Consultancy Fee ";
        private const string cchest13_cardLabel = "You are assessed for street repairs – $40 per house, $115 per hotel ";
        private const string cchest14_cardLabel = "You have won second prize in a beauty contest– collect $10 ";
        private const string cchest15_cardLabel = "You inherit $100 ";
        private const string cchest16_cardLabel = "From sale of stock you get $50 ";
        private const string cchest17_cardLabel = "Holiday Fund matures - Receive $100 ";
        #endregion

        #region Chance Cards
        private const string chance1_cardLabel = "Advance to Go (Collect $200) ";
        private const string chance2_cardLabel = "Advance to Illinois Ave. ";
        private const string chance3_cardLabel = "Advance token to nearest Utility. If unowned, you may buy it from the Bank. If owned, throw dice and pay owner a total ten times the amount thrown. ";
        private const string chance4_cardLabel = "Advance token to the nearest Railroad and pay owner twice the rental to which he/she is otherwise entitled. If Railroad is unowned, you may buy it from the Bank. (There are two of these.) ";
        private const string chance5_cardLabel = "Advance to St. Charles Place – if you pass Go, collect $200 ";
        private const string chance6_cardLabel = "Bank pays you dividend of $50 ";
        private const string chance7_cardLabel = "Get out of Jail free – this card may be kept until needed, or traded/sold ";
        private const string chance8_cardLabel = "Go back 3 spaces ";
        private const string chance9_cardLabel = "Go directly to Jail – do not pass Go, do not collect $200 ";
        private const string chance10_cardLabel = "Make general repairs on all your property – for each house pay $25 – for each hotel $100 ";
        private const string chance11_cardLabel = "Pay poor tax of $15 ";
        private const string chance12_cardLabel = "Take a trip to Reading Railroad – if you pass Go collect $200 ";
        private const string chance13_cardLabel = "Take a walk on the Boardwalk – advance token to Boardwalk ";
        private const string chance14_cardLabel = "You have been elected chairman of the board – pay each player $50 ";
        private const string chance15_cardLabel = "Your building loan matures – collect $150 ";
        private const string chance16_cardLabel = "You have won a crossword competition - collect $100";
        #endregion


        #endregion

        private Bank bank;
        private List<Player> listPlayer;
        private List<Space> listSpace;
        private Board board;
        private Dice dice;
        private List<Symbol> listSymbol;
        private List<Card> listCard;
        private int maxCountPlayer;

        public GameController()
        {
            bank = new Bank();
            listPlayer = new List<Player>();
            listSpace = new List<Space>();
            //board = new Board();
            dice = new Dice();
            listSymbol = new List<Symbol>();
            listCard = new List<Card>();
        }

        public void init()
        {
            #region SAMPLE OBJECTS

            //ADD SYMBOL
            Symbol symbol = new Symbol("at");
            Symbol symbol2 = new Symbol("kopek");
            listSymbol.Add(symbol);
            listSymbol.Add(symbol2);
            //ADD PLAYER
            string playerName = "ahmet";
            int playerCash = 10000;
            Player p = new Player(playerName, playerCash, listSymbol[0]);
            listPlayer.Add(p);
            // ADD PROPERTY SPACE
            int prop_mortgageval = 500;
            string prop_name = "medeterinian";
            int prop_cellprice = 300;
            int prop_hotelcost = 200;
            int prop_housecost = 50;
            int prop_rentprice = 25;
            PropertyCellGroup prop_pCellGroup = new PropertyCellGroup(PropertyCellGroup.CellColor.Blue);
            PropertyCell prop_pcell = new PropertyCell(prop_pCellGroup, prop_mortgageval, prop_name, prop_cellprice, prop_hotelcost, prop_housecost, prop_rentprice);
            prop_pCellGroup.addCell(prop_pcell);
            PurchasableSpace prop_pSpace = new PurchasableSpace(prop_pcell);
            listSpace.Add(prop_pSpace);
            //ADD UTILITY SPACE
            int util_mortgageval = 400;
            string util_name = "electric";
            int util_cellprice = 230;
            int util_rentprice = 55;
            NonPropertyCellGroup util_npCellGroup = new NonPropertyCellGroup();
            UtilityCell util_npcell = new UtilityCell(util_npCellGroup, util_mortgageval, util_name, util_cellprice, util_rentprice);
            util_npCellGroup.addCell(util_npcell);
            PurchasableSpace util_Space = new PurchasableSpace(util_npcell);
            listSpace.Add(util_Space);
            //ADD RAILROAD SPACE
            int rail_mortgageval = 200;
            string rail_name = "railroad";
            int rail_cellprice = 250;
            int rail_rentprice = 45;
            NonPropertyCellGroup rail_npCellGroup = new NonPropertyCellGroup();
            RailroadCell rail_npcell = new RailroadCell(rail_npCellGroup, rail_mortgageval, rail_name, rail_cellprice, rail_rentprice);
            rail_npCellGroup.addCell(rail_npcell);
            PurchasableSpace rail_Space = new PurchasableSpace(rail_npcell);
            listSpace.Add(rail_Space);
            //ADD CHANCE CARD SPACE
            string chance_label = "chance gidi chance";
            ChanceCard chance_card = new ChanceCard(chance_label);
            CardSpace chance_cardSpace = new CardSpace(chance_card);
            listSpace.Add(chance_cardSpace);
            //ADD CCHEST CARD SPACE
            string chest_label = "chest gidi chest";
            CommunityChestCard chest_card = new CommunityChestCard(chest_label);
            CardSpace chest_cardSpace = new CardSpace(chest_card);
            listSpace.Add(chest_cardSpace);
            //ADD FREEPARKING SPACE
            string fpsName = "FREEPARKING";
            FreeParkingSpace fpSpace = new FreeParkingSpace(fpsName);
            listSpace.Add(fpSpace);
            //ADD GO SPACE
            string goName = "GO";
            GoSpace goSpace = new GoSpace(goName);
            listSpace.Add(goSpace);
            //ADD GOTO JAIL SPACE
            string gotojailName = "GOTO JAIL";
            GoToJailSpace gotojailSpace = new GoToJailSpace(gotojailName);
            listSpace.Add(gotojailSpace);
            //ADD JAIL SPACE
            string jailName = "JAIL";
            JailSpace jailSpace = new JailSpace(jailName);
            listSpace.Add(jailSpace);

            #endregion


        }

        public void movePlayer()
        {
            Console.WriteLine("GameController");
            Console.ReadLine();
        }
        public void showMessage()
        {
        }
        public void startGame()
        {
        }
    }
}
