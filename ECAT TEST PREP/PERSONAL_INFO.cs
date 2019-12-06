using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECAT_TEST_PREP
{
    public partial class PERSONAL_INFO : Form
    {
        int mov;
        int movX;
        int movY;
        public PERSONAL_INFO()
        {
            InitializeComponent();
            string[] s = new string[] { "NED university", "National University", "Mehran University", "Other Engineering University" };
            comboBox1.Items.AddRange(s);

        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            Visible = false;
            TEST__PATTERN tp = new TEST__PATTERN();
            tp.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DATAS.cadidates_name = textBox1.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label4.Visible = false;
            DATAS.perparation = comboBox1.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) { DATAS.practice = 1; }
            else { DATAS.practice = 0; }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true) { DATAS.practice = 1; }
            else { DATAS.practice = 0; }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            DATAS.father_name = textBox2.Text;
        }


      
        private void PERSONAL_INFO_Load(object sender, EventArgs e)
        {
            //this.Location = Screen.AllScreens[1].WorkingArea.Location;
        }

        private void bunifuGradientPanel2_MouseDown_1(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void bunifuGradientPanel2_MouseUp_1(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void bunifuGradientPanel2_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void label10_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label9_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
