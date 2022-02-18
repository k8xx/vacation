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
    public partial class TitileFrm : Form
    {
        public TitileFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        AddTitleFrm addTitleFrm;
        EditTitleFrm editTitleFrm;
        DeletTitleFrm deletTitleFrm;

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            addTitleFrm = new AddTitleFrm();
            addTitleFrm.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            editTitleFrm = new EditTitleFrm();
            editTitleFrm.Show();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            deletTitleFrm = new DeletTitleFrm();
            deletTitleFrm.Show();
        }
    }
}
