namespace ZH2_V1DJF6
{
    partial class NewStudentForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxStudentName = new System.Windows.Forms.TextBox();
            this.txtBoxStudentNeptun = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "StudentName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "StudentNeptun";
            // 
            // txtBoxStudentName
            // 
            this.txtBoxStudentName.Location = new System.Drawing.Point(52, 75);
            this.txtBoxStudentName.Name = "txtBoxStudentName";
            this.txtBoxStudentName.Size = new System.Drawing.Size(203, 23);
            this.txtBoxStudentName.TabIndex = 4;
            this.txtBoxStudentName.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxStudentName_Validating);
            this.txtBoxStudentName.Validated += new System.EventHandler(this.txtBoxStudentName_Validated);
            // 
            // txtBoxStudentNeptun
            // 
            this.txtBoxStudentNeptun.Location = new System.Drawing.Point(52, 154);
            this.txtBoxStudentNeptun.Name = "txtBoxStudentNeptun";
            this.txtBoxStudentNeptun.Size = new System.Drawing.Size(203, 23);
            this.txtBoxStudentNeptun.TabIndex = 5;
            this.txtBoxStudentNeptun.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxStudentNeptun_Validating);
            this.txtBoxStudentNeptun.Validated += new System.EventHandler(this.txtBoxStudentNeptun_Validated);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(12, 318);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(126, 75);
            this.buttonOk.TabIndex = 6;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(189, 318);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(126, 75);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // NewStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 417);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.txtBoxStudentNeptun);
            this.Controls.Add(this.txtBoxStudentName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "NewStudentForm";
            this.Text = "NewStudentForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private Label label3;
        private Button buttonOk;
        private Button buttonCancel;
        public TextBox txtBoxStudentName;
        public TextBox txtBoxStudentNeptun;
        private ErrorProvider errorProvider1;
    }
}