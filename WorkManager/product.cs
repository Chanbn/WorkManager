using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBHelper =WorkManager.DBHelper;

namespace WorkManager
{
    public partial class product : Form
    {
        public product()
        {
            InitializeComponent();
        }

        private void product_submit_Click(object sender, EventArgs e)
        {
            string productName = txtProductName.Text;
            string specification = txtSpecification.Text;
            int unitPrice;
            if(!int.TryParse(txtUnitPrice.Text,out unitPrice)){
                MessageBox.Show("단가에는 숫자만 입력해주세요!", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show($"제품명: {productName} \n스펙: {specification} \n단가: {unitPrice}원");
            try
            {
                int result = DBHelper.InsertProduct(productName, specification, unitPrice);
                MessageBox.Show($"{result}개의 제품이 등록되었습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("등록 실패: " + ex.Message);
            }
        }
    }
}
