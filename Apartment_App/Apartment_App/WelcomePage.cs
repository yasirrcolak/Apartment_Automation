using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Apartment_App
{
    public partial class WelcomePage : Form
    {
        // This string contains user details database path.
        string userDetailsTxtPath = @"..\..\userDetails.txt";
        // This string array contains Users details.
        public string[] userDetails = File.ReadAllLines(@"..\..\userDetails.txt");
        // This string array contains Users Name and Password. 
        public string[] userNameAndPassword = File.ReadAllLines(@"..\..\userNameAndPassword.txt");
        // This string array contains a user information.
        public string[] users;
        // This string is contains logged in user.
        public static string currentUserName = null;

        public WelcomePage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Login button method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void login_Button_Click(object sender, EventArgs e)
        {
            // if logging user is admin
            if (userName_TextBox.Text == "admin" && userPassword_TextBox.Text == "admin")
            {
                currentUserName = "admin";
                AdminOperationsPage adminOperationsPage = new AdminOperationsPage();
                adminOperationsPage.Show();
                this.Hide();

            }
            else
            {

                // control database.
                for (int i = 0; i < userNameAndPassword.Length; i++)
                {
                    users = userNameAndPassword[i].Split('#');

                    // if this user exists in the database.
                    if (userName_TextBox.Text == users[0] && userPassword_TextBox.Text == users[1])
                    {
                        currentUserName = users[0];
                        MemberPage memberPage = new MemberPage();
                        memberPage.Show();
                        this.Hide(); // dispose
                        break;
                    }
                }

                // if this user is not in the database.
                if (currentUserName == null)
                {
                    MessageBox.Show("Hatalı giriş yaptınız. \nLütfen tekrar deneyiniz.");
                    userName_TextBox.Clear();
                    userPassword_TextBox.Clear();
                }

            }
        }

        /// <summary>
        /// Welcome Page Loaded Method. if today is the 15th of the month, change the is pay dues information to 'Hayır'.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WelcomePage_Load(object sender, EventArgs e)
        {
            // What date is today
            string[] dayOfMonth = DateTime.Now.ToString().Split('.');

            // if todey is the 15th of the month. 
            if (dayOfMonth[0] == "15")
            {

                // user details string array is reset.
                userDetails = File.ReadAllLines(userDetailsTxtPath);

                // user details database reset
                File.Delete(userDetailsTxtPath);
                FileStream filecreate = new FileStream(userDetailsTxtPath, FileMode.OpenOrCreate, FileAccess.Write);
                filecreate.Close();

                // turn all user. and write to database.
                for (int i = 0; i < userDetails.Length; i++)
                {
                    users = userDetails[i].Split('#');

                    File.AppendAllText(userDetailsTxtPath, users[0] + "#", Encoding.UTF8);
                    File.AppendAllText(userDetailsTxtPath, users[1] + "#", Encoding.UTF8);
                    File.AppendAllText(userDetailsTxtPath, users[2] + "#", Encoding.UTF8);
                    File.AppendAllText(userDetailsTxtPath, "Hayır" + "#", Encoding.UTF8);
                    File.AppendAllText(userDetailsTxtPath, users[4] + "#", Encoding.UTF8);
                    File.AppendAllText(userDetailsTxtPath, users[5] + "#", Encoding.UTF8);
                    File.AppendAllText(userDetailsTxtPath, users[6] + "#", Encoding.UTF8);
                    File.AppendAllText(userDetailsTxtPath, users[7] + "#", Encoding.UTF8);
                    File.AppendAllText(userDetailsTxtPath, users[8] + "\n", Encoding.UTF8);

                }
            }
        }
    }
}
