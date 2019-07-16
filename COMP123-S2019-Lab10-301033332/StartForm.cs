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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the event handler for the SplashScreen load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartForm_Load(object sender, EventArgs e)
        {
            SplashTimer.Enabled = true;
        }
        /// <summary>
        /// This is the event handler for the tick event of SplashTimer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            //stop triggering every timer interval
            SplashTimer.Enabled = false;
            //new instance of MainForm
            MainForm mainForm = new MainForm();
            //display main form
            mainForm.Show();
            //hide this "StartForm" form
            this.Hide();
        }
    }
}
