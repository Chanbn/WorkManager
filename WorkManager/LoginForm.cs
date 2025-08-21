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
    public partial class LoginForm : Form
    {
        private DBHelper db = new DBHelper();
        public LoginForm()
        {
            InitializeComponent();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string password = txtPassword.Text;
            
            User userInfo = db.getUser(id, password);

            if(userInfo != null)
            {
                
                if (string.IsNullOrEmpty(userInfo.Role))
                {
                    MessageBox.Show("로그인 실패: 아이디 또는 비밀번호가 잘못되었습니다.");
                    return;
                }
                CurrentSession.SetLoggedInUser(userInfo.UserID, userInfo.UserName, userInfo.Role);

                switch (userInfo.Role)
                {
                    case "Admin":
                        MessageBox.Show("Admin 로그인 성공");
                        // 관리자 화면으로 이동하는 코드 추가
                        MainForm_Admin adminForm = new MainForm_Admin();
                        adminForm.Show();
                        this.Hide(); // 현재 로그인 폼 숨김
                        break;
                    case "TeamLeader":
                        MessageBox.Show("Team Leader 로그인 성공");
                        // 팀장 화면으로 이동하는 코드 추가
                        MainForm_TeamLeader teamLeaderForm = new MainForm_TeamLeader();
                        teamLeaderForm.Show();
                        this.Hide(); // 현재 로그인 폼 숨김
                        break;
                    case "Worker":
                        MessageBox.Show("Worker 로그인 성공");
                        // 작업자 화면으로 이동하는 코드 추가
                        MainForm_Worker workerForm = new MainForm_Worker();
                        workerForm.Show();
                        this.Hide(); // 현재 로그인 폼 숨김
                        break;
                    default:
                        MessageBox.Show("로그인 실패: 알 수 없는 사용자 역할입니다.");
                        break;
                }

            }
        }
    }
}
