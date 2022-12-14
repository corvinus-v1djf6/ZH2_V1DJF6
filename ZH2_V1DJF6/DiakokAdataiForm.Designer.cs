namespace ZH2_V1DJF6
{
    partial class DiakokAdataiForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.diákIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.névDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.neptunkódDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diakokDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDiakHozzaadasa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diakokDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Diákok Adatai";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.diákIDDataGridViewTextBoxColumn,
            this.névDataGridViewTextBoxColumn,
            this.neptunkódDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.diakokDetailBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(378, 393);
            this.dataGridView1.TabIndex = 1;
            // 
            // diákIDDataGridViewTextBoxColumn
            // 
            this.diákIDDataGridViewTextBoxColumn.DataPropertyName = "DiákID";
            this.diákIDDataGridViewTextBoxColumn.HeaderText = "DiákID";
            this.diákIDDataGridViewTextBoxColumn.Name = "diákIDDataGridViewTextBoxColumn";
            // 
            // névDataGridViewTextBoxColumn
            // 
            this.névDataGridViewTextBoxColumn.DataPropertyName = "Név";
            this.névDataGridViewTextBoxColumn.HeaderText = "Név";
            this.névDataGridViewTextBoxColumn.Name = "névDataGridViewTextBoxColumn";
            // 
            // neptunkódDataGridViewTextBoxColumn
            // 
            this.neptunkódDataGridViewTextBoxColumn.DataPropertyName = "Neptunkód";
            this.neptunkódDataGridViewTextBoxColumn.HeaderText = "Neptunkód";
            this.neptunkódDataGridViewTextBoxColumn.Name = "neptunkódDataGridViewTextBoxColumn";
            // 
            // diakokDetailBindingSource
            // 
            this.diakokDetailBindingSource.DataSource = typeof(ZH2_V1DJF6.DiakokDetail);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(ZH2_V1DJF6.Models.Student);
            // 
            // btnDiakHozzaadasa
            // 
            this.btnDiakHozzaadasa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDiakHozzaadasa.Location = new System.Drawing.Point(12, 458);
            this.btnDiakHozzaadasa.Name = "btnDiakHozzaadasa";
            this.btnDiakHozzaadasa.Size = new System.Drawing.Size(142, 55);
            this.btnDiakHozzaadasa.TabIndex = 2;
            this.btnDiakHozzaadasa.Text = "Új Diák Hozzáadása";
            this.btnDiakHozzaadasa.UseVisualStyleBackColor = true;
            this.btnDiakHozzaadasa.Click += new System.EventHandler(this.btnDiakHozzaadasa_Click);
            // 
            // DiakokAdataiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 534);
            this.Controls.Add(this.btnDiakHozzaadasa);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "DiakokAdataiForm";
            this.Text = "DiakokAdataiForm";
            this.Load += new System.EventHandler(this.DiakokAdataiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diakokDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button btnDiakHozzaadasa;
        private BindingSource studentBindingSource;
        private DataGridViewTextBoxColumn diákIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn névDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn neptunkódDataGridViewTextBoxColumn;
        private BindingSource diakokDetailBindingSource;
    }
}