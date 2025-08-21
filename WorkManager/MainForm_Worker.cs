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
    public partial class MainForm_Worker : Form
    {
        public MainForm_Worker()
        {
            InitializeComponent();
            string user = CurrentSession.UserName;
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
