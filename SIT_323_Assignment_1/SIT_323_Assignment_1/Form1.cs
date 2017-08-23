using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIT_323_Assignment_1
{
    public partial class Form1 : Form
    {
        public static Error errorList = new Error();
        public static Error errorListOfCrozzle = new Error();
        public static Error errorListOfLogic = new Error();
        string fileName;
        // constant var here
        public const string numFormat = @"^[0-9]*$";
        public const string letterFormat = @"^[a-zA-Z]*$";
        public const string lowLetterFormat = @"^[a-z]*$";
        public const string colorFormat = @"^#([0-9a-fA-F]{6}|[0-9a-fA-F]{3})$";
        // end constant var
        

        public Form1()
        {
            InitializeComponent();
        }

        private void bowserFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            errorList = new Error();
            errorListOfCrozzle = new Error();
            errorListOfLogic = new Error();
            LoadFunctions function = new LoadFunctions();
            function.BowserFile();
            fileName = function.GetFIleName();
            //function.LoadWords();
        }

        private void testingCrozzleTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            errorList = new Error();
            errorListOfCrozzle = new Error();
            errorListOfLogic = new Error();
            LoadFunctions function = new LoadFunctions();
            function.LoadCrozzle(fileName);
            function.LoadConfiguration();
            function.DisplayCrozzle(Crozzle);
            function.DisplayErrors(ErrorView);

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void testingErrorsTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFunctions function = new LoadFunctions();
            function.DisplayErrors(ErrorView);
        }
    }
}
