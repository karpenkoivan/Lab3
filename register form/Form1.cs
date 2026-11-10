using register_form.Exeptions;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace register_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CheckUsernameInput();
                CheckEmailInput();
                CheckPasswordInput();

                MessageBox.Show("Sucsesfuly registered");
            }
            catch (UsernameExeption ex) {
                MessageBox.Show("Username has incorect form:\n" + ex.Message);
            }
            catch (EmailExeption ex)
            {
                MessageBox.Show("Email has incorect form:\n" + ex.Message);
            }
            catch (PaswordExeption ex)
            {
                MessageBox.Show("Password has incorect form:\n" + ex.Message);
            }

        }

        private void CheckPasswordInput()
        {
            string password = this.PasswordtextBox2.Text;
            
            foreach(var (rule, errorMesage) in Rules.PASSWORD_RULES)
            {
                if (!Regex.IsMatch(password, rule)) throw new PaswordExeption(errorMesage);
            }

        }

        private void CheckEmailInput()
        {
            string email = this.EmailtextBox3.Text;

            foreach (var (rule, errorMesage) in Rules.EMAIL_RULES)
            {
                if (!Regex.IsMatch(email, rule)) throw new EmailExeption(errorMesage);
            }

        }

        private void CheckUsernameInput()
        {
            string username = this.UsernametextBox1.Text;

            foreach (var (rule, errorMesage) in Rules.USERNAME_RULES)
            {
                if (!Regex.IsMatch(username, rule)) throw new UsernameExeption(errorMesage);
            }
        }
    }
}
