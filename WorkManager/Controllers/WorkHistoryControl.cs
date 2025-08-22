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
        private DBHelper db = new DBHelper();
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
                string role = CurrentSession.Role;

                if (role == "TeamLeader" || role == "Admin")
                {
                    // 관리자 또는 팀장일 경우 작업자명 컬럼 추가
                    var users = db.getAllUser();
                    List<string> userNames = users.Select(u => u.UserName + '.' + u.Name).ToList();

                    boxWorker.Items.Clear();
                    boxWorker.Items.AddRange(userNames.ToArray());

                }
                else
                {


                    DataTable dt = DBHelper.LoadWorkhistory();
                    dataGridView1.DataSource = dt;

                    // DB에 데이터가 없어도 DataTable에는 컬럼이 있음
                    if (dataGridView1.Columns.Contains("Username"))
                        dataGridView1.Columns["Username"].HeaderText = "작업자ID";
                    if (dataGridView1.Columns.Contains("Status"))
                        dataGridView1.Columns["Status"].HeaderText = "상태";
                    if (dataGridView1.Columns.Contains("TimeStamp"))
                        dataGridView1.Columns["TimeStamp"].HeaderText = "작업일시";
                }
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
            //int user = CurrentSession.UserID;
            try
            {
                dataGridView1.DataSource = DBHelper.LoadWorkhistory();
                //dataGridView1.DataSource = db.getWorkHistory(user);
            }
            catch (Exception ex)
            {
                MessageBox.Show("작업 이력 로딩 실패: " + ex.Message);
            }
        }

        private void boxWorker_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = boxWorker.SelectedItem as String;
            if (!string.IsNullOrEmpty(selectedItem))
            {
                // '.'을 기준으로 문자열을 나눔
                string[] parts = selectedItem.Split('.');

                // 첫 번째 부분(username)만 추출
                if (parts.Length > 0)
                {
                    string username = parts[0];

                    // 추출한 username을 사용하여 쿼리 실행
                    try
                    {
                        List<WorkHistoryDto> workHistoryDtos = db.getWorkHistory(username);
                        dataGridView1.DataSource = workHistoryDtos;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("작업 목록 로딩 실패: " + ex.Message);
                    }
                }
            }
        }
    }
}