using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Register
{
    public partial class LogIn : Form
    {
        public Register register = new Register();

        public LogIn()
        {
            InitializeComponent();
            //sets a mask for my password textbox
            txtPassword.UseSystemPasswordChar = true;
            this.ActiveControl = TxtCashier;
        }

        private void LogInClear()
        {
            //Clears everything
            TxtCashier.Clear();
            txtPassword.Clear();
            LblName.Text = "Cashier";

            TxtCashier.Enabled = true;
            TxtCashier.Focus();
            txtPassword.Enabled = false;
        }
        
        //concatenates text onto a specified text box for buttons 0 - 9
        Control ActiveControl;
        private void btn0_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            ActiveControl.Focus();
            SendKeys.Send(btn.Text);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clears everything to default
            LogInClear();
            TxtCashier.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //removes last character from string and assigns it back            
            ActiveControl.Focus();
            SendKeys.Send("{BS}");
        }
        
        private void btnEnter_Click(object sender, EventArgs e)
        {
            
            try
            {
                if(TxtCashier.Enabled == true)
                {

                    //if it matches, establish data access based on the cashier number entered
                    DataAccess db = new DataAccess();

                    Cashiers c = db.GetCashiers(Convert.ToInt16(TxtCashier.Text));
                    Supervisors s = db.GetSupervisors(Convert.ToInt16(TxtCashier.Text));
                    
                    //If user enters an invalid cashier number, chashier name will turn up null and will not run. clears
                    if (c.Name != null || s.Name != null)
                    {
                        //sets the variables for password entry and stores cashier name
                        
                        if(c.Name != null)
                        {
                            register._cashier = c.Name;
                            register._password = c.UserPassword.ToString();
                        }

                        if (s.Name != null)
                        {
                            register._cashier = s.Name;
                            register._password = s.Sup_Password.ToString();
                        }
                        LblName.Text = register._cashier;
                        TxtCashier.Enabled = false;
                        txtPassword.Enabled = true;
                        txtPassword.Focus();
                        return;
                    }
                    else
                    {
                        
                        MessageBox.Show("Invalid Cashier!");
                        LogInClear();                        
                    }

                }

                //runs when the password textbox is enabled
                if (txtPassword.Enabled == true)
                {

                    //runs if the password entered matches the users password
                    if (txtPassword.Text == register._password)
                    {
                        MessageBox.Show("Whoohooo!");
                        
                        //closes/hides the log in form
                        this.Hide();
                        
                        //launches the register form
                        register.FormClosed += (s, args) => this.Close();
                        register.Show();
                    }
                    else
                    {
                        //resets the log in form
                        MessageBox.Show("Wrong Password!" + Environment.NewLine + "Try Again!");
                        LogInClear();
                    }

                }
                
            }
            catch
            {
                
            }
        }

        private void TxtCashier_Enter(object sender, EventArgs e)
        {
            ActiveControl = (Control)sender;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            ActiveControl = (Control)sender;
        }
    }
}
