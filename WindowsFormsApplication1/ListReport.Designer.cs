namespace WindowsFormsApplication1
{
    partial class ListReport
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Report_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Report_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_created = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Path_to_file = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Report_ID,
            this.Report_Name,
            this.Date_created,
            this.Path_to_file});
            this.dataGridView1.Location = new System.Drawing.Point(12, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(508, 242);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Отчеты";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Открыть в текстовом редакторе";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Report_ID
            // 
            this.Report_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Report_ID.HeaderText = "ID";
            this.Report_ID.Name = "Report_ID";
            this.Report_ID.Width = 50;
            // 
            // Report_Name
            // 
            this.Report_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Report_Name.HeaderText = "Название отчета";
            this.Report_Name.Name = "Report_Name";
            // 
            // Date_created
            // 
            this.Date_created.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date_created.HeaderText = "Дата создания";
            this.Date_created.Name = "Date_created";
            // 
            // Path_to_file
            // 
            this.Path_to_file.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Path_to_file.HeaderText = "Путь к файлу";
            this.Path_to_file.Name = "Path_to_file";
            // 
            // ListReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 365);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListReport";
            this.Text = "ListReport";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Report_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Report_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_created;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path_to_file;
    }
}