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
    public partial class WorkerControl : UserControl
    {
        private DBHelper db = new DBHelper();
        public WorkerControl()
        {
            InitializeComponent();

            panel1.AutoSize = false;
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
            panel1.BackColor = Color.WhiteSmoke;
            this.AutoScroll = true;


        }

        private void Worker_Load(object sender, EventArgs e)
        {

        }

        private void Worker_submit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string role = boxRole.SelectedItem.ToString();
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("이름을 입력해주세요.");
                return;
            }

            if(string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("아이디를 입력해주세요.");
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("비밀번호를 입력해주세요.");
                return;
            }

            if (string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("직급을 입력해주세요.");
                return;
            }
            if (db.checkUsername(username))
            {
                MessageBox.Show("이미 존재하는 아이디입니다. 다른 아이디를 입력해주세요.");
                return;
            }

            MessageBox.Show($"이름 : {name}\n직급 : {role}");

            if (role == "작업자")
            {
                role = "Worker";
            }else if(role == "팀장")
            {
                role = "TeamLeader";
            }

                try
                {
                    int result = db.InsertUser(username, name, password, role);
                    MessageBox.Show("등록되었습니다.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("등록실패 " + ex.Message);
                }
        }
    }
}