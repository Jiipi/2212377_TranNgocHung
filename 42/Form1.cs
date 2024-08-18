using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _42
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPassword.Text;

            if (username
         == "UserA" && password == "123456")
            {
                MessageBox.Show("Description: -Career: Teacher\n-Hobbies: Listen to music, travel,....");
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Đóng form hiện tại
            this.Close();

            // Hoặc: Hủy bỏ thao tác nhập liệu
            txtUser.Text = "";
            txtPassword.Text = "";
        }
    }
}
