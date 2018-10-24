using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PYLsystems
{
    public partial class HomeControl : UserControl
    {
        MainForm parentForm;
        public HomeControl(MainForm parent)
        {
            InitializeComponent();
            this.parentForm = parent;
        }

        private void empManButtton_Click(object sender, EventArgs e)
        {
            this.parentForm.empManControl_Load(this);

        }
    }
}
