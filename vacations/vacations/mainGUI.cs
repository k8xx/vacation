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
    public partial class mainGUI : Form
    {
        public mainGUI()
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
        TitileFrm titileFrm;
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            titileFrm = new TitileFrm();
            titileFrm.MdiParent = this;
            titileFrm.Show();
        }
    }
}
