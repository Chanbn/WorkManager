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
            this.tabPageWorkOrder = new System.Windows.Forms.TabPage();
            this.label_Username4 = new System.Windows.Forms.Label();
            this.tabPage = new System.Windows.Forms.TabControl();
            this.tabPageWorker = new System.Windows.Forms.TabPage();
            this.label_Username1 = new System.Windows.Forms.Label();
            this.tabPageProduct = new System.Windows.Forms.TabPage();
            this.label_Username2 = new System.Windows.Forms.Label();
            this.tabPageHistory = new System.Windows.Forms.TabPage();
            this.label_Username3 = new System.Windows.Forms.Label();
            this.tabPageWorkOrder.SuspendLayout();
            this.tabPage.SuspendLayout();
            this.tabPageWorker.SuspendLayout();
            this.tabPageProduct.SuspendLayout();
            this.tabPageHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageWorkOrder
            // 
            this.tabPageWorkOrder.Controls.Add(this.label_Username4);
            this.tabPageWorkOrder.Location = new System.Drawing.Point(4, 25);
            this.tabPageWorkOrder.Name = "tabPageWorkOrder";
            this.tabPageWorkOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWorkOrder.Size = new System.Drawing.Size(792, 421);
            this.tabPageWorkOrder.TabIndex = 3;
            this.tabPageWorkOrder.Text = "작업지시";
            this.tabPageWorkOrder.UseVisualStyleBackColor = true;
            // 
            // label_Username4
            // 
            this.label_Username4.AutoSize = true;
            this.label_Username4.Location = new System.Drawing.Point(614, 4);
            this.label_Username4.Name = "label_Username4";
            this.label_Username4.Size = new System.Drawing.Size(45, 15);
            this.label_Username4.TabIndex = 0;
            this.label_Username4.Text = "label1";
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.tabPageWorker);
            this.tabPage.Controls.Add(this.tabPageProduct);
            this.tabPage.Controls.Add(this.tabPageHistory);
            this.tabPage.Controls.Add(this.tabPageWorkOrder);
            this.tabPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPage.Location = new System.Drawing.Point(0, 0);
            this.tabPage.Name = "tabPage";
            this.tabPage.SelectedIndex = 0;
            this.tabPage.Size = new System.Drawing.Size(800, 450);
            this.tabPage.TabIndex = 1;
            // 
            // tabPageWorker
            // 
            this.tabPageWorker.Controls.Add(this.label_Username1);
            this.tabPageWorker.Location = new System.Drawing.Point(4, 25);
            this.tabPageWorker.Name = "tabPageWorker";
            this.tabPageWorker.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWorker.Size = new System.Drawing.Size(792, 421);
            this.tabPageWorker.TabIndex = 0;
            this.tabPageWorker.Text = "작업자";
            this.tabPageWorker.UseVisualStyleBackColor = true;
            // 
            // label_Username1
            // 
            this.label_Username1.AutoSize = true;
            this.label_Username1.Location = new System.Drawing.Point(607, 3);
            this.label_Username1.Name = "label_Username1";
            this.label_Username1.Size = new System.Drawing.Size(45, 15);
            this.label_Username1.TabIndex = 1;
            this.label_Username1.Text = "label1";
            // 
            // tabPageProduct
            // 
            this.tabPageProduct.Controls.Add(this.label_Username2);
            this.tabPageProduct.Location = new System.Drawing.Point(4, 25);
            this.tabPageProduct.Name = "tabPageProduct";
            this.tabPageProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProduct.Size = new System.Drawing.Size(792, 421);
            this.tabPageProduct.TabIndex = 1;
            this.tabPageProduct.Text = "상품";
            this.tabPageProduct.UseVisualStyleBackColor = true;
            // 
            // label_Username2
            // 
            this.label_Username2.AutoSize = true;
            this.label_Username2.Location = new System.Drawing.Point(627, 3);
            this.label_Username2.Name = "label_Username2";
            this.label_Username2.Size = new System.Drawing.Size(45, 15);
            this.label_Username2.TabIndex = 1;
            this.label_Username2.Text = "label1";
            // 
            // tabPageHistory
            // 
            this.tabPageHistory.Controls.Add(this.label_Username3);
            this.tabPageHistory.Location = new System.Drawing.Point(4, 25);
            this.tabPageHistory.Name = "tabPageHistory";
            this.tabPageHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHistory.Size = new System.Drawing.Size(792, 421);
            this.tabPageHistory.TabIndex = 2;
            this.tabPageHistory.Text = "작업이력";
            this.tabPageHistory.UseVisualStyleBackColor = true;
            // 
            // label_Username3
            // 
            this.label_Username3.AutoSize = true;
            this.label_Username3.Location = new System.Drawing.Point(627, 3);
            this.label_Username3.Name = "label_Username3";
            this.label_Username3.Size = new System.Drawing.Size(45, 15);
            this.label_Username3.TabIndex = 1;
            this.label_Username3.Text = "label1";
            // 
            // MainForm_Worker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabPage);
            this.Name = "MainForm_Worker";
            this.Text = "MainForm_Worker";
            this.tabPageWorkOrder.ResumeLayout(false);
            this.tabPageWorkOrder.PerformLayout();
            this.tabPage.ResumeLayout(false);
            this.tabPageWorker.ResumeLayout(false);
            this.tabPageWorker.PerformLayout();
            this.tabPageProduct.ResumeLayout(false);
            this.tabPageProduct.PerformLayout();
            this.tabPageHistory.ResumeLayout(false);
            this.tabPageHistory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageWorkOrder;
        private System.Windows.Forms.Label label_Username4;
        private System.Windows.Forms.TabControl tabPage;
        private System.Windows.Forms.TabPage tabPageWorker;
        private System.Windows.Forms.Label label_Username1;
        private System.Windows.Forms.TabPage tabPageProduct;
        private System.Windows.Forms.Label label_Username2;
        private System.Windows.Forms.TabPage tabPageHistory;
        private System.Windows.Forms.Label label_Username3;
    }
}