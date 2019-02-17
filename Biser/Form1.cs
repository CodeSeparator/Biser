using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biser
{
    public partial class Biser : Form
    {
        Random rnd = new Random();
        public Biser()
        {
            InitializeComponent();
            
        }

        private void generateText(char ch, int rows, int cols, Color _1, Color _2, Color _3)
        {
            int i = 0;
            double prob;
            for (; i < rows>>1; i++)
            {
                prob = (((double)(rows>>1) - i) / (double)(rows>>1));
                for (int j = 0; j < cols; j++)
                {
                    int x = rnd.Next(rows>>1);
                    richTextBox.AppendText(ch.ToString(), prob*(rows >> 1) > x ? _1 : _2);
                }
                richTextBox.AppendText('\n'.ToString());
            }
            for (; i < rows; i++)
            {
                prob = ((double)rows - i) / (double)(rows >> 1);
                for (int j = 0; j < cols; j++)
                {
                    int x = rnd.Next(rows >> 1);
                    richTextBox.AppendText(ch.ToString(), prob * (rows >> 1) > x ? _2 : _3);
                }
                richTextBox.AppendText('\n'.ToString());
            }
        }

        private void buttonActive_MouseClick(object sender, MouseEventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                ((Button)sender).BackColor = colorDialog.Color;
            }
        }

        private void btGenerate_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
            int rows = int.Parse(tbRows.Text);
            int cols = int.Parse(tbCols.Text);
            Color first = buttonActive1.BackColor;
            Color second = buttonActive2.BackColor;
            Color third = buttonActive3.BackColor;
            generateText('■', rows,cols, first, second, third);
        }

        //•￭
    }
}
