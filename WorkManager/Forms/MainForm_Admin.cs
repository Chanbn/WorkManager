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
    public partial class MainForm_Admin : Form
    {
        public MainForm_Admin()
        {
            InitializeComponent();
            string user = CurrentSession.UserName;
            MessageBox.Show($"관리자 {user}님 환영합니다!", "로그인 성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
            label_Username1.Text = $"사용자: {user}";
            label_Username2.Text = $"사용자: {user}";
            label_Username3.Text = $"사용자: {user}";
            label_Username4.Text = $"사용자: {user}";           
            //작업자 탭에 WorkerControl 삽입
            WorkerControl workerControl = new WorkerControl();
            workerControl.Dock = DockStyle.Fill;
            tabPageWorker.Controls.Add(workerControl);

            //제품 탭에 ProductControl 삽입
            ProductControl productControl = new ProductControl();
            productControl.Dock = DockStyle.Fill;
            tabPageProduct.Controls.Add(productControl);

            //작업이력 탭에 WorkHistoryControl 삽입
            WorkHistoryControl workHistoryControl = new WorkHistoryControl();
            workHistoryControl.Dock = DockStyle.Fill;
            tabPageHistory.Controls.Add(workHistoryControl);

            WorkOrderControl workOrderControl = new WorkOrderControl();
            workOrderControl.Dock = DockStyle.Fill;
            tabPageWorkOrder.Controls.Add(workOrderControl);

        }
    }
}
