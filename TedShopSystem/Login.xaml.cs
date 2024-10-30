using Service;
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
using TedShopObject.Models;

namespace TedShopSystem
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        private readonly IUserService _userService;
        private readonly IAccountService _accountService; 
        public Login()
        {
            InitializeComponent();
            _accountService = new AccountService();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            Account ac = _accountService.GetAccountByUserName(txtUsername.Text);
            if(ac != null && ac.Password.Equals(txtPassword))
            {
                int roleid = _userService.GetRoleID(ac.GetUserID());
                if (roleid == 1) { this.Hide(); 
                MainManager mainManager = new MainManager();    
                    mainManager.Show();
                
                
                }
                if(roleid == 2)
                {
                    this.Hide();
                    MainStaff mainStaff = new MainStaff();  
                    mainStaff.Show();


                }
                if (roleid == 3) 
                {
                    this.Hide();
                    MainCustomer mainCustomer = new MainCustomer(); 
                  mainCustomer.Show();
                
                }


            }

        }


        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
