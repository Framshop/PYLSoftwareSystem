using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PYLsystems
{
    public partial class EmpManage : Form
    {
        public EmpManage()
        {
            InitializeComponent();
        }

        private void EmpManage_Load(object sender, EventArgs e)
        {
           // this.IsMdiContainer = MainForm;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
