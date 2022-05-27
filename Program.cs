using System;

namespace cse210_03
{
    //This is the main processing program.
    class Program
    {
        //This connects and runs all the functions in each class.
        static void Main(string[] args)
        {
            Game game = new Game();
            Words word = new Words();
            Player player = new Player();


            while (player.playerArray.Count >= 5  && !player.playerWin){
               
                player.playerWin = game.playRound(word.letterList, player.playerArray, word.blankList, player.playerWin);
            }

            

        }

    }
}
