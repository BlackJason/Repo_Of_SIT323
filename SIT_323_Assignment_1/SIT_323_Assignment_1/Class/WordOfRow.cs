using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIT_323_Assignment_1
{
    class WordOfRow
    {
        // *****ATTRIBUTES HERE***** //
        private int position;
        private List<string> word;
        private int beginIndex;

        // *****SET FUNCTIONS HERE***** //
        // function to set position
        public void SetPosition(int value)
        {
            this.position = value;
        }

        //function to set word
        public void SetWrod(List<string> value)
        {
            this.word = value;
        }

        //function to set word
        public void SetBeginIndex(int value)
        {
            this.beginIndex = value;
        }


        // *****GET FUNCTIONS HERE***** //
        // function to get position
        public int GetPosition()
        {
            return this.position;
        }

        // Function to get word
        public List<string> GetWord()
        {
            return this.word;
        }

        // Functioin to get beginIndex
        public int GetBeginIndex()
        {
            return this.beginIndex;
        }

    }
}
