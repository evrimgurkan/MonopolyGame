using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IMonopoly
{
    public interface Observer
    {
        void Update();

        void SendMessageToView(string message, int money);

        void AddLog(string message);

        void OpenItemsPage(int color, int title, int rent,
                                    int oneHouseRent, int twoHouseRent,
                                    int threeHouseRent, int fourHouseRent,
                                    int hotelRent, int mortgagedValue,
                                    int housePrice, int hotelPrice);
    }
}
