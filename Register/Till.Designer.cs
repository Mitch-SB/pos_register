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
            this.groupBoxPad = new System.Windows.Forms.GroupBox();
            this.btnQty = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.tmrDate = new System.Windows.Forms.Timer(this.components);
            this.listBoxOrder = new System.Windows.Forms.ListBox();
            this.listViewGrocery = new System.Windows.Forms.ListView();
            this.listBoxOrderPrice = new System.Windows.Forms.ListBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxTax = new System.Windows.Forms.ListBox();
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
            this.BtnPrintSave = new System.Windows.Forms.Button();
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
            this.listBoxId18 = new System.Windows.Forms.ListBox();
            this.listBoxId21 = new System.Windows.Forms.ListBox();
            this.richTextBoxPrintCtrl1 = new RichTextBoxPrintCtrl.RichTextBoxPrintCtrl();
            this.groupBoxPad.SuspendLayout();
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
            // groupBoxPad
            // 
            this.groupBoxPad.Controls.Add(this.btnQty);
            this.groupBoxPad.Controls.Add(this.btnEnter);
            this.groupBoxPad.Controls.Add(this.btnDelete);
            this.groupBoxPad.Controls.Add(this.btnClear);
            this.groupBoxPad.Controls.Add(this.btn0);
            this.groupBoxPad.Controls.Add(this.btn3);
            this.groupBoxPad.Controls.Add(this.btn2);
            this.groupBoxPad.Controls.Add(this.btn1);
            this.groupBoxPad.Controls.Add(this.btn6);
            this.groupBoxPad.Controls.Add(this.btn5);
            this.groupBoxPad.Controls.Add(this.btn4);
            this.groupBoxPad.Controls.Add(this.btn9);
            this.groupBoxPad.Controls.Add(this.btn8);
            this.groupBoxPad.Controls.Add(this.btn7);
            this.groupBoxPad.Location = new System.Drawing.Point(582, 202);
            this.groupBoxPad.Name = "groupBoxPad";
            this.groupBoxPad.Size = new System.Drawing.Size(281, 244);
            this.groupBoxPad.TabIndex = 15;
            this.groupBoxPad.TabStop = false;
            // 
            // btnQty
            // 
            this.btnQty.FlatAppearance.BorderSize = 0;
            this.btnQty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQty.Location = new System.Drawing.Point(190, 19);
            this.btnQty.Name = "btnQty";
            this.btnQty.Size = new System.Drawing.Size(85, 50);
            this.btnQty.TabIndex = 13;
            this.btnQty.Text = "Qty";
            this.btnQty.UseVisualStyleBackColor = true;
            this.btnQty.Click += new System.EventHandler(this.btnQty_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.FlatAppearance.BorderSize = 0;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.Location = new System.Drawing.Point(190, 187);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(85, 50);
            this.btnEnter.TabIndex = 12;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(190, 131);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 50);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "<==";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(190, 75);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 50);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btn0
            // 
            this.btn0.FlatAppearance.BorderSize = 0;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Location = new System.Drawing.Point(62, 187);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(50, 50);
            this.btn0.TabIndex = 9;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn3
            // 
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Location = new System.Drawing.Point(118, 131);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(50, 50);
            this.btn3.TabIndex = 8;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Location = new System.Drawing.Point(62, 131);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(50, 50);
            this.btn2.TabIndex = 7;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Location = new System.Drawing.Point(6, 131);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(50, 50);
            this.btn1.TabIndex = 6;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn6
            // 
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Location = new System.Drawing.Point(118, 75);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(50, 50);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Location = new System.Drawing.Point(62, 75);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(50, 50);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Location = new System.Drawing.Point(6, 75);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(50, 50);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn9
            // 
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Location = new System.Drawing.Point(118, 19);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(50, 50);
            this.btn9.TabIndex = 2;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Location = new System.Drawing.Point(62, 19);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(50, 50);
            this.btn8.TabIndex = 1;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Location = new System.Drawing.Point(6, 19);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(50, 50);
            this.btn7.TabIndex = 0;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.SystemColors.Control;
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(455, 452);
            this.txtInput.MaxLength = 10;
            this.txtInput.Name = "txtInput";
            this.txtInput.ReadOnly = true;
            this.txtInput.Size = new System.Drawing.Size(408, 35);
            this.txtInput.TabIndex = 16;
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
            // listBoxOrder
            // 
            this.listBoxOrder.BackColor = System.Drawing.SystemColors.Highlight;
            this.listBoxOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxOrder.ForeColor = System.Drawing.Color.Cyan;
            this.listBoxOrder.FormattingEnabled = true;
            this.listBoxOrder.ItemHeight = 29;
            this.listBoxOrder.Location = new System.Drawing.Point(12, 12);
            this.listBoxOrder.MultiColumn = true;
            this.listBoxOrder.Name = "listBoxOrder";
            this.listBoxOrder.Size = new System.Drawing.Size(183, 29);
            this.listBoxOrder.TabIndex = 18;
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
            // listBoxOrderPrice
            // 
            this.listBoxOrderPrice.BackColor = System.Drawing.SystemColors.Highlight;
            this.listBoxOrderPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxOrderPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxOrderPrice.ForeColor = System.Drawing.Color.Cyan;
            this.listBoxOrderPrice.FormattingEnabled = true;
            this.listBoxOrderPrice.ItemHeight = 29;
            this.listBoxOrderPrice.Location = new System.Drawing.Point(12, 38);
            this.listBoxOrderPrice.MultiColumn = true;
            this.listBoxOrderPrice.Name = "listBoxOrderPrice";
            this.listBoxOrderPrice.Size = new System.Drawing.Size(183, 29);
            this.listBoxOrderPrice.TabIndex = 21;
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
            // listBoxTax
            // 
            this.listBoxTax.FormattingEnabled = true;
            this.listBoxTax.Location = new System.Drawing.Point(12, 74);
            this.listBoxTax.Name = "listBoxTax";
            this.listBoxTax.Size = new System.Drawing.Size(183, 17);
            this.listBoxTax.TabIndex = 25;
            this.listBoxTax.Visible = false;
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
            this.TxtCashOut.Enabled = false;
            this.TxtCashOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCashOut.Location = new System.Drawing.Point(6, 16);
            this.TxtCashOut.MaxLength = 10;
            this.TxtCashOut.Name = "TxtCashOut";
            this.TxtCashOut.ReadOnly = true;
            this.TxtCashOut.Size = new System.Drawing.Size(165, 35);
            this.TxtCashOut.TabIndex = 28;
            this.TxtCashOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtCashOut.Visible = false;
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
            // BtnPrintSave
            // 
            this.BtnPrintSave.Location = new System.Drawing.Point(120, 416);
            this.BtnPrintSave.Name = "BtnPrintSave";
            this.BtnPrintSave.Size = new System.Drawing.Size(75, 23);
            this.BtnPrintSave.TabIndex = 30;
            this.BtnPrintSave.Text = "Print/Save";
            this.BtnPrintSave.UseVisualStyleBackColor = true;
            this.BtnPrintSave.Click += new System.EventHandler(this.BtnPrintSave_Click);
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
            this.TxtUnlock.Enabled = false;
            this.TxtUnlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUnlock.Location = new System.Drawing.Point(107, 68);
            this.TxtUnlock.MaxLength = 10;
            this.TxtUnlock.Name = "TxtUnlock";
            this.TxtUnlock.ReadOnly = true;
            this.TxtUnlock.Size = new System.Drawing.Size(147, 35);
            this.TxtUnlock.TabIndex = 31;
            this.TxtUnlock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // listBoxId18
            // 
            this.listBoxId18.FormattingEnabled = true;
            this.listBoxId18.Location = new System.Drawing.Point(12, 97);
            this.listBoxId18.Name = "listBoxId18";
            this.listBoxId18.Size = new System.Drawing.Size(183, 17);
            this.listBoxId18.TabIndex = 33;
            this.listBoxId18.Visible = false;
            // 
            // listBoxId21
            // 
            this.listBoxId21.FormattingEnabled = true;
            this.listBoxId21.Location = new System.Drawing.Point(12, 120);
            this.listBoxId21.Name = "listBoxId21";
            this.listBoxId21.Size = new System.Drawing.Size(183, 17);
            this.listBoxId21.TabIndex = 34;
            this.listBoxId21.Visible = false;
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
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 498);
            this.Controls.Add(this.listBoxId21);
            this.Controls.Add(this.listBoxId18);
            this.Controls.Add(this.groupBoxUnlock);
            this.Controls.Add(this.BtnPrintSave);
            this.Controls.Add(this.groupBoxTenderTotal);
            this.Controls.Add(this.listBoxTax);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.listBoxOrder);
            this.Controls.Add(this.listBoxOrderPrice);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.groupBoxPad);
            this.Controls.Add(this.groupBoxMain);
            this.Controls.Add(this.listViewGrocery);
            this.Controls.Add(this.richTextBoxPrintCtrl1);
            this.Controls.Add(this.groupBoxLock);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxPad.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBoxPad;
        private System.Windows.Forms.Button btnQty;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer tmrDate;
        private System.Windows.Forms.ListBox listBoxOrder;
        private System.Windows.Forms.ListView listViewGrocery;
        private System.Windows.Forms.ListBox listBoxOrderPrice;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxTax;
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
        private System.Windows.Forms.Button BtnPrintSave;
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
        private System.Windows.Forms.ListBox listBoxId18;
        private System.Windows.Forms.ListBox listBoxId21;
        //private Register.GroceryDbDataSet groceryDbDataSet1;
    }
}

