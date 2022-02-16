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
    public partial class PositionsFrm : Form
    {
        public PositionsFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        AddPositionFrm addPositionFrm;
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            addPositionFrm = new AddPositionFrm();
            //addPositionFrm.MdiParent = this;
            addPositionFrm.Show();
        }
    }
}
