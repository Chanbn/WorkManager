namespace WorkManager
{
    partial class ProductControl
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtSpecification = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.product_submit = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.boxTimeUnit = new System.Windows.Forms.ComboBox();
            this.txtTimePerUnit = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15F);
            this.label1.Location = new System.Drawing.Point(401, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "상품등록";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "상품명";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "사양";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "가격";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(406, 104);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(100, 25);
            this.txtProductName.TabIndex = 4;
            // 
            // txtSpecification
            // 
            this.txtSpecification.Location = new System.Drawing.Point(406, 164);
            this.txtSpecification.Name = "txtSpecification";
            this.txtSpecification.Size = new System.Drawing.Size(100, 25);
            this.txtSpecification.TabIndex = 5;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(406, 229);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(100, 25);
            this.txtUnitPrice.TabIndex = 6;
            // 
            // product_submit
            // 
            this.product_submit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.product_submit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.product_submit.Location = new System.Drawing.Point(589, 229);
            this.product_submit.Name = "product_submit";
            this.product_submit.Size = new System.Drawing.Size(75, 23);
            this.product_submit.TabIndex = 7;
            this.product_submit.Text = "제출";
            this.product_submit.UseVisualStyleBackColor = false;
            this.product_submit.Click += new System.EventHandler(this.product_submit_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "제품당 소요시간";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(248, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "소요시간 단위";
            // 
            // boxTimeUnit
            // 
            this.boxTimeUnit.FormattingEnabled = true;
            this.boxTimeUnit.Items.AddRange(new object[] {
            "초",
            "분",
            "시간"});
            this.boxTimeUnit.Location = new System.Drawing.Point(406, 323);
            this.boxTimeUnit.Name = "boxTimeUnit";
            this.boxTimeUnit.Size = new System.Drawing.Size(121, 23);
            this.boxTimeUnit.TabIndex = 10;
            // 
            // txtTimePerUnit
            // 
            this.txtTimePerUnit.Location = new System.Drawing.Point(406, 276);
            this.txtTimePerUnit.Name = "txtTimePerUnit";
            this.txtTimePerUnit.Size = new System.Drawing.Size(100, 25);
            this.txtTimePerUnit.TabIndex = 11;
            // 
            // ProductControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.txtTimePerUnit);
            this.Controls.Add(this.boxTimeUnit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.product_submit);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtSpecification);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProductControl";
            this.Size = new System.Drawing.Size(783, 400);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtSpecification;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Button product_submit;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox txtTimePerUnit;
        private System.Windows.Forms.ComboBox boxTimeUnit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

