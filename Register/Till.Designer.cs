namespace Register
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.btnLock = new System.Windows.Forms.Button();
            this.BtnCoupon = new System.Windows.Forms.Button();
            this.btnVoid = new System.Windows.Forms.Button();
            this.btnRegOptions = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnTender = new System.Windows.Forms.Button();
            this.btnQty = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.tmrDate = new System.Windows.Forms.Timer(this.components);
            this.listViewGrocery = new System.Windows.Forms.ListView();
            this.lblQty = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxMain = new System.Windows.Forms.GroupBox();
            this.BtnLogOff = new System.Windows.Forms.Button();
            this.BtnEnterCoupon = new System.Windows.Forms.Button();
            this.BtnPay = new System.Windows.Forms.Button();
            this.TxtCashOut = new System.Windows.Forms.TextBox();
            this.BtnCash = new System.Windows.Forms.Button();
            this.BtnEFT = new System.Windows.Forms.Button();
            this.groupBoxTenderTotal = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblSavings = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.groupBoxLock = new System.Windows.Forms.GroupBox();
            this.LblLockCashier = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBoxUnlock = new System.Windows.Forms.GroupBox();
            this.TxtUnlock = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.richTextBoxPrintCtrl1 = new RichTextBoxPrintCtrl.RichTextBoxPrintCtrl();
            this.numPad1 = new NumPad();
            this.tmrReceipt = new System.Windows.Forms.Timer(this.components);
            this.groupBoxMain.SuspendLayout();
            this.groupBoxTenderTotal.SuspendLayout();
            this.groupBoxLock.SuspendLayout();
            this.groupBoxUnlock.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLock
            // 
            this.btnLock.Location = new System.Drawing.Point(190, 16);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(85, 50);
            this.btnLock.TabIndex = 5;
            this.btnLock.Text = "Lock";
            this.btnLock.UseVisualStyleBackColor = true;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // BtnCoupon
            // 
            this.BtnCoupon.Location = new System.Drawing.Point(99, 16);
            this.BtnCoupon.Name = "BtnCoupon";
            this.BtnCoupon.Size = new System.Drawing.Size(85, 50);
            this.BtnCoupon.TabIndex = 4;
            this.BtnCoupon.Text = "Coupon";
            this.BtnCoupon.UseVisualStyleBackColor = true;
            this.BtnCoupon.Click += new System.EventHandler(this.BtnCoupon_Click);
            // 
            // btnVoid
            // 
            this.btnVoid.Location = new System.Drawing.Point(99, 72);
            this.btnVoid.Name = "btnVoid";
            this.btnVoid.Size = new System.Drawing.Size(85, 50);
            this.btnVoid.TabIndex = 3;
            this.btnVoid.Text = "Void";
            this.btnVoid.UseVisualStyleBackColor = true;
            this.btnVoid.Click += new System.EventHandler(this.btnVoid_Click);
            // 
            // btnRegOptions
            // 
            this.btnRegOptions.Location = new System.Drawing.Point(190, 72);
            this.btnRegOptions.Name = "btnRegOptions";
            this.btnRegOptions.Size = new System.Drawing.Size(85, 50);
            this.btnRegOptions.TabIndex = 2;
            this.btnRegOptions.Text = "Register Options";
            this.btnRegOptions.UseVisualStyleBackColor = true;
            this.btnRegOptions.Click += new System.EventHandler(this.btnRegOptions_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(190, 128);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(85, 50);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "<==";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnTender
            // 
            this.btnTender.Location = new System.Drawing.Point(99, 128);
            this.btnTender.Name = "btnTender";
            this.btnTender.Size = new System.Drawing.Size(85, 50);
            this.btnTender.TabIndex = 0;
            this.btnTender.Text = "Tender";
            this.btnTender.UseVisualStyleBackColor = true;
            this.btnTender.Click += new System.EventHandler(this.btnTender_Click);
            // 
            // btnQty
            // 
            this.btnQty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQty.Location = new System.Drawing.Point(771, 215);
            this.btnQty.Name = "btnQty";
            this.btnQty.Size = new System.Drawing.Size(85, 50);
            this.btnQty.TabIndex = 13;
            this.btnQty.Text = "Qty";
            this.btnQty.UseVisualStyleBackColor = true;
            this.btnQty.Click += new System.EventHandler(this.btnQty_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.Location = new System.Drawing.Point(771, 383);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(85, 50);
            this.btnEnter.TabIndex = 12;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(771, 271);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 50);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.SystemColors.Control;
            this.txtInput.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(455, 452);
            this.txtInput.MaxLength = 12;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(408, 35);
            this.txtInput.TabIndex = 16;
            this.txtInput.Enter += new System.EventHandler(this.txtInput_Enter);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblDate.Location = new System.Drawing.Point(12, 459);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 24);
            this.lblDate.TabIndex = 17;
            // 
            // tmrDate
            // 
            this.tmrDate.Enabled = true;
            this.tmrDate.Tick += new System.EventHandler(this.tmrDate_Tick);
            // 
            // listViewGrocery
            // 
            this.listViewGrocery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewGrocery.GridLines = true;
            this.listViewGrocery.Location = new System.Drawing.Point(201, 12);
            this.listViewGrocery.Name = "listViewGrocery";
            this.listViewGrocery.Size = new System.Drawing.Size(360, 393);
            this.listViewGrocery.TabIndex = 19;
            this.listViewGrocery.UseCompatibleStateImageBehavior = false;
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(393, 452);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(29, 13);
            this.lblQty.TabIndex = 22;
            this.lblQty.Text = "Qty: ";
            this.lblQty.Visible = false;
            // 
            // TxtTotal
            // 
            this.TxtTotal.BackColor = System.Drawing.SystemColors.Window;
            this.TxtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotal.Location = new System.Drawing.Point(396, 411);
            this.TxtTotal.MaxLength = 10;
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.ReadOnly = true;
            this.TxtTotal.Size = new System.Drawing.Size(165, 35);
            this.TxtTotal.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 29);
            this.label1.TabIndex = 24;
            this.label1.Text = "Start New Order";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBoxMain
            // 
            this.groupBoxMain.Controls.Add(this.BtnLogOff);
            this.groupBoxMain.Controls.Add(this.BtnEnterCoupon);
            this.groupBoxMain.Controls.Add(this.BtnPay);
            this.groupBoxMain.Controls.Add(this.TxtCashOut);
            this.groupBoxMain.Controls.Add(this.btnBack);
            this.groupBoxMain.Controls.Add(this.btnLock);
            this.groupBoxMain.Controls.Add(this.BtnCash);
            this.groupBoxMain.Controls.Add(this.BtnCoupon);
            this.groupBoxMain.Controls.Add(this.btnVoid);
            this.groupBoxMain.Controls.Add(this.btnRegOptions);
            this.groupBoxMain.Controls.Add(this.btnTender);
            this.groupBoxMain.Controls.Add(this.BtnEFT);
            this.groupBoxMain.Location = new System.Drawing.Point(582, 12);
            this.groupBoxMain.Name = "groupBoxMain";
            this.groupBoxMain.Size = new System.Drawing.Size(281, 184);
            this.groupBoxMain.TabIndex = 3;
            this.groupBoxMain.TabStop = false;
            // 
            // BtnLogOff
            // 
            this.BtnLogOff.Location = new System.Drawing.Point(8, 72);
            this.BtnLogOff.Name = "BtnLogOff";
            this.BtnLogOff.Size = new System.Drawing.Size(85, 50);
            this.BtnLogOff.TabIndex = 31;
            this.BtnLogOff.Text = "Log Off";
            this.BtnLogOff.UseVisualStyleBackColor = true;
            this.BtnLogOff.Visible = false;
            this.BtnLogOff.Click += new System.EventHandler(this.BtnLogOff_Click);
            // 
            // BtnEnterCoupon
            // 
            this.BtnEnterCoupon.Location = new System.Drawing.Point(8, 128);
            this.BtnEnterCoupon.Name = "BtnEnterCoupon";
            this.BtnEnterCoupon.Size = new System.Drawing.Size(85, 50);
            this.BtnEnterCoupon.TabIndex = 30;
            this.BtnEnterCoupon.Text = "Enter";
            this.BtnEnterCoupon.UseVisualStyleBackColor = true;
            this.BtnEnterCoupon.Visible = false;
            this.BtnEnterCoupon.Click += new System.EventHandler(this.BtnEnterCoupon_Click);
            // 
            // BtnPay
            // 
            this.BtnPay.Location = new System.Drawing.Point(8, 128);
            this.BtnPay.Name = "BtnPay";
            this.BtnPay.Size = new System.Drawing.Size(85, 50);
            this.BtnPay.TabIndex = 29;
            this.BtnPay.Text = "Pay";
            this.BtnPay.UseVisualStyleBackColor = true;
            this.BtnPay.Visible = false;
            this.BtnPay.Click += new System.EventHandler(this.BtnPay_Click);
            // 
            // TxtCashOut
            // 
            this.TxtCashOut.BackColor = System.Drawing.SystemColors.Window;
            this.TxtCashOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCashOut.Location = new System.Drawing.Point(6, 16);
            this.TxtCashOut.MaxLength = 6;
            this.TxtCashOut.Name = "TxtCashOut";
            this.TxtCashOut.Size = new System.Drawing.Size(165, 35);
            this.TxtCashOut.TabIndex = 28;
            this.TxtCashOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtCashOut.Visible = false;
            this.TxtCashOut.Enter += new System.EventHandler(this.TxtCashOut_Enter);
            // 
            // BtnCash
            // 
            this.BtnCash.Location = new System.Drawing.Point(8, 16);
            this.BtnCash.Name = "BtnCash";
            this.BtnCash.Size = new System.Drawing.Size(85, 50);
            this.BtnCash.TabIndex = 0;
            this.BtnCash.Text = "Cash";
            this.BtnCash.UseVisualStyleBackColor = true;
            this.BtnCash.Visible = false;
            this.BtnCash.Click += new System.EventHandler(this.BtnCash_Click);
            // 
            // BtnEFT
            // 
            this.BtnEFT.Location = new System.Drawing.Point(190, 16);
            this.BtnEFT.Name = "BtnEFT";
            this.BtnEFT.Size = new System.Drawing.Size(85, 50);
            this.BtnEFT.TabIndex = 1;
            this.BtnEFT.Text = "EFT";
            this.BtnEFT.UseVisualStyleBackColor = true;
            // 
            // groupBoxTenderTotal
            // 
            this.groupBoxTenderTotal.BackColor = System.Drawing.Color.Silver;
            this.groupBoxTenderTotal.Controls.Add(this.lblTotal);
            this.groupBoxTenderTotal.Controls.Add(this.lblTax);
            this.groupBoxTenderTotal.Controls.Add(this.lblSavings);
            this.groupBoxTenderTotal.Controls.Add(this.lblSubTotal);
            this.groupBoxTenderTotal.Controls.Add(this.label5);
            this.groupBoxTenderTotal.Controls.Add(this.label4);
            this.groupBoxTenderTotal.Controls.Add(this.label3);
            this.groupBoxTenderTotal.Controls.Add(this.label2);
            this.groupBoxTenderTotal.Location = new System.Drawing.Point(201, 72);
            this.groupBoxTenderTotal.Name = "groupBoxTenderTotal";
            this.groupBoxTenderTotal.Size = new System.Drawing.Size(360, 187);
            this.groupBoxTenderTotal.TabIndex = 27;
            this.groupBoxTenderTotal.TabStop = false;
            this.groupBoxTenderTotal.Visible = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(135, 144);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 29);
            this.lblTotal.TabIndex = 32;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(135, 16);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(0, 29);
            this.lblTax.TabIndex = 31;
            // 
            // lblSavings
            // 
            this.lblSavings.AutoSize = true;
            this.lblSavings.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSavings.Location = new System.Drawing.Point(135, 45);
            this.lblSavings.Name = "lblSavings";
            this.lblSavings.Size = new System.Drawing.Size(0, 29);
            this.lblSavings.TabIndex = 30;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(135, 74);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(0, 29);
            this.lblSubTotal.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 29);
            this.label5.TabIndex = 28;
            this.label5.Text = "Total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 29);
            this.label4.TabIndex = 27;
            this.label4.Text = "Tax:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 29);
            this.label3.TabIndex = 26;
            this.label3.Text = "Savings:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 29);
            this.label2.TabIndex = 25;
            this.label2.Text = "Sub Total:";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // groupBoxLock
            // 
            this.groupBoxLock.BackColor = System.Drawing.Color.Silver;
            this.groupBoxLock.Controls.Add(this.LblLockCashier);
            this.groupBoxLock.Controls.Add(this.label7);
            this.groupBoxLock.Controls.Add(this.label6);
            this.groupBoxLock.Controls.Add(this.label10);
            this.groupBoxLock.Location = new System.Drawing.Point(201, 72);
            this.groupBoxLock.Name = "groupBoxLock";
            this.groupBoxLock.Size = new System.Drawing.Size(360, 187);
            this.groupBoxLock.TabIndex = 31;
            this.groupBoxLock.TabStop = false;
            this.groupBoxLock.Visible = false;
            // 
            // LblLockCashier
            // 
            this.LblLockCashier.AutoSize = true;
            this.LblLockCashier.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLockCashier.Location = new System.Drawing.Point(135, 75);
            this.LblLockCashier.Name = "LblLockCashier";
            this.LblLockCashier.Size = new System.Drawing.Size(0, 29);
            this.LblLockCashier.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(104, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 29);
            this.label7.TabIndex = 30;
            this.label7.Text = "**************";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(104, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 29);
            this.label6.TabIndex = 29;
            this.label6.Text = "**************";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(132, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 29);
            this.label10.TabIndex = 28;
            this.label10.Text = "Locked";
            // 
            // groupBoxUnlock
            // 
            this.groupBoxUnlock.BackColor = System.Drawing.Color.Silver;
            this.groupBoxUnlock.Controls.Add(this.TxtUnlock);
            this.groupBoxUnlock.Controls.Add(this.label9);
            this.groupBoxUnlock.Controls.Add(this.label11);
            this.groupBoxUnlock.Controls.Add(this.label12);
            this.groupBoxUnlock.Location = new System.Drawing.Point(201, 72);
            this.groupBoxUnlock.Name = "groupBoxUnlock";
            this.groupBoxUnlock.Size = new System.Drawing.Size(360, 187);
            this.groupBoxUnlock.TabIndex = 32;
            this.groupBoxUnlock.TabStop = false;
            this.groupBoxUnlock.Visible = false;
            // 
            // TxtUnlock
            // 
            this.TxtUnlock.BackColor = System.Drawing.SystemColors.Window;
            this.TxtUnlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUnlock.Location = new System.Drawing.Point(107, 68);
            this.TxtUnlock.MaxLength = 4;
            this.TxtUnlock.Name = "TxtUnlock";
            this.TxtUnlock.Size = new System.Drawing.Size(147, 35);
            this.TxtUnlock.TabIndex = 31;
            this.TxtUnlock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtUnlock.Enter += new System.EventHandler(this.TxtUnlock_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(102, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 29);
            this.label9.TabIndex = 30;
            this.label9.Text = "**************";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(102, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 29);
            this.label11.TabIndex = 29;
            this.label11.Text = "**************";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(134, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 29);
            this.label12.TabIndex = 28;
            this.label12.Text = "Unlock";
            // 
            // richTextBoxPrintCtrl1
            // 
            this.richTextBoxPrintCtrl1.BackColor = System.Drawing.Color.White;
            this.richTextBoxPrintCtrl1.Location = new System.Drawing.Point(201, 12);
            this.richTextBoxPrintCtrl1.Name = "richTextBoxPrintCtrl1";
            this.richTextBoxPrintCtrl1.ReadOnly = true;
            this.richTextBoxPrintCtrl1.Size = new System.Drawing.Size(360, 396);
            this.richTextBoxPrintCtrl1.TabIndex = 29;
            this.richTextBoxPrintCtrl1.Text = "";
            this.richTextBoxPrintCtrl1.Visible = false;
            // 
            // numPad1
            // 
            this.numPad1.Location = new System.Drawing.Point(584, 202);
            this.numPad1.Name = "numPad1";
            this.numPad1.Size = new System.Drawing.Size(281, 244);
            this.numPad1.TabIndex = 35;
            this.numPad1.ButtonClick += new System.EventHandler(this.numPad1_ButtonClick);
            // 
            // tmrReceipt
            // 
            this.tmrReceipt.Interval = 3000;
            this.tmrReceipt.Tick += new System.EventHandler(this.tmrReceipt_Tick);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 498);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnQty);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.numPad1);
            this.Controls.Add(this.groupBoxUnlock);
            this.Controls.Add(this.groupBoxTenderTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.groupBoxMain);
            this.Controls.Add(this.listViewGrocery);
            this.Controls.Add(this.richTextBoxPrintCtrl1);
            this.Controls.Add(this.groupBoxLock);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxMain.ResumeLayout(false);
            this.groupBoxMain.PerformLayout();
            this.groupBoxTenderTotal.ResumeLayout(false);
            this.groupBoxTenderTotal.PerformLayout();
            this.groupBoxLock.ResumeLayout(false);
            this.groupBoxLock.PerformLayout();
            this.groupBoxUnlock.ResumeLayout(false);
            this.groupBoxUnlock.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.Button BtnCoupon;
        private System.Windows.Forms.Button btnVoid;
        private System.Windows.Forms.Button btnRegOptions;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnTender;
        private System.Windows.Forms.Button btnQty;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer tmrDate;
        private System.Windows.Forms.ListView listViewGrocery;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxMain;
        private System.Windows.Forms.Button BtnEFT;
        private System.Windows.Forms.Button BtnCash;
        private System.Windows.Forms.GroupBox groupBoxTenderTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblSavings;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCashOut;
        private System.Windows.Forms.Button BtnPay;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private RichTextBoxPrintCtrl.RichTextBoxPrintCtrl richTextBoxPrintCtrl1;
        private System.Windows.Forms.Button BtnEnterCoupon;
        private System.Windows.Forms.GroupBox groupBoxLock;
        private System.Windows.Forms.Label LblLockCashier;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBoxUnlock;
        private System.Windows.Forms.TextBox TxtUnlock;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button BtnLogOff;
        private NumPad numPad1;
        private System.Windows.Forms.Timer tmrReceipt;
        //private Register.GroceryDbDataSet groceryDbDataSet1;
    }
}

