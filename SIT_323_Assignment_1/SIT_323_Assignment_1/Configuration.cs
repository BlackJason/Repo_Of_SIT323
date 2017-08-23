using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIT_323_Assignment_1
{
    class Configuration
    {
        // *****ATTRIBUTES HERE***** //
        private string logFileName;
        private Int32 minNumOfEachWord=0;
        private Int32 maxNumOfEachWord=0;
        private string invalidCrozzleScore;
        private string isUppercase;
        private string outputStyle;
        private string outputColorEmpty;
        private string outputColorNonEmpty;
        private Int32 minNumOfRows=0;
        private Int32 maxNumOfRows=0;
        private Int32 minNumOfColumns=0;
        private Int32 maxNumOfColumns=0;
        private Int32 minHorWord=0;
        private Int32 maxHorWord=0;
        private Int32 minVerWord=0;
        private Int32 maxVerWord=0;
        private Int32 minIntersectionInHorWord=0;
        private Int32 maxIntersectionInHorWord=0;
        private Int32 minIntersectionInVerWord=0;
        private Int32 maxIntersectionInVerWord=0;
        private Int32 minNumOfSameWord=0;
        private Int32 maxNumOfSameWord=0;
        private Int32 minNumOfGroup=0;
        private Int32 maxNumOfgroup=0;
        private Int32 pointPerWord=0;
        private Dictionary<string, Int32> intersectionPointPerWord = new Dictionary<string, Int32>();
        private Dictionary<string, Int32> nonIntersectionPointPerWord = new Dictionary<string, Int32>();

        // *****SET FUNCTIONS HERE***** //
        public void SetLogFileName(string logFileName)
        {
            this.logFileName = logFileName;
        }
        public void SetMinNumOfEachWord(Int32 minNumOfEachWord)
        {
            this.minNumOfEachWord = minNumOfEachWord;
        }
        public void SetMaxNumOfEachWord(Int32 maxNumOfEachWord)
        {
            this.maxNumOfEachWord = maxNumOfEachWord;
        }
        public void SetInvalidCrozzleScore(string invalidCrozzleScore)
        {
            this.invalidCrozzleScore = invalidCrozzleScore;
        }
        public void SetIsUppercase(string isUppercase)
        {
            this.isUppercase = isUppercase;
        }
        public void SetOutputStyle(string outputStyle)
        {
            this.outputStyle = outputStyle;
        }
        public void SetOutputColorEmpty(string outputColorEmpty)
        {
            this.outputColorEmpty = outputColorEmpty;
        }
        public void SetOuputColorNonEmpty(string outputColorNonEmpty)
        {
            this.outputColorNonEmpty = outputColorNonEmpty;
        }
        public void SetMinNumOfRows(Int32 minNumOfRows)
        {
            this.minNumOfRows = minNumOfRows;
        }
        public void SetMaxNumOfRows(Int32 maxNumOfRows)
        {
            this.maxNumOfRows = maxNumOfRows;
        }
        public void SetMinNumOfColumns(Int32 minNumOfColumns)
        {
            this.minNumOfColumns = minNumOfColumns;
        }
        public void SetMaxNumOfColumns(Int32 maxNumOfColumns)
        {
            this.maxNumOfColumns = maxNumOfColumns;
        }
        public void SetMinHorWord(Int32 minHorWord)
        {
            this.minHorWord = minHorWord;
        }
        public void SetMaxHorWord(Int32 maxHorWord)
        {
            this.maxHorWord = maxHorWord;
        }
        public void SetMinVerWord(Int32 minVerWord)
        {
            this.minVerWord = minVerWord;
        }
        public void SetMaxVerWord(Int32 maxVerWord)
        {
            this.maxVerWord = maxVerWord;
        }
        public void SetMinIntersectionInHorWord(Int32 minIntersectionInHorWord)
        {
            this.minIntersectionInHorWord = minIntersectionInHorWord;
        }
        public void SetMaxIntersectionInHorWord(Int32 maxIntersectionInHorWord)
        {
            this.maxIntersectionInHorWord = maxIntersectionInHorWord;
        }
        public void SetMinIntersectionInVerWord(Int32 minIntersectionInVerWord)
        {
            this.minIntersectionInVerWord = minIntersectionInVerWord;
        }
        public void SetMaxIntersectionInVerWord(Int32 maxIntersectionInVerWord)
        {
            this.maxIntersectionInVerWord = maxIntersectionInVerWord;
        }
        public void SetMinNumOfSameWord(Int32 minNumOfSameWord)
        {
            this.minNumOfSameWord = minNumOfSameWord;
        }
        public void SetMaxNumOfSameWord(Int32 maxNumOfSameWord)
        {
            this.maxNumOfSameWord = maxNumOfSameWord;
        }
        public void SetMinNumOfGroup(Int32 minNumOfGroup)
        {
            this.minNumOfGroup = minNumOfGroup;
        }
        public void SetMaxNumOfgroup(Int32 maxNumOfgroup)
        {
            this.maxNumOfgroup = maxNumOfgroup;
        }
        public void SetPointPerWord(Int32 pointPerWord)
        {
            this.pointPerWord = pointPerWord;
        }
        public void SetIntersectionPointPerWord(Dictionary<string, Int32> intersectionPointPerWord)
        {
            this.intersectionPointPerWord = intersectionPointPerWord;
        }
        public void SetNonIntersectionPointPerWord(Dictionary<string, Int32> nonIntersectionPointPerWord)
        {
            this.nonIntersectionPointPerWord = nonIntersectionPointPerWord;
        }

        // *****GET FUNCTIONS HERE***** //
        public string GetLogFileName()
        {
            return this.logFileName;
        }
        public Int32 GetMinNumOfEachWord()
        {
            return this.minNumOfEachWord;
        }
        public Int32 GetMaxNumOfEachWord()
        {
            return this.maxNumOfEachWord;
        }
        public string GetInvalidCrozzleScore()
        {
            return this.invalidCrozzleScore;
        }
        public string GetIsUppercase()
        {
            return this.isUppercase;
        }
        public string GetOutputStyle()
        {
            return this.outputStyle;
        }
        public string GetOutputColorEmpty()
        {
            return this.outputColorEmpty;
        }
        public string GetOutputColorNonEmpty()
        {
            return this.outputColorNonEmpty;
        }
        public Int32 GetMinNumOfRows()
        {
            return this.minNumOfRows;
        }
        public Int32 GetMaxNumOfRows()
        {
            return this.maxNumOfRows;
        }
        public Int32 GetMinNumOfColumns()
        {
            return this.minNumOfColumns;
        }
        public Int32 GetMaxNumOfColumns()
        {
            return this.maxNumOfColumns;
        }
        public Int32 GetMinHorWord()
        {
            return this.minHorWord;
        }
        public Int32 GetMaxHorWord()
        {
            return this.maxHorWord;
        }
        public Int32 GetMinVerWord()
        {
            return this.minVerWord;
        }
        public Int32 GetMaxVerWord()
        {
            return this.maxVerWord;
        }
        public Int32 GetMinIntersectionInHorWord()
        {
            return this.minIntersectionInHorWord;
        }
        public Int32 GetMaxIntersectionInHorWord()
        {
            return this.maxIntersectionInHorWord;
        }
        public Int32 GetMinIntersectionInVerWord()
        {
            return this.minIntersectionInVerWord;
        }
        public Int32 GetMaxIntersectionInVerWord()
        {
            return this.maxIntersectionInVerWord;
        }
        public Int32 GetMinNumOfSameWord()
        {
            return this.minNumOfSameWord;
        }
        public Int32 GetMaxNumOfSameWord()
        {
            return this.maxNumOfSameWord;
        }
        public Int32 GetMinNumOfGroup()
        {
            return this.minNumOfGroup;
        }
        public Int32 GetMaxNumOfgroup()
        {
            return this.maxNumOfgroup;
        }
        public Int32 GetPointPerWord()
        {
            return this.pointPerWord;
        }
        public Dictionary<string, Int32> GetIntersectionPointPerWord()
        {
            return this.intersectionPointPerWord;
        }
        public Dictionary<string, Int32> GetNonIntersectionPointPerWord()
        {
            return this.nonIntersectionPointPerWord;
        }

        // *****FUNCTIONS HERE***** //
        // Function to load all things
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
                int errorFlag = Form1.errorList.ErrorCheck(thisLine, Form1.errorList);
                if (errorFlag == -1)
                {
                    continue;
                }
                // end error check

                this.SaveLogFileName(thisLine);
                this.SaveMinNumOfEachWord(thisLine);
                this.SaveMaxNumOfEachWord(thisLine);
                this.SaveInvalidCrozzleScore(thisLine);
                this.SaveIsUppercase(thisLine);
                this.SaveOutputStyle(thisLine);
                this.SaveOutputColorEmpty(thisLine);
                this.SaveOutputColorNonEmpty(thisLine);
                this.SaveMinNumOfRows(thisLine);
                this.SaveMaxNumOfRows(thisLine);
                this.SaveMinNumOfColumns(thisLine);
                this.SaveMaxNumOfColumns(thisLine);
                this.SaveMinHorWord(thisLine);
                this.SaveMaxHorWord(thisLine);
                this.SaveMinVerWord(thisLine);
                this.SaveMaxVerWord(thisLine);
                this.SaveMinIntersectionInHorWord(thisLine);
                this.SaveMaxIntersectionInHorWord(thisLine);
                this.SaveMinIntersectionInVerWord(thisLine);
                this.SaveMaxIntersectionInVerWord(thisLine);
                this.SaveminNumOfSameWord(thisLine);
                this.SavemaxNumOfSameWord(thisLine);
                this.SaveMinNumOfGroup(thisLine);
                this.SaveMaxNumOfGroup(thisLine);
                this.SavePointPerWord(thisLine);
                this.SaveIntersectionPointPerWord(thisLine);
                this.SaveNonIntersectionPointPerWord(thisLine);
            }

        }

        // Function to save log File Name
        public void SaveLogFileName(string readingLine)
        {
            if (readingLine.StartsWith(@"LOGFILE_NAME"))
            {
                char[] delimiterChars = { '=' };
                string[] temp = readingLine.Split(delimiterChars);
                temp[1] = temp[1].Replace("\"", "");
                this.logFileName = temp[1];
            }
        }

        // Function to save min num of words
        public void SaveMinNumOfEachWord(string readingLine)
        {
            if (readingLine.StartsWith(@"MINIMUM_NUMBER_OF_UNIQUE_WORDS"))
            {
                char[] delimiterChars = { '=' };
                string[] temp = readingLine.Split(delimiterChars);

                //error check incorrect format
                System.Text.RegularExpressions.Regex reg1 = new System.Text.RegularExpressions.Regex(Form1.numFormat);
                if (!reg1.IsMatch(temp[1]) || temp[1] == "")
                {
                    Form1.errorList.SetErrorList(readingLine, "Incorrect format");
                    return;
                }
                //error check overload
                if (this.minNumOfEachWord != 0)
                {
                    Form1.errorList.SetErrorList(readingLine, "Duplicate  this value");
                    return;
                }
                //end error check

                this.minNumOfEachWord = Convert.ToInt32(temp[1]);
            }
        }

        // Function to save max num of words
        public void SaveMaxNumOfEachWord(string readingLine)
        {
            if (readingLine.StartsWith(@"MAXIMUM_NUMBER_OF_UNIQUE_WORDS"))
            {
                char[] delimiterChars = { '=' };
                string[] temp = readingLine.Split(delimiterChars);

                //error check incorrect format
                System.Text.RegularExpressions.Regex reg1 = new System.Text.RegularExpressions.Regex(Form1.numFormat);
                if (!reg1.IsMatch(temp[1]) || temp[1] == "")
                {
                    Form1.errorList.SetErrorList(readingLine, "Incorrect format");
                    return;
                }
                //error check overload
                if (this.maxNumOfEachWord != 0)
                {
                    Form1.errorList.SetErrorList(readingLine, "Duplicate  this value");
                    return;
                }
                //end error check

                this.maxNumOfEachWord = Convert.ToInt32(temp[1]);
            }
        }

        // Function to save invalid crozzle score
        public void SaveInvalidCrozzleScore(string readingLine)
        {
            if (readingLine.StartsWith(@"INVALID_CROZZLE_SCORE"))
            {
                char[] delimiterChars = { '=' };
                string[] temp = readingLine.Split(delimiterChars);
                this.invalidCrozzleScore = temp[1];
            }
        }

        // Function to save uppercase
        public void SaveIsUppercase(string readingLine)
        {
            if (readingLine.StartsWith(@"UPPERCASE"))
            {
                char[] delimiterChars = { '=' };
                string[] temp = readingLine.Split(delimiterChars);

                //error check incorrect format
                System.Text.RegularExpressions.Regex reg1 = new System.Text.RegularExpressions.Regex(Form1.lowLetterFormat);
                if (!reg1.IsMatch(temp[1]))
                {
                    Form1.errorList.SetErrorList(readingLine, "Here should use lowercase letter");
                    return;
                }
                this.isUppercase = temp[1];
            }
        }

        // Function to save output style
        public void SaveOutputStyle(string readingLine)
        {
            if (readingLine.StartsWith(@"STYLE"))
            {
                char[] delimiterChars = { '=' };
                string[] temp = readingLine.Split(delimiterChars);
                string deleteChar = "\"";
                temp[1] = temp[1].Replace(deleteChar, "");
                this.outputStyle = temp[1];
            }
        }

        // Function to save bgcolour empty td
        public void SaveOutputColorEmpty(string readingLine)
        {
            if (readingLine.StartsWith(@"BGCOLOUR_EMPTY_TD"))
            {
                char[] delimiterChars = { '=' };
                string[] temp = readingLine.Split(delimiterChars);

                //error check incorrect format
                System.Text.RegularExpressions.Regex reg1 = new System.Text.RegularExpressions.Regex(Form1.colorFormat);
                if (!reg1.IsMatch(temp[1]))
                {
                    Form1.errorList.SetErrorList(readingLine, "Incorrect color code");
                    return;
                }
                //end error check

                this.outputColorEmpty = temp[1];
            }
        }

        // Function to save bgcolour non empty td
        public void SaveOutputColorNonEmpty(string readingLine)
        {
            if (readingLine.StartsWith(@"BGCOLOUR_NON_EMPTY_TD"))
            {
                char[] delimiterChars = { '=' };
                string[] temp = readingLine.Split(delimiterChars);

                //error check incorrect format
                System.Text.RegularExpressions.Regex reg1 = new System.Text.RegularExpressions.Regex(Form1.colorFormat);
                if (!reg1.IsMatch(temp[1]))
                {
                    Form1.errorList.SetErrorList(readingLine, "Incorrect color code");
                    return;
                }
                //end error check
                this.outputColorNonEmpty = temp[1];
            }
        }

        // Function to save min num of rows
        public void SaveMinNumOfRows(string readingLine)
        {
            if (readingLine.StartsWith(@"MINIMUM_NUMBER_OF_ROWS"))
            {
                char[] delimiterChars = { '=' };
                string[] temp = readingLine.Split(delimiterChars);
                //error check incorrect format
                System.Text.RegularExpressions.Regex reg1 = new System.Text.RegularExpressions.Regex(Form1.numFormat);
                if (!reg1.IsMatch(temp[1]))
                {
                    Form1.errorList.SetErrorList(readingLine, "Incorrect format");
                    return;
                }
                //error check overload
                if (this.minNumOfRows != 0)
                {
                    Form1.errorList.SetErrorList(readingLine, "Duplicate  this value");
                    return;
                }
                //end error check
                this.minNumOfRows = Convert.ToInt32(temp[1]);
            }
        }

        // FUnction to save man num of rows
        public void SaveMaxNumOfRows(string readingLine)
        {
            if (readingLine.StartsWith(@"MAXIMUM_NUMBER_OF_ROWS"))
            {
                char[] delimiterChars = { '=' };
                string[] temp = readingLine.Split(delimiterChars);

                //error check incorrect format
                System.Text.RegularExpressions.Regex reg1 = new System.Text.RegularExpressions.Regex(Form1.numFormat);
                if (!reg1.IsMatch(temp[1]))
                {
                    Form1.errorList.SetErrorList(readingLine, "Incorrect format");
                    return;
                }

                //error check overload
                if (this.maxNumOfRows != 0)
                {
                    Form1.errorList.SetErrorList(readingLine, "Duplicate  this value");
                    return;
                }
                //end error check

                this.maxNumOfRows = Convert.ToInt32(temp[1]);
            }
        }

        // Function to save min num of columns
        public void SaveMinNumOfColumns(string readingLine)
        {
            if (readingLine.StartsWith(@"MINIMUM_NUMBER_OF_COLUMNS"))
            {
                char[] delimiterChars = { '=' };
                string[] temp = readingLine.Split(delimiterChars);

                //error check incorrect format
                System.Text.RegularExpressions.Regex reg1 = new System.Text.RegularExpressions.Regex(Form1.numFormat);
                if (!reg1.IsMatch(temp[1]))
                {
                    Form1.errorList.SetErrorList(readingLine, "Incorrect format");
                    return;
                }
                //error check overload
                if (this.minNumOfColumns != 0)
                {
                    Form1.errorList.SetErrorList(readingLine, "Duplicate  this value");
                    return;
                }
                //end error check

                this.minNumOfColumns = Convert.ToInt32(temp[1]);
            }
        }

        // Function to save max num of columns
        public void SaveMaxNumOfColumns(string readingLine)
        {
            if (readingLine.StartsWith(@"MAXIMUM_NUMBER_OF_COLUMNS"))
            {
                char[] delimiterChars = { '=' };
                string[] temp = readingLine.Split(delimiterChars);

                //error check incorrect format
                System.Text.RegularExpressions.Regex reg1 = new System.Text.RegularExpressions.Regex(Form1.numFormat);
                if (!reg1.IsMatch(temp[1]))
                {
                    Form1.errorList.SetErrorList(readingLine, "Incorrect format");
                    return;
                }
                //error check overload
                if (this.maxNumOfColumns != 0)
                {
                    Form1.errorList.SetErrorList(readingLine, "Duplicate  this value");
                    return;
                }
                //end error check

                this.maxNumOfColumns = Convert.ToInt32(temp[1]);
            }
        }

        // Function to save min hor words
        public void SaveMinHorWord(string readingLine)
        {
            if (readingLine.StartsWith(@"MINIMUM_HORIZONTAL_WORDS"))
            {
                char[] delimiterChars = { '=' };
                string[] temp = readingLine.Split(delimiterChars);

                //error check incorrect format
                System.Text.RegularExpressions.Regex reg1 = new System.Text.RegularExpressions.Regex(Form1.numFormat);
                if (!reg1.IsMatch(temp[1]) || temp[1]=="")
                {
                    Form1.errorList.SetErrorList(readingLine, "Incorrect format");
                    return;
                }
                //error check overload
                if (this.minHorWord != 0)
                {
                    Form1.errorList.SetErrorList(readingLine, "Duplicate  this value");
                    return;
                }
                //end error check

                this.minHorWord = Convert.ToInt32(temp[1]);
            }
        }

        // Function to save max hor words
        public void SaveMaxHorWord(string readingLine)
        {
            if (readingLine.StartsWith(@"MAXIMUM_HORIZONTAL_WORDS"))
            {
                char[] delimiterChars = { '=' };
                string[] temp = readingLine.Split(delimiterChars);

                //error check incorrect format
                System.Text.RegularExpressions.Regex reg1 = new System.Text.RegularExpressions.Regex(Form1.numFormat);
                if (!reg1.IsMatch(temp[1]))
                {
                    Form1.errorList.SetErrorList(readingLine, "Incorrect format");
                    return;
                }
                //error check overload
                if (this.maxHorWord != 0)
                {
                    Form1.errorList.SetErrorList(readingLine, "Duplicate  this value");
                    return;
                }
                //end error check

                this.maxHorWord = Convert.ToInt32(temp[1]);
            }
        }

        // Function to save min ver words
        public void SaveMinVerWord(string readingLine)
        {
            if (readingLine.StartsWith(@"MINIMUM_VERTICAL_WORDS"))
            {
                char[] delimiterChars = { '=' };
                string[] temp = readingLine.Split(delimiterChars);

                //error check incorrect format
                System.Text.RegularExpressions.Regex reg1 = new System.Text.RegularExpressions.Regex(Form1.numFormat);
                if (!reg1.IsMatch(temp[1]))
                {
                    Form1.errorList.SetErrorList(readingLine, "Incorrect format");
                    return;
                }
                //error check overload
                if (this.minVerWord != 0)
                {
                    Form1.errorList.SetErrorList(readingLine, "Duplicate  this value");
                    return;
                }
                //end error check

                this.minVerWord = Convert.ToInt32(temp[1]);
            }
        }

        // Function to save max ver words
        public void SaveMaxVerWord(string readingLine)
        {
            if (readingLine.StartsWith(@"MAXIMUM_VERTICAL_WORDS"))
            {
                char[] delimiterChars = { '=' };
                string[] temp = readingLine.Split(delimiterChars);

                //error check incorrect format
                System.Text.RegularExpressions.Regex reg1 = new System.Text.RegularExpressions.Regex(Form1.numFormat);
                if (!reg1.IsMatch(temp[1]))
                {
                    Form1.errorList.SetErrorList(readingLine, "Incorrect format");
                    return;
                }
                //error check overload
                if (this.maxVerWord != 0)
                {
                    Form1.errorList.SetErrorList(readingLine, "Duplicate  this value");
                    return;
                }
                //end error check

                this.maxVerWord = Convert.ToInt32(temp[1]);
            }
        }

        // Function to save min intersetion in hor words
        public void SaveMinIntersectionInHorWord(string readingLine)
        {
            if (readingLine.StartsWith(@"MINIMUM_INTERSECTIONS_IN_HORIZONTAL_WORDS"))
            {
                char[] delimiterChars = { '=' };
                string[] temp = readingLine.Split(delimiterChars);

                //error check incorrect format
                System.Text.RegularExpressions.Regex reg1 = new System.Text.RegularExpressions.Regex(Form1.numFormat);
                if (!reg1.IsMatch(temp[1]))
                {
                    Form1.errorList.SetErrorList(readingLine, "Incorrect format");
                    return;
                }
                //error check overload
                if (this.minIntersectionInHorWord != 0)
                {
                    Form1.errorList.SetErrorList(readingLine, "Duplicate  this value");
                    return;
                }
                //end error check

                this.minIntersectionInHorWord = Convert.ToInt32(temp[1]);
            }
        }

        // Function to save max intersetion in hor words
        public void SaveMaxIntersectionInHorWord(string readingLine)
        {
            if (readingLine.StartsWith(@"MAXIMUM_INTERSECTIONS_IN_HORIZONTAL_WORDS"))
            {
                char[] delimiterChars = { '=' };
                string[] temp = readingLine.Split(delimiterChars);

                //error check incorrect format
                System.Text.RegularExpressions.Regex reg1 = new System.Text.RegularExpressions.Regex(Form1.numFormat);
                if (!reg1.IsMatch(temp[1]))
                {
                    Form1.errorList.SetErrorList(readingLine, "Incorrect format");
                    return;
                }
                //error check overload
                if (this.maxIntersectionInHorWord != 0)
                {
                    Form1.errorList.SetErrorList(readingLine, "Duplicate  this value");
                    return;
                }
                //end error check

                this.maxIntersectionInHorWord = Convert.ToInt32(temp[1]);
            }
        }

        // Function to save min intersetion in ver words
        public void SaveMinIntersectionInVerWord(string readingLine)
        {
            if (readingLine.StartsWith(@"MINIMUM_INTERSECTIONS_IN_VERTICAL_WORDS"))
            {
                char[] delimiterChars = { '=' };
                string[] temp = readingLine.Split(delimiterChars);

                //error check incorrect format
                System.Text.RegularExpressions.Regex reg1 = new System.Text.RegularExpressions.Regex(Form1.numFormat);
                if (!reg1.IsMatch(temp[1]))
                {
                    Form1.errorList.SetErrorList(readingLine, "Incorrect format");
                    return;
                }
                //error check overload
                if (this.minIntersectionInVerWord != 0)
                {
                    Form1.errorList.SetErrorList(readingLine, "Duplicate  this value");
                    return;
                }
                //end error check

                this.minIntersectionInVerWord = Convert.ToInt32(temp[1]);
            }
        }

        // Function to save max intersetion in ver words
        public void SaveMaxIntersectionInVerWord(string readingLine)
        {
            if (readingLine.StartsWith(@"MAXIMUM_INTERSECTIONS_IN_VERTICAL_WORDS"))
            {
                char[] delimiterChars = { '=' };
                string[] temp = readingLine.Split(delimiterChars);

                //error check incorrect format
                System.Text.RegularExpressions.Regex reg1 = new System.Text.RegularExpressions.Regex(Form1.numFormat);
                if (!reg1.IsMatch(temp[1]))
                {
                    Form1.errorList.SetErrorList(readingLine, "Incorrect format");
                    return;
                }
                //error check overload
                if (this.maxIntersectionInVerWord != 0)
                {
                    Form1.errorList.SetErrorList(readingLine, "Duplicate  this value");
                    return;
                }
                //end error check

                this.maxIntersectionInVerWord = Convert.ToInt32(temp[1]);
            }
        }

        // Function to save min num of the save word
        public void SaveminNumOfSameWord(string readingLine)
        {
            if (readingLine.StartsWith(@"MINIMUM_NUMBER_OF_THE_SAME_WORD"))
            {
                char[] delimiterChars = { '=' };
                string[] temp = readingLine.Split(delimiterChars);

                //error check incorrect format
                System.Text.RegularExpressions.Regex reg1 = new System.Text.RegularExpressions.Regex(Form1.numFormat);
                if (!reg1.IsMatch(temp[1]))
                {
                    Form1.errorList.SetErrorList(readingLine, "Incorrect format");
                    return;
                }
                //error check overload
                if (this.minNumOfSameWord != 0)
                {
                    Form1.errorList.SetErrorList(readingLine, "Duplicate  this value");
                    return;
                }
                //end error check

                this.minNumOfSameWord = Convert.ToInt32(temp[1]);
            }
        }

        // Function to save max num of the save word
        public void SavemaxNumOfSameWord(string readingLine)
        {
            if (readingLine.StartsWith(@"MAXIMUM_NUMBER_OF_THE_SAME_WORD"))
            {
                char[] delimiterChars = { '=' };
                string[] temp = readingLine.Split(delimiterChars);

                //error check incorrect format
                System.Text.RegularExpressions.Regex reg1 = new System.Text.RegularExpressions.Regex(Form1.numFormat);
                if (!reg1.IsMatch(temp[1]))
                {
                    Form1.errorList.SetErrorList(readingLine, "Incorrect format");
                    return;
                }
                //error check overload
                if (this.maxNumOfSameWord != 0)
                {
                    Form1.errorList.SetErrorList(readingLine, "Duplicate  this value");
                    return;
                }
                //end error check

                this.maxNumOfSameWord = Convert.ToInt32(temp[1]);
            }
        }

        // Function to save min num of groups
        public void SaveMinNumOfGroup(string readingLine)
        {
            if (readingLine.StartsWith(@"MINIMUM_NUMBER_OF_GROUPS"))
            {
                char[] delimiterChars = { '=' };
                string[] temp = readingLine.Split(delimiterChars);

                //error check incorrect format
                System.Text.RegularExpressions.Regex reg1 = new System.Text.RegularExpressions.Regex(Form1.numFormat);
                if (!reg1.IsMatch(temp[1]))
                {
                    Form1.errorList.SetErrorList(readingLine, "Incorrect format");
                    return;
                }
                //error check overload
                if (this.minNumOfGroup != 0)
                {
                    Form1.errorList.SetErrorList(readingLine, "Duplicate  this value");
                    return;
                }
                //end error check

                this.minNumOfGroup = Convert.ToInt32(temp[1]);
            }
        }

        // Function to save max num of groups
        public void SaveMaxNumOfGroup(string readingLine)
        {
            if (readingLine.StartsWith(@"MAXIMUM_NUMBER_OF_GROUPS"))
            {
                char[] delimiterChars = { '=' };
                string[] temp = readingLine.Split(delimiterChars);

                //error check incorrect format
                System.Text.RegularExpressions.Regex reg1 = new System.Text.RegularExpressions.Regex(Form1.numFormat);
                if (!reg1.IsMatch(temp[1]))
                {
                    Form1.errorList.SetErrorList(readingLine, "Incorrect format");
                    return;
                }
                //error check overload
                if (this.maxNumOfgroup != 0)
                {
                    Form1.errorList.SetErrorList(readingLine, "Duplicate  this value");
                    return;
                }
                //end error check

                this.maxNumOfgroup = Convert.ToInt32(temp[1]);
            }
        }

        // Function to save point per word
        public void SavePointPerWord(string readingLine)
        {
            if (readingLine.StartsWith(@"POINTS_PER_WORD"))
            {
                char[] delimiterChars = { '=' };
                string[] temp = readingLine.Split(delimiterChars);

                //error check incorrect format
                System.Text.RegularExpressions.Regex reg1 = new System.Text.RegularExpressions.Regex(Form1.numFormat);
                if (!reg1.IsMatch(temp[1]))
                {
                    Form1.errorList.SetErrorList(readingLine, "Incorrect format");
                    return;
                }
                //error check overload
                if (this.pointPerWord != 0)
                {
                    Form1.errorList.SetErrorList(readingLine, "Duplicate  this value");
                    return;
                }
                //end error check

                this.pointPerWord = Convert.ToInt32(temp[1]);
            }
        }

        // FUnction to save point of intersection word
        public void SaveIntersectionPointPerWord(string readingLine)
        {
            if (readingLine.StartsWith(@"INTERSECTING_POINTS_PER_LETTER"))
            {
                char[] delimiterChars = { '=', '"', ',' };
                string[] temp = readingLine.Split(delimiterChars);
                for(int i=2; i < temp.Length-1; i=i+2)
                {
                   this.intersectionPointPerWord.Add(temp[i], Convert.ToInt32(temp[i + 1]));
                }
            }
        }

        // Function to save point of non intersection word
        public void SaveNonIntersectionPointPerWord(string readingLine)
        {
            if (readingLine.StartsWith(@"NON_INTERSECTING_POINTS_PER_LETTER"))
            {
                char[] delimiterChars = { '=', '"', ',' };
                string[] temp = readingLine.Split(delimiterChars);
                for (int i = 2; i < temp.Length - 1; i = i + 2)
                {
                    this.nonIntersectionPointPerWord.Add(temp[i], Convert.ToInt32(temp[i + 1]));
                }
            }
        }

    }

}
