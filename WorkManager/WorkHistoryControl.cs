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
    public partial class WorkHistoryControl : UserControl
    {
        public WorkHistoryControl()
        {
            InitializeComponent();

            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //dataGridView1.Columns.Add("WorkerName", "작업자명");
            //dataGridView1.Columns.Add("Status", "상태");
            //dataGridView1.Columns.Add("TimeStamp", "작업일자");

            try
            {
                DataTable dt = DBHelper.LoadWorkhistory();
                dataGridView1.DataSource = dt;

                // DB에 데이터가 없어도 DataTable에는 컬럼이 있음
                if (dataGridView1.Columns.Contains("WorkerID"))
                    dataGridView1.Columns["WorkerID"].HeaderText = "작업자ID";
                if (dataGridView1.Columns.Contains("Status"))
                    dataGridView1.Columns["Status"].HeaderText = "상태";
                if (dataGridView1.Columns.Contains("TimeStamp"))
                    dataGridView1.Columns["TimeStamp"].HeaderText = "작업일시";
            }
            catch (Exception ex)
            {
                MessageBox.Show("작업 이력 로딩 실패: " + ex.Message);
            }

            panelWorker.Dock = DockStyle.Top;
            panelWorker.Height = 50;
            panelGrid.Dock = DockStyle.Fill;
            
            this.Controls.Add(panelGrid);
            this.Controls.Add(panelWorker);
            //this.Controls.Add(dataGridView1);
        }

        private void WorkHistoryControl_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = DBHelper.LoadWorkhistory();
            }
            catch(Exception ex)
            {
                MessageBox.Show("작업 이력 로딩 실패: " + ex.Message);
            }
        }
    }
}
