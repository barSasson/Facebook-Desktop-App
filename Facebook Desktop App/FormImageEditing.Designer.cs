namespace B16_Ex01_Sapir_201028867_Bar_200959286
{
    partial class FormImageEditing
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trackBarBlue = new System.Windows.Forms.TrackBar();
            this.trackBarGreen = new System.Windows.Forms.TrackBar();
            this.buttonReset = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBarBrightness = new System.Windows.Forms.TrackBar();
            this.trackBarSaturation = new System.Windows.Forms.TrackBar();
            this.trackBarContrast = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarRed = new System.Windows.Forms.TrackBar();
            this.textBoxNewFilterName = new System.Windows.Forms.TextBox();
            this.buttonAddFilter = new System.Windows.Forms.Button();
            this.listBoxUserFilters = new System.Windows.Forms.ListBox();
            this.buttonBrowseImage = new System.Windows.Forms.Button();
            this.buttonUploadImage = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.pictureBoxFilteredPicture = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonSaveFilters = new System.Windows.Forms.Button();
            this.textBoxPostTitle = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSaturation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarContrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilteredPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trackBarBlue);
            this.groupBox1.Controls.Add(this.trackBarGreen);
            this.groupBox1.Controls.Add(this.buttonReset);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.trackBarBrightness);
            this.groupBox1.Controls.Add(this.trackBarSaturation);
            this.groupBox1.Controls.Add(this.trackBarContrast);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.trackBarRed);
            this.groupBox1.Location = new System.Drawing.Point(12, 315);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 178);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filters";
            // 
            // trackBarBlue
            // 
            this.trackBarBlue.Location = new System.Drawing.Point(236, 32);
            this.trackBarBlue.Minimum = -10;
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Size = new System.Drawing.Size(101, 45);
            this.trackBarBlue.TabIndex = 12;
            this.trackBarBlue.Scroll += new System.EventHandler(this.trackBarBlue_Scroll);
            // 
            // trackBarGreen
            // 
            this.trackBarGreen.Location = new System.Drawing.Point(129, 33);
            this.trackBarGreen.Minimum = -10;
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Size = new System.Drawing.Size(101, 45);
            this.trackBarGreen.TabIndex = 2;
            this.trackBarGreen.Scroll += new System.EventHandler(this.trackBarGreen_Scroll);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(69, 141);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(235, 23);
            this.buttonReset.TabIndex = 17;
            this.buttonReset.Text = "Reset Adjustments";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(258, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Contrast";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(276, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Blue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Brightness";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Saturation";
            // 
            // trackBarBrightness
            // 
            this.trackBarBrightness.Location = new System.Drawing.Point(129, 96);
            this.trackBarBrightness.Name = "trackBarBrightness";
            this.trackBarBrightness.Size = new System.Drawing.Size(101, 45);
            this.trackBarBrightness.TabIndex = 9;
            this.trackBarBrightness.Scroll += new System.EventHandler(this.trackBarBrightness_Scroll);
            // 
            // trackBarSaturation
            // 
            this.trackBarSaturation.Location = new System.Drawing.Point(25, 96);
            this.trackBarSaturation.Name = "trackBarSaturation";
            this.trackBarSaturation.Size = new System.Drawing.Size(101, 45);
            this.trackBarSaturation.TabIndex = 8;
            this.trackBarSaturation.Scroll += new System.EventHandler(this.trackBarSaturation_Scroll);
            // 
            // trackBarContrast
            // 
            this.trackBarContrast.Location = new System.Drawing.Point(232, 96);
            this.trackBarContrast.Name = "trackBarContrast";
            this.trackBarContrast.Size = new System.Drawing.Size(101, 45);
            this.trackBarContrast.TabIndex = 13;
            this.trackBarContrast.Scroll += new System.EventHandler(this.trackBarContrast_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Green";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Red";
            // 
            // trackBarRed
            // 
            this.trackBarRed.Location = new System.Drawing.Point(25, 33);
            this.trackBarRed.Minimum = -10;
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Size = new System.Drawing.Size(101, 45);
            this.trackBarRed.TabIndex = 0;
            this.trackBarRed.Scroll += new System.EventHandler(this.trackBarRed_Scroll);
            // 
            // textBoxNewFilterName
            // 
            this.textBoxNewFilterName.Location = new System.Drawing.Point(394, 462);
            this.textBoxNewFilterName.Name = "textBoxNewFilterName";
            this.textBoxNewFilterName.Size = new System.Drawing.Size(122, 20);
            this.textBoxNewFilterName.TabIndex = 16;
            // 
            // buttonAddFilter
            // 
            this.buttonAddFilter.Location = new System.Drawing.Point(522, 462);
            this.buttonAddFilter.Name = "buttonAddFilter";
            this.buttonAddFilter.Size = new System.Drawing.Size(66, 20);
            this.buttonAddFilter.TabIndex = 3;
            this.buttonAddFilter.Text = "Add Filter";
            this.buttonAddFilter.UseVisualStyleBackColor = true;
            this.buttonAddFilter.Click += new System.EventHandler(this.buttonAddFilter_Click);
            // 
            // listBoxUserFilters
            // 
            this.listBoxUserFilters.FormattingEnabled = true;
            this.listBoxUserFilters.Location = new System.Drawing.Point(394, 322);
            this.listBoxUserFilters.Name = "listBoxUserFilters";
            this.listBoxUserFilters.Size = new System.Drawing.Size(194, 134);
            this.listBoxUserFilters.TabIndex = 2;
            this.listBoxUserFilters.SelectedIndexChanged += new System.EventHandler(this.listBoxUserDefinedFilters_SelectedIndexChanged);
            // 
            // buttonBrowseImage
            // 
            this.buttonBrowseImage.Location = new System.Drawing.Point(394, 161);
            this.buttonBrowseImage.Name = "buttonBrowseImage";
            this.buttonBrowseImage.Size = new System.Drawing.Size(194, 36);
            this.buttonBrowseImage.TabIndex = 4;
            this.buttonBrowseImage.Text = "Load From File..";
            this.buttonBrowseImage.UseVisualStyleBackColor = true;
            this.buttonBrowseImage.Click += new System.EventHandler(this.buttonBrowseImage_Click);
            // 
            // buttonUploadImage
            // 
            this.buttonUploadImage.Location = new System.Drawing.Point(394, 203);
            this.buttonUploadImage.Name = "buttonUploadImage";
            this.buttonUploadImage.Size = new System.Drawing.Size(194, 36);
            this.buttonUploadImage.TabIndex = 6;
            this.buttonUploadImage.Text = "Upload To Facebook";
            this.buttonUploadImage.UseVisualStyleBackColor = true;
            this.buttonUploadImage.Click += new System.EventHandler(this.buttonUploadImage_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            // 
            // pictureBoxFilteredPicture
            // 
            this.pictureBoxFilteredPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxFilteredPicture.Image = global::B16_Ex01_Sapir_201028867_Bar_200959286.Properties.Resources.no_photo;
            this.pictureBoxFilteredPicture.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxFilteredPicture.Name = "pictureBoxFilteredPicture";
            this.pictureBoxFilteredPicture.Size = new System.Drawing.Size(349, 297);
            this.pictureBoxFilteredPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFilteredPicture.TabIndex = 0;
            this.pictureBoxFilteredPicture.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(394, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 36);
            this.button2.TabIndex = 17;
            this.button2.Text = "Go Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonSaveFilters
            // 
            this.buttonSaveFilters.Location = new System.Drawing.Point(394, 119);
            this.buttonSaveFilters.Name = "buttonSaveFilters";
            this.buttonSaveFilters.Size = new System.Drawing.Size(194, 36);
            this.buttonSaveFilters.TabIndex = 18;
            this.buttonSaveFilters.Text = "Save Filters";
            this.buttonSaveFilters.UseVisualStyleBackColor = true;
            this.buttonSaveFilters.Click += new System.EventHandler(this.buttonSaveFilters_Click);
            // 
            // textBoxPostTitle
            // 
            this.textBoxPostTitle.Location = new System.Drawing.Point(394, 245);
            this.textBoxPostTitle.Name = "textBoxPostTitle";
            this.textBoxPostTitle.Size = new System.Drawing.Size(194, 20);
            this.textBoxPostTitle.TabIndex = 19;
            this.textBoxPostTitle.Text = "Photo Title";
            this.textBoxPostTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormImageEditing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(611, 502);
            this.Controls.Add(this.textBoxPostTitle);
            this.Controls.Add(this.buttonSaveFilters);
            this.Controls.Add(this.buttonAddFilter);
            this.Controls.Add(this.listBoxUserFilters);
            this.Controls.Add(this.textBoxNewFilterName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonUploadImage);
            this.Controls.Add(this.buttonBrowseImage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxFilteredPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormImageEditing";
            this.ShowIcon = false;
            this.Text = "Image Editor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSaturation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarContrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilteredPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFilteredPicture;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar trackBarGreen;
        private System.Windows.Forms.TrackBar trackBarRed;
        private System.Windows.Forms.ListBox listBoxUserFilters;
        private System.Windows.Forms.Button buttonAddFilter;
        private System.Windows.Forms.Button buttonBrowseImage;
        private System.Windows.Forms.Button buttonUploadImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBarBrightness;
        private System.Windows.Forms.TrackBar trackBarSaturation;
        private System.Windows.Forms.TrackBar trackBarContrast;
        private System.Windows.Forms.TrackBar trackBarBlue;
        private System.Windows.Forms.TextBox textBoxNewFilterName;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonSaveFilters;
        private System.Windows.Forms.TextBox textBoxPostTitle;
    }
}