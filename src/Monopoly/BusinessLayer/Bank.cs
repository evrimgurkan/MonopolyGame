using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    class Bank
    {
        private int bankCash;

        public Bank()
        {
            bankCash = 50000000;
        }

        public bool payMoneyToPlayer(int amount, Player player)
        {
            bool is_success = false;
            if (bankCash > amount)
            {
                bankCash -= amount;
                player.cash += amount;
                is_success = true;
            }
            return is_success;
        }

        public bool takeMoneyFromPlayer(int amount, Player player)
        {
            bool is_success = false;
            if (player.cash > amount)
            {
                bankCash += amount;
                player.cash -= amount;
                is_success = true;
            }
            return is_success; // TODO: if success is false, player should be bankrupted
        }
    }
}
