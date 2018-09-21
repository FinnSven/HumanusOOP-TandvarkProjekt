using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TandVerk
{
    public partial class Receptionist : Form
    {
        public Receptionist()
        {
            InitializeComponent();
        }

        private void bokaTid_Click(object sender, EventArgs e)
        {
            panelAngePersonnummer.Show();

        
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelAngePersonnummer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            panelAngePersonnummer.Hide();
            maskedTextBox1.Text = textBox2.Text;
        }

        private void tabBokaTid_Click(object sender, EventArgs e)
        {

        }

        private void tabReceptionist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            panelÄndraTid.Hide();
           


        }

        private void ändraBokning_Click(object sender, EventArgs e)
        {
            panelÄndraTid.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelTaBortPatient.Hide();
        }

        private void taBortKund_Click(object sender, EventArgs e)
        {
            panelTaBortPatient.Show();
        }
    }
}
