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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TandVarkSQL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Tandvark_ProjektEntities TandDB = new Tandvark_ProjektEntities();
        public static DataGrid datagrid;

        public MainWindow()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            tandVarkDBDataGrid.ItemsSource = TandDB.TblUsers.ToList();
            datagrid = tandVarkDBDataGrid;
        }

        private void addAccountAddBtn_Click(object sender, RoutedEventArgs e)
        {
            addAccount AddAcc = new addAccount();
            AddAcc.ShowDialog();
        }

        private void editAccountAddBtn_Click(object sender, RoutedEventArgs e)
        {
            int Id = (tandVarkDBDataGrid.SelectedItem as TblUser).FldId;
            editAccount EditAcc = new editAccount(Id);
            EditAcc.ShowDialog();
        }

        private void deleteAccountDeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            int Id = (tandVarkDBDataGrid.SelectedItem as TblUser).FldId;
            var deleteAccount = TandDB.TblUsers.Where(account => account.FldId == Id).Single();
            TandDB.TblUsers.Remove(deleteAccount);
            TandDB.SaveChanges();
            tandVarkDBDataGrid.ItemsSource = TandDB.TblUsers.ToList();
        }
    }
}
