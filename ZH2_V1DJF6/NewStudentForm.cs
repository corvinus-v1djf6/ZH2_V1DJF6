using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZH2_V1DJF6
{
    public partial class NewStudentForm : Form
    {
        public NewStudentForm()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren() == true)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void txtBoxStudentName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxStudentName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtBoxStudentName, "Nem lehet üresen hagyni!");
            }

        }

        private void txtBoxStudentName_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtBoxStudentName, string.Empty);
        }

        private void txtBoxStudentNeptun_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("^[A-Z0-9]{6}$");
            if (!regex.IsMatch(txtBoxStudentNeptun.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtBoxStudentNeptun, "Nagy betű(k) vagy szám(ok) kellenek, összesen hat darab!");
            }

        }

        private void txtBoxStudentNeptun_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtBoxStudentNeptun, string.Empty);
        }

    }
}
