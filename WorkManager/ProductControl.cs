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
    public partial class ProductControl : UserControl
    {
        public ProductControl()
        {
            InitializeComponent();
        }

        private void product_submit_Click(object sender, EventArgs e)
        {
            string productName = txtProductName.Text;
            string specification = txtSpecification.Text;
            int timePerUnit;
            string timeUnit = boxTimeUnit.SelectedItem.ToString();

            if (string.IsNullOrEmpty(productName)) {
                MessageBox.Show("상품명을 입력해주세요.");
            }
            if (string.IsNullOrEmpty(specification))
            {
                MessageBox.Show("상세사항을 입력해주세요.");
                return;
            }
            if (!int.TryParse(txtTimePerUnit.Text,out timePerUnit) || timePerUnit <=0) {
                MessageBox.Show("소요시간을 입력해주세요.");
                return;
            }
            if (string.IsNullOrEmpty(timeUnit))
            {
                MessageBox.Show("시간단위를 선택해주세요.");
                return;
            }

            int unitPrice;
            if(!int.TryParse(txtUnitPrice.Text,out unitPrice)){
                MessageBox.Show("단가에는 숫자만 입력해주세요!", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show($"제품명: {productName} \n스펙: {specification} \n단가: {unitPrice}원");
            try
            {
                int result = DBHelper.InsertProduct(productName, specification, unitPrice,timePerUnit);
                MessageBox.Show($"{result}개의 제품이 등록되었습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("등록 실패: " + ex.Message);
            }
        }
    }
}
