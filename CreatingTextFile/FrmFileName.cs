using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LabExer501
{
    public partial class FrmFileName : Form
    {
        public static string SetFileName { get; private set; }
        public FrmFileName()
        {
            InitializeComponent();
        }
        private void btnOkay_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFileName.Text))
            {
                MessageBox.Show("Please enter a file name.");
                return;
            }
            SetFileName = txtFileName.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
            Close();
        }

        private void txtFileName_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmFileName_Load(object sender, EventArgs e)
        {

        }
    }
}
