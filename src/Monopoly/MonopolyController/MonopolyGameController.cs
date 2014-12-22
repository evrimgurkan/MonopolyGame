﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using IMonopoly;

namespace MonopolyController
{
    public class MonopolyGameController : Subject
    {
        GameController gameController = GameController.GameControllerInstance;
        public void initBoard()
        {
            gameController.initilaise();
            gameController.initBoard();
            
        }

        public void fillBoard()
        {
            gameController.fillBoard();
        }

        public void addPlayer(string name)
        {
            gameController.addPlayer(name);
        }

        public string getPlayerName(int index)
        {
            return gameController.getPlayerName(index);
        }
        public int getNextPlayerIndex(int current)
        {
            int playersCount = getPlayersCount();
            return ++current >= playersCount ? 0 : current;
        }
        public int getPlayerCash(int index)
        {
            return gameController.getPlayerCash(index);
        }
        public bool isPlayerJail(int index)
        {
            return gameController.isPlayerJail(index);
        }
        public Symbol getPlayerSymbol(int index)
        {
            return gameController.getPlayerSymbol(index);
        }
        public int getPlayersCount()
        {
            return gameController.getPlayersCount();
        }
        public void movePlayer(int playerIndex, int count)
        {
            gameController.movePlayer(playerIndex, count);
        }
        public int getCurrentIndex(int playerIndex, int count)
        {
            return gameController.getCurrentIndex(playerIndex, count);
        }
    }

    
}
