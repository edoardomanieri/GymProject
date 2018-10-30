using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void inserisciNome_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void labelAltezza_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDownPeso_ValueChanged(object sender, EventArgs e)
        {

        }

        private void labelPeso_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void labelConfermaPassword_Click(object sender, EventArgs e)
        {

        }

        

        private void labelPassword_Click(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxAnno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxMese_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxGiorno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelDataNascita_Click(object sender, EventArgs e)
        {

        }

        private void buttonFemmina_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void labelSesso_Click(object sender, EventArgs e)
        {

        }

        private void labelCognome_Click(object sender, EventArgs e)
        {

        }

        private void labelNome_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDownAltezza_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
       

        

        private void buttonHidePassword_Click(object sender, EventArgs e)
        {

        }
        int i = 0;

        private void buttonShowHide1_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                Password.UseSystemPasswordChar = false;
                buttonShowHide1.Image = imageHidePassword.Image;
                i = 1;
            }
            else
            {
                Password.UseSystemPasswordChar = true;
                buttonShowHide1.Image = imageShowPassword.Image;
                i = 0;
            }
        }
        int j = 0;
        private void buttonShowHide2_Click(object sender, EventArgs e)
        {
            if (j == 0)
            {
                ConfirmPassword.UseSystemPasswordChar = false;
                buttonShowHide2.Image = imageHidePassword.Image;
                j = 1;
            }
            else
            {
                ConfirmPassword.UseSystemPasswordChar = true;
                buttonShowHide2.Image = imageShowPassword.Image;
                j = 0;
            }
        }

        private void checkBoxAutomatica_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxManuale.Checked = false;
        }

        private void checkBoxManuale_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxAutomatica.Checked = false;
        }
    }
}
