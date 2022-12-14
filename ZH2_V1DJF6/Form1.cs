using ZH2_V1DJF6.Models;

namespace ZH2_V1DJF6
{
    public partial class Form1 : Form
    {
        TankonyvContext context = new TankonyvContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FilterStudents();
            FilterTextbooks();

        }

        private void txtStudent01_TextChanged(object sender, EventArgs e)
        {
            FilterStudents();

        }

        private void FilterStudents()
        {
            var students = from x in context.Students
                           where x.Name.Contains(txtStudent01.Text)
                           select x;

            listStudent.DataSource = students.ToList();
            listStudent.DisplayMember = "Name";
        }

        private void txtTextBook_TextChanged(object sender, EventArgs e)
        {
            FilterTextbooks();

        }

        private void FilterTextbooks()
        {
            var textbooks = from x in context.Textbooks
                            where x.Title.Contains(txtTextBook.Text)
                            select x;

            listTextBook.DataSource = textbooks.ToList();
            listTextBook.DisplayMember = "Title";
        }

        private void listStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListOrders();
        }

        private void ListOrders()
        {
            var selectedStudent = (Student)listStudent.SelectedValue;

            var orders = from x in context.Orders
                         where x.StudentFk == selectedStudent.StudentId
                         select new OrderDetail
                         {
                             OrderSk = x.OrderSk,
                             Title = x.TextbookFkNavigation.Title,
                             Price = x.TextbookFkNavigation.Price,
                             StockNumber = x.TextbookFkNavigation.StockNumber,
                         };

            listOrder.DataSource = orders.ToList();
            listOrder.DisplayMember = "Title";

            var total = (from x in orders
                         select x.Price).Sum();
            txtHallgatoRendeles.Text = total.ToString();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //idegen kulcsok
            var selectedStudent = (Student)listStudent.SelectedItem;
            var selectedTextBook = (Textbook)listTextBook.SelectedItem;

            //�j oszt�ly
            Order newOrder = new Order();

            newOrder.StudentFk = selectedStudent.StudentId;
            newOrder.TextbookFk = selectedTextBook.TextbookId;

            //hozz�ad�s
            context.Orders.Add(newOrder);

            //ment�s
            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //�jra olvas�s
            ListOrders();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //1
            var selectedOrder = (OrderDetail)listOrder.SelectedItem;

            var orderToBeDeleted = (from x in context.Orders
                                    where x.OrderSk == selectedOrder.OrderSk
                                    select x).FirstOrDefault();

            //3
            if (MessageBox.Show("Biztos ki akarod t�r�lni?", "T�rl�s!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                context.Orders.Remove(orderToBeDeleted);

            //4
            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //5
            ListOrders();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Biztos ki akarsz l�pni?", "Kil�p�s!",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                e.Cancel = true;
        }

        private void btnDiakokAdatai_Click(object sender, EventArgs e)
        {
            DiakokAdataiForm diakokAdataiForm = new DiakokAdataiForm();
            diakokAdataiForm.ShowDialog();

        }
    }

    public class OrderDetail
    {
        public int OrderSk { get; set; }
        public string? Title { get; set; }
        public double? Price { get; set; }
        public string? StockNumber { get; set; }

    }
}