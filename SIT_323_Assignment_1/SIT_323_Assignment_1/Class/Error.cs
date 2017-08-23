using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIT_323_Assignment_1
{
    public class Error
    {
        // *****ATTRIBUTES HERE***** //
        Dictionary<string, string> errorList = new Dictionary<string, string>();
        
        // *****SET FUNCTIONS HERE***** //
        public void SetErrorList(string key,string value)
        {
            // error is have this key value
            foreach (string keyWord in this.errorList.Keys)
            {
                if (keyWord==key)
                {
                    return;
                }
            }
            this.errorList.Add(key, value);
        }

        // *****GET FUNCTIONS HERE***** //
        public Dictionary<string, string> GetErrorList()
        {
            return this.errorList;
        }

        // *****FUNCTIONS HERE***** //
        public int ErrorCheck(string readingLine, Error errorList)
        {
            int errorFlag = 1;
            if (!readingLine.StartsWith(@"CONFIGURATION_FILE") && !readingLine.StartsWith(@"WORDLIST_FILE") && !readingLine.StartsWith(@"ROWS") && !readingLine.StartsWith(@"COLUMNS") && !readingLine.StartsWith(@"ROW") && !readingLine.StartsWith(@"COLUMN") && !readingLine.StartsWith(@"LOGFILE_NAME") && !readingLine.StartsWith(@"MINIMUM_NUMBER_OF_UNIQUE_WORDS") && !readingLine.StartsWith(@"MAXIMUM_NUMBER_OF_UNIQUE_WORDS") && !readingLine.StartsWith(@"INVALID_CROZZLE_SCORE") && !readingLine.StartsWith(@"UPPERCASE") && !readingLine.StartsWith(@"STYLE") && !readingLine.StartsWith(@"BGCOLOUR_EMPTY_TD") && !readingLine.StartsWith(@"BGCOLOUR_NON_EMPTY_TD") && !readingLine.StartsWith(@"MINIMUM_NUMBER_OF_ROWS") && !readingLine.StartsWith(@"MAXIMUM_NUMBER_OF_ROWS") && !readingLine.StartsWith(@"MINIMUM_NUMBER_OF_COLUMNS") && !readingLine.StartsWith(@"MAXIMUM_NUMBER_OF_COLUMNS") && !readingLine.StartsWith(@"MINIMUM_HORIZONTAL_WORDS") && !readingLine.StartsWith(@"MAXIMUM_HORIZONTAL_WORDS") && !readingLine.StartsWith(@"MINIMUM_VERTICAL_WORDS") && !readingLine.StartsWith(@"MAXIMUM_VERTICAL_WORDS") && !readingLine.StartsWith(@"MINIMUM_INTERSECTIONS_IN_HORIZONTAL_WORDS") && !readingLine.StartsWith(@"MAXIMUM_INTERSECTIONS_IN_HORIZONTAL_WORDS") && !readingLine.StartsWith(@"MINIMUM_INTERSECTIONS_IN_VERTICAL_WORDS") && !readingLine.StartsWith(@"MAXIMUM_INTERSECTIONS_IN_VERTICAL_WORDS") && !readingLine.StartsWith(@"MINIMUM_NUMBER_OF_THE_SAME_WORD") && !readingLine.StartsWith(@"MAXIMUM_NUMBER_OF_THE_SAME_WORD") && !readingLine.StartsWith(@"MINIMUM_NUMBER_OF_GROUPS") && !readingLine.StartsWith(@"MAXIMUM_NUMBER_OF_GROUPS") && !readingLine.StartsWith(@"POINTS_PER_WORD") && !readingLine.StartsWith(@"INTERSECTING_POINTS_PER_LETTER") && !readingLine.StartsWith(@"NON_INTERSECTING_POINTS_PER_LETTER"))
            {
                errorList.SetErrorList(readingLine, "Missing word");
                errorFlag = -1;
            }

            if (!readingLine.Contains("="))
            {
                errorList.SetErrorList(readingLine, "Missing word");
                errorFlag = -1;
            }

            return errorFlag;
        }
        
    }
}
