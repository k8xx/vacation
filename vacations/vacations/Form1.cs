using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vacations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        EmpAddFrm  myform;
        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            //var myForm = new EmpAddFrm();
            //myForm.Show();
            myform = new EmpAddFrm();
            myform.MdiParent = this;
            myform.Show();

        }
    }
}
