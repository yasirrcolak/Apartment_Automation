using System;
using System.IO;
using System.Windows.Forms;

namespace Apartment_App
{
    public partial class AdminListingPage : Form
    {
        // This string array contains Users details.
        public string[] userDetails = File.ReadAllLines(@"..\..\userDetails.txt");
        // This string array contains a user details.
        public string[] users;

        public AdminListingPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Back button method. Go to Admin Operations Page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void back_Button_Click(object sender, EventArgs e)
        {
            AdminOperationsPage adminOperationsPage = new AdminOperationsPage();
            adminOperationsPage.Show();
            this.Hide(); // dispose

        }

        /// <summary>
        /// Admin Listing Page Loaded Method. Write all user details to screen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdminListingPage_Load(object sender, EventArgs e)
        {

            userDetails = File.ReadAllLines(@"..\..\userDetails.txt");

            users_ListView.View = View.Details;

            // add columns.
            users_ListView.Columns.Add("Sıra", 100);
            users_ListView.Columns.Add("İsim", 120);
            users_ListView.Columns.Add("Kayıt Tarihi", 230);
            users_ListView.Columns.Add("Aidat Miktarı", 120);
            users_ListView.Columns.Add("Aidat Ödendi mi", 200);
            users_ListView.Columns.Add("Borç", 100);
            users_ListView.Columns.Add("Kiracı / Ev Sahibi", 200);
            users_ListView.Columns.Add("Kira Bedeli", 120);
            users_ListView.Columns.Add("Kullanıcı Adı", 130);
            users_ListView.Columns.Add("Giriş Şifresi", 130);

            // add all users.
            for (int i = 0; i < userDetails.Length; i++)
            {
                users = userDetails[i].Split('#');
                users_ListView.Items.Add((i + 1).ToString());
                users_ListView.Items[i].SubItems.Add(users[0]);
                users_ListView.Items[i].SubItems.Add(users[1]);
                users_ListView.Items[i].SubItems.Add(users[2]);
                users_ListView.Items[i].SubItems.Add(users[3]);
                users_ListView.Items[i].SubItems.Add(users[4]);
                users_ListView.Items[i].SubItems.Add(users[5]);
                users_ListView.Items[i].SubItems.Add(users[6]);
                users_ListView.Items[i].SubItems.Add(users[7]);
                users_ListView.Items[i].SubItems.Add(users[8]);

            }

            // write user count to total member label
            totalMember_Label.Text = users_ListView.Items.Count.ToString();

        }
    }
}
