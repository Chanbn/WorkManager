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

            //작업자 탭에 WorkerControl 삽입
            MyTaskForm myTaskForm= new MyTaskForm();
            myTaskForm.Dock = DockStyle.Fill;
            tabPageWorker.Controls.Add(myTaskForm);


        }
    }
}
