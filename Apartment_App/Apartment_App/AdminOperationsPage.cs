using System;
using System.Windows.Forms;

namespace Apartment_App
{
    public partial class AdminOperationsPage : Form
    {
        public AdminOperationsPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Listing button method. Go to Admin Listing Page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listing_Button_Click(object sender, EventArgs e)
        {
            AdminListingPage adminListingPage = new AdminListingPage();
            adminListingPage.Show();
            this.Hide();
        }

        /// <summary>
        /// New member button method. Go to Admin New Member Page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newMember_Button_Click(object sender, EventArgs e)
        {
            AdminNewMemberPage adminNewMemberPage = new AdminNewMemberPage();
            adminNewMemberPage.Show();
            this.Hide();
        }

        /// <summary>
        /// Member change and delete button method. Go to Admin Change And Delete Page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void memberChangeAndDelette_Button_Click(object sender, EventArgs e)
        {
            AdminChangeAndDeletePage adminChangeAndDeletePage = new AdminChangeAndDeletePage();
            adminChangeAndDeletePage.Show();
            this.Hide();
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
            this.Hide();
        }
    }
}
