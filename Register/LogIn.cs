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
        }

        private void LogInClear()
        {
            //Clears everything
            TxtCashier.Clear();
            txtPassword.Clear();
            LblName.Text = "Cashier";

            TxtCashier.Enabled = true;
            txtPassword.Enabled = false;
        }

        //concatenates text onto a specified text box if the conditions are true for buttons 0 - 9

        private void btn0_Click(object sender, EventArgs e)
        {
            
            if (TxtCashier.Enabled == true)
            {
                if (TxtCashier.TextLength <= 2)
                {
                    TxtCashier.Text += 0;
                }
                else
                {
                    txtPassword.Focus();
                }
                
            }
            if (txtPassword.Enabled == true)
            {
                if (txtPassword.TextLength <= 3)
                {
                    txtPassword.Text += 0;
                }
            }

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (TxtCashier.Enabled == true)
            {
                if (TxtCashier.TextLength <= 2)
                {
                    TxtCashier.Text += 1;
                }
                else
                {
                    txtPassword.Focus();
                }

            }
            if (txtPassword.Enabled == true)
            {
                if (txtPassword.TextLength <= 3)
                {
                    txtPassword.Text += 1;
                }
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (TxtCashier.Enabled == true)
            {
                if (TxtCashier.TextLength <= 2)
                {
                    TxtCashier.Text += 2;
                }
                else
                {
                    txtPassword.Focus();
                }

            }
            if (txtPassword.Enabled == true)
            {
                if (txtPassword.TextLength <= 3)
                {
                    txtPassword.Text += 2;
                }
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (TxtCashier.Enabled == true)
            {
                if (TxtCashier.TextLength <= 2)
                {
                    TxtCashier.Text += 3;
                }
                else
                {
                    txtPassword.Focus();
                }

            }
            if (txtPassword.Enabled == true)
            {
                if (txtPassword.TextLength <= 3)
                {
                    txtPassword.Text += 3;
                }
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (TxtCashier.Enabled == true)
            {
                if (TxtCashier.TextLength <= 2)
                {
                    TxtCashier.Text += 4;
                }
                else
                {
                    txtPassword.Focus();
                }

            }
            if (txtPassword.Enabled == true)
            {
                if (txtPassword.TextLength <= 3)
                {
                    txtPassword.Text += 4;
                }
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (TxtCashier.Enabled == true)
            {
                if (TxtCashier.TextLength <= 2)
                {
                    TxtCashier.Text += 5;
                }
                else
                {
                    txtPassword.Focus();
                }

            }
            if (txtPassword.Enabled == true)
            {
                if (txtPassword.TextLength <= 3)
                {
                    txtPassword.Text += 5;
                }
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (TxtCashier.Enabled == true)
            {
                if (TxtCashier.TextLength <= 2)
                {
                    TxtCashier.Text += 6;
                }
                else
                {
                    txtPassword.Focus();
                }

            }
            if (txtPassword.Enabled == true)
            {
                if (txtPassword.TextLength <= 3)
                {
                    txtPassword.Text += 6;
                }
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (TxtCashier.Enabled == true)
            {
                if (TxtCashier.TextLength <= 2)
                {
                    TxtCashier.Text += 7;
                }
                else
                {
                    txtPassword.Focus();
                }

            }
            if (txtPassword.Enabled == true)
            {
                if (txtPassword.TextLength <= 3)
                {
                    txtPassword.Text += 7;
                }
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (TxtCashier.Enabled == true)
            {
                if (TxtCashier.TextLength <= 2)
                {
                    TxtCashier.Text += 8;
                }
                else
                {
                    txtPassword.Focus();
                }

            }
            if (txtPassword.Enabled == true)
            {
                if (txtPassword.TextLength <= 3)
                {
                    txtPassword.Text += 8;
                }
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (TxtCashier.Enabled == true)
            {
                if (TxtCashier.TextLength <= 2)
                {
                    TxtCashier.Text += 9;
                }
                else
                {
                    txtPassword.Focus();
                }

            }
            if (txtPassword.Enabled == true)
            {
                if (txtPassword.TextLength <= 3)
                {
                    txtPassword.Text += 9;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clears everything to default
            LogInClear();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //captures the current string
            string c = TxtCashier.Text;
            string p = txtPassword.Text;

            //removes last character from string and assigns it back
            if (TxtCashier.Enabled == true)
            {
                if (c.Length > 0)
                {
                    string result = c.Remove((c.Length - 1), 1);

                    TxtCashier.Text = result;
                }
            }
            if (txtPassword.Enabled == true)
            {
                if (p.Length > 0)
                {
                    string result = p.Remove((p.Length - 1), 1);

                    txtPassword.Text = result;
                }
            }

        }
        
        private void btnEnter_Click(object sender, EventArgs e)
        {
            
            try
            {
                if(TxtCashier.Enabled == true)
                {
                    //clears out if the cashier user entry is less than 3
                    if (TxtCashier.TextLength < 3)
                    {
                        MessageBox.Show("Invalid Cashier!");
                        LogInClear();
                        return;
                    }

                    //if it matches, establish data access based on the cashier number entered
                    DataAccess db = new DataAccess();
                    
                    Cashiers c = db.GetCashiers(Convert.ToInt16(TxtCashier.Text));
                    
                    //If user enters an invalid cashier number, chashier name will turn up null and will not run. clears
                    if (c.Name is null)
                    {
                        MessageBox.Show("Invalid Cashier!");
                        LogInClear();
                        return;
                    }
                    else
                    {
                        //sets the variables for password entry and stores cashier name
                        LblName.Text = c.Name;
                        TxtCashier.Enabled = false;
                        txtPassword.Enabled = true;
                        register._cashier = c.Name;
                        register._password = c.UserPassword.ToString();
                    }
                    
                    
                }

                //runs when the password textbox is enabled
                if (txtPassword.Enabled == true)
                {
                    //fails if the password length is less than 4 and clears out
                    if (txtPassword.TextLength <= 3)
                    {
                        MessageBox.Show("Wrong Password!");
                        LogInClear();
                        return;
                    }

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
                        TxtCashier.Enabled = true;
                        txtPassword.Enabled = false;
                        TxtCashier.Clear();
                        txtPassword.Clear();

                        LblName.Text = "";
                    }

                }
                
                
            }
            catch
            {

                MessageBox.Show("Invalid Cashier!");
                LogInClear();
            }
        }

        

    }
}
