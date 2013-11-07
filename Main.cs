using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formdgv = new FormDGV();
            formdgv.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formdet = new FormDetails();
            formdet.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formmd = new FormMD();
            formmd.Show();
        }
    }
}
