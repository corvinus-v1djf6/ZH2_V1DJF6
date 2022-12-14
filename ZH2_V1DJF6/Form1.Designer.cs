namespace ZH2_V1DJF6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtStudent01 = new System.Windows.Forms.TextBox();
            this.txtTextBook = new System.Windows.Forms.TextBox();
            this.listStudent = new System.Windows.Forms.ListBox();
            this.listOrder = new System.Windows.Forms.ListBox();
            this.listTextBook = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHallgatoRendeles = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnDiakokAdatai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtStudent01
            // 
            this.txtStudent01.Location = new System.Drawing.Point(12, 24);
            this.txtStudent01.Name = "txtStudent01";
            this.txtStudent01.Size = new System.Drawing.Size(202, 23);
            this.txtStudent01.TabIndex = 0;
            this.txtStudent01.TextChanged += new System.EventHandler(this.txtStudent01_TextChanged);
            // 
            // txtTextBook
            // 
            this.txtTextBook.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTextBook.Location = new System.Drawing.Point(598, 24);
            this.txtTextBook.Name = "txtTextBook";
            this.txtTextBook.Size = new System.Drawing.Size(227, 23);
            this.txtTextBook.TabIndex = 1;
            this.txtTextBook.TextChanged += new System.EventHandler(this.txtTextBook_TextChanged);
            // 
            // listStudent
            // 
            this.listStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listStudent.FormattingEnabled = true;
            this.listStudent.ItemHeight = 15;
            this.listStudent.Location = new System.Drawing.Point(12, 53);
            this.listStudent.Name = "listStudent";
            this.listStudent.Size = new System.Drawing.Size(202, 349);
            this.listStudent.TabIndex = 2;
            this.listStudent.SelectedIndexChanged += new System.EventHandler(this.listStudent_SelectedIndexChanged);
            // 
            // listOrder
            // 
            this.listOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listOrder.FormattingEnabled = true;
            this.listOrder.ItemHeight = 15;
            this.listOrder.Location = new System.Drawing.Point(220, 53);
            this.listOrder.Name = "listOrder";
            this.listOrder.Size = new System.Drawing.Size(261, 349);
            this.listOrder.TabIndex = 3;
            // 
            // listTextBook
            // 
            this.listTextBook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listTextBook.FormattingEnabled = true;
            this.listTextBook.ItemHeight = 15;
            this.listTextBook.Location = new System.Drawing.Point(598, 53);
            this.listTextBook.Name = "listTextBook";
            this.listTextBook.Size = new System.Drawing.Size(227, 349);
            this.listTextBook.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Rendelés összege:";
            // 
            // txtHallgatoRendeles
            // 
            this.txtHallgatoRendeles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtHallgatoRendeles.Location = new System.Drawing.Point(234, 440);
            this.txtHallgatoRendeles.Name = "txtHallgatoRendeles";
            this.txtHallgatoRendeles.Size = new System.Drawing.Size(202, 23);
            this.txtHallgatoRendeles.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(487, 86);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 86);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Hozzáadás(add)";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(487, 207);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(105, 86);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "Törlés(remove)";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnDiakokAdatai
            // 
            this.btnDiakokAdatai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDiakokAdatai.Location = new System.Drawing.Point(831, 24);
            this.btnDiakokAdatai.Name = "btnDiakokAdatai";
            this.btnDiakokAdatai.Size = new System.Drawing.Size(98, 99);
            this.btnDiakokAdatai.TabIndex = 9;
            this.btnDiakokAdatai.Text = "Diakok Adatai Új Form";
            this.btnDiakokAdatai.UseVisualStyleBackColor = true;
            this.btnDiakokAdatai.Click += new System.EventHandler(this.btnDiakokAdatai_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 493);
            this.Controls.Add(this.btnDiakokAdatai);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtHallgatoRendeles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listTextBook);
            this.Controls.Add(this.listOrder);
            this.Controls.Add(this.listStudent);
            this.Controls.Add(this.txtTextBook);
            this.Controls.Add(this.txtStudent01);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtStudent01;
        private TextBox txtTextBook;
        private ListBox listStudent;
        private ListBox listOrder;
        private ListBox listTextBook;
        private Label label1;
        private TextBox txtHallgatoRendeles;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnDiakokAdatai;
    }
}