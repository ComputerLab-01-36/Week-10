using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FontDilalog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntFontDialog_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() ==  DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
                propertyGrid1.Refresh();

            }
        }

        private void btnUpdateRichTextBox1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = TextBox1.Text;
        }
    }
}
