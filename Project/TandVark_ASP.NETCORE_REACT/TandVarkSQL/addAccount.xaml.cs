using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TandVarkSQL
{
    /// <summary>
    /// Interaction logic for addAccount.xaml
    /// </summary>
    public partial class addAccount : Window
    {

        Tandvark_ProjektEntities TandDB = new Tandvark_ProjektEntities();

        public addAccount()
        {
            InitializeComponent();
        }

        private void addAccountAddBtn_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(addAccountUserIdTxtBox.Text))
            {
                MessageBox.Show("ERROR! Please enter Name");
            }

            else
            {

                TblUser Account = new TblUser()
                {
                    FldAccountName = addAccountNameTxtBox.Text,
                    FldPassword = addAccountPasswordTxtBox.Text,
                    UserTypeId = Convert.ToInt32(addAccountUserIdTxtBox.Text)
                };
                if (Validator.IsValid(Account))
                {
                    TandDB.TblUsers.Add(Account);
                    TandDB.SaveChanges();
                    MainWindow.datagrid.ItemsSource = TandDB.TblUsers.ToList();
                    this.Hide();
                }
            }

        }
    }
}
