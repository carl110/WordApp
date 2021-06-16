using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordApp
{
    public partial class Form1 : Form
    {
        string textArea;
        string word;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnWordCount_Click(object sender, EventArgs e)
        {  //if there is no text in the TextArea no action should be taken
            if (txtEnterText.TextLength != 0)
            {
                txtNoCharWithSpace.Text = txtEnterText.TextLength.ToString();
                txtNoCharWithoutSpace.Text = (txtEnterText.Text.Length - txtEnterText.Text.Count(predicate: char.IsWhiteSpace)).ToString();
                txtNoOfWord.Text = txtEnterText.Text.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length.ToString();
                txtNoOfPara.Text = (txtEnterText.Text.Split(new[] { Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries).Count()).ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                TextBox box = c as TextBox;
                if (box != null)
                {
                    box.Text = string.Empty;
                }
            }
            txtEnterText.Clear();
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            textArea = txtEnterText.Text;
            // if there is no word entered in the ‘Enter word’ TextField no action should be taken
            //f there is no text in the TextArea no action should be taken
            if (txtEnterWord.TextLength != 0 && txtEnterText.TextLength != 0)
            {
                txtEnterText.Clear();
                txtEnterText.Text = textArea;
                if (txtEnterText.Text.Contains(txtEnterWord.Text))
                {
                    txtStatus.Text = ($"Word found at: {txtEnterText.Text.IndexOf(txtEnterWord.Text) + 1}");
                    txtStatus.ForeColor = Color.Blue;
                    txtEnterText.SelectionStart = txtEnterText.Text.IndexOf(txtEnterWord.Text);
                    txtEnterText.SelectionLength = txtEnterWord.TextLength;
                    txtEnterText.SelectionBackColor = Color.Yellow;
                    txtEnterText.SelectionColor = Color.Red;
                } else
                {
                    txtStatus.Text = "Word not found";
                    txtStatus.ForeColor = Color.Red;
                }
            }
        }
    }
}
