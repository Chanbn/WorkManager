namespace WorkManager
{
    partial class MainForm
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
            this.tabPageProduct = new System.Windows.Forms.TabPage();
            this.tabPageHistory = new System.Windows.Forms.TabPage();
            this.tabPageWorkOrder = new System.Windows.Forms.TabPage();
            this.tabPage.SuspendLayout();
            this.SuspendLayout();
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
            this.tabPage.TabIndex = 0;
            // 
            // tabPageWorker
            // 
            this.tabPageWorker.Location = new System.Drawing.Point(4, 25);
            this.tabPageWorker.Name = "tabPageWorker";
            this.tabPageWorker.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWorker.Size = new System.Drawing.Size(792, 421);
            this.tabPageWorker.TabIndex = 0;
            this.tabPageWorker.Text = "작업자";
            this.tabPageWorker.UseVisualStyleBackColor = true;
            // 
            // tabPageProduct
            // 
            this.tabPageProduct.Location = new System.Drawing.Point(4, 25);
            this.tabPageProduct.Name = "tabPageProduct";
            this.tabPageProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProduct.Size = new System.Drawing.Size(792, 421);
            this.tabPageProduct.TabIndex = 1;
            this.tabPageProduct.Text = "상품";
            this.tabPageProduct.UseVisualStyleBackColor = true;
            // 
            // tabPageHistory
            // 
            this.tabPageHistory.Location = new System.Drawing.Point(4, 25);
            this.tabPageHistory.Name = "tabPageHistory";
            this.tabPageHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHistory.Size = new System.Drawing.Size(792, 421);
            this.tabPageHistory.TabIndex = 2;
            this.tabPageHistory.Text = "작업이력";
            this.tabPageHistory.UseVisualStyleBackColor = true;
            // 
            // tabPageWorkOrder
            // 
            this.tabPageWorkOrder.Location = new System.Drawing.Point(4, 25);
            this.tabPageWorkOrder.Name = "tabPageWorkOrder";
            this.tabPageWorkOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWorkOrder.Size = new System.Drawing.Size(792, 421);
            this.tabPageWorkOrder.TabIndex = 3;
            this.tabPageWorkOrder.Text = "작업지시";
            this.tabPageWorkOrder.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabPage);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPage;
        private System.Windows.Forms.TabPage tabPageWorker;
        private System.Windows.Forms.TabPage tabPageProduct;
        private System.Windows.Forms.TabPage tabPageHistory;
        private System.Windows.Forms.TabPage tabPageWorkOrder;
    }
}