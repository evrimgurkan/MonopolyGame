using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    class GameController
    {
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
            //SAMPLE OBJECTS

            //ADD SYMBOL
            Symbol symbol = new Symbol("at");
            Symbol symbol2 = new Symbol("kopek");
            listSymbol.Add(symbol);
            listSymbol.Add(symbol2);
            //ADD PLAYER
            Player p = new Player("ahmet", 10000, listSymbol[0]);
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
            //ADD GO SPACE
            //ADD GOTO JAIL SPACE
            //ADD JAIL SPACE

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
