using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace IMonopoly
{
    public abstract class Subject
    {
        private ArrayList observers = new ArrayList();

        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (Observer o in observers)
            {
                o.Update();
            }
        }

        public void SendMessageToView(string message,int money)
        {
            foreach (Observer o in observers)
            {
                o.SendMessageToView(message,money);
            }
        }

        public void AddLog(string message)
        {
            foreach (Observer o in observers)
            {
                o.AddLog(message);
            }
        }

        public void OpenItemsPage(int color, int title, int rent,
                                    int oneHouseRent, int twoHouseRent,
                                    int threeHouseRent, int fourHouseRent,
                                    int hotelRent, int mortgagedValue,
                                    int housePrice, int hotelPrice)
        {
            foreach (Observer o in observers)
            {
                o.OpenItemsPage(color, title, rent,
                                    oneHouseRent, twoHouseRent,
                                    threeHouseRent, fourHouseRent,
                                    hotelRent, mortgagedValue,
                                    housePrice, hotelPrice);
            }
        }
    }
}
