using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Apartment_App
{
    public partial class MemberPage : Form
    {
        // This string contains user details database path.
        string userDetailsTxtPath = @"..\..\userDetails.txt";
        // This string contains user information database path.
        string userNameAndPasswordTxtPath = @"..\..\userNameAndPassword.txt";
        // This string array contains Users details.. 
        public string[] userDetails = File.ReadAllLines(@"..\..\userDetails.txt");
        // This string array contains a user details.
        public string[] users;

        public MemberPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Member Page loaded method. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MemberPage_Load(object sender, EventArgs e)
        {

            // Find the right user.
            for (int i = 0; i < userDetails.Length; i++)
            {
                users = userDetails[i].Split('#');

                // Print to screen if true.
                if (WelcomePage.currentUserName == users[7])
                {
                    userName_Label.Text = users[0];
                    registrationDate_Label.Text = users[1];
                    dues_Label.Text = users[2];
                    isDuesPaid_Label.Text = users[3];
                    debt_Label.Text = users[4];
                    hostOrTenant_Label.Text = users[5];
                    rentPrise_Label.Text = users[6];
                    userLoginName_Label.Text = users[7];
                    userLoginPassword_Label.Text = users[8];
                                                              
                }

            }

            // if dues have been paid. 
            if (users[3] == "Evet")
            {
                payDues_Button.Enabled = false;
            }
            else // if the dues have not been paid.
            {
                notifyIcon.Icon = SystemIcons.Warning;
                notifyIcon.BalloonTipTitle = "Uyarı!";
                notifyIcon.BalloonTipText = "Ödenmemiş aidat borcunuz var!";
                notifyIcon.ShowBalloonTip(500);
            }

            //if the user is a tenant
            if (users[5] == "Kiracı")
            {
                rentPrise_Label.Visible = true;
                rent_label.Visible = true;
            }

        }

        /// <summary>
        /// Pay dues button method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void payDues_Button_Click(object sender, EventArgs e)
        {

            isDuesPaid_Label.Text = "Evet";

            AdminNewMemberPage adminNewMemberPage = new AdminNewMemberPage();
            adminNewMemberPage.CheckAndDeleteDataBase(userName_Label.Text);

            File.AppendAllText(userDetailsTxtPath, userName_Label.Text + "#", Encoding.UTF8);
            File.AppendAllText(userDetailsTxtPath, registrationDate_Label.Text + "#", Encoding.UTF8);
            File.AppendAllText(userDetailsTxtPath, dues_Label.Text + "#", Encoding.UTF8);
            File.AppendAllText(userDetailsTxtPath, isDuesPaid_Label.Text + "#", Encoding.UTF8);
            File.AppendAllText(userDetailsTxtPath, debt_Label.Text + "#", Encoding.UTF8);
            File.AppendAllText(userDetailsTxtPath, hostOrTenant_Label.Text + "#", Encoding.UTF8);
            File.AppendAllText(userDetailsTxtPath, rentPrise_Label.Text + "#", Encoding.UTF8);
            File.AppendAllText(userDetailsTxtPath, userLoginName_Label.Text + "#", Encoding.UTF8);
            File.AppendAllText(userDetailsTxtPath, userLoginPassword_Label.Text, Encoding.UTF8);

            File.AppendAllText(userNameAndPasswordTxtPath, userLoginName_Label.Text + "#", Encoding.UTF8);
            File.AppendAllText(userNameAndPasswordTxtPath, userLoginPassword_Label.Text, Encoding.UTF8);

            payDues_Button.Enabled = false;

            MessageBox.Show("Aidat ödemesi başarılı");
        }

        /// <summary>
        /// Quit button method. Go to Welcome Page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quit_Button_Click(object sender, EventArgs e)
        {
            WelcomePage welcomePage = new WelcomePage();
            welcomePage.Show();
            this.Hide(); // dispose
        }

    }
}
