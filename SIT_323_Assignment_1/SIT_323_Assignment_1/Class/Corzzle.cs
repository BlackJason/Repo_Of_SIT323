using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIT_323_Assignment_1
{
    class Crozzle
    {
        // *****ATTRIBUTES HERE***** //
        private string pathOfConfigurationFile;
        private string pathOfWordListFile;
        private int rowsOfCrozzle=15;// init value
        private int columnsOfCrozzle=15;// init value
        private List<WordOfRow> rowWords = new List<WordOfRow>();
        private List<WordOfColumn> columnWords = new List<WordOfColumn>();

        // *****OBJECTS HERE***** //
        Configuration config = new Configuration();
        WordList words = new WordList();

        // *****GET FUNCTIONS HERE***** //
        public string GetpathOfConfigurationFile()
        {
            return this.pathOfConfigurationFile;
        }
        public string GetpathOfWordListFile()
        {
            return this.pathOfWordListFile;
        }
        public int GetRowsOfCrozzle()
        {
            return this.rowsOfCrozzle;
        }
        public int GetColumnsOfCrozzle()
        {
            return this.columnsOfCrozzle;
        }
        public List<WordOfRow> GetRowWords()
        {
            return this.rowWords;
        }
        public List<WordOfColumn> GetcolumnWords()
        {
            return this.columnWords;
        }

        // *****FUNCTIONS HERE***** //
        // Function to load all files
        public void LoadAll(string fileName)
        {
            StreamReader readWords = new StreamReader(fileName, Encoding.Default);
            string thisLine;
            while ((thisLine = readWords.ReadLine()) != null)
            {
                int commIndex = thisLine.IndexOf(@"//");
                if (commIndex >= 0)
                {
                    thisLine = thisLine.Remove(commIndex);
                    thisLine = thisLine.Trim();
                }
                if (thisLine.Length == 0)
                    continue;
                // error check missing first word
                int errorFlag = Form1.errorListOfCrozzle.ErrorCheck(thisLine, Form1.errorListOfCrozzle);
                if (errorFlag == -1)
                {
                    continue;
                }

                this.SaveConfigurationPath(thisLine, fileName);
                this.SaveWordListFilePath(thisLine, fileName);
                this.SaveRows(thisLine);
                this.SaveColumns(thisLine);
                this.SaveRowWordData(thisLine);
                this.SaveColumnWordData(thisLine);
            }

            //Error testError = Form1.errorList;
        }

        // Function to save configuration path
        public void SaveConfigurationPath(string readingLine, string filePath)
        {
            if (readingLine.StartsWith(@"CONFIGURATION_FILE"))
            {
                filePath = Path.GetDirectoryName(filePath);
                char[] delimiterChars = {'='};
                string[] temp = readingLine.Split(delimiterChars);
                temp[1] = temp[1].Replace("\"","");
                temp[1] = temp[1].Replace(".\\", "\\");
                filePath += temp[1];
                this.pathOfConfigurationFile = filePath;

                //load config document
                config.LoadAll(this.pathOfConfigurationFile);
            }
        }

        // Function to save Word list file path
        public void SaveWordListFilePath(string readingLine, string filePath)
        {
            if (readingLine.StartsWith(@"WORDLIST_FILE"))
            {
                filePath = Path.GetDirectoryName(filePath);
                char[] delimiterChars = { '=' };
                string[] temp = readingLine.Split(delimiterChars);
                temp[1] = temp[1].Replace("\"", "");
                temp[1] = temp[1].Replace(".\\", "\\");
                filePath += temp[1];
                this.pathOfWordListFile = filePath;

                //load word list document
                //words.LoadWords(this.pathOfWordListFile);
            }
        }

        // Function to save ROWS
        public void SaveRows(string readingLine)
        {
            if (readingLine.StartsWith(@"ROWS"))
            {
                char[] delimiterChars = { '=' };
                string[] temp = readingLine.Split(delimiterChars);
                //error check miss word
                if (temp.Length!=2)
                {
                    Form1.errorListOfCrozzle.SetErrorList(readingLine, "Missing word");
                    return;
                }

                this.rowsOfCrozzle = Convert.ToInt32(temp[1]);
            }
        }

        // Function to save Columns
        public void SaveColumns(string readingLine)
        {
            if (readingLine.StartsWith(@"COLUMNS"))
            {
                char[] delimiterChars = { '=' };
                string[] temp = readingLine.Split(delimiterChars);
                //error check miss word
                if (temp.Length != 2)
                {
                    Form1.errorListOfCrozzle.SetErrorList(readingLine, "Missing word");
                    return;
                }
                this.columnsOfCrozzle = Convert.ToInt32(temp[1]);
            }
        }

        // Function to save word data (rows)
        public void SaveRowWordData(string readingLine)
        {
            if (readingLine.StartsWith(@"ROW="))
            {
                char[] delimiterChars = { '=', ',' ,',' };
                string[] temp = readingLine.Split(delimiterChars);
                List<string> wordTemp = new List<string>();
                WordOfRow temp2 = new WordOfRow();

                // error check missing word
                for(int i = 0; i < temp.Count(); i++)
                {
                    if (temp[i] == "")
                    {
                        Form1.errorListOfCrozzle.SetErrorList(readingLine, "Missing word");
                        return;
                    }
                }

                // error check incorrect format
                if (temp.Count() != 4)
                {
                    Form1.errorListOfCrozzle.SetErrorList(readingLine, "Missing word");
                    return;
                }
                System.Text.RegularExpressions.Regex reg1 = new System.Text.RegularExpressions.Regex(Form1.numFormat);
                if (!reg1.IsMatch(temp[1])){
                    Form1.errorListOfCrozzle.SetErrorList(readingLine, "Incorrect format");
                    return;
                }
                else if(!reg1.IsMatch(temp[3])){
                    Form1.errorListOfCrozzle.SetErrorList(readingLine, "Incorrect format");
                    return;
                }

                //error check incorrect format
                System.Text.RegularExpressions.Regex reg2 = new System.Text.RegularExpressions.Regex(Form1.letterFormat);
                if (!reg2.IsMatch(temp[2]))
                {
                    Form1.errorListOfCrozzle.SetErrorList(readingLine, "Incorrect format");
                    return;
                }
                //end error check

                temp2.SetPosition(Convert.ToInt32(temp[1]));
                for(int i = 0; i < temp[2].Length; i++)
                {
                    wordTemp.Add(temp[2].Substring(i,1));
                }
                temp2.SetWrod(wordTemp);
                temp2.SetBeginIndex(Convert.ToInt32(temp[3]));
                rowWords.Add(temp2);
            }
        }

        // Function to save word data (rows)
        public void SaveColumnWordData(string readingLine)
        {
            if (readingLine.StartsWith(@"COLUMN="))
            {
                char[] delimiterChars = { '=', ',', ',' };
                string[] temp = readingLine.Split(delimiterChars);
                List<string> wordTemp = new List<string>();
                WordOfColumn temp2 = new WordOfColumn();

                // error check missing word
                for (int i = 0; i < temp.Count(); i++)
                {
                    if (temp[i] == "")
                    {
                        Form1.errorListOfCrozzle.SetErrorList(readingLine, "Missing word");
                        return;
                    }
                }

                // error check incorrect format
                if (temp.Count() != 4)
                {
                    Form1.errorListOfCrozzle.SetErrorList(readingLine, "Missing word");
                    return;
                }
                System.Text.RegularExpressions.Regex reg1 = new System.Text.RegularExpressions.Regex(Form1.numFormat);
                if (!reg1.IsMatch(temp[1]))
                {
                    Form1.errorListOfCrozzle.SetErrorList(readingLine, "Incorrect format");
                    return;
                }
                else if (!reg1.IsMatch(temp[3]))
                {
                    Form1.errorListOfCrozzle.SetErrorList(readingLine, "Incorrect format");
                    return;
                }

                //error check incorrect format
                System.Text.RegularExpressions.Regex reg2 = new System.Text.RegularExpressions.Regex(Form1.letterFormat);
                if (!reg2.IsMatch(temp[2]))
                {
                    Form1.errorListOfCrozzle.SetErrorList(readingLine, "Incorrect format");
                    return;
                }
                //end error check

                temp2.SetPosition(Convert.ToInt32(temp[1]));
                for (int i = 0; i < temp[2].Length; i++)
                {
                    wordTemp.Add(temp[2].Substring(i, 1));
                }
                temp2.SetWrod(wordTemp);
                temp2.SetBeginIndex(Convert.ToInt32(temp[3]));
                columnWords.Add(temp2);
            }
        }
    }
}
