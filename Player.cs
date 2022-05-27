using System;
using System.Collections.Generic;


namespace cse210_03
{
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

           /* for (int i = 0; i < this.playerArray.Count; i++){
                Console.WriteLine(this.playerArray[i]);
            }*/
            
        }

    }
}
