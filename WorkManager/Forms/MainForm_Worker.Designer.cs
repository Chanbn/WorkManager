namespace WorkManager
{
    partial class MainForm_Worker
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
            this.tabPage = new System.Windows.Forms.TabControl();
            this.tabPageWorker = new System.Windows.Forms.TabPage();
            this.label_Username1 = new System.Windows.Forms.Label();
            this.tabPage.SuspendLayout();
            this.tabPageWorker.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.tabPageWorker);
            this.tabPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPage.Font = new System.Drawing.Font("Noto Serif KR", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage.Location = new System.Drawing.Point(0, 0);
            this.tabPage.Name = "tabPage";
            this.tabPage.SelectedIndex = 0;
            this.tabPage.Size = new System.Drawing.Size(800, 450);
            this.tabPage.TabIndex = 3;
            // 
            // tabPageWorker
            // 
            this.tabPageWorker.BackColor = System.Drawing.Color.LightGray;
            this.tabPageWorker.Controls.Add(this.label_Username1);
            this.tabPageWorker.Location = new System.Drawing.Point(4, 48);
            this.tabPageWorker.Name = "tabPageWorker";
            this.tabPageWorker.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWorker.Size = new System.Drawing.Size(792, 398);
            this.tabPageWorker.TabIndex = 0;
            this.tabPageWorker.Text = "작업자";
            // 
            // label_Username1
            // 
            this.label_Username1.AutoSize = true;
            this.label_Username1.Location = new System.Drawing.Point(607, 3);
            this.label_Username1.Name = "label_Username1";
            this.label_Username1.Size = new System.Drawing.Size(99, 40);
            this.label_Username1.TabIndex = 1;
            this.label_Username1.Text = "label1";
            // 
            // MainForm_Worker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabPage);
            this.Name = "MainForm_Worker";
            this.Text = "MainForm_Worker";
            this.tabPage.ResumeLayout(false);
            this.tabPageWorker.ResumeLayout(false);
            this.tabPageWorker.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPage;
        private System.Windows.Forms.TabPage tabPageWorker;
        private System.Windows.Forms.Label label_Username1;
    }
}