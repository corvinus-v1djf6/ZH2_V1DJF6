using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZH2_V1DJF6.Models;

namespace ZH2_V1DJF6
{
    public partial class DiakokAdataiForm : Form
    {
        TankonyvContext context = new TankonyvContext();

        public DiakokAdataiForm()
        {
            InitializeComponent();
        }

        private void DiakokAdataiForm_Load(object sender, EventArgs e)
        {
            //diakokDetailBindingSource.DataSource = context.Students.ToList();
            DiakokList();
        }


        private void DiakokList()
        {
            var diakok = from x in context.Students
                         where x.Name == x.Name
                         select new DiakokDetail
                         {
                             DiákID = x.StudentId,
                             Név = x.Name,
                             Neptunkód = x.Neptun,

                         };
            diakokDetailBindingSource.DataSource = diakok.ToList();
        }

        private void btnDiakHozzaadasa_Click(object sender, EventArgs e)
        {
            NewStudentForm newStudentForm = new NewStudentForm();
            if (newStudentForm.ShowDialog() == DialogResult.OK)
            {
                Student student = new Student();
                //student.StudentId = newStudentForm.txtBoxStudentId.Text;
                student.Name = newStudentForm.txtBoxStudentName.Text;
                student.Neptun = newStudentForm.txtBoxStudentNeptun.Text;

                //valamiért csak az elsőt tudja hozzáadni (Kiss Pista-t én adtam hozzá), többet nem.
                //és hibára futott úgyhogy inkább kikommenteltem
                //context.Students.Add(student);

                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                //diakokDetailBindingSource.DataSource = context.Students.ToList();
                DiakokList();

            }
        }

    }
}
