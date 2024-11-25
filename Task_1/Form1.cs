using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Welcome_Click(object sender, EventArgs e)
        {
            this.Text = tb_Input.Text;
            tb_Input.Text = "";
            tb_Input.Focus();
            pb_Smile.Image = Image.FromFile("../../image/smiley.png");
        }
    }
}
