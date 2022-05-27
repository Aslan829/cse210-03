using System;
using System.Collections.Generic;

namespace cse210_03
{
    //This class holds all the possible words in a list.
    public class WordList
    {
        public List<string> wordsList = new List<string>();


        //Sets up word list.
        public WordList()
        {
            this.wordsList.Add("friendship");
            this.wordsList.Add("scary");
            this.wordsList.Add("noodles");
            this.wordsList.Add("flabergasted");
            this.wordsList.Add("excitement");
            this.wordsList.Add("assistance");
           
        }
    }
}
