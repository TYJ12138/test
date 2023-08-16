namespace WinFormsApp1
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();//关闭程序
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData==Keys.Return)//记录回车
            {
                Login();
            }
        }
        private void Login()
        {
            string strName = "", strPassword = "";
            strName = txtName.Text;
            strPassword = txtPassword.Text;

            if (strName == "" && strPassword == "")
            {
                MessageBox.Show("用户名和密码不能为空");
            }
            else if (strName == "" || strPassword == "")
            {
                if (strName == "")
                {
                    MessageBox.Show("用户名不能为空");
                }
                if (strPassword == "")
                {
                    MessageBox.Show("密码不能为空");
                }
            }
            else
            {
                if (strName != "1092280352")
                {
                    MessageBox.Show("用户名不存在");
                }
                else if (strPassword != "20021121tyj")
                {
                    MessageBox.Show("密码错误");
                }
                else
                {
                    MessageBox.Show("登录成功");
                }
            }
        }
    }
}