using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thực_hành_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float x1, x2, x3, x4, x5;
            x1 = float.Parse(CSC.Text);
            x2 = float.Parse(CSM.Text);
            x3 = x2 - x1;
            DNTT.Text = x3.ToString();
            if (x3 <= 100 && x3 > 0)
            {
                x4 = x3 * 1418;
                TT.Text = x4.ToString();
                x5 = x4 * 110 / 100;
                TTCV.Text = x5.ToString();
            }
            else if (x3 <= 150)
            {
                x4 = (x3 - 100) * 1622 + 100 * 1418;
                TT.Text = x4.ToString();
                x5 = x4 * 110 / 100;
                TTCV.Text = x5.ToString();
            }
            else if (x3 <= 200)
            {
                x4 = (x3 - 150) * 2044 + 50 * 1622 + 100 * 1418;
                TT.Text = x4.ToString();
                x5 = x4 * 110 / 100;
                TTCV.Text = x5.ToString();
            }
            else if (x3 <= 300)
            {
                x4 = (x3 - 200) * 2210 + 50 * 2044 + 50 * 1622 + 100 * 1418;
                TT.Text = x4.ToString();
                x5 = x4 * 110 / 100;
                TTCV.Text = x5.ToString();
            }
            else if (x3 <= 400)
            {
                x4 = (x3 - 300) * 2361 + 100 * 2210 + 50 * 2044 + 50 * 1622 + 100 * 1418;
                TT.Text = x4.ToString();
                x5 = x4 * 110 / 100;
                TTCV.Text = x5.ToString();
            }
            else if (x3 >= 401)
            {
                x4 = (x3 - 400) * 2420 + 100 * 2361 + 100 * 2210 + 50 * 2044 + 50 * 1622 + 100 * 1418;
                TT.Text = x4.ToString();
                x5 = x4 * 110 / 100;
                TTCV.Text = x5.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CSC.ResetText();
            CSM.ResetText();
            DNTT.ResetText();
            TT.ResetText();
            TTCV.ResetText();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
