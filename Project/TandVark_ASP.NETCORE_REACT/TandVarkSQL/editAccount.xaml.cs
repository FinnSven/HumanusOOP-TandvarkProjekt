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
    /// Interaction logic for editAccount.xaml
    /// </summary>
    public partial class editAccount : Window
    {
        Tandvark_ProjektEntities TandDB = new Tandvark_ProjektEntities();
        int Id;

        public editAccount(int accountId)
        {
            InitializeComponent();
            Id = accountId;
        }

        private void editAccountAddBtn_Click(object sender, RoutedEventArgs e)
        {
            TblUser editAccount = (from account in TandDB.TblUsers
                                   where account.FldId == Id
                                   select account).Single();
            editAccount.FldAccountName = editAccountNameTxtBox.Text;
            editAccount.FldPassword = editAccountPasswordTxtBox.Text;
            editAccount.UserTypeId = Convert.ToInt32(editAccountUserIdTxtBox.Text);
            TandDB.SaveChanges();
            MainWindow.datagrid.ItemsSource = TandDB.TblUsers.ToList();
            this.Hide();
        }
    }
}
