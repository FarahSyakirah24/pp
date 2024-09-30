namespace Login
{
    public partial class FormLogin : System.Windows.Forms.Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username, passwd;
            username = txtUsername.Text;
            passwd = txtPassword.Text;

            if (username == "541231067" && passwd == "541231067")
            {
                FormKasir fk = new FormKasir();
                fk.Show();
            }
            else
            {
                MessageBox.Show("Username dan Passowrd anda salah!");
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }
    }
}
