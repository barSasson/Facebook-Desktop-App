using System;
using System.Drawing;
using System.Windows.Forms;
using B16_Ex01_Sapir_201028867_Bar_200959286.Properties;

namespace B16_Ex01_Sapir_201028867_Bar_200959286
{
    using System.Drawing.Imaging;
    using System.IO;
    using FacebookWrapper.ObjectModel;

    public partial class FormImageEditing : Form
    {
        private static readonly int sr_ValueRange = 10;

        public Image CurrentImage { get; set; }

        public User LoggedInUser { get; set; }

        public FormImageEditing(Image i_ImageToEdit, User i_LoggedInUser)
        {
            InitializeComponent();
            LoggedInUser = i_LoggedInUser;

            // check if image was given
            if (i_ImageToEdit != null)
            {
                CurrentImage = i_ImageToEdit;
                this.pictureBoxFilteredPicture.Image = this.CurrentImage;
            }
            else
            {
                // show no-image icon and disable appropriate controls
                this.CurrentImage = new Bitmap(Resources.no_photo);
                this.listBoxUserFilters.Enabled = false;
                this.disableFilterControls();
                this.buttonUploadImage.Enabled = false;
            }

            this.loadFiltersToListBox();
            this.pictureBoxFilteredPicture.Show();
        }

        private void loadFiltersToListBox()
        {
            this.listBoxUserFilters.Items.Clear();
            foreach (Filter filter in FiltersManager.GetFiltersList())
            {
                this.listBoxUserFilters.Items.Add(filter.Name);
            }
        }

        private void trackBarRed_Scroll(object sender, EventArgs e)
        {
            this.readjustImageAndShow();
        }

        private void trackBarGreen_Scroll(object sender, EventArgs e)
        {
            this.readjustImageAndShow();

        }

        private void trackBarBlue_Scroll(object sender, EventArgs e)
        {
            this.readjustImageAndShow();
        }

        private void trackBarSaturation_Scroll(object sender, EventArgs e)
        {
            readjustImageAndShow();
        }

        private void trackBarBrightness_Scroll(object sender, EventArgs e)
        {
            readjustImageAndShow();

        }

        private void trackBarContrast_Scroll(object sender, EventArgs e)
        {
            readjustImageAndShow();
        }

        private void readjustImageAndShow(bool i_IdentityFilter = false)
        {
            ColorMatrix filter;
            if (i_IdentityFilter == false)
            {
                // get the right filter with given sliders values
                    filter = ColorMatrixUtilities.GetColorMatrixWithAllFilters(
                    this.trackBarSaturation.Value,
                    this.trackBarBrightness.Value,
                    this.trackBarContrast.Value,
                    this.trackBarRed.Value,
                    this.trackBarGreen.Value,
                    this.trackBarBlue.Value,
                    sr_ValueRange);
            }
            else
            {
                // default matrix is the identity matrix
                filter = new ColorMatrix();
            }

            // Adjust image
            Bitmap filteredImage = ColorMatrixUtilities.AdjustImage(filter, this.CurrentImage);
            this.pictureBoxFilteredPicture.Image = filteredImage;
            this.pictureBoxFilteredPicture.Show();
        }

        private void resetColorControls()
        {
             foreach(Control control in this.Controls)
             {
                   if(control is GroupBox)
                   {
                      foreach(Control innerControl in control.Controls)
                      {
                          TrackBar trackBarBar = innerControl as TrackBar;
                          if (trackBarBar != null)
                          {
                              trackBarBar.Value = 0;
                          }
                      }
                  }
             }
        }

        private void buttonBrowseImage_Click(object sender, EventArgs e)
        {
            bool v_ApplyIdentityFilter = true;
            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.CurrentImage = Image.FromFile(this.openFileDialog.FileName);
                this.resetColorControls();
                listBoxUserFilters.SelectedIndex = 0;
                this.enableFilterControls();
                this.buttonUploadImage.Enabled = true;
                listBoxUserFilters.Enabled = true;
                readjustImageAndShow(v_ApplyIdentityFilter);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool v_ApplyIdentityFilter = true;
            this.resetColorControls();
            readjustImageAndShow(v_ApplyIdentityFilter);
        }

        private void listBoxUserDefinedFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            int chosenIndex = this.listBoxUserFilters.SelectedIndex;
            ColorMatrix chosenFilter = FiltersManager.GetFiltersList()[chosenIndex].PixelFilter;
            this.pictureBoxFilteredPicture.Image = ColorMatrixUtilities.AdjustImage(chosenFilter, this.CurrentImage);

            if (chosenIndex  != 0)
            {
               this.textBoxNewFilterName.Text = string.Empty;
               this.disableFilterControls();
            }
            else
            {
                this.enableFilterControls();
            }
        }

        private void buttonSaveFilters_Click(object sender, EventArgs e)
        {
            try
            {
                FiltersManager.SaveFilterListToFile(FiltersManager.GetFiltersList());
                MessageBox.Show(@"Filters Saved succesfully!", @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show(@"We couldn't save your filter data locally..Please check your permission settings", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void disableFilterControls()
        {
            this.resetColorControls();
            this.buttonSaveFilters.Enabled = false;
            this.textBoxNewFilterName.Enabled = false;
            this.buttonAddFilter.Enabled = false;
            this.groupBox1.Enabled = false;
        }

        private void enableFilterControls()
        {
            this.resetColorControls();
            this.buttonSaveFilters.Enabled = true;
            this.textBoxNewFilterName.Enabled = true;
            this.buttonAddFilter.Enabled = true;
            this.groupBox1.Enabled = true;
        }

        private void buttonAddFilter_Click(object sender, EventArgs e)
        {
            if (this.textBoxNewFilterName.Text != string.Empty)
            {
                // create filter
                Filter newFilter =
                new Filter(
                    ColorMatrixUtilities.GetColorMatrixWithAllFilters(
                        this.trackBarSaturation.Value,
                        this.trackBarBrightness.Value,
                        this.trackBarContrast.Value,
                        this.trackBarRed.Value,
                        this.trackBarGreen.Value,
                        this.trackBarBlue.Value,
                        sr_ValueRange),
                    this.textBoxNewFilterName.Text);
                this.textBoxNewFilterName.Text = string.Empty;

                // add filter to list
                FiltersManager.GetFiltersList().Add(newFilter);
                this.loadFiltersToListBox();
            }
            else
            {
                MessageBox.Show(@"You Must Choose a Name For The Filter", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUploadImage_Click(object sender, EventArgs e)
        {
            try
            {
                Image imageToUpload = this.pictureBoxFilteredPicture.Image;
                byte[] imageInBytes = ImageToByteArray(imageToUpload);
                LoggedInUser.PostPhoto(imageInBytes, this.textBoxPostTitle.Text, i_PrivacyParameterValue: "{'value':'SELF'}");
                MessageBox.Show(@"Upload Completed!", @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show(@"Upload Faild!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public byte[] ImageToByteArray(Image i_ImageIn)
        {
            using (var ms = new MemoryStream())
            {
                i_ImageIn.Save(ms, ImageFormat.Gif);
                return ms.ToArray();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
