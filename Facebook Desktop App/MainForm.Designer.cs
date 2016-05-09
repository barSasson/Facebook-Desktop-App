namespace B16_Ex01_Sapir_201028867_Bar_200959286
{
    partial class MainForm
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
            this.buttonShowLikedPages = new System.Windows.Forms.Button();
            this.listBoxLikedPages = new System.Windows.Forms.ListBox();
            this.labelLikedPages = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDaysToInactive = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxProfilePicture = new System.Windows.Forms.PictureBox();
            this.buttonProfilePicture = new System.Windows.Forms.Button();
            this.buttonPrevPicture = new System.Windows.Forms.Button();
            this.buttonNextPicture = new System.Windows.Forms.Button();
            this.labelProfilePictureDate = new System.Windows.Forms.Label();
            this.buttonEditImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonShowLikedPages
            // 
            this.buttonShowLikedPages.Location = new System.Drawing.Point(238, 13);
            this.buttonShowLikedPages.Name = "buttonShowLikedPages";
            this.buttonShowLikedPages.Size = new System.Drawing.Size(169, 23);
            this.buttonShowLikedPages.TabIndex = 0;
            this.buttonShowLikedPages.Text = "Show My Inactive Liked Pages";
            this.buttonShowLikedPages.UseVisualStyleBackColor = true;
            this.buttonShowLikedPages.Click += new System.EventHandler(this.buttonButtonShowLikedPages_Click);
            // 
            // listBoxLikedPages
            // 
            this.listBoxLikedPages.FormattingEnabled = true;
            this.listBoxLikedPages.Location = new System.Drawing.Point(239, 80);
            this.listBoxLikedPages.Name = "listBoxLikedPages";
            this.listBoxLikedPages.Size = new System.Drawing.Size(382, 277);
            this.listBoxLikedPages.TabIndex = 1;
            // 
            // labelLikedPages
            // 
            this.labelLikedPages.AutoSize = true;
            this.labelLikedPages.Location = new System.Drawing.Point(237, 64);
            this.labelLikedPages.Name = "labelLikedPages";
            this.labelLikedPages.Size = new System.Drawing.Size(316, 13);
            this.labelLikedPages.TabIndex = 2;
            this.labelLikedPages.Text = "Press the button to view the inactive pages you like on facebook.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "A page will be counted as inactive if there aren\'t posts within the last";
            // 
            // textBoxDaysToInactive
            // 
            this.textBoxDaysToInactive.Location = new System.Drawing.Point(567, 40);
            this.textBoxDaysToInactive.Name = "textBoxDaysToInactive";
            this.textBoxDaysToInactive.Size = new System.Drawing.Size(21, 20);
            this.textBoxDaysToInactive.TabIndex = 4;
            this.textBoxDaysToInactive.Text = "7";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(589, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "days.";
            // 
            // pictureBoxProfilePicture
            // 
            this.pictureBoxProfilePicture.Location = new System.Drawing.Point(23, 79);
            this.pictureBoxProfilePicture.Name = "pictureBoxProfilePicture";
            this.pictureBoxProfilePicture.Size = new System.Drawing.Size(187, 166);
            this.pictureBoxProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProfilePicture.TabIndex = 6;
            this.pictureBoxProfilePicture.TabStop = false;
            // 
            // buttonProfilePicture
            // 
            this.buttonProfilePicture.Location = new System.Drawing.Point(23, 14);
            this.buttonProfilePicture.Name = "buttonProfilePicture";
            this.buttonProfilePicture.Size = new System.Drawing.Size(156, 23);
            this.buttonProfilePicture.TabIndex = 8;
            this.buttonProfilePicture.Text = "Show My Profile Picture";
            this.buttonProfilePicture.UseVisualStyleBackColor = true;
            this.buttonProfilePicture.Click += new System.EventHandler(this.buttonProfilePicture_Click);
            // 
            // buttonPrevPicture
            // 
            this.buttonPrevPicture.Location = new System.Drawing.Point(24, 251);
            this.buttonPrevPicture.Name = "buttonPrevPicture";
            this.buttonPrevPicture.Size = new System.Drawing.Size(56, 23);
            this.buttonPrevPicture.TabIndex = 9;
            this.buttonPrevPicture.Text = "<";
            this.buttonPrevPicture.UseVisualStyleBackColor = true;
            this.buttonPrevPicture.Click += new System.EventHandler(this.buttonPrevPicture_Click);
            // 
            // buttonNextPicture
            // 
            this.buttonNextPicture.Location = new System.Drawing.Point(154, 251);
            this.buttonNextPicture.Name = "buttonNextPicture";
            this.buttonNextPicture.Size = new System.Drawing.Size(56, 23);
            this.buttonNextPicture.TabIndex = 10;
            this.buttonNextPicture.Text = ">";
            this.buttonNextPicture.UseVisualStyleBackColor = true;
            this.buttonNextPicture.Click += new System.EventHandler(this.buttonNextPicture_Click);
            // 
            // labelProfilePictureDate
            // 
            this.labelProfilePictureDate.AutoSize = true;
            this.labelProfilePictureDate.Location = new System.Drawing.Point(24, 60);
            this.labelProfilePictureDate.Name = "labelProfilePictureDate";
            this.labelProfilePictureDate.Size = new System.Drawing.Size(104, 13);
            this.labelProfilePictureDate.TabIndex = 11;
            this.labelProfilePictureDate.Text = "Latest Profile Picture";
            // 
            // buttonEditImage
            // 
            this.buttonEditImage.Location = new System.Drawing.Point(86, 251);
            this.buttonEditImage.Name = "buttonEditImage";
            this.buttonEditImage.Size = new System.Drawing.Size(62, 23);
            this.buttonEditImage.TabIndex = 12;
            this.buttonEditImage.Text = "Edit Image";
            this.buttonEditImage.UseVisualStyleBackColor = true;
            this.buttonEditImage.Click += new System.EventHandler(this.buttonEditImage_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 369);
            this.Controls.Add(this.buttonEditImage);
            this.Controls.Add(this.labelProfilePictureDate);
            this.Controls.Add(this.buttonNextPicture);
            this.Controls.Add(this.buttonPrevPicture);
            this.Controls.Add(this.buttonProfilePicture);
            this.Controls.Add(this.pictureBoxProfilePicture);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDaysToInactive);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelLikedPages);
            this.Controls.Add(this.listBoxLikedPages);
            this.Controls.Add(this.buttonShowLikedPages);
            this.Name = "MainForm";
            this.Text = "Facebook Form Application";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonShowLikedPages;
        private System.Windows.Forms.ListBox listBoxLikedPages;
        private System.Windows.Forms.Label labelLikedPages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDaysToInactive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxProfilePicture;
        private System.Windows.Forms.Button buttonProfilePicture;
        private System.Windows.Forms.Button buttonPrevPicture;
        private System.Windows.Forms.Button buttonNextPicture;
        private System.Windows.Forms.Label labelProfilePictureDate;
        private System.Windows.Forms.Button buttonEditImage;
    }
}

