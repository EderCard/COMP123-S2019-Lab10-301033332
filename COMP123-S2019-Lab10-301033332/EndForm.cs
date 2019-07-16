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
    public partial class EndForm : Form
    {
        public EndForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the event handler for the BackButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            //new instance of MainForm
            MainForm mainForm = new MainForm();
            //show MainForm
            mainForm.Show();
            //hide this "EndForm" form
            this.Hide();
        }
        /// <summary>
        /// This is the event handler for the closing form event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EndForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
