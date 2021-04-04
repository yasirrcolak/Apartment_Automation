
namespace Apartment_App
{
    partial class AdminListingPage
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
            this.back_Button = new System.Windows.Forms.Button();
            this.users_ListView = new System.Windows.Forms.ListView();
            this.label18 = new System.Windows.Forms.Label();
            this.totalMember_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // back_Button
            // 
            this.back_Button.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.back_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.back_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.back_Button.Location = new System.Drawing.Point(618, 495);
            this.back_Button.Name = "back_Button";
            this.back_Button.Size = new System.Drawing.Size(163, 57);
            this.back_Button.TabIndex = 15;
            this.back_Button.Text = "Geri";
            this.back_Button.UseVisualStyleBackColor = false;
            this.back_Button.Click += new System.EventHandler(this.back_Button_Click);
            // 
            // users_ListView
            // 
            this.users_ListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.users_ListView.HideSelection = false;
            this.users_ListView.Location = new System.Drawing.Point(31, 37);
            this.users_ListView.Name = "users_ListView";
            this.users_ListView.Size = new System.Drawing.Size(1499, 420);
            this.users_ListView.TabIndex = 17;
            this.users_ListView.UseCompatibleStateImageBehavior = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label18.Location = new System.Drawing.Point(42, 473);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(182, 32);
            this.label18.TabIndex = 106;
            this.label18.Text = "Toplam Üye:";
            // 
            // totalMember_Label
            // 
            this.totalMember_Label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalMember_Label.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.totalMember_Label.ForeColor = System.Drawing.SystemColors.WindowText;
            this.totalMember_Label.Location = new System.Drawing.Point(230, 473);
            this.totalMember_Label.Name = "totalMember_Label";
            this.totalMember_Label.Size = new System.Drawing.Size(48, 38);
            this.totalMember_Label.TabIndex = 105;
            // 
            // AdminListingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1574, 583);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.totalMember_Label);
            this.Controls.Add(this.users_ListView);
            this.Controls.Add(this.back_Button);
            this.MaximizeBox = false;
            this.Name = "AdminListingPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üye listeleme sayfası";
            this.Load += new System.EventHandler(this.AdminListingPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_Button;
        private System.Windows.Forms.ListView users_ListView;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label totalMember_Label;
    }
}