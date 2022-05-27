using System;
using System.Collections.Generic;


namespace cse210_03
{

    //This holds the player parachute information.
    public class Player
    {
        public List<string> playerArray = new List<string>();
        public bool playerWin = false;


        //Add the parachute, man, and spikes to the player array.
        public Player()
        {
            this.playerArray.Add("  ___   ");
            this.playerArray.Add(" /___\\ ");
            this.playerArray.Add(" \\   / ");
            this.playerArray.Add("  \\ / ");
            this.playerArray.Add("   0  ");
            this.playerArray.Add("  /|\\ ");
            this.playerArray.Add("  / \\ ");
             this.playerArray.Add(" ");
             this.playerArray.Add("^^^^^^^");

           
            
        }

    }
}
