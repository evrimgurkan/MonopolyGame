using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    class Board
    {
        private List<Space> _listSpaces;
        private List<Player> _listPlayers;

        public Board()
        {
        }

        public void fillBoard(List<Player> _players, List<Space> _spaces)
        {
            _listPlayers = _players;
            _listSpaces = _spaces;
        }

        private void movePlayer(Player player, int space)
        {

        }
    }
}
