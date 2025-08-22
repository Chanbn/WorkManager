using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkManager
{
    public partial class MyTaskForm : UserControl
    {
        private DBHelper db = new DBHelper();
        public MyTaskForm()
        {
            InitializeComponent();

        }
        private void MyTaskForm_Load(object sender, EventArgs e)
        {
            // 데이터 그리드 뷰 설정
            string user = CurrentSession.UserName;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // 데이터 로드
            try
            {
                List<MyTaskDto> myTaskDtos = db.GetMyTaskDtos(user);
                dataGridView1.DataSource = myTaskDtos;
                SetColumnHeaders();
            }
            catch (Exception ex)
            {
                MessageBox.Show("작업 이력 로딩 실패: " + ex.Message);
            }
      }
        private void SetColumnHeaders()
        {
            if (dataGridView1.Columns.Contains("ProductName"))
                dataGridView1.Columns["ProductName"].HeaderText = "상품명";
            if (dataGridView1.Columns.Contains("Quantity"))
                dataGridView1.Columns["Quantity"].HeaderText = "수량";
            if (dataGridView1.Columns.Contains("Status"))
                dataGridView1.Columns["Status"].HeaderText = "상태";
            if (dataGridView1.Columns.Contains("StartTime"))
                dataGridView1.Columns["StartTime"].HeaderText = "작업일시";
        }
    }
}
