using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RegexTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEvaluate_Click(object sender, EventArgs e)
        {
            string result = "Did not evaluate.";

            RegexOptions caseIgnore = new RegexOptions();
            caseIgnore = RegexOptions.IgnoreCase;
            if (chkIgnoreCase.Checked == false)
            {
                caseIgnore = RegexOptions.None;
            }

            string evalString = @txtEvalString.Text;
            string pattern = @txtPattern.Text;
            Regex rgx = new Regex(pattern, caseIgnore);

            MatchCollection matches = rgx.Matches(evalString);
            if (matches.Count > 0)
            {
                result = "The EvalString matches the pattern! " + evalString + " matches " + pattern;


            }
            else
            {
                result = "The EvalString DOES NOT MATCH the pattern. " + evalString + " does not match " + pattern;
            }

            lblResult.Text = result;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
