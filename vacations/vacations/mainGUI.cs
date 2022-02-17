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
        EmpAddFrm empAddFrm;
        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            //var myForm = new EmpAddFrm();
            //myForm.Show();
            empAddFrm = new EmpAddFrm();
            empAddFrm.MdiParent = this;
            empAddFrm.Show();

        }

        PositionsFrm positionsFrm;
        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            positionsFrm = new PositionsFrm();
            positionsFrm.MdiParent = this;
            positionsFrm.Show();

        }
        TitileFrm titileFrm;
        CertificatesFrm certificatesFrm;
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            titileFrm = new TitileFrm();
            titileFrm.MdiParent = this;
            titileFrm.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            certificatesFrm = new CertificatesFrm();
            certificatesFrm.MdiParent = this;
            certificatesFrm.Show();
        }
    }
}