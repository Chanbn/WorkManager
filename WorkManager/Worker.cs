using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBHelper = WorkManager.DBHelper;

namespace WorkManager
{
    public partial class Worker : Form
    {
        public Worker()
        {
            InitializeComponent();
        }

        private void Worker_Load(object sender, EventArgs e)
        {

        }

        private void Worker_submit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string jobTitle = boxJobTitle.SelectedItem.ToString();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("이름을 입력해주세요.");
                return;
            }

            if (string.IsNullOrWhiteSpace(jobTitle))
            {
                MessageBox.Show("직급을 입력해주세요.");
                return;
            }
            MessageBox.Show($"이름 : {name}\n직급 : {jobTitle}");

            try
            {
                int result = DBHelper.InsertWorker(name, jobTitle);
                MessageBox.Show("등록되었습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("등록실패 " + ex.Message);
            }
        }
    }
}