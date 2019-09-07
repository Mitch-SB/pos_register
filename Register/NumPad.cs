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

        Control ActiveControl;
        protected void btn0_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            ActiveControl.Focus();
            SendKeys.Send(btn.Text);
        }
    }
}
