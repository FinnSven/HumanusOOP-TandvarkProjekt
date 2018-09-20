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
    public partial class Login : Form
    {
        // Om man loggar in med användarnamn 1 och lösenord 1 kommer man till Dentist.
        // Om man loggar in med användarnamn 2 och lösenord 2 så kommer man till Receptionist.
        public Login()
        {
            InitializeComponent();
        }

        private void btn_LoginOk_Click(object sender, EventArgs e)
        {
            // Detta är verkligen placeholder kod som behövs ersättas med ordentlig login-funktionallitet.
            if (txtb_UserName.Text == "1" && txtb_PassWord.Text == "1")
            {
                this.Hide();
                Dentist d = new Dentist();
                d.Show();
            }
            else if (txtb_UserName.Text == "2" && txtb_PassWord.Text == "2")
            {
                this.Hide();
                Receptionist r = new Receptionist();
                r.Show();
            }
        }
    }
}
