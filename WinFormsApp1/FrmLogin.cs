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
            this.Close();//�رճ���
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData==Keys.Return)//��¼�س�
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
                MessageBox.Show("�û��������벻��Ϊ��");
            }
            else if (strName == "" || strPassword == "")
            {
                if (strName == "")
                {
                    MessageBox.Show("�û�������Ϊ��");
                }
                if (strPassword == "")
                {
                    MessageBox.Show("���벻��Ϊ��");
                }
            }
            else
            {
                if (strName != "1092280352")
                {
                    MessageBox.Show("�û���������");
                }
                else if (strPassword != "20021121tyj")
                {
                    MessageBox.Show("�������");
                }
                else
                {
                    MessageBox.Show("��¼�ɹ�");
                }
            }
        }
    }
}