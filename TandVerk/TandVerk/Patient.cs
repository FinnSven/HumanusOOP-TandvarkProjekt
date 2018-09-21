using System;
using System.Windows.Forms;

namespace TandVerk
{
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }

        private void Tillbaka_Till_Dentist_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dentist Dentist = new Dentist();
            Dentist.Show();
        }
    }
}
