
namespace Apartment_App
{
    partial class AdminOperationsPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.quit_Button = new System.Windows.Forms.Button();
            this.listing_Button = new System.Windows.Forms.Button();
            this.memberChangeAndDelette_Button = new System.Windows.Forms.Button();
            this.newMember_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // quit_Button
            // 
            this.quit_Button.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.quit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.quit_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.quit_Button.Location = new System.Drawing.Point(95, 311);
            this.quit_Button.Name = "quit_Button";
            this.quit_Button.Size = new System.Drawing.Size(279, 57);
            this.quit_Button.TabIndex = 54;
            this.quit_Button.Text = "Çıkış";
            this.quit_Button.UseVisualStyleBackColor = false;
            this.quit_Button.Click += new System.EventHandler(this.quit_Button_Click);
            // 
            // listing_Button
            // 
            this.listing_Button.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.listing_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listing_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listing_Button.Location = new System.Drawing.Point(95, 40);
            this.listing_Button.Name = "listing_Button";
            this.listing_Button.Size = new System.Drawing.Size(279, 57);
            this.listing_Button.TabIndex = 51;
            this.listing_Button.Text = "Üyeleri Listele";
            this.listing_Button.UseVisualStyleBackColor = false;
            this.listing_Button.Click += new System.EventHandler(this.listing_Button_Click);
            // 
            // memberChangeAndDelette_Button
            // 
            this.memberChangeAndDelette_Button.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.memberChangeAndDelette_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.memberChangeAndDelette_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.memberChangeAndDelette_Button.Location = new System.Drawing.Point(95, 191);
            this.memberChangeAndDelette_Button.Name = "memberChangeAndDelette_Button";
            this.memberChangeAndDelette_Button.Size = new System.Drawing.Size(279, 57);
            this.memberChangeAndDelette_Button.TabIndex = 53;
            this.memberChangeAndDelette_Button.Text = "Üye Düzenle / Sil";
            this.memberChangeAndDelette_Button.UseVisualStyleBackColor = false;
            this.memberChangeAndDelette_Button.Click += new System.EventHandler(this.memberChangeAndDelette_Button_Click);
            // 
            // newMember_Button
            // 
            this.newMember_Button.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.newMember_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newMember_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.newMember_Button.Location = new System.Drawing.Point(95, 114);
            this.newMember_Button.Name = "newMember_Button";
            this.newMember_Button.Size = new System.Drawing.Size(279, 57);
            this.newMember_Button.TabIndex = 52;
            this.newMember_Button.Text = "Yeni Üye Oluştur";
            this.newMember_Button.UseVisualStyleBackColor = false;
            this.newMember_Button.Click += new System.EventHandler(this.newMember_Button_Click);
            // 
            // AdminOperationsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(473, 403);
            this.Controls.Add(this.quit_Button);
            this.Controls.Add(this.listing_Button);
            this.Controls.Add(this.memberChangeAndDelette_Button);
            this.Controls.Add(this.newMember_Button);
            this.MaximizeBox = false;
            this.Name = "AdminOperationsPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yönetici işlem sayfası";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button quit_Button;
        private System.Windows.Forms.Button listing_Button;
        private System.Windows.Forms.Button memberChangeAndDelette_Button;
        private System.Windows.Forms.Button newMember_Button;
    }
}