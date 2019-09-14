using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing.Printing;
using System.IO;
using System.Threading;

namespace Register
{
    public partial class Register : Form
    {
        public int qty = 1;
        public decimal subTotal = 0M;
        public decimal total = 0M;
        public bool taxable;
        public int voided;
        public bool id18;
        public bool id21;

        const decimal _tax = .07M;

        public decimal tax = 0M;
        public decimal taxTotal = 0M;

        public decimal change = 0M;
        public decimal coupon = 0M;

        private int checkPrint;
        public string _cashier;
        public string _password;
        

        private void printDocument1_BeginPrint(object sender, PrintEventArgs e)
        {
            checkPrint = 0;
        }
        
        public Register()
        {
            InitializeComponent();

            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            
            //Sets a password mask over text
            TxtUnlock.UseSystemPasswordChar = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Initialize the ListView Control
            listViewGrocery.View = View.Details;
            listViewGrocery.GridLines = true;
            listViewGrocery.FullRowSelect = true;

            this.ActiveControl = txtInput;
            numPad1.ButtonClick += new EventHandler(numPad1_ButtonClick);

            //Add column header
            listViewGrocery.Columns.Add("Product Name", 100);
            listViewGrocery.Columns.Add("Price", 70);
            listViewGrocery.Columns.Add("Quantity", 70);
            listViewGrocery.Columns.Add("Sub Total", 70);
            listViewGrocery.Columns.Add("Tax", 45);
        }

        private void LockForm()
        {
            //Disables and hides specific controls
            groupBoxLock.Visible = true;
            groupBoxLock.BringToFront();
            LblLockCashier.Text = _cashier;

            //groupBoxPad.Enabled = false;

            BtnCoupon.Enabled = false;
            btnVoid.Enabled = false;
            btnTender.Enabled = false;
            btnQty.Enabled = false;

            btnLock.Text = "Unlock";

        }

        private void ResetForm()
        {
            //Reset Form to its default values to start a new order
            qty = 1;
            subTotal = 0M;
            total = 0M;

            tax = 0M;
            taxTotal = 0M;

            change = 0M;
            coupon = 0M;

            label1.Text = "Start New Order";
            TxtTotal.Text = "";
            
            richTextBoxPrintCtrl1.Clear();
            richTextBoxPrintCtrl1.Visible = false;

            //Empties out the ListView control
            foreach (ListViewItem eachItem in listViewGrocery.Items)
            {
                listViewGrocery.Items.Remove(eachItem);
            }
        }

        private void SaveReceipt()
        {
            //Checks to see if my richTextBox control has value
            //If it does, it saves it to a specified path
            if (richTextBoxPrintCtrl1.Text != String.Empty)
            {
                //set directory
                string dir = @"C:\Users\Jack of Dunces\Source\Repos\Register\Register\ReceiptHistory\" + DateTime.Today.ToString("dd_MMM_yy"); //add unique time format
                //set path
                string path = @"C:\Users\Jack of Dunces\Source\Repos\Register\Register\ReceiptHistory\" + DateTime.Today.ToString("dd_MMM_yy") + "\\" + DateTime.Now.ToString("HH.mm.ss") + ".rtxt";
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir); //creates directory if it does not exist
                }

                if (!File.Exists(path))
                {
                    using (File.Create(path)) ; //creates path if it does not exist
                    richTextBoxPrintCtrl1.SaveFile(path, RichTextBoxStreamType.RichText); //saves richtextbox to file path
                }

            }
            else
                MessageBox.Show("ERROR - Failed To Save Receipt!");
        }

        private void TotalCount()
        {
            total = 0M; //clears total

            //adds up the value on the 4th column index for each item inside the ListView
            for (int i = 0; i < listViewGrocery.Items.Count; i++)
            {
                total += decimal.Parse(listViewGrocery.Items[i].SubItems[3].Text);
            }
            TxtTotal.Text = "$" + total.ToString();
        }

        private void TotalTaxCount()
        {
            taxTotal = 0M; //clears tax total

            //adds up the value on the 5th column index for each item inside the ListView IF they have tax
            for (int i = 0; i < listViewGrocery.Items.Count; i++)
            {

                if (listViewGrocery.Items[i].SubItems[4].Text == "Y")
                {

                    taxTotal += (decimal.Parse(listViewGrocery.Items[i].SubItems[1].Text) * decimal.Parse(listViewGrocery.Items[i].SubItems[2].Text) * _tax);
                }
            }
        }

        private void MainClear()
        {
            //Clears everything back into the default view
            if (BtnCash.Visible == true || TxtCashOut.Visible == true)
            {
                BtnCash.Visible = false;
                BtnEFT.Visible = false;

                TxtCashOut.Visible = false;
                TxtCashOut.Clear();
                TxtUnlock.Clear();

                BtnCoupon.Visible = true;
                btnLock.Visible = true;
                btnVoid.Visible = true;
                btnRegOptions.Visible = true;
                btnTender.Visible = true;
                BtnPay.Visible = false;
                BtnEnterCoupon.Visible = false;

                groupBoxTenderTotal.Visible = false;
            }
            //clear user entry
            txtInput.Clear();
            qty = 1;
            lblQty.Visible = false;
        }
        
        private void btnClear_Click(object sender, EventArgs e)
        {
            MainClear();
        }
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //create variables for each textbox to modify the text inside them
            string i = txtInput.Text;
            string o = TxtCashOut.Text;
            string p = TxtUnlock.Text;

            if (TxtCashOut.Visible == true & o != "0.00") 
            {
                if (o.Length > 0)
                {
                    string result = o.Remove((o.Length - 1), 1); //removes the last character out of the captured text

                    TxtCashOut.Text = result;
                }
            } else
            {
                if (i.Length > 0)
                {
                    string result = i.Remove((i.Length - 1), 1);

                    txtInput.Text = result;
                }
            }

            if (i.Length > 0)
            {
                string result = i.Remove((i.Length - 1), 1);

                txtInput.Text = result;
            }
            if (p.Length > 0)
            {
                string result = p.Remove((p.Length - 1), 1);

                TxtUnlock.Text = result;
            }
        }
        
        private void tmrDate_Tick(object sender, EventArgs e)
        {
            //Sets the current date/time on a 100 interval
            var date = DateTime.Now;
            lblDate.Text = date.ToString();

            
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            //There are multiple uses for this button, all set to different conditions

            try
            {
                //This code will validate the password input field
                //if the password matches, the form is unlocked, if not, it resets
                if (groupBoxUnlock.Visible == true)
                {
                    if (TxtUnlock.Text == _password)
                    {
                        //If the Unlock groupbox text is set to "Log Off", it will close the current form and launch
                        //the initial LogIn Form
                        if (label12.Text == "Log Off")
                        {
                            this.Hide();
                            LogIn logIn = new LogIn();
                            logIn.FormClosed += (s, args) => this.Close();
                            logIn.Show();
                            return;
                        }

                        //Unlocks the form and enables all the necessary fields
                        groupBoxLock.Visible = false;
                        groupBoxUnlock.Visible = false;

                        BtnCoupon.Enabled = true;
                        btnVoid.Enabled = true;
                        btnTender.Enabled = true;
                        btnQty.Enabled = true;

                        TxtUnlock.Clear();
                        btnLock.Text = "Lock";
                        txtInput.Enabled = true;
                        txtInput.Focus();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Password!");
                        TxtUnlock.Clear();
                    }

                    return;
                }

                if (TxtCashOut.Visible == true) //calls the BtnPay click event
                {
                    BtnPay_Click(sender, e);
                    return;
                }


                //Establish Connection
                DataAccess db = new DataAccess();

                //Gets the appropriate grocery based on the look up entry from the input textbox
                Grocery grocery = db.GetGrocery(Convert.ToInt16(txtInput.Text));
                
                //Add first item
                if (grocery.Name != null) //will not run if the user types in an invalid lookup number
                {
                    txtInput.Clear();
                    lblQty.Visible = false;
                    label1.Text = "Total:";

                    //set up an array for the ListView
                    string[] arr = new string[5];
                    ListViewItem itm;
                    decimal result;
                    
                    //TRY Parse the boolean data for validation
                    bool.TryParse(grocery.Identification18.ToString(), out bool id18);
                    bool.TryParse(grocery.Identification21.ToString(), out bool id21);

                    if (id18 == true && id21 == true)
                    {
                        DialogResult dialogResult21 = MessageBox.Show("Is the customer 21 years or older?", "Please Ask For ID", MessageBoxButtons.YesNo);
                        if (dialogResult21 == DialogResult.Yes)
                        {
                            //will resume as normal if the customer is 21 years or older
                            
                        }
                        else if (dialogResult21 == DialogResult.No)
                        {
                            return; //End execution
                        }

                    }
                    else if (id18 == true && id21 == false)
                    {
                        DialogResult dialogResult18 = MessageBox.Show("Is the customer 18 years or older?", "Please Ask For ID", MessageBoxButtons.YesNo);
                        if (dialogResult18 == DialogResult.Yes)
                        {
                            //will resume as normal if the customer is 18 years or older
                        }
                        else if (dialogResult18 == DialogResult.No)
                        {
                            return; //End execution
                        }
                    }

                    //assign the data to the appropriate fileds
                    arr[0] = grocery.Name;
                    arr[1] = grocery.Price.ToString();
                    arr[2] = qty.ToString();

                    //TRY Parse the boolean data for validation
                    bool.TryParse(grocery.Taxable.ToString(), out bool taxable);

                    //Parse Price into a decimal
                    decimal.TryParse(grocery.Price.ToString(), out decimal price);

                    // if taxable, will calculate the price of the item, quantity, and the tax constant
                    if (taxable == true) 
                    {
                        arr[4] = "Y";
                        tax = (price * qty * _tax);
                        decimal.Round(tax, 2, MidpointRounding.AwayFromZero);
                        result = ((price * qty) + tax);
                    }
                    else
                    {
                        arr[4] = "N";
                        result = (price * qty);
                    }
                    
                    arr[3] = result.ToString("#.##");

                    //add items inside arr array into the ListView
                    itm = new ListViewItem(arr);
                    listViewGrocery.Items.Add(itm);
                }
                else
                {
                    MessageBox.Show("Invalid Input!");
                    txtInput.Clear();
                    return;
                }

                //Reset total
                TotalCount();

                //Reset quantity
                qty = 1;

                btnBack_Click(sender, e);
            }
            catch
            {
                MessageBox.Show("Invalid Input!");
                txtInput.Clear();
            }
            
        }

        private void btnQty_Click(object sender, EventArgs e)
        {
            try
            {
                //Grabs the quantity up to a certain length
                if (txtInput.TextLength > 2)
                {
                    MessageBox.Show("Please Select Less Than 100!" + Environment.NewLine + "We Don't Have That Much Stock!", "Maximum Quantity Exceeded!");
                    txtInput.Clear();
                }
                else
                {
                    qty = Convert.ToInt32(txtInput.Text);
                    txtInput.Clear();
                    lblQty.Text = "Qty: " + qty;
                    lblQty.Visible = true;
                }
            }
            catch
            {

            }
            
            
        }
        
        private void btnVoid_Click(object sender, EventArgs e)
        {
            try
            {
                //removes the selected items inside the list view
                foreach (ListViewItem eachItem in listViewGrocery.SelectedItems)
                {
                    listViewGrocery.Items.Remove(eachItem);
                }

                TotalCount();
                TotalTaxCount();

                TxtTotal.Text = "$" + total.ToString();
                qty = 1;
            }
            catch { }
            
            
        }

        private void btnTender_Click(object sender, EventArgs e)
        {
            //Will only allow transaction to be tendered if there is a scanned item inside the ListView
            if (listViewGrocery.Items.Count is 0)
            {
                MessageBox.Show("Start A New Order To Tender");

            }
            else
            {
                //sets the tender groupbox visibility to true and hides certain buttons to continue transaction
                BtnCash.Visible = true;
                BtnEFT.Visible = true;

                BtnCoupon.Visible = false;
                btnLock.Visible = false;
                btnVoid.Visible = false;
                btnRegOptions.Visible = false;
                btnTender.Visible = false;

                groupBoxTenderTotal.Visible = true;

                TotalCount();
                TotalTaxCount();

                //Calculates the amount of savings/coupons in the transaction
                coupon = 0.00M;
                
                for (int i = 0; i < listViewGrocery.Items.Count; i++)
                {
                    if (listViewGrocery.Items[i].SubItems[0].Text == "Coupon")
                    {
                        coupon += decimal.Parse(listViewGrocery.Items[i].SubItems[3].Text);
                    }
                }
                lblSavings.Text = "$" + coupon;


                lblTax.Text = "$" + taxTotal.ToString("0.00");

                //Calculates the subtotal of the current transaction
                subTotal = 0.00M;

                for (int i = 0; i < listViewGrocery.Items.Count; i++)
                {
                    if (listViewGrocery.Items[i].SubItems[0].Text != "Coupon" & listViewGrocery.Items[i].SubItems[0].Text != "Cash")
                    {
                        subTotal += decimal.Parse(listViewGrocery.Items[i].SubItems[1].Text) * decimal.Parse(listViewGrocery.Items[i].SubItems[2].Text);
                    }
                }

                lblSubTotal.Text = "$" + subTotal.ToString("#.##");
                lblTotal.Text = TxtTotal.Text;
            }
        }        

        private void BtnCash_Click(object sender, EventArgs e)
        {
            //hide cash and tender buttons and displays the cashout textbox
            BtnCash.Visible = false;
            BtnEFT.Visible = false;
            TxtCashOut.Visible = true;
            BtnPay.Visible = true;
            TxtCashOut.Focus();

            TxtCashOut.Text = "0.00";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //enables and disables the visibility option based on what needs to be displayed
            //Prioritizing the default view
            if (BtnCash.Visible == true || BtnLogOff.Visible == true)
            {
                BtnCash.Visible = false;
                BtnEFT.Visible = false;
                BtnPay.Visible = false;
                BtnLogOff.Visible = false;

                BtnCoupon.Visible = true;
                btnLock.Visible = true;
                btnVoid.Visible = true;
                btnRegOptions.Visible = true;
                btnTender.Visible = true;
                btnLock.Enabled = true;

                groupBoxTenderTotal.Visible = false;
            }

            if (BtnPay.Visible == true)
            {
                BtnCash.Visible = true;
                BtnEFT.Visible = true;
                TxtCashOut.Visible = false;
                BtnPay.Visible = false;
                TxtCashOut.Clear();
            }

            if(BtnEnterCoupon.Visible == true)
            {
                BtnEnterCoupon.Visible = false;
                TxtCashOut.Visible = false;
                TxtCashOut.Text = "";

                BtnCoupon.Visible = true;
                btnLock.Visible = true;
                btnVoid.Visible = true;
                btnRegOptions.Visible = true;
                btnTender.Visible = true;
            }

            if(groupBoxUnlock.Visible == true)
            {
                groupBoxUnlock.Visible = false;
                LockForm();
            }
        }

        private void BtnCoupon_Click(object sender, EventArgs e)
        {
            //enables and disables the cupon visibility options based on what needs to be displayed
            //won't allow coupon entry if there is not an order in progress
            if (listViewGrocery.Items.Count is 0)
            {
                MessageBox.Show("Start A New Order To Tender");
            }
            else
            {

                BtnCoupon.Visible = false;
                btnLock.Visible = false;
                btnVoid.Visible = false;
                btnRegOptions.Visible = false;
                btnTender.Visible = false;
                BtnEFT.Visible = false;

                BtnEnterCoupon.Visible = true;
                TxtCashOut.Visible = true;
            }

        }
        
        private void BtnPay_Click(object sender, EventArgs e)
        {
            try
            {
                //if payment field is empty, will stop execution
                if (TxtCashOut.Text == "")
                {
                    return;
                }

                //string builder that allows me to insert decimal points into certain parts of the textfiled based on how many characters are inside
                StringBuilder myCashBuilder = new StringBuilder(TxtCashOut.Text);

                //string builder for my richtextbox
                StringBuilder rtfTable = new StringBuilder();

                //array set up to input a cash entry into the ListView if the amount entered is less than the total amount
                string[] arr = new string[5];
                ListViewItem itm;

                //header for my receipt
                string header = "Mitch's Grocery & Mercantile Supply" + Environment.NewLine
                    + "1234 Best Damn Groceries Rd" + Environment.NewLine + "Vieques, PR 00765"
                    + Environment.NewLine + "407-555-5555" + Environment.NewLine + Environment.NewLine;
                string footer = Environment.NewLine + "Thank You Very Much For Shopping With Us" + Environment.NewLine +
                    "Your Cashier was: " + _cashier + Environment.NewLine +
                    "We Hope To See You Again!" + Environment.NewLine + Environment.NewLine + "Mitch's Grocery & Mercantile Supply";
                string tenderTime = Environment.NewLine + lblDate.Text + Environment.NewLine;

                //Allows insertion of a decimal point based on how many characters are inside the string
                string cashStr = TxtCashOut.Text;

                if (cashStr.Contains(".") == false)
                {
                    if (TxtCashOut.TextLength < 3)
                    {
                        if (TxtCashOut.TextLength == 2)
                        {
                            myCashBuilder.Insert((TxtCashOut.TextLength - TxtCashOut.TextLength), "0.");
                            TxtCashOut.Text = myCashBuilder.ToString();
                        }
                        else
                        {
                            myCashBuilder.Insert((TxtCashOut.TextLength - TxtCashOut.TextLength), "0.0");
                            TxtCashOut.Text = myCashBuilder.ToString();
                        }
                    }
                    else
                    {
                        myCashBuilder.Insert((TxtCashOut.TextLength - 2), ".");
                        TxtCashOut.Text = myCashBuilder.ToString();
                    }
                    
                }
                else
                {
                    //array set up to input a cash entry into the ListView if the amount entered is less than the total amount
                    if (decimal.Parse(TxtCashOut.Text) < total)
                    {
                        if (TxtCashOut.Text == "0.00")
                        {
                            return;
                        }

                        arr[0] = "Cash";
                        arr[1] = "";
                        arr[2] = "";
                        arr[3] = "-" + decimal.Parse(TxtCashOut.Text).ToString("#.##");
                        arr[4] = "";


                        itm = new ListViewItem(arr);
                        listViewGrocery.Items.Add(itm);

                        TotalCount();

                        MainClear();
                        TxtCashOut.Clear();

                        return;
                    }
                    else
                    {
                        //runs if the amount entered is greater than the total
                        //renders everything back into the default view and reveals the richtextbox receipt
                        BtnCash.Visible = false;
                        BtnEFT.Visible = false;
                        BtnPay.Visible = false;
                        TxtCashOut.Visible = false;


                        BtnCoupon.Visible = true;
                        btnLock.Visible = true;
                        btnVoid.Visible = true;
                        btnRegOptions.Visible = true;
                        btnTender.Visible = true;

                        groupBoxTenderTotal.Visible = false;

                        richTextBoxPrintCtrl1.Visible = true;


                        //THIS VVVVVVVVV custom fontstyle and text alignment
                        richTextBoxPrintCtrl1.SelectionFont = new Font(richTextBoxPrintCtrl1.Font, FontStyle.Bold);
                        richTextBoxPrintCtrl1.SelectionAlignment = HorizontalAlignment.Center;
                        //   VVVVVV Goes To VVVVVVV
                        richTextBoxPrintCtrl1.SelectedText = header;

                        //Appends each item inside the ListView into my table string builder
                        rtfTable.Append(@"{\rtf1 ");
                        for (int i = 0; i < listViewGrocery.Items.Count; i++)
                        {
                            rtfTable.Append(@"\trowd");
                            rtfTable.Append(@"\cellx1500" + listViewGrocery.Items[i].SubItems[0].Text);
                            rtfTable.Append(@"\intbl\cell");
                            rtfTable.Append(@"\cellx3000" + "");
                            rtfTable.Append(@"\intbl\cell");
                            rtfTable.Append(@"\cellx4500" + "x" + listViewGrocery.Items[i].SubItems[2].Text);
                            rtfTable.Append(@"\intbl\cell");
                            rtfTable.Append(@"\cellx6000" + "$" + listViewGrocery.Items[i].SubItems[3].Text);
                            rtfTable.Append(@"\intbl\cell");
                            rtfTable.Append(@"\cellx7500" + listViewGrocery.Items[i].SubItems[4].Text);
                            rtfTable.Append(@"\intbl\cell\row");
                        }
                        //Appends the order total, Sales Tax, Grand Total, Cash Payment, Change, and savings into the table
                        rtfTable.Append(@"\trowd");
                        rtfTable.Append(@"\cellx1500" + "");
                        rtfTable.Append(@"\intbl\cell\row");

                        rtfTable.Append(@"\trowd");
                        rtfTable.Append(@"\cellx1500" + "Order Total");
                        rtfTable.Append(@"\intbl\cell");
                        rtfTable.Append(@"\cellx1500" + "");
                        rtfTable.Append(@"\intbl\cell");
                        rtfTable.Append(@"\cellx1500" + "");
                        rtfTable.Append(@"\intbl\cell");
                        rtfTable.Append(@"\cellx1500" + "$" + (total - taxTotal).ToString("#.##"));
                        rtfTable.Append(@"\intbl\cell\row");

                        rtfTable.Append(@"\trowd");
                        rtfTable.Append(@"\cellx1500" + "Sales Tax");
                        rtfTable.Append(@"\intbl\cell");
                        rtfTable.Append(@"\cellx1500" + "");
                        rtfTable.Append(@"\intbl\cell");
                        rtfTable.Append(@"\cellx1500" + "");
                        rtfTable.Append(@"\intbl\cell");
                        rtfTable.Append(@"\cellx1500" + lblTax.Text);
                        rtfTable.Append(@"\intbl\cell\row");

                        rtfTable.Append(@"\trowd");
                        rtfTable.Append(@"\cellx1500" + "Grand Total");
                        rtfTable.Append(@"\intbl\cell");
                        rtfTable.Append(@"\cellx1500" + "");
                        rtfTable.Append(@"\intbl\cell");
                        rtfTable.Append(@"\cellx1500" + "");
                        rtfTable.Append(@"\intbl\cell");
                        rtfTable.Append(@"\cellx1500" + "$" + total.ToString("#.##"));
                        rtfTable.Append(@"\intbl\cell\row");

                        rtfTable.Append(@"\trowd");
                        rtfTable.Append(@"\cellx1500" + "Cash");
                        rtfTable.Append(@"\intbl\cell");
                        rtfTable.Append(@"\cellx1500" + "");
                        rtfTable.Append(@"\intbl\cell");
                        rtfTable.Append(@"\cellx1500" + "Payment");
                        rtfTable.Append(@"\intbl\cell");
                        rtfTable.Append(@"\cellx1500" + "$" + TxtCashOut.Text);
                        rtfTable.Append(@"\intbl\cell\row");

                        rtfTable.Append(@"\trowd");
                        rtfTable.Append(@"\cellx1500" + "Change");
                        rtfTable.Append(@"\intbl\cell");
                        rtfTable.Append(@"\cellx1500" + "");
                        rtfTable.Append(@"\intbl\cell");
                        rtfTable.Append(@"\cellx1500" + "");
                        rtfTable.Append(@"\intbl\cell");
                        rtfTable.Append(@"\cellx1500" + "$" + (total - decimal.Parse(TxtCashOut.Text)).ToString("#.##"));
                        rtfTable.Append(@"\intbl\cell\row");

                        rtfTable.Append(@"\trowd");
                        rtfTable.Append(@"\cellx1500" + "");
                        rtfTable.Append(@"\intbl\cell\row");

                        rtfTable.Append(@"\trowd");
                        rtfTable.Append(@"\cellx1500" + "Savings");
                        rtfTable.Append(@"\intbl\cell");
                        rtfTable.Append(@"\cellx1500" + "");
                        rtfTable.Append(@"\intbl\cell");
                        rtfTable.Append(@"\cellx1500" + "");
                        rtfTable.Append(@"\intbl\cell");
                        rtfTable.Append(@"\cellx1500" + lblSavings.Text);
                        rtfTable.Append(@"\intbl\cell\row");

                        rtfTable.Append(@"\pard");
                        rtfTable.Append(@"}");

                        //trims any trailing occurance of the specified character
                        string rtf1 = richTextBoxPrintCtrl1.Rtf.Trim().TrimEnd('}');
                        string rtf2 = rtfTable.ToString();

                        //Place all text entries in a specified order into the rich text box
                        richTextBoxPrintCtrl1.Select(header.ToString().Count(), 0);
                        richTextBoxPrintCtrl1.SelectedRtf = rtf2;

                        richTextBoxPrintCtrl1.Text += tenderTime + footer;

                        richTextBoxPrintCtrl1.BringToFront();

                        label1.Text = "Change";
                        TxtTotal.Text = (total - decimal.Parse(TxtCashOut.Text)).ToString("#.##");                        
                    }
                }


            }
            catch
            {
                
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            checkPrint = 0;
            checkPrint = richTextBoxPrintCtrl1.Print(checkPrint, richTextBoxPrintCtrl1.TextLength, e);

            // Check for more pages
            if (checkPrint < richTextBoxPrintCtrl1.TextLength)
                e.HasMorePages = true;
            else
                e.HasMorePages = false;
        }

        private void BtnPrintSave_Click(object sender, EventArgs e)
        {
            //Print/saves the receipt and resets the form
            SaveReceipt();
            ResetForm();
        }

        private void BtnEnterCoupon_Click(object sender, EventArgs e)
        {
            //new array for coupon entry
            string[] arr = new string[5];
            ListViewItem itm;

            //new string builder for coupon entry
            StringBuilder couponBuilder = new StringBuilder(TxtCashOut.Text);

            string couponString = TxtCashOut.Text;

            arr[0] = "Coupon";
            arr[1] = "";
            arr[2] = "";
            arr[4] = "";

            //allows insertion of a decimal point depending on how many characters are inside the string
            if (couponString.Contains(".") == false)
            {
                if (TxtCashOut.TextLength < 3)
                {
                    if (TxtCashOut.TextLength == 2)
                    {
                        couponBuilder.Insert((TxtCashOut.TextLength - TxtCashOut.TextLength), "0.");
                        TxtCashOut.Text = couponBuilder.ToString();
                    }
                    else
                    {
                        couponBuilder.Insert((TxtCashOut.TextLength - TxtCashOut.TextLength), "0.0");
                        TxtCashOut.Text = couponBuilder.ToString();
                    }
                }
                else
                {
                    couponBuilder.Insert((TxtCashOut.TextLength - 2), ".");
                    TxtCashOut.Text = couponBuilder.ToString();
                }
            }
            else
            {
                if (decimal.Parse(TxtCashOut.Text) <= 0)
                {
                    TxtCashOut.Text = "";
                }
                else
                {
                    arr[3] = "-" + TxtCashOut.Text;

                    itm = new ListViewItem(arr);
                    listViewGrocery.Items.Add(itm);

                    MainClear();
                    TotalCount();
                }
                
            }
        }
        
        private void btnLock_Click(object sender, EventArgs e)
        {
            //locks register and clears any user entry
            if (btnLock.Text == "Lock")
            {
                LockForm();
                txtInput.Clear();
                TxtCashOut.Clear();
                label12.Text = "Lock";
                txtInput.Enabled = false;

                return;
            }

            //enables the form to be ulocked
            if (btnLock.Text == "Unlock")
            {
                groupBoxLock.Visible = false;
                groupBoxUnlock.Visible = true;
                //groupBoxPad.Enabled = true;
                BtnLogOff.Visible = false;
                label12.Text = "Unlock";
                TxtUnlock.Focus();
            }
        }

        private void btnRegOptions_Click(object sender, EventArgs e)
        {
            //displays the register option controls and hides the others
            BtnCoupon.Visible = false;
            btnVoid.Visible = false;
            btnTender.Visible = false;
            btnLock.Enabled = false;

            BtnLogOff.Visible = true;
        }

        private void BtnLogOff_Click(object sender, EventArgs e)
        {
            //allows the user to log out of their current session as long as there are is not a transaction in progress
            if (listViewGrocery.Items.Count < 1)
            {
                groupBoxUnlock.Visible = true;
                groupBoxLock.Visible = false;

                //groupBoxPad.Enabled = true;
                label12.Text = "Log Off";
            }
            else
            {
                MessageBox.Show("Transaction in Progress!" + Environment.NewLine + "Unable to Log Out");
            }
        }

        private void txtInput_Enter(object sender, EventArgs e)
        {
            ActiveControl = (Control)sender;
        }

        private void TxtCashOut_Enter(object sender, EventArgs e)
        {
            ActiveControl = (Control)sender;
        }

        private void TxtUnlock_Enter(object sender, EventArgs e)
        {
            ActiveControl = (Control)sender;
        }

        Control ActiveControl;
        private void numPad1_ButtonClick(object sender, EventArgs e)
        {
            ActiveControl.Focus();
        }
    }
    }

