namespace WorkManager
{
    partial class Worker
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.boxJobTitle = new System.Windows.Forms.ComboBox();
            this.Worker_submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "작업자";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "이름";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(515, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "직책";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(314, 139);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 25);
            this.txtName.TabIndex = 3;
            // 
            // boxJobTitle
            // 
            this.boxJobTitle.FormattingEnabled = true;
            this.boxJobTitle.Items.AddRange(new object[] {
            "작업자",
            "팀장",
            "관리자"});
            this.boxJobTitle.Location = new System.Drawing.Point(603, 140);
            this.boxJobTitle.Name = "boxJobTitle";
            this.boxJobTitle.Size = new System.Drawing.Size(121, 23);
            this.boxJobTitle.TabIndex = 4;
            // 
            // Worker_submit
            // 
            this.Worker_submit.Location = new System.Drawing.Point(314, 222);
            this.Worker_submit.Name = "Worker_submit";
            this.Worker_submit.Size = new System.Drawing.Size(75, 23);
            this.Worker_submit.TabIndex = 5;
            this.Worker_submit.Text = "제출";
            this.Worker_submit.UseVisualStyleBackColor = true;
            this.Worker_submit.Click += new System.EventHandler(this.Worker_submit_Click);
            // 
            // Worker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Worker_submit);
            this.Controls.Add(this.boxJobTitle);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Worker";
            this.Text = "Worker";
            this.Load += new System.EventHandler(this.Worker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox boxJobTitle;
        private System.Windows.Forms.Button Worker_submit;
    }
}