using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    // Special EventArgs class to hold info about Shapes. 
    //public class MoveEventArgs : EventArgs
    //{
    //    private Player movedPlayer;
    //    private Space newPosition;

    //    public MoveEventArgs(Player _player,Space _position)
    //    {
    //        movedPlayer = _player;
    //        newPosition = _position;
    //    }
    //    public Player player
    //    {
    //        get { return movedPlayer; }
    //    }

    //    public Space position
    //    {
    //        get { return newPosition; }
    //    }
    //}

    abstract class Space
    {
        //public event EventHandler<MoveEventArgs> playerLanded;
        public abstract void playAction();

        ////The event-invoking method that derived classes can override. 
        //protected virtual void OnPlayerLanded(MoveEventArgs e)
        //{
        //    // Make a temporary copy of the event to avoid possibility of 
        //    // a race condition if the last subscriber unsubscribes 
        //    // immediately after the null check and before the event is raised.
        //    EventHandler<MoveEventArgs> handler = playerLanded;
        //    if (handler != null)
        //    {
        //        handler(this, e);
        //    }
        //}
    }
}
