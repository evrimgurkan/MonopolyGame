﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.CommandOperations;
using Model.IteratorOperations;

namespace Model
{
    class Board : CommandReceiver
    {
        private SpaceList _listSpaces;
        private List<Player> _listPlayers;
        public Board()
        {
        }

        public void fillBoard(List<Player> _players, SpaceList _spaces)
        {
            _listPlayers = _players;
            _listSpaces = _spaces;
            CreateIterators();
        }

        private void CreateIterators()
        {
            foreach (Player _player in _listPlayers)
            {
                _player.CreateIterator(_listSpaces);
            }
        }

        private void movePlayer(Player player, int space)
        {
            Iterator i = _listPlayers[0].GetIterator();
            Space s = i.Next();
            s.playAction();
        }
    }
}
