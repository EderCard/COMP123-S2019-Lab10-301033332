using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lab10_301033332
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            #region Refactored
            ////new instance of EndForm
            //EndForm endForm = new EndForm();
            ////show MainForm
            //endForm.Show();
            ////hide this "MainForm" form
            //this.Hide();
            #endregion
            Program.endForm.Show();
            Program.mainForm.Hide();
        }
        /// <summary>
        /// This is the event handler for the closing form event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
