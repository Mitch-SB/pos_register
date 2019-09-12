using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Register
{
    public partial class NumPad : UserControl
    {
        public NumPad()
        {
            InitializeComponent();
        }

        public event EventHandler ButtonClick;

        protected void btn0_Click(object sender, EventArgs e)
        {
            //bubble the event up to the parent
            if (this.ButtonClick != null)
            {
                Button btn = (Button)sender;
                ActiveControl.Focus();
                SendKeys.Send(btn.Text);
                this.ButtonClick(sender, e);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //if (this.ButtonClick != null)
            //{
            //    foreach (TextBox textbox in LogIn.ActiveForm.Controls.OfType<TextBox>())
            //        textbox.Text = string.Empty;
            //}
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //removes last character from string and assigns it back
            if (this.ButtonClick != null)
            {
                Button btn = (Button)sender;
                ActiveControl.Focus();
                SendKeys.Send("{BS}");
                this.ButtonClick(sender, e);
            }
        }
    }
}
