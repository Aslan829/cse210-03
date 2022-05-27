using System;
using System.Collections.Generic;
using System.IO; // if want to read file

namespace cse210_03
{
    //This holds a random word from the word list and the letter list.
    public class Words
    {
       private string word;
       public char[] letterList;
       public char[] blankList;

        //This selects the word from the word list, and seperates it into a letter list. 
       public Words()
       {
            
            WordList list = new WordList();

            Random randm = new Random();
            int num = randm.Next(0,6);

            //Picks a random word in the list.
            this.word = list.wordsList[num];

            //Split word into letters
            this.letterList = this.word.ToCharArray();
            
            //Make a blank version of the letter list
            this.blankList = this.word.ToCharArray();
            for(int i = 0; i < this.blankList.Length; i++){
                this.blankList[i] = '_';
            }
            

       }
    

    

    }
}
