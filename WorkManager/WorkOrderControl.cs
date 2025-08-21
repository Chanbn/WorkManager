using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WorkManager
{
    public partial class WorkOrderControl : UserControl
    {
        private DBHelper db;
        // 클래스 전역에서 사용할 변수 선언
        private int productID;
        private DateTime expectedEndtime;
        private DateTime startTime;

        public WorkOrderControl()
        {
            InitializeComponent();
            this.Load += WorkOrderControl_Load;
            this.txtQuantity.Leave += txtQuantity_Leave; // Leave 이벤트 핸들러 연결

            db = new DBHelper();
        }

        // Load 이벤트에서 콤보박스 데이터 채움
        private void WorkOrderControl_Load(object sender, EventArgs e)
        {
            var workerNames = db.GetWorkerNames();
            boxWorker.Items.Clear();
            boxWorker.Items.AddRange(workerNames.ToArray());

            var productsWithSpec = db.GetProductNamesWithSpecification();
            boxProduct.Items.Clear();
            boxProduct.Items.AddRange(productsWithSpec.ToArray());
        }

        // 상품 콤보박스 선택이 변경될 때 productID를 업데이트합니다.
        private void boxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (boxProduct.SelectedItem != null)
            {
                string selectedItem = boxProduct.SelectedItem.ToString();
                string productIDString = selectedItem.Split('.')[0];
                if (int.TryParse(productIDString, out int id))
                {
                    this.productID = id; // 클래스 변수에 저장
                }
            }
        }

        // 수량 텍스트박스에서 포커스를 잃을 때 이벤트
        private void txtQuantity_Leave(object sender, EventArgs e)
        {
            // 콤보박스 선택 여부와 수량 유효성 검사
            if (boxProduct.SelectedItem == null)
            {
                MessageBox.Show("상품을 먼저 선택해주세요.");
                txtQuantity.Focus(); // 다시 수량 텍스트박스로 포커스 이동
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("올바른 수량을 입력해주세요.");
                txtQuantity.Focus();
                return;
            }

            // DB에서 시간 정보를 가져와 expectedEndtime을 계산하고 클래스 변수에 저장합니다.
            // GetProductTime 메서드 로직은 아래에서 수정합니다.
            int totalTime = db.GetProductTime(this.productID, quantity);
            this.startTime = DateTime.Now; // 현재 시간을 시작 시간으로 설정
            this.expectedEndtime = startTime.AddSeconds(totalTime); // 예상 완료 시간을 계산
            MessageBox.Show($"예상 완료 시간: {this.expectedEndtime.ToString("yyyy-MM-dd HH:mm:ss")}");
            txtExpectedTime.Text = this.expectedEndtime.ToString("yyyy-MM-dd HH:mm:ss");

            // 사용자에게 예상 완료 시간을 보여주는 코드 추가 가능
            // 예: labelExpectedTime.Text = $"예상 완료 시간: {totalTime} 분";
        }

        // "주문 등록" 버튼 클릭 시 값 검증 및 DB 저장
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (boxWorker.SelectedItem == null)
            {
                MessageBox.Show("작업자를 선택해주세요.");
                return;
            }
            if (boxProduct.SelectedItem == null)
            {
                MessageBox.Show("상품을 선택해주세요.");
                return;
            }
            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("올바른 수량을 입력해주세요.");
                return;
            }

            int workerID = int.Parse(boxWorker.SelectedItem.ToString().Split('.')[0]);
            // productID와 expectedEndtime은 이미 Leave 이벤트에서 계산되었으므로 재사용
 
            DBHelper.InsertOrder(workerID, this.productID, quantity,this.startTime, this.expectedEndtime);

            MessageBox.Show("작업지시가 등록되었습니다.");
        }
    }

}