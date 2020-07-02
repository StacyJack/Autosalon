using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autosalon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAuto_Click(object sender, EventArgs e)
        {
            Form auto1 = new Auto1();
            auto1.Show();
        }

        private void buttonFirms_Click(object sender, EventArgs e)
        {
            Form firms1 = new Firms1();
            firms1.Show();
        }

        private void buttonAvailability_Click(object sender, EventArgs e)
        {
            Form availability1 = new Availability1();
            availability1.Show();
        }
    }
}
