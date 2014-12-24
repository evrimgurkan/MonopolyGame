using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.CommandOperations;
using Model.CommandOperations.Orders;
using Model.IteratorOperations;
using IMonopoly;

namespace Model
{
    public class GameController : Subject
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
        private const int brown1_cost = 60;

        private const int brown_perHouseCost = 50;
        private const int brown_perHotelCost = 200;

        private const string brown2_name = "Baltic Avenue";
        private const int brown2_rentPrice = 4;
        private const int brown2_1housePrice = 20;
        private const int brown2_2housePrice = 60;
        private const int brown2_3housePrice = 180;
        private const int brown2_4housePrice = 320;
        private const int brown2_hotelPrice = 450;
        private const int brown2_mortgagePrice = 30;
        private const int brown2_cost = 60;
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
        private const int blue1_cost = 100;

        private const int blue_perHouseCost = 50;
        private const int blue_perHotelCost = 200;

        private const string blue2_name = "Vermont Avenue";
        private const int blue2_rentPrice = 6;
        private const int blue2_1housePrice = 30;
        private const int blue2_2housePrice = 90;
        private const int blue2_3housePrice = 270;
        private const int blue2_4housePrice = 400;
        private const int blue2_hotelPrice = 550;
        private const int blue2_mortgagePrice = 50;
        private const int blue2_cost = 100;

        private const string blue3_name = "Connecticut Avenue";
        private const int blue3_rentPrice = 8;
        private const int blue3_1housePrice = 40;
        private const int blue3_2housePrice = 100;
        private const int blue3_3housePrice = 300;
        private const int blue3_4housePrice = 450;
        private const int blue3_hotelPrice = 600;
        private const int blue3_mortgagePrice = 60;
        private const int blue3_cost = 120;
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
        private const int pink1_cost = 140;

        private const int pink_perHouseCost = 100;
        private const int pink_perHotelCost = 400;

        private const string pink2_name = "States Avenue";
        private const int pink2_rentPrice = 10;
        private const int pink2_1housePrice = 50;
        private const int pink2_2housePrice = 150;
        private const int pink2_3housePrice = 450;
        private const int pink2_4housePrice = 625;
        private const int pink2_hotelPrice = 750;
        private const int pink2_mortgagePrice = 70;
        private const int pink2_cost = 140;

        private const string pink3_name = "Virginia Avenue";
        private const int pink3_rentPrice = 12;
        private const int pink3_1housePrice = 60;
        private const int pink3_2housePrice = 180;
        private const int pink3_3housePrice = 500;
        private const int pink3_4housePrice = 700;
        private const int pink3_hotelPrice = 900;
        private const int pink3_mortgagePrice = 80;
        private const int pink3_cost = 160;
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
        private const int orange1_cost = 180;

        private const int orange_perHouseCost = 100;
        private const int orange_perHotelCost = 400;

        private const string orange2_name = "Tennessee Avenue";
        private const int orange2_rentPrice = 14;
        private const int orange2_1housePrice = 70;
        private const int orange2_2housePrice = 200;
        private const int orange2_3housePrice = 550;
        private const int orange2_4housePrice = 750;
        private const int orange2_hotelPrice = 950;
        private const int orange2_mortgagePrice = 90;
        private const int orange2_cost = 180;

        private const string orange3_name = "New York Avenue";
        private const int orange3_rentPrice = 16;
        private const int orange3_1housePrice = 80;
        private const int orange3_2housePrice = 220;
        private const int orange3_3housePrice = 600;
        private const int orange3_4housePrice = 800;
        private const int orange3_hotelPrice = 1000;
        private const int orange3_mortgagePrice = 100;
        private const int orange3_cost = 200;
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
        private const int red1_cost = 220;

        private const int red_perHouseCost = 150;
        private const int red_perHotelCost = 600;

        private const string red2_name = "Indiana Avenue";
        private const int red2_rentPrice = 18;
        private const int red2_1housePrice = 90;
        private const int red2_2housePrice = 250;
        private const int red2_3housePrice = 700;
        private const int red2_4housePrice = 875;
        private const int red2_hotelPrice = 1050;
        private const int red2_mortgagePrice = 110;
        private const int red2_cost = 220;

        private const string red3_name = "Illinois Avenue";
        private const int red3_rentPrice = 20;
        private const int red3_1housePrice = 100;
        private const int red3_2housePrice = 300;
        private const int red3_3housePrice = 750;
        private const int red3_4housePrice = 925;
        private const int red3_hotelPrice = 1100;
        private const int red3_mortgagePrice = 120;
        private const int red3_cost = 240;
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
        private const int yellow1_cost = 260;

        private const int yellow_perHouseCost = 150;
        private const int yellow_perHotelCost = 600;

        private const string yellow2_name = "Ventnor Avenue";
        private const int yellow2_rentPrice = 22;
        private const int yellow2_1housePrice = 110;
        private const int yellow2_2housePrice = 330;
        private const int yellow2_3housePrice = 800;
        private const int yellow2_4housePrice = 975;
        private const int yellow2_hotelPrice = 1150;
        private const int yellow2_mortgagePrice = 130;
        private const int yellow2_cost = 260;

        private const string yellow3_name = "Marvin Gardens";
        private const int yellow3_rentPrice = 24;
        private const int yellow3_1housePrice = 120;
        private const int yellow3_2housePrice = 360;
        private const int yellow3_3housePrice = 850;
        private const int yellow3_4housePrice = 1025;
        private const int yellow3_hotelPrice = 1200;
        private const int yellow3_mortgagePrice = 140;
        private const int yellow3_cost = 280;
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
        private const int green1_cost = 300;

        private const int green_perHouseCost = 200;
        private const int green_perHotelCost = 800;

        private const string green2_name = "North Carolina Avenue";
        private const int green2_rentPrice = 26;
        private const int green2_1housePrice = 130;
        private const int green2_2housePrice = 390;
        private const int green2_3housePrice = 900;
        private const int green2_4housePrice = 1100;
        private const int green2_hotelPrice = 1275;
        private const int green2_mortgagePrice = 150;
        private const int green2_cost = 300;

        private const string green3_name = "Pennsylvania Avenue";
        private const int green3_rentPrice = 28;
        private const int green3_1housePrice = 150;
        private const int green3_2housePrice = 450;
        private const int green3_3housePrice = 1000;
        private const int green3_4housePrice = 1200;
        private const int green3_hotelPrice = 1400;
        private const int green3_mortgagePrice = 160;
        private const int green3_cost = 320;
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
        private const int purple1_cost = 350;

        private const int purple_perHouseCost = 200;
        private const int purple_perHotelCost = 800;

        private const string purple2_name = "Boardwalk";
        private const int purple2_rentPrice = 50;
        private const int purple2_1housePrice = 200;
        private const int purple2_2housePrice = 600;
        private const int purple2_3housePrice = 1400;
        private const int purple2_4housePrice = 1700;
        private const int purple2_hotelPrice = 2000;
        private const int purple2_mortgagePrice = 200;
        private const int purple2_cost = 400;
        #endregion

        #region Railroads

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
        private const string utilities2_name = "Water Works";
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


        private int maxCountPlayer = 5;
        private int luxuryTaxAmount = 75;
        private int incomeTaxAmount = 200;
        private int passingGoAmount = 200;
        private string incomeLabel = "Pay %10 or 200$";
        private string luxuryLabel = "Luxury Tax 75$";
        private string jailName = "JAIL";
        private string goToJailName = "GOTO JAIL";
        private string freeParkingName = "FREE PARKING SPACE";
        private string goName = "GO";

        #endregion

        #region Properties
        private Bank bank;
        private List<Player> listPlayer;
        private IteratorOperations.SpaceList listSpace;
        private Board board;
        private Dice dice;
        private List<Symbol> listSymbol;
        private List<Card> listChanceCard;
        private List<Card> listCChest;
        private Command command;
        private State state;
        private int currPlayerIndex = 0; // Should be removed
        #endregion

        private static GameController instance;

        private GameController(State _state)
        {
            state = _state;
        }

        public static GameController GameControllerInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GameController(new PlayableState());
                }
                return instance;
            }
        }

        public void initilaise()
        {
            bank = new Bank();
            listPlayer = new List<Player>();
            listSpace = new IteratorOperations.SpaceList();
            board = new Board();
            dice = new Dice();
            listSymbol = new List<Symbol>();
            listChanceCard = new List<Card>();
            listCChest = new List<Card>();
        }

        public void initBoard()
        {
            #region ADD BOARD ITEMS

            #region ADD CARDS TO LIST
            addCChestCards();
            addChanceCards();
            #endregion

            #region ADD SYMBOLS
            listSymbol.Add(new Symbol(Symbol.SymbolType.BOOK));
            listSymbol.Add(new Symbol(Symbol.SymbolType.CAR));
            listSymbol.Add(new Symbol(Symbol.SymbolType.HORSE));
            listSymbol.Add(new Symbol(Symbol.SymbolType.TOWER));
            listSymbol.Add(new Symbol(Symbol.SymbolType.TREE));
            #endregion

            #region ADD CELL GROUPS
            PropertyCellGroup pBlueCellGroup = new PropertyCellGroup(PropertyCellGroup.CellColor.Blue, blue_perHotelCost, blue_perHouseCost);
            PropertyCellGroup pBrownCellGroup = new PropertyCellGroup(PropertyCellGroup.CellColor.Brown, brown_perHotelCost, brown_perHouseCost);
            PropertyCellGroup pGreenCellGroup = new PropertyCellGroup(PropertyCellGroup.CellColor.Green, green_perHotelCost, green_perHouseCost);
            PropertyCellGroup pOrangeCellGroup = new PropertyCellGroup(PropertyCellGroup.CellColor.Orange, orange_perHotelCost, green_perHouseCost);
            PropertyCellGroup pPinkCellGroup = new PropertyCellGroup(PropertyCellGroup.CellColor.Pink, pink_perHotelCost, pink_perHouseCost);
            PropertyCellGroup pPurpleCellGroup = new PropertyCellGroup(PropertyCellGroup.CellColor.Purple, purple_perHotelCost, purple_perHouseCost);
            PropertyCellGroup pRedCellGroup = new PropertyCellGroup(PropertyCellGroup.CellColor.Red, red_perHotelCost, red_perHouseCost);
            PropertyCellGroup pYellowCellGroup = new PropertyCellGroup(PropertyCellGroup.CellColor.Yellow, yellow_perHotelCost, yellow_perHouseCost);

            NonPropertyCellGroup npRailRoadCellGroup = new NonPropertyCellGroup();
            NonPropertyCellGroup npUtilitiesCellGroup = new NonPropertyCellGroup();
            #endregion

            #region ADD PLAYERS
            //Player player1 = new Player("ahmet", 2000, listSymbol[0]);
            //listPlayer.Add(player1);
            //Player player2 = new Player("veli", 2000, listSymbol[3]);
            //listPlayer.Add(player2);
            #endregion

            #region ADD BROWN1 SPACE

            PropertyCell brown1_cell = new PropertyCell(pBrownCellGroup, brown1_mortgagePrice, brown1_name, brown1_cost,
                                                        brown1_hotelPrice, brown1_1housePrice, brown1_2housePrice,
                                                        brown1_3housePrice, brown1_4housePrice, brown1_rentPrice);

            pBrownCellGroup.addCell(brown1_cell);
            listSpace.Add(new PropertySpace(brown1_cell));
            #endregion

            #region ADD CCHEST CARD SPACE
            listSpace.Add(new CardSpace(getRandomCard(listCChest)));
            #endregion

            #region ADD BROWN2 SPACE
            PropertyCell brown2_cell = new PropertyCell(pBrownCellGroup, brown2_mortgagePrice, brown2_name, brown2_cost,
                                                        brown2_hotelPrice, brown2_1housePrice, brown2_2housePrice,
                                                        brown2_3housePrice, brown2_4housePrice, brown2_rentPrice);

            pBrownCellGroup.addCell(brown2_cell);
            listSpace.Add(new PropertySpace(brown2_cell));
            #endregion

            #region ADD INCOME TAX SPACE
            listSpace.Add(new TaxSpace(new IncomeTax(incomeLabel, incomeTaxAmount)));
            #endregion

            #region ADD RAILROAD1 SPACE
            RailroadCell railroadCell1 = new RailroadCell(npRailRoadCellGroup, railroad_mortgagePrice,
                                                          railroad1_name, railroad_cost, railroad_rentPrice);
            npRailRoadCellGroup.addCell(railroadCell1);
            listSpace.Add(new PropertySpace(railroadCell1));
            #endregion

            #region ADD BLUE1 SPACE
            PropertyCell blue1_cell = new PropertyCell(pBlueCellGroup, blue1_mortgagePrice, blue1_name, blue1_cost,
                                                        blue1_hotelPrice, blue1_1housePrice, blue1_2housePrice,
                                                        blue1_3housePrice, blue1_4housePrice, blue1_rentPrice);

            pBrownCellGroup.addCell(blue1_cell);
            listSpace.Add(new PropertySpace(blue1_cell));
            #endregion

            #region ADD CHANCE CARD SPACE
            listSpace.Add(new CardSpace(getRandomCard(listChanceCard)));
            #endregion

            #region ADD BLUE2 SPACE
            PropertyCell blue2_cell = new PropertyCell(pBlueCellGroup, blue2_mortgagePrice, blue2_name, blue2_cost,
                                                        blue2_hotelPrice, blue2_1housePrice, blue2_2housePrice,
                                                        blue2_3housePrice, blue2_4housePrice, blue2_rentPrice);

            pBrownCellGroup.addCell(blue2_cell);
            listSpace.Add(new PropertySpace(blue2_cell));
            #endregion

            #region ADD BLUE3 SPACE
            PropertyCell blue3_cell = new PropertyCell(pBlueCellGroup, blue3_mortgagePrice, blue3_name, blue3_cost,
                                                        blue3_hotelPrice, blue3_1housePrice, blue3_2housePrice,
                                                        blue3_3housePrice, blue3_4housePrice, blue3_rentPrice);

            pBrownCellGroup.addCell(blue3_cell);
            listSpace.Add(new PropertySpace(blue3_cell));
            #endregion

            #region ADD JAIL SPACE
            listSpace.Add(new JailSpace(jailName));
            #endregion

            #region ADD PINK1 SPACE
            PropertyCell pink1_cell = new PropertyCell(pPinkCellGroup, pink1_mortgagePrice, pink1_name, pink1_cost,
                                            pink1_hotelPrice, pink1_1housePrice, pink1_2housePrice,
                                            pink1_3housePrice, pink1_4housePrice, pink1_rentPrice);

            pBrownCellGroup.addCell(pink1_cell);
            listSpace.Add(new PropertySpace(pink1_cell));
            #endregion

            #region ADD UTILITY1 SPACE
            UtilityCell utility1_cell = new UtilityCell(npUtilitiesCellGroup, utilities_mortgagePrice,
                                                        utilities1_name, utilities_cost);
            npUtilitiesCellGroup.addCell(utility1_cell);
            listSpace.Add(new PropertySpace(utility1_cell));
            #endregion

            #region ADD PINK2 SPACE
            PropertyCell pink2_cell = new PropertyCell(pPinkCellGroup, pink2_mortgagePrice, pink2_name, pink2_cost,
                                            pink2_hotelPrice, pink2_1housePrice, pink2_2housePrice,
                                            pink2_3housePrice, pink2_4housePrice, pink2_rentPrice);

            pBrownCellGroup.addCell(pink2_cell);
            listSpace.Add(new PropertySpace(pink2_cell));
            #endregion

            #region ADD PINK3 SPACE
            PropertyCell pink3_cell = new PropertyCell(pPinkCellGroup, pink3_mortgagePrice, pink3_name, pink3_cost,
                                            pink3_hotelPrice, pink3_1housePrice, pink3_2housePrice,
                                            pink3_3housePrice, pink3_4housePrice, pink3_rentPrice);

            pBrownCellGroup.addCell(pink3_cell);
            listSpace.Add(new PropertySpace(pink3_cell));
            #endregion

            #region ADD RAILROAD2 SPACE
            RailroadCell railroadCell2 = new RailroadCell(npRailRoadCellGroup, railroad_mortgagePrice,
                                                          railroad2_name, railroad_cost, railroad_rentPrice);
            npRailRoadCellGroup.addCell(railroadCell2);
            listSpace.Add(new PropertySpace(railroadCell2));
            #endregion

            #region ADD ORANGE1 SPACE
            PropertyCell orange1_cell = new PropertyCell(pOrangeCellGroup, orange1_mortgagePrice, orange1_name, orange1_cost,
                                            orange1_hotelPrice, orange1_1housePrice, orange1_2housePrice,
                                            orange1_3housePrice, orange1_4housePrice, orange1_rentPrice);

            pBrownCellGroup.addCell(orange1_cell);
            listSpace.Add(new PropertySpace(orange1_cell));
            #endregion

            #region ADD CCHEST CARD SPACE
            listSpace.Add(new CardSpace(getRandomCard(listCChest)));
            #endregion

            #region ADD ORANGE2 SPACE
            PropertyCell orange2_cell = new PropertyCell(pOrangeCellGroup, orange2_mortgagePrice, orange2_name, orange2_cost,
                                            orange2_hotelPrice, orange2_1housePrice, orange2_2housePrice,
                                            orange2_3housePrice, orange2_4housePrice, orange2_rentPrice);

            pBrownCellGroup.addCell(orange2_cell);
            listSpace.Add(new PropertySpace(orange2_cell));
            #endregion

            #region ADD ORANGE3 SPACE
            PropertyCell orange3_cell = new PropertyCell(pOrangeCellGroup, orange3_mortgagePrice, orange3_name, orange3_cost,
                                            orange3_hotelPrice, orange3_1housePrice, orange3_2housePrice,
                                            orange3_3housePrice, orange3_4housePrice, orange3_rentPrice);

            pBrownCellGroup.addCell(orange3_cell);
            listSpace.Add(new PropertySpace(orange3_cell));
            #endregion

            #region ADD FREE PARKING SPACE
            listSpace.Add(new FreeParkingSpace(freeParkingName));
            #endregion

            #region ADD RED1 SPACE
            PropertyCell red1_cell = new PropertyCell(pRedCellGroup, red1_mortgagePrice, red1_name, red1_cost,
                                            red1_hotelPrice, red1_1housePrice, red1_2housePrice,
                                            red1_3housePrice, red1_4housePrice, red1_rentPrice);

            pBrownCellGroup.addCell(red1_cell);
            listSpace.Add(new PropertySpace(red1_cell));
            #endregion

            #region ADD CHANCE CARD SPACE
            listSpace.Add(new CardSpace(getRandomCard(listChanceCard)));
            #endregion

            #region ADD RED2 SPACE
            PropertyCell red2_cell = new PropertyCell(pRedCellGroup, red2_mortgagePrice, red2_name, red2_cost,
                                            red2_hotelPrice, red2_1housePrice, red2_2housePrice,
                                            red2_3housePrice, red2_4housePrice, red2_rentPrice);

            pBrownCellGroup.addCell(red2_cell);
            listSpace.Add(new PropertySpace(red2_cell));
            #endregion

            #region ADD RED3 SPACE
            PropertyCell red3_cell = new PropertyCell(pRedCellGroup, red3_mortgagePrice, red3_name, red3_cost,
                                            red3_hotelPrice, red3_1housePrice, red3_2housePrice,
                                            red3_3housePrice, red3_4housePrice, red3_rentPrice);

            pBrownCellGroup.addCell(red3_cell);
            listSpace.Add(new PropertySpace(red3_cell));
            #endregion

            #region ADD RAILROAD3 SPACE
            RailroadCell railroadCell3 = new RailroadCell(npRailRoadCellGroup, railroad_mortgagePrice,
                                                          railroad3_name, railroad_cost, railroad_rentPrice);
            npRailRoadCellGroup.addCell(railroadCell3);
            listSpace.Add(new PropertySpace(railroadCell3));
            #endregion

            #region ADD YELLOW1 SPACE
            PropertyCell yellow1_cell = new PropertyCell(pYellowCellGroup, yellow1_mortgagePrice, yellow1_name, yellow1_cost,
                                            yellow1_hotelPrice, yellow1_1housePrice, yellow1_2housePrice,
                                            yellow1_3housePrice, yellow1_4housePrice, yellow1_rentPrice);

            pBrownCellGroup.addCell(yellow1_cell);
            listSpace.Add(new PropertySpace(yellow1_cell));
            #endregion

            #region ADD YELLOW2 SPACE
            PropertyCell yellow2_cell = new PropertyCell(pYellowCellGroup, yellow2_mortgagePrice, yellow2_name, yellow2_cost,
                                            yellow2_hotelPrice, yellow2_1housePrice, yellow2_2housePrice,
                                            yellow2_3housePrice, yellow2_4housePrice, yellow2_rentPrice);

            pBrownCellGroup.addCell(yellow2_cell);
            listSpace.Add(new PropertySpace(yellow2_cell));
            #endregion

            #region ADD UTILITY2 SPACE
            UtilityCell utility2_cell = new UtilityCell(npUtilitiesCellGroup, utilities_mortgagePrice,
                                                        utilities2_name, utilities_cost);
            npUtilitiesCellGroup.addCell(utility2_cell);
            listSpace.Add(new PropertySpace(utility2_cell));
            #endregion

            #region ADD YELLOW3 SPACE
            PropertyCell yellow3_cell = new PropertyCell(pYellowCellGroup, yellow3_mortgagePrice, yellow3_name, yellow3_cost,
                                            yellow3_hotelPrice, yellow3_1housePrice, yellow3_2housePrice,
                                            yellow3_3housePrice, yellow3_4housePrice, yellow3_rentPrice);

            pBrownCellGroup.addCell(yellow3_cell);
            listSpace.Add(new PropertySpace(yellow3_cell));
            #endregion

            #region ADD GO TO JAIL SPACE
            listSpace.Add(new GoToJailSpace(goToJailName));
            #endregion

            #region ADD GREEN1 SPACE
            PropertyCell green1_cell = new PropertyCell(pGreenCellGroup, green1_mortgagePrice, green1_name, green1_cost,
                                            green1_hotelPrice, green1_1housePrice, green1_2housePrice,
                                            green1_3housePrice, green1_4housePrice, green1_rentPrice);

            pBrownCellGroup.addCell(green1_cell);
            listSpace.Add(new PropertySpace(green1_cell));
            #endregion

            #region ADD GREEN2 SPACE
            PropertyCell green2_cell = new PropertyCell(pGreenCellGroup, green2_mortgagePrice, green2_name, green2_cost,
                                            green2_hotelPrice, green2_1housePrice, green2_2housePrice,
                                            green2_3housePrice, green2_4housePrice, green2_rentPrice);

            pBrownCellGroup.addCell(green2_cell);
            listSpace.Add(new PropertySpace(green2_cell));
            #endregion

            #region ADD CCHEST CARD SPACE
            listSpace.Add(new CardSpace(getRandomCard(listCChest)));
            #endregion

            #region ADD GREEN3 SPACE
            PropertyCell green3_cell = new PropertyCell(pGreenCellGroup, green3_mortgagePrice, green3_name, green3_cost,
                                            green3_hotelPrice, green3_1housePrice, green3_2housePrice,
                                            green3_3housePrice, green3_4housePrice, green3_rentPrice);

            pBrownCellGroup.addCell(green3_cell);
            listSpace.Add(new PropertySpace(green3_cell));
            #endregion

            #region ADD RAILROAD4 SPACE
            RailroadCell railroadCell4 = new RailroadCell(npRailRoadCellGroup, railroad_mortgagePrice,
                                                          railroad4_name, railroad_cost, railroad_rentPrice);
            npRailRoadCellGroup.addCell(railroadCell4);
            listSpace.Add(new PropertySpace(railroadCell4));
            #endregion

            #region ADD CHANCE CARD SPACE
            listSpace.Add(new CardSpace(getRandomCard(listChanceCard)));
            #endregion

            #region ADD PURPLE1 SPACE
            PropertyCell purple1_cell = new PropertyCell(pPurpleCellGroup, purple1_mortgagePrice, purple1_name, purple1_cost,
                                            purple1_hotelPrice, purple1_1housePrice, purple1_2housePrice,
                                            purple1_3housePrice, purple1_4housePrice, purple1_rentPrice);

            pBrownCellGroup.addCell(purple1_cell);
            listSpace.Add(new PropertySpace(purple1_cell));
            #endregion

            #region ADD LUXURY TAX SPACE
            listSpace.Add(new TaxSpace(new LuxuryTax(luxuryLabel, luxuryTaxAmount)));
            #endregion

            #region ADD PURPLE2 SPACE
            PropertyCell purple2_cell = new PropertyCell(pPurpleCellGroup, purple2_mortgagePrice, purple2_name, purple2_cost,
                                            purple2_hotelPrice, purple2_1housePrice, purple2_2housePrice,
                                            purple2_3housePrice, purple2_4housePrice, purple2_rentPrice);

            pBrownCellGroup.addCell(purple2_cell);
            listSpace.Add(new PropertySpace(purple2_cell));
            #endregion

            #region ADD GO SPACE
            listSpace.Add(new GoSpace(goName));
            #endregion

            #endregion

        }

        public void fillBoard()
        {
            board.fillBoard(listPlayer, listSpace);
        }

        public void addPlayer(string name)
        {
            Symbol symbol = new Symbol(Symbol.SymbolType.CAR);
            listSymbol.Add(symbol);
            Player player = new Player(name, 0, listSymbol[0]);
            listPlayer.Add(player);
        }

        private void addCChestCards()
        {
            CommunityChestCard card;
            card = new CommunityChestCard(cchest1_cardLabel, Card.OrderType.AdvancetoGo);
            listCChest.Add(card);
            card = new CommunityChestCard(cchest2_cardLabel, Card.OrderType.BankErrorInYourFavor);
            listCChest.Add(card);
            card = new CommunityChestCard(cchest3_cardLabel, Card.OrderType.DoctorFees);
            listCChest.Add(card);
            card = new CommunityChestCard(cchest4_cardLabel, Card.OrderType.GetOutofJail);
            listCChest.Add(card);
            card = new CommunityChestCard(cchest5_cardLabel, Card.OrderType.GotoJail);
            listCChest.Add(card);
            card = new CommunityChestCard(cchest6_cardLabel, Card.OrderType.Birthday_CollectFromEachPlayer);
            listCChest.Add(card);
            card = new CommunityChestCard(cchest7_cardLabel, Card.OrderType.GrandOperaNight);
            listCChest.Add(card);
            card = new CommunityChestCard(cchest8_cardLabel, Card.OrderType.IncomeTaxRefund);
            listCChest.Add(card);
            card = new CommunityChestCard(cchest9_cardLabel, Card.OrderType.LifeInsuranceMatures);
            listCChest.Add(card);
            card = new CommunityChestCard(cchest10_cardLabel, Card.OrderType.PayHospitalFees);
            listCChest.Add(card);
            card = new CommunityChestCard(cchest11_cardLabel, Card.OrderType.PaySchoolFees);
            listCChest.Add(card);
            card = new CommunityChestCard(cchest12_cardLabel, Card.OrderType.ReceiveConsultancyFee);
            listCChest.Add(card);
            card = new CommunityChestCard(cchest13_cardLabel, Card.OrderType.StreetRepairs);
            listCChest.Add(card);
            card = new CommunityChestCard(cchest14_cardLabel, Card.OrderType.WonSecondPrize);
            listCChest.Add(card);
            card = new CommunityChestCard(cchest15_cardLabel, Card.OrderType.Inherit);
            listCChest.Add(card);
            card = new CommunityChestCard(cchest16_cardLabel, Card.OrderType.FromSaleofStock);
            listCChest.Add(card);
        }

        private void addChanceCards()
        {
            ChanceCard card;
            card = new ChanceCard(chance1_cardLabel, Card.OrderType.AdvancetoGo);
            listChanceCard.Add(card);
            card = new ChanceCard(chance2_cardLabel, Card.OrderType.AdvancetoIllinoisAve);
            listChanceCard.Add(card);
            card = new ChanceCard(chance3_cardLabel, Card.OrderType.AdvancetoNearestUtility);
            listChanceCard.Add(card);
            card = new ChanceCard(chance4_cardLabel, Card.OrderType.AdvancetoNearestRailroad);
            listChanceCard.Add(card);
            card = new ChanceCard(chance5_cardLabel, Card.OrderType.AdvancetoCharlesPlace);
            listChanceCard.Add(card);
            card = new ChanceCard(chance6_cardLabel, Card.OrderType.BankPaysYou);
            listChanceCard.Add(card);
            card = new ChanceCard(chance7_cardLabel, Card.OrderType.GetOutofJail);
            listChanceCard.Add(card);
            card = new ChanceCard(chance8_cardLabel, Card.OrderType.GoBack_3_Space);
            listChanceCard.Add(card);
            card = new ChanceCard(chance9_cardLabel, Card.OrderType.GotoJail);
            listChanceCard.Add(card);
            card = new ChanceCard(chance10_cardLabel, Card.OrderType.RepairsAllProperty);
            listChanceCard.Add(card);
            card = new ChanceCard(chance11_cardLabel, Card.OrderType.PayPoorTax);
            listChanceCard.Add(card);
            card = new ChanceCard(chance12_cardLabel, Card.OrderType.AdvancetoReadingRailroad);
            listChanceCard.Add(card);
            card = new ChanceCard(chance13_cardLabel, Card.OrderType.AdvancetoBoardwalk);
            listChanceCard.Add(card);
            card = new ChanceCard(chance14_cardLabel, Card.OrderType.PayEachPlayer);
            listChanceCard.Add(card);
            card = new ChanceCard(chance15_cardLabel, Card.OrderType.Collect_150);
            listChanceCard.Add(card);
            card = new ChanceCard(chance16_cardLabel, Card.OrderType.WonCompetition);
            listChanceCard.Add(card);
        }

        public void setState(State _state)
        {
            state = _state;
        }

        public State getState()
        {
            return state;
        }

        public bool IsInJail()
        {
            return state.IsInJail();
        }

        private Card getRandomCard(List<Card> cardlist)
        {
            Random rnd = new Random();
            if (cardlist.Count > 0)
            {
                int index = rnd.Next(16);
                return cardlist[index];
            }
            return null;
        }

        public void movePlayer(int playerIndex, int count)
        {
            Iterator it = listPlayer[playerIndex].GetIterator();

            //for (int i = 0; i < count; i++)
            //{
            //    it.Next();
            //}

            Space s = it.CurrentItem(); //it.Next();
            s.playAction();
        }

        public int getCurrentIndex(int playerIndex, int count)
        {
            currPlayerIndex = playerIndex;
            Iterator it = listPlayer[playerIndex].GetIterator();

            for (int i = 0; i < count; i++)
            {
                it.Next();
            }
            return it.CurrentIndex();
        }

        public void moveBackPlayer(Player player, int spaceIndex)
        {
            Iterator it = player.GetIterator();

            for (int i = 0; i < spaceIndex; i++)
            {
                it.Prev();
            }
        }

        public Space getCurrentSpace()
        {
            Iterator it = listPlayer[currPlayerIndex].GetIterator();
            return it.CurrentItem();
        }

        public void showMessage()
        {
        }

        public void startGame()
        {
        }

        public Bank getBank()
        {
            return bank;
        }

        public Dice getDice()
        {
            return dice;
        }

        public Player getCurrentPlayer()
        {
            return listPlayer[currPlayerIndex]; // TODO return correct player
        }

        public void SetCommand(Command command)
        {
            this.command = command;
        }

        public void ExecuteCommand()
        {
            command.Execute();
        }

        public string getPlayerName(int index)
        {
            return listPlayer[index].name;
        }

        public int getPlayerCash(int index)
        {
            return listPlayer[index].cash;
        }

        public bool isPlayerJail(int index)
        {
            return listPlayer[index].inJail;
        }

        public Symbol getPlayerSymbol(int index)
        {
            return listPlayer[index].symbol;
        }

        public int getPlayersCount()
        {
            return listPlayer.Count();
        }

        public int getPassingGoAmount()
        {
            return passingGoAmount;
        }

        public void buyCurrentProperty()
        {
            PropertySpace pSpace = (PropertySpace)getCurrentSpace();
            Order order = new BuyPropertyOrder(getCurrentPlayer(),
                                                getBank(), pSpace.pCell);

            Command _command = new CardCommand(order);
            SetCommand(_command);
            ExecuteCommand();
        }
    }
}
