namespace WindowsFormsApplication1
{
    partial class AddProject
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.urlBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.expirationBox = new System.Windows.Forms.MaskedTextBox();
            this.descBox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавить новый проект";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Название проекта";
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(34, 89);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(211, 22);
            this.titleBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Дата окончания проекта";
            // 
            // urlBox
            // 
            this.urlBox.Location = new System.Drawing.Point(34, 194);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(211, 22);
            this.urlBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "URL проекта";
            // 
            // expirationBox
            // 
            this.expirationBox.Location = new System.Drawing.Point(34, 144);
            this.expirationBox.Mask = "00/00/0000";
            this.expirationBox.Name = "expirationBox";
            this.expirationBox.Size = new System.Drawing.Size(211, 22);
            this.expirationBox.TabIndex = 7;
            this.expirationBox.ValidatingType = typeof(System.DateTime);
            // 
            // descBox
            // 
            this.descBox.Location = new System.Drawing.Point(34, 248);
            this.descBox.Name = "descBox";
            this.descBox.Size = new System.Drawing.Size(211, 96);
            this.descBox.TabIndex = 8;
            this.descBox.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Описание проекта";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "Применить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 391);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.descBox);
            this.Controls.Add(this.expirationBox);
            this.Controls.Add(this.urlBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddProject";
            this.Text = "AddProject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox expirationBox;
        private System.Windows.Forms.RichTextBox descBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}