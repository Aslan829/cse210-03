using System;
using System.Collections.Generic;
using System.Linq;

namespace cse210_03
{
    public class Game
    {
        public bool playRound(char[] letList, List<string> player, char[] blankList, bool isWin){
            Console.WriteLine("Guess a letter [a-z]: ");
            char testLetter = Console.ReadKey().KeyChar;
            Console.WriteLine("\n");


            
            //customize to add letters already figured out
            bool isIn = false;
            for(int i = 0; i < letList.Length; i++)
            {
                

                char ch1 = letList[i];
                char ch2 = testLetter;


                if(letList[i].Equals(testLetter)){
                    blankList[i] = testLetter;
                    //Console.Write(letList[i] + " ");
                    isIn = true;
                }
                Console.Write(blankList[i] + " ");
            }
            
            Console.WriteLine("\n ");

            //sees if letter was in word
            if (isIn == false ){
                player.RemoveAt(0);
            }

            if (player.Count == 4){
                Console.WriteLine("   X  ");
            }
            //prints player
            foreach (string line in player)
            {

                Console.WriteLine(line);
            }

            //sees if arrays are equal
            if(Enumerable.SequenceEqual(letList, blankList)){
                isWin = true;
                Console.WriteLine("You win!");
            }
            
            return isWin;
        }
            
        
            
    }


    }

