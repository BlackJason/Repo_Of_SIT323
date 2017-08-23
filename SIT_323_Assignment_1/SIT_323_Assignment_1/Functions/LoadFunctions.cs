using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIT_323_Assignment_1
{
    class LoadFunctions
    {
        // *****ATTRIBUTES HERE***** //
        private string fileName;
        private string directoryName;

        // *****LOAD OBJECTS HERE***** //
        WordList words = new WordList();
        Crozzle croz = new Crozzle();
        Configuration config = new Configuration();
        
        public string GetFIleName()
        {
            return this.fileName;
        }

        // *****FUNCTIONS HERE***** //
        // Function to choose a document

        public void BowserFile()
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            DialogResult result;

            result = openDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                fileName = openDialog.FileName;
                directoryName = Path.GetDirectoryName(fileName);
                MessageBox.Show(fileName);

                if (!File.Exists(fileName))
                {
                    MessageBox.Show("error: file missing");
                }
            }
            else
            {
                fileName = "";
                MessageBox.Show("file not selected");
            }
        }

        // Function to load words
        public void LoadWords()
        {
            // Using function LoadWords from class WordList
            words.LoadWords(croz.GetpathOfWordListFile());
        }

        // Function to load Crozzle
        public void LoadCrozzle(string filePath)
        {
            croz.LoadAll(filePath);
            // fileName = croz.GetpathOfConfigurationFile();
        }

        // Function to load configuration
        public void LoadConfiguration()
        {
            config.LoadAll(croz.GetpathOfConfigurationFile());
        }
        
        // Function to display a crozzle
        public void DisplayCrozzle(WebBrowser displayWindows)
        {
            int rows = croz.GetRowsOfCrozzle();
            int columns = croz.GetColumnsOfCrozzle();
            String[,] grid = new String[rows, columns];
            List<string> scoreLetter = new List<string>();
            List<WordOfRow> rowWords = croz.GetRowWords();
            List<WordOfColumn> columnWrods = croz.GetcolumnWords();
            Dictionary<string, int> intersectionPointPerLetter = config.GetIntersectionPointPerWord();
            int score = 0;

            score = (rowWords.Count + columnWrods.Count) * config.GetPointPerWord();

            // save row word to 2d array
            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    for (int i = 0; i < rowWords.Count; i++)
                    {
                        if (rowWords[i].GetPosition() == row + 1 && rowWords[i].GetBeginIndex() == column + 1)
                        {
                            int tempBeginIndex = rowWords[i].GetBeginIndex();
                            List<string> tempWord = rowWords[i].GetWord();
                            if (tempWord.Count != 0)
                            {
                                grid[row, column] = tempWord[0];
                                tempBeginIndex++;
                                rowWords[i].SetBeginIndex(tempBeginIndex);
                                tempWord.RemoveAt(0);
                                rowWords[i].SetWrod(tempWord);
                            }

                        }
                    }
                }
            }

            // save colunm word to 2d array
            for (int column = 0; column < columns; column++)
            {
                for (int row = 0; row < rows; row++)
                {
                    for (int i = 0; i < columnWrods.Count; i++)
                    {
                        if (columnWrods[i].GetPosition() == column + 1 && columnWrods[i].GetBeginIndex() == row + 1)
                        {
                            int tempBeginIndex = columnWrods[i].GetBeginIndex();
                            List<string> tempWord = columnWrods[i].GetWord();
                            if (tempWord.Count != 0)
                            {
                                if (grid[row, column] != null)
                                {
                                    scoreLetter.Add(grid[row, column]);
                                }
                                grid[row, column] = tempWord[0];
                                tempWord.RemoveAt(0);
                                tempBeginIndex++;
                                columnWrods[i].SetBeginIndex(tempBeginIndex);
                                columnWrods[i].SetWrod(tempWord);
                            }

                        }
                    }
                }
            }

            foreach(string key in intersectionPointPerLetter.Keys)
            {
                for(int i = 0; i < scoreLetter.Count; i++)
                {
                    if (scoreLetter[i] == key)
                    {
                        score += intersectionPointPerLetter[key];
                    }
                }
            }

            // output
            Dictionary<string, string> errorList = Form1.errorList.GetErrorList();
            Dictionary<string, string> errorListOfCrozzle = Form1.errorListOfCrozzle.GetErrorList();
            Dictionary<string, string> errorListOfLogic = Form1.errorListOfLogic.GetErrorList();
            String crozzleHTML;
            if (errorList.Count==0 && errorListOfCrozzle.Count==0)
            {
                crozzleHTML = @"<!DOCTYPE html><html><head>" + config.GetOutputStyle() + "</head><body><p>Score:" + score + "</p><table>";
            }
            else
            {
                crozzleHTML = @"<!DOCTYPE html><html><head>" + config.GetOutputStyle() + "</head><body><p>Score: INVALID CROZZLE</p><table>";
            }

            for (int row = 0; row < rows; row++)
            {
                String tr = "<tr>";
                for (int column = 0; column < columns; column++)
                {
                    if (grid[row,column] != null)
                    {
                        tr += @"<td bgcolor='"+config.GetOutputColorNonEmpty()+"'>" + grid[row, column] + @"</td>";
                    }else if(grid[row, column] == null)
                    {
                        tr += @"<td bgcolor='" + config.GetOutputColorEmpty() + "'>" + grid[row, column] + @"</td>";
                    }
                }
                tr += "</tr>";

                crozzleHTML += tr;
            }

            crozzleHTML += @"</table>
                             </body>
                             </html>";

            displayWindows.DocumentText = crozzleHTML;
        }

        // Function to display errors
        public void DisplayErrors(WebBrowser displayWindows)
        {
            String errorHTML = @"<!DOCTYPE html><html><head><style> table, td { border: 1px solid black; border-collapse: collapse; }</style></head><body>";

            Dictionary<string, string> errorArray = Form1.errorList.GetErrorList();
            Dictionary<string, string> errorListOfCrozzle = Form1.errorListOfCrozzle.GetErrorList();
            Dictionary<string, string> errorListOfLogic = Form1.errorListOfLogic.GetErrorList();
            if (errorArray.Count == 0 && errorListOfCrozzle.Count == 0)
            {
                errorHTML += @"<p>There is no any errors.</p>";
            }
            else
            {
                // crozzle file table
                int count = 1;
                errorHTML += @"<p>Error in configuration file</p><table><tr>
                                    <td>Count</td>
                                    <td>Error postion</td>
                                    <td>Error type</td>
                                             </tr>";
                foreach (string key in errorArray.Keys)
                {
                    
                    errorHTML += @"<tr><td>Error" + count + "</td><td>" + key + "</td><td>" + errorArray[key] + "</td></tr>";
                    count++;
                }
                errorHTML += @"</table>";
                //end crozzle file table

                //cofig file errors
                count = 1;
                errorHTML += @"<p>Error in crozzle file</p><table><tr>
                                    <td>Count</td>
                                    <td>Error postion</td>
                                    <td>Error type</td>
                                             </tr>";
                foreach (string key in errorListOfCrozzle.Keys)
                {

                    errorHTML += @"<tr><td>Error" + count + "</td><td>" + key + "</td><td>" + errorListOfCrozzle[key] + "</td></tr>";
                    count++;
                }
                errorHTML += @"</table>";
            }

            errorHTML += @"</body>
                             </html>";

            displayWindows.DocumentText = errorHTML;

        }
    }
}
