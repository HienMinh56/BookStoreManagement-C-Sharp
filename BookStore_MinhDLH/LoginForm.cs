using Repositories.Entities;
using Services;

namespace BookStore_MinhDLH
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string email = txtEmail.Text;
            string password = txtPassword.Text;
            BookManagementMemberService se = new BookManagementMemberService(); ;

            BookManagementMember account = se.CheckLogin(email, password);
            if (account == null)
            {
                MessageBox.Show("Login failed. Please check your credentials",
                                 "Wrong credentials", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                return;
            }

            if (account.MemberRole == 1 || account.MemberRole == 2 || account.MemberRole == 3)
            {
                BookManagerForm bookMgt = new BookManagerForm();
                bookMgt.Account = account;
                bookMgt.Show();
                this.Hide();
            }
        }
    }
}