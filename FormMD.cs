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
    public partial class FormMD : Form
    {
        public FormMD()
        {
            InitializeComponent();
        }

        private void FormMD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'karateDataSet.Members' table. You can move, or remove it, as needed.
            this.membersTableAdapter.Fill(this.karateDataSet.Members);
            // TODO: This line of code loads data into the 'karateDataSet.Payments' table. You can move, or remove it, as needed.
            this.paymentsTableAdapter.Fill(this.karateDataSet.Payments);

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedValue != null){
                    this.paymentsTableAdapter.FillBy(this.karateDataSet.Payments, ((short)(System.Convert.ChangeType(comboBox1.SelectedValue, typeof(short)))));
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
