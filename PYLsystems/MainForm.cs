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
    public partial class MainForm : Form
    {
        private int employeeStatus; //type of account based on database. 1 - admin programmer/owner, 2 - manager, 3 - cashier, 4 - framer.
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //this.IsMdiContainer = true;
            //LoginForm loginForm = new LoginForm();
            //loginForm.ShowDialog();
            //this.employeeStatus = loginForm.employeeStatus;
            /*this.accountId = loginForm.accountId;
            if (accountType == null)
            {
                Application.Exit();
            }
            else if (accountType.Contains("encoder"))
            {
                usersToolStripMenuItem.Enabled = false;
                menuStrip.ShowItemToolTips = true;
            }*/

        }

        private void empManButtton_Click(object sender, EventArgs e)
        {
            EmpManage empManageForm = new EmpManage();
            mainWindow(empManageForm,content);
        }
        //Single Window interface. No opening of new window other than login
        public void mainWindow(Form form, Panel content) {
            form.TopLevel = false;
            content.Controls.Clear();
            content.Controls.Add(form);
            form.Show();
        }
    }
}
