using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace shadowEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int value = tbHorizontal.Value;
            txtHorizontal.Text = value.ToString();
        }

        private void tbVertical_Scroll(object sender, EventArgs e)
        {
            int value = tbVertical.Value;
            txtVertical.Text = value.ToString();
        }

        private void tbBlur_Scroll(object sender, EventArgs e)
        {
            int value = tbBlur.Value;
            txtBlur.Text = value.ToString();
        }

        private void tbSpread_Scroll(object sender, EventArgs e)
        {
            int value = tbSpread.Value;
            txtSpread.Text = value.ToString();
        }
    }
}
