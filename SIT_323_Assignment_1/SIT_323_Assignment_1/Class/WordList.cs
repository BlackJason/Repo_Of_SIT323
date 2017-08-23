using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIT_323_Assignment_1
{
    class WordList
    {
        // *****ATTRIBUTES HERE***** //

        private string[] wordsMembers;

        // *****GET FUNCTIONS HERE***** //

        //get wordsMembers
        public string[] GetWrodsMembers()
        {
            return this.wordsMembers;
        }
        
        // *****FUNCTIONS HERE***** //

        // Function to load document to wordlist
        public void LoadWords(string fileName)
        {
            StreamReader readWords = new StreamReader(fileName, Encoding.Default);
            string thisLine;
            while ((thisLine = readWords.ReadLine()) != null)
            {
                string[] temp;
                char[] separator = { ',' };
                temp = thisLine.Split(separator);
                this.wordsMembers = temp;
            }

            
        }
    }
}
