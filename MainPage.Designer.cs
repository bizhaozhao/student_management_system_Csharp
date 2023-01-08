namespace StudentManagementByCSharp
{
    partial class MainPage
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
            this.addBtn = new System.Windows.Forms.Button();
            this.inquireBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.modifyBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Faculity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SWEN501 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SWEN502 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SWEN504 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SWEN589 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSet1 = new System.Data.DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Green;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(1, -3);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(156, 48);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // inquireBtn
            // 
            this.inquireBtn.BackColor = System.Drawing.Color.Green;
            this.inquireBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inquireBtn.Location = new System.Drawing.Point(149, -3);
            this.inquireBtn.Name = "inquireBtn";
            this.inquireBtn.Size = new System.Drawing.Size(194, 48);
            this.inquireBtn.TabIndex = 1;
            this.inquireBtn.Text = "Display All / Update";
            this.inquireBtn.UseVisualStyleBackColor = false;
            this.inquireBtn.Click += new System.EventHandler(this.inquireBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Green;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(339, -3);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(156, 48);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // modifyBtn
            // 
            this.modifyBtn.BackColor = System.Drawing.Color.Green;
            this.modifyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyBtn.Location = new System.Drawing.Point(491, -3);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(156, 48);
            this.modifyBtn.TabIndex = 3;
            this.modifyBtn.Text = "Modify";
            this.modifyBtn.UseVisualStyleBackColor = false;
            this.modifyBtn.Click += new System.EventHandler(this.modifyBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.StudentName,
            this.Gender,
            this.Mobile,
            this.Email,
            this.Faculity,
            this.SWEN501,
            this.SWEN502,
            this.SWEN504,
            this.SWEN589});
            this.dataGridView1.Location = new System.Drawing.Point(1, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 40;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1178, 456);
            this.dataGridView1.TabIndex = 4;
            // 
            // ID
            // 
            this.ID.FillWeight = 51.94671F;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // StudentName
            // 
            this.StudentName.FillWeight = 103.3781F;
            this.StudentName.HeaderText = "Student Name";
            this.StudentName.MinimumWidth = 8;
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.FillWeight = 65.70408F;
            this.Gender.HeaderText = "Gender";
            this.Gender.MinimumWidth = 8;
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // Mobile
            // 
            this.Mobile.FillWeight = 103.3781F;
            this.Mobile.HeaderText = "Mobile";
            this.Mobile.MinimumWidth = 8;
            this.Mobile.Name = "Mobile";
            this.Mobile.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.FillWeight = 176.7702F;
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 8;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Faculity
            // 
            this.Faculity.FillWeight = 103.3781F;
            this.Faculity.HeaderText = "Faculity";
            this.Faculity.MinimumWidth = 8;
            this.Faculity.Name = "Faculity";
            this.Faculity.ReadOnly = true;
            // 
            // SWEN501
            // 
            this.SWEN501.FillWeight = 95.53429F;
            this.SWEN501.HeaderText = "SWEN501";
            this.SWEN501.MinimumWidth = 8;
            this.SWEN501.Name = "SWEN501";
            this.SWEN501.ReadOnly = true;
            // 
            // SWEN502
            // 
            this.SWEN502.FillWeight = 97.69036F;
            this.SWEN502.HeaderText = "SWEN502";
            this.SWEN502.MinimumWidth = 8;
            this.SWEN502.Name = "SWEN502";
            this.SWEN502.ReadOnly = true;
            // 
            // SWEN504
            // 
            this.SWEN504.FillWeight = 99.94762F;
            this.SWEN504.HeaderText = "SWEN504";
            this.SWEN504.MinimumWidth = 8;
            this.SWEN504.Name = "SWEN504";
            this.SWEN504.ReadOnly = true;
            // 
            // SWEN589
            // 
            this.SWEN589.FillWeight = 102.2728F;
            this.SWEN589.HeaderText = "SWEN589";
            this.SWEN589.MinimumWidth = 8;
            this.SWEN589.Name = "SWEN589";
            this.SWEN589.ReadOnly = true;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 494);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.modifyBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.inquireBtn);
            this.Controls.Add(this.addBtn);
            this.Name = "MainPage";
            this.Text = "Student Management System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainPage_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button inquireBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button modifyBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Faculity;
        private System.Windows.Forms.DataGridViewTextBoxColumn SWEN501;
        private System.Windows.Forms.DataGridViewTextBoxColumn SWEN502;
        private System.Windows.Forms.DataGridViewTextBoxColumn SWEN504;
        private System.Windows.Forms.DataGridViewTextBoxColumn SWEN589;
    }
}